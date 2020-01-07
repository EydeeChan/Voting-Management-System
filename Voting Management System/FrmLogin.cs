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
    public partial class FrmLogin : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmLogin()
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
            Application.Exit();
        }
        #endregion
        #region Minimized Button
        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Setting Button
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            TransparentLogin a = new TransparentLogin();
            FrmDatabaseSetting b = new FrmDatabaseSetting();

            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Place Holder
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Username")
            {
                TxtUsername.Text = "";
                TxtUsername.Clear();
                TxtUsername.ForeColor = Color.Black;
            }
        }
        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                TxtUsername.Clear();
                TxtUsername.Text = "Username";
                TxtUsername.ForeColor = Color.Silver;
            }
        }
        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.PasswordChar = '•';
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.PasswordChar = '\0';
                TxtPassword.Text = "Password";
                TxtPassword.ForeColor = Color.Silver;
                TxtPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion
        #region Remember Me
        private void RememberMeCheckBox_OnChange(object sender, EventArgs e)
        {
            if (RememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = TxtUsername.Text;
                Properties.Settings.Default.Password = TxtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }
        #endregion
        #region Login Button
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            GlobalVar.user = TxtUsername.Text;
            if (TxtUsername.Text == "Username" && TxtPassword.Text == "Password")
            {
                label10.Text = "Username and Password can't be blank!";
            }
            else if (TxtPassword.Text == "Password" && TxtUsername.Text == "")
            {
                label10.Text = "Username and Password can't be blank!";
            }
            else if (TxtUsername.Text == "Username" && TxtPassword.Text == "")
            {
                label10.Text = "Username and Password can't be blank!";
            }
            else if (TxtUsername.Text == "Username")
            {
                label10.Text = "Username can't be blank! ";
            }
            else if (TxtPassword.Text == "Password")
            {
                label10.Text = "Password can't be blank! ";
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT account_type, account_id, status FROM account WHERE username = @user and password = @pass";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", TxtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", SHA256Hasher.ComputeSha256Hash(TxtPassword.Text));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GlobalVar.user_type = reader["account_type"].ToString();
                        GlobalVar.user_id = reader["account_id"].ToString();
                        GlobalVar.status = reader["status"].ToString();
                    }
                    con.Close();
                    if (GlobalVar.user_type == "")
                    {
                        label10.Text = "Incorrect Password or Username. ";
                    }
                    else
                    {
                        LogHistoryLoginSuccess(GlobalVar.user_id, GlobalVar.user_type, TxtUsername.Text);
                        if (GlobalVar.user_type.Equals("SSG"))
                        {
                            FrmAdmin a = new FrmAdmin();
                            a.Show();
                            this.Hide();
                        }
                        else if (GlobalVar.user_type.Equals("Comelec"))
                        {
                            FrmTally a = new FrmTally();
                            a.Show();
                            this.Hide();
                        }
                        else if (GlobalVar.user_type.Equals("Voter"))
                        {
                            try
                            {
                                con.Open();
                                string query1 = "SELECT voters_id, status FROM voters WHERE account_id = @id";
                                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                                cmd1.Parameters.AddWithValue("@id", GlobalVar.user_id);
                                MySqlDataReader reader1 = cmd1.ExecuteReader();
                                while (reader1.Read())
                                {
                                    GlobalVar.status = reader1["status"].ToString();
                                    GlobalVar.voters_id = reader1["voters_id"].ToString();
                                }
                                con.Close();
                                if (GlobalVar.status == "Voted")
                                {
                                    label10.Text = "You are already voted.";
                                }
                                else
                                {
                                    FrmDashboard a = new FrmDashboard();
                                    a.Show();
                                    this.Hide();
                                }
                            }
                            catch
                            {
                                NotificationConnectionError b = new NotificationConnectionError();
                                b.ShowDialog();
                            }
                        }
                    }
                }
                catch
                {
                    NotificationConnectionError a = new NotificationConnectionError();
                    a.ShowDialog();
                }
            }
        }
        #endregion
        #region Log History Login Success
        void LogHistoryLoginSuccess(string user_id, string user_type, string user)
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
                cmd3.Parameters.AddWithValue("@logS", user + " has been succesfully login.");
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
        #region Form Load
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = Properties.Settings.Default.Username;
            TxtPassword.Text = Properties.Settings.Default.Password;
            if(TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                TxtUsername.Text = "Username";
                TxtPassword.Text = "Password";
                TxtPassword.PasswordChar = '\0';
            }
            else if (TxtUsername.Text == "Username" || TxtPassword.Text == "Password")
            {
                TxtUsername.Text = "Username";
                TxtPassword.Text = "Password";
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
    }
}
