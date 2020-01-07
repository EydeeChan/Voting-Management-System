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
using System.IO;
#endregion

namespace Voting_Management_System
{
    public partial class FrmTally : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmTally()
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
        #region Close Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            LogHistoryLogout();
            this.Hide();
            FrmLogin a = new FrmLogin();
            a.Show();
        }
        #endregion
        #region Log History Logout
        public void LogHistoryLogout()
        {
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                con.Open();
                //Query to log history
                string query3 = "INSERT INTO `loghistory`(`account_id`, `account_type`,`username`, `log`) VALUES (@id, @accid,@user, @logs)";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("id", GlobalVar.user_id);
                cmd3.Parameters.AddWithValue("accid", GlobalVar.user_type);
                cmd3.Parameters.AddWithValue("user", GlobalVar.user);
                cmd3.Parameters.AddWithValue("logs", GlobalVar.user + " has been succesfully logout.");
                cmd3.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.Show();
            }
        }
        #endregion
        #region Form Load
        private void FrmTally_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            RetrieveTitle();
            Retrieve();
            RetrievePosition();
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
        #region Retrieve Title 
        public void RetrieveTitle()
        {
            //try
            //{
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            con.Open();
            String query = "select title from title";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = (dr["title"]).ToString();
            }
            else
            {
                label1.Text = "Voting Management System";
            }
            dr.Close();
            con.Close();
            //}
            //catch
            //{
            //    NotificationConnectionError a = new NotificationConnectionError();
            //    a.Show();
            //}
        }
        #endregion
        #region Retrieve Position
        void RetrievePosition()
        {
            //try
            //{
            con.Open();
            String query = "select * from position";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtPosition.Items.Add(reader.GetString("position"));
            }
            con.Close();
            //}
            //catch
            //{
            //    NotificationConnectionError a = new NotificationConnectionError();
            //    a.ShowDialog();
            //}
        }
        #endregion
        #region Txt Position Selected Index Changed
        private void TxtPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from candidate where position = @Search";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@Search", TxtPosition.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewTallyVote a = new ViewTallyVote();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[i]["img"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.StudentPicture.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.lblcandidateid.Text = dt.Rows[i]["candidate_id"].ToString();
                    String last_name = dt.Rows[i]["last_name"].ToString();
                    String first_name = dt.Rows[i]["first_name"].ToString();
                    String middle_name = dt.Rows[i]["middle_name"].ToString();
                    a.lblfullname.Text = last_name + " " + first_name + " " + middle_name[0];
                    a.lblgender.Text = dt.Rows[i]["gender"].ToString();
                    String Track = dt.Rows[i]["track"].ToString();
                    String Strand = dt.Rows[i]["strand"].ToString();
                    a.lbltrackstrand.Text = Track + " " + Strand;
                    a.lblpartylist.Text = dt.Rows[i]["partylist"].ToString();
                    a.lblposition.Text = dt.Rows[i]["position"].ToString();
                    a.lblplatform.Text = dt.Rows[i]["platform"].ToString();
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
        #region Retrieve
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from candidate";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewTallyVote a = new ViewTallyVote();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[i]["img"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.StudentPicture.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.lblcandidateid.Text = dt.Rows[i]["candidate_id"].ToString();
                    String last_name = dt.Rows[i]["last_name"].ToString();
                    String first_name = dt.Rows[i]["first_name"].ToString();
                    String middle_name = dt.Rows[i]["middle_name"].ToString();
                    a.lblfullname.Text = last_name + " " + first_name + " " + middle_name[0];
                    a.lblgender.Text = dt.Rows[i]["gender"].ToString();
                    String Track = dt.Rows[i]["track"].ToString();
                    String Strand = dt.Rows[i]["strand"].ToString();
                    a.lbltrackstrand.Text = Track + " " + Strand;
                    a.lblpartylist.Text = dt.Rows[i]["partylist"].ToString();
                    a.lblposition.Text = dt.Rows[i]["position"].ToString();
                    a.lblplatform.Text = dt.Rows[i]["platform"].ToString();
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
    }
}
