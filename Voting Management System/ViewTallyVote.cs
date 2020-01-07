#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
#endregion

namespace Voting_Management_System
{
    public partial class ViewTallyVote : UserControl
    {
        public ViewTallyVote()
        {
            InitializeComponent();
        }

        private void ViewTallyVote_Load(object sender, EventArgs e)
        {
            t1.Start(); 
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            RetrieveVote();
        }
        #region Retrieve Votes
        public void RetrieveVote()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                String query = "select count(*) from votes where candidate_id = @candidate_id and position = @position";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@candidate_id", lblcandidateid.Text);
                cmd.Parameters.AddWithValue("@position", lblposition.Text);
                string getValue = cmd.ExecuteScalar().ToString();
                lbltotalvotes.Text = "Total Votes: " + getValue;
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
