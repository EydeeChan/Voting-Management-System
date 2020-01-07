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
    public partial class FrmVoters : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmVoters()
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
        private void FrmVoters_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            Retrieve();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
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
        #region Close Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            FrmAdmin a = new FrmAdmin();
            a.Show();
            this.Hide();
        }
        #endregion
        #region Retrieve
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select voters.voters_id, voters.first_name, voters.middle_name, voters.last_name, voters.track, voters.strand, account.username, voters.status from voters inner join account on voters.account_id = account.account_id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewVoter a = new ViewVoter();
                    a.lblvotersid.Text = dt.Rows[i]["voters_id"].ToString();
                    a.lblfirstname.Text = dt.Rows[i]["first_name"].ToString();
                    a.lblmiddlename.Text = dt.Rows[i]["middle_name"].ToString();
                    a.lblastname.Text = dt.Rows[i]["last_name"].ToString();
                    a.lbltrack.Text = dt.Rows[i]["track"].ToString();
                    a.lblstrand.Text = dt.Rows[i]["strand"].ToString();
                    a.lblusername.Text = dt.Rows[i]["username"].ToString();
                    a.lblstatus.Text = dt.Rows[i]["status"].ToString();
                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Add Position Button
        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            TransparentVoters a = new TransparentVoters();
            FrmAddVoters b = new FrmAddVoters();
            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Refresh Button
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Retrieve();
        }
        #endregion
        #region Search Button
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchBy.Text == "First Name")
            {
                GlobalVar.VoterSearch = "first_name";
            }
            if (TxtSearchBy.Text == "Middle Name")
            {
                GlobalVar.VoterSearch = "middle_name";
            }
            if (TxtSearchBy.Text == "Last Name")
            {
                GlobalVar.VoterSearch = "last_name";
            }
            if (TxtSearchBy.Text == "Grade")
            {
                GlobalVar.VoterSearch = "grade";
            }
            if (TxtSearchBy.Text == "Track")
            {
                GlobalVar.VoterSearch = "track";
            }
            if (TxtSearchBy.Text == "Strand")
            {
                GlobalVar.VoterSearch = "Strand";
            }
            RetrieveOne(GlobalVar.VoterSearch);
        }
        #endregion
        #region Retrieve One
        void RetrieveOne(string VoterSearch)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select voters.voters_id, voters.first_name, voters.middle_name, voters.last_name, voters.track, voters.strand, account.username, voters.status from voters inner join account on voters.account_id = account.account_id where " + VoterSearch + " = @Search";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@Search", TxtSearch.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewVoter a = new ViewVoter();
                    a.lblvotersid.Text = dt.Rows[i]["voters_id"].ToString();
                    a.lblfirstname.Text = dt.Rows[i]["first_name"].ToString();
                    a.lblmiddlename.Text = dt.Rows[i]["middle_name"].ToString();
                    a.lblastname.Text = dt.Rows[i]["last_name"].ToString();
                    a.lbltrack.Text = dt.Rows[i]["track"].ToString();
                    a.lblstrand.Text = dt.Rows[i]["strand"].ToString();
                    a.lblusername.Text = dt.Rows[i]["username"].ToString();
                    a.lblstatus.Text = dt.Rows[i]["status"].ToString();
                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Place Holder
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Search here..")
            {
                TxtSearch.Text = "";
                TxtSearch.Clear();
                TxtSearch.ForeColor = Color.Black;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Search here..";
                TxtSearch.Clear();
                TxtSearch.ForeColor = Color.Black;
            }
        }
        #endregion
    }
}
