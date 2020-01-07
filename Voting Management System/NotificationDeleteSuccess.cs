#region Imports
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
#endregion

namespace Voting_Management_System
{
    public partial class NotificationDeleteSuccess : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public NotificationDeleteSuccess()
        {
            InitializeComponent();
        }
        #region Okay Button
        private void BtnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Form Load
        private void NotificationDeleteSuccess_Load(object sender, EventArgs e)
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
