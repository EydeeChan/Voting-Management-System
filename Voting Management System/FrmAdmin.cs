#region Imports
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace Voting_Management_System
{
    public partial class FrmAdmin : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmAdmin()
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
        #region Minimize Button
        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
        #region Form Load
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            CountVoter();
            CountVoterVote();
            RetrieveTitle();
            DateAndTime.Start();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
        #region Date And Time Tick
        private void DateAndTime_Tick(object sender, EventArgs e)
        {
            lblweek.Text = DateTime.Now.ToString("dddd  MMMM dd yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm");
            lblsec.Text = DateTime.Now.ToString("ss");
            lblam.Text = DateTime.Now.ToString("tt");
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
        #region Log Out Button
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            LogHistoryLogout();
            FrmLogin a = new FrmLogin();
            this.Hide();
            a.Show();
        }
        #endregion
        #region Log History Button
        private void BtnLogHistory_Click(object sender, EventArgs e)
        {
            FrmLogHistory a = new FrmLogHistory();
            a.Show();
            this.Hide();
        }
        #endregion
        #region Report Button
        private void BtnReports_Click(object sender, EventArgs e)
        {
            FrmReport a = new FrmReport();
            a.Show();
            this.Hide();
        }
        #endregion
        #region Position Button
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            TransparentAdmin a = new TransparentAdmin();
            FrmPosition b = new FrmPosition();

            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Candidate Button
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            TransparentLogin a = new TransparentLogin();
            FrmCandidate b = new FrmCandidate();
            this.Hide();
            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Dashboard Button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
        #region Count Voter
        public void CountVoter()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                string query = "select count(*) from voters";
                MySqlCommand cmd = new MySqlCommand(query, con);
                string getValue = cmd.ExecuteScalar().ToString();
                label2.Text = getValue;
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.Show();
            }
        }
        #endregion
        #region Count Voter Voted
        public void CountVoterVote()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                string query = "select count(*) from voters where status = 'voted'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                string getValue = cmd.ExecuteScalar().ToString();
                label5.Text = getValue;
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.Show();
            }
        }
        #endregion
        #region Voter Button
        private void BtnVoters_Click(object sender, EventArgs e)
        {
            FrmVoters a = new FrmVoters();
            a.Show();
            this.Hide();
        }
        #endregion
        #region Election Title
        private void BtnSection_Click(object sender, EventArgs e)
        {
            TransparentAdmin a = new TransparentAdmin();
            FrmElectionTitle b = new FrmElectionTitle();
            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Retrieve Title 
        public void RetrieveTitle()
        {
            try
            {
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
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.Show();
            }
        }
        #endregion
        #region Partylist Button
        private void BtnPartyList_Click(object sender, EventArgs e)
        {
            FrmPartylist a = new FrmPartylist();
            a.Show();
            this.Hide();
        }
        #endregion
    }
}
