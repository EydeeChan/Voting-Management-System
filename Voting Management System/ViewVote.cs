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
    public partial class ViewVote : UserControl
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public ViewVote()
        {
            InitializeComponent();
        }
        #region Un Vote Button
        private void BtnUnVote_Click(object sender, EventArgs e)
        {
            BtnUnVote.Visible = false;
            BtnVote.Visible = true;
            GlobalVar.candidate_id = lblcandidateid.Text;
            GlobalVar.position = lblposition.Text;
            GlobalVar.fullname = lblfullname.Text;
            try
            {
                con.Open();
                String query = "delete from votes where voters_id = @voters_id and position = @position";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@voters_id", GlobalVar.voters_id);
                cmd.Parameters.AddWithValue("@position", GlobalVar.position);
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryVote(GlobalVar.account_id, GlobalVar.user_type, GlobalVar.user);
                NotificationAddedSuccess a = new NotificationAddedSuccess();
                a.ShowDialog();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Vote Button
        private void BtnVote_Click(object sender, EventArgs e)
        {
            BtnUnVote.Visible = true;
            BtnVote.Visible = false;
            GlobalVar.candidate_id = lblcandidateid.Text;
            GlobalVar.position = lblposition.Text;
            GlobalVar.fullname = lblfullname.Text;
            DeleteVote();
            try
            {
                con.Open();
                String query = "insert into votes (voters_id,candidate_id,position) values (@voters_id, @candidate_id, @position)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@voters_id", GlobalVar.voters_id);
                cmd.Parameters.AddWithValue("@candidate_id", GlobalVar.candidate_id);
                cmd.Parameters.AddWithValue("@position", GlobalVar.position);
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryUnVote(GlobalVar.account_id, GlobalVar.user_type, GlobalVar.user);
                NotificationAddedSuccess a = new NotificationAddedSuccess();
                a.ShowDialog();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Retrieve Vote
        public void RetrieveVote()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                String query = "select candidate_id from votes where voters_id = @voters_id and position = @position";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@voters_id", GlobalVar.voters_id);
                cmd.Parameters.AddWithValue("@position", lblposition.Text) ;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   String candidate = dr["candidate_id"].ToString();
                    if (candidate == lblcandidateid.Text)
                    {
                        BtnUnVote.Visible = true;
                        BtnVote.Visible = false;
                    }
                    else
                    {
                        BtnVote.Visible = true;
                        BtnUnVote.Visible = false;
                    }
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
        #region Form Load
        private void ViewVote_Load(object sender, EventArgs e)
        {
            t1.Start();
        }
        #endregion
        #region Log History Vote Success
        void LogHistoryVote(string user_id, string user_type, string user)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                //Query to log history
                string query3 = "INSERT INTO `loghistory`(`account_id`, `account_type`,`username`, `log`) VALUES (@id, @accid,@user, @logs)";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@id", user_id);
                cmd3.Parameters.AddWithValue("@accid", user_type);
                cmd3.Parameters.AddWithValue("@user", user);
                cmd3.Parameters.AddWithValue("@logs", user + " has been succesfully vote " + GlobalVar.candidate_id + " in " + GlobalVar.position);
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
        #region Log History Un Vote Success
        void LogHistoryUnVote(string user_id, string user_type, string user)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                //Query to log history
                string query3 = "INSERT INTO `loghistory`(`account_id`, `account_type`,`username`, `log`) VALUES (@id, @accid,@user, @logs)";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@id", user_id);
                cmd3.Parameters.AddWithValue("@accid", user_type);
                cmd3.Parameters.AddWithValue("@user", user);
                cmd3.Parameters.AddWithValue("@logs", user + " has been succesfully un - vote " + GlobalVar.candidate_id + " in " + GlobalVar.position);
                cmd3.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion        #region Delete Vote
        #region Delete Vote
        public void DeleteVote()
        {
            try
            {
                con.Open();
                String query = "delete from votes where voters_id = @voters_id and position = @position";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@voters_id", GlobalVar.voters_id);
                cmd.Parameters.AddWithValue("@position", GlobalVar.position);
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryVote(GlobalVar.account_id, GlobalVar.user_type, GlobalVar.user);
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion

        private void t1_Tick(object sender, EventArgs e)
        {
            RetrieveVote();
        }
    }
}
