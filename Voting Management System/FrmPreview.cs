#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
#endregion

namespace Voting_Management_System
{
    public partial class FrmPreview : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmPreview()
        {
            InitializeComponent();
        }
        private const int cs = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs;
                return cp;
            }
        }
        #region Form Load
        private void FrmPreview_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            Retrieve();
        }
        #endregion
        #region Fade In Event
        void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        #endregion
        #region Retrive
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select votes.candidate_id, candidate.first_name, candidate.middle_name, candidate.last_name, votes.position from votes inner join candidate on votes.candidate_id = candidate.candidate_id where votes.voters_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@id", GlobalVar.voters_id);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewVoteFinal a = new ViewVoteFinal();
                    String last_name = dt.Rows[i]["last_name"].ToString();
                    String first_name = dt.Rows[i]["first_name"].ToString();
                    String middle_name = dt.Rows[i]["middle_name"].ToString();
                    a.lblvote.Text = last_name + " " + first_name + " " + middle_name[0];
                    a.lblposition.Text = dt.Rows[i]["position"].ToString();
                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Close Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            CloseTransparent();
        }
        #endregion
        #region Close Transparent
        public void CloseTransparent()
        {
            TransparentDashboard a = (TransparentDashboard)Application.OpenForms["TransparentDashboard"];
            a.Close();
            this.Hide();
        }
        #endregion
    }
}
