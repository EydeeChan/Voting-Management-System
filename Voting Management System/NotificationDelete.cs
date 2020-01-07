#region Imports
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
#endregion

namespace Voting_Management_System
{
    public partial class NotificationDelete : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public NotificationDelete()
        {
            InitializeComponent();
        }
        #region Form Load
        private void NotificationDelete_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            RetrieveTitle();
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
        #region Delete Button
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "delete from " + GlobalVar.Delete + " where " + GlobalVar.Delete + "_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", lblid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryDelete(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
                this.Hide();
                NotificationDeleteSuccess a = new NotificationDeleteSuccess();
                a.ShowDialog();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Log History Delete Data
        void LogHistoryDelete(string user_id, string user_type, string user)
        {
            try
            {
                con.Open();
                //Query to log history
                string query3 = "INSERT INTO `loghistory`(`account_id`, `account_type`,`username`, `log`) VALUES (@id, @accid,@user, @logs)";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("id", user_id);
                cmd3.Parameters.AddWithValue("accid", user_type);
                cmd3.Parameters.AddWithValue("user", user);
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully delete " + GlobalVar.Delete + " .");
                cmd3.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Cancel Button
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                    label2.Text = (dr["title"]).ToString();
                }
                else
                {
                    label2.Text = "Voting Management System";
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
    }
}
