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
    public partial class FrmAddPosition : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmAddPosition()
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
        private void FrmAddPosition_Load(object sender, EventArgs e)
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
        #region Cancel Button
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseTransparent();
        }
        #endregion
        #region Close Transparent
        public void CloseTransparent()
        {
            TransparentPosition a = (TransparentPosition)Application.OpenForms["TransparentPosition"];
            a.Close();
            this.Hide();
        }
        #endregion
        #region Add Position Button
        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            if(TxtPosition.Text == "")
            {
                NotificationFillBlank a = new NotificationFillBlank();
                a.ShowDialog();
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "insert into position (position) values (@position)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@position", TxtPosition.Text);
                    cmd.ExecuteNonQuery();
                    Clear();
                    con.Close();
                    LogHistory(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
                    CloseTransparent();
                    NotificationAddedSuccess a = new NotificationAddedSuccess();
                    a.ShowDialog();
                }
                catch
                {
                    NotificationConnectionError a = new NotificationConnectionError();
                    a.ShowDialog();
                }
            }
        }
        #endregion
        #region Edit Position Button
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "update position set position = @position where position_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", lblpositionid.Text);
                cmd.Parameters.AddWithValue("@position", TxtPosition.Text);
                cmd.ExecuteNonQuery();
                Clear();
                con.Close();
                CloseTransparent();
                LogHistoryEdit(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
                NotificationEditSuccess a = new NotificationEditSuccess();
                a.ShowDialog();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Clear
        public void Clear()
        {
            TxtPosition.Clear();
        }
        #endregion
        #region Log History Add Position
        void LogHistory(string user_id, string user_type, string user)
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully add position.");
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
        #region Log History Edit Position
        void LogHistoryEdit(string user_id, string user_type, string user)
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully edit position.");
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
    }
}
