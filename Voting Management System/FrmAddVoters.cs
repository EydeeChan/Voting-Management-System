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
    public partial class FrmAddVoters : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        String user_id = null;
        public FrmAddVoters()
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
        private void FrmAddVoters_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            RetrieveTrack();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            if (TxtUsername.Text == "" || TxtPassword.Text == "")
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
        #region Edit Account Button
        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            if (TxtGrade.Text == "" || TxtStrand.Text == "" || TxtTrack.Text == "")
            {
                NotificationFillBlank a = new NotificationFillBlank();
                a.ShowDialog();
            }
            else
            {
                try
                {
                    GetAccountInfo();
                    UpdateAccount();
                    con.Open();
                    String query = "update voters set grade = @grade, track = @track, strand = @strand where account_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", user_id);
                    cmd.Parameters.AddWithValue("@grade", TxtGrade.Text);
                    cmd.Parameters.AddWithValue("@track", TxtTrack.Text);
                    cmd.Parameters.AddWithValue("@strand", TxtStrand.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LogHistoryEdit(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
                    CloseTransparent();
                    NotificationEditSuccess a = new NotificationEditSuccess();
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
        #region Add Position Button
        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == "" || TxtMiddleName.Text == "" || TxtLastName.Text == "" || TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                NotificationFillBlank a = new NotificationFillBlank();
                a.ShowDialog();
            }
            else if (TxtFirstName.Text == "E.G. MERCADO RIZAL" || TxtMiddleName.Text == "E.G. JOSE PROTASIO JR." || TxtLastName.Text == "E.G. ALONSO REALONDA" || TxtUsername.Text == "Username" || TxtPassword.Text == "Password")
            {
                NotificationFillBlank a = new NotificationFillBlank();
                a.ShowDialog();
            }
            else
            {
                InserAccount();
                GetAccountInfo();
                try
                {
                    con.Open();
                    String query = "insert into voters(account_id, last_name, first_name, middle_name, track, strand) values (@voters_id, @last_name, @first_name, @middle_name, @track, @strand)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@voters_id", user_id);
                    cmd.Parameters.AddWithValue("@last_name", TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@first_name", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@middle_name", TxtMiddleName.Text);
                    cmd.Parameters.AddWithValue("@track", TxtTrack.Text);
                    cmd.Parameters.AddWithValue("@strand", TxtStrand.Text);
                    cmd.ExecuteNonQuery();
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
        #region Log History Add Voter
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully add voter.");
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
        #region Log History Edit Voter
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully edit voter.");
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
        #region Close Transparent
        public void CloseTransparent()
        {
            TransparentVoters a = (TransparentVoters)Application.OpenForms["TransparentVoters"];
            a.Close();
            this.Hide();
        }
        #endregion
        #region Cancel Button
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseTransparent();
        }
        #endregion
        #region Place Holder
        private void TxtStudentLName_Enter(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "E.G. MERCADO RIZAL")
            {
                TxtLastName.Text = "";
            }
        }
        private void TxtStudentLName_Leave(object sender, EventArgs e)
        {
            if (TxtLastName.Text == "")
            {
                TxtLastName.Text = "E.G. MERCADO RIZAL";
            }
        }
        private void TxtStudentFName_Enter(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == "E.G. JOSE PROTASIO JR.")
            {
                TxtFirstName.Text = "";
            }
        }
        private void TxtStudentFName_Leave(object sender, EventArgs e)
        {
            if (TxtFirstName.Text == "")
            {
                TxtFirstName.Text = "E.G. JOSE PROTASIO JR.";
            }
        }
        private void TxtStudentMName_Enter(object sender, EventArgs e)
        {
            if (TxtMiddleName.Text == "E.G. ALONSO REALONDA")
            {
                TxtMiddleName.Text = "";
            }
        }
        private void TxtStudentMName_Leave(object sender, EventArgs e)
        {
            if (TxtMiddleName.Text == "")
            {
                TxtMiddleName.Text = "E.G. ALONSO REALONDA";
            }
        }
        #endregion
        #region Insert Account
        public void InserAccount()
        {
            try
            {
                con.Open();
                String query = "INSERT INTO `account` (`username`, `password`, `account_type`) VALUES (@username, @password, @account_type)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@password", SHA256Hasher.ComputeSha256Hash(TxtPassword.Text));
                cmd.Parameters.AddWithValue("@account_type", "Voter");
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryAddAccount(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Update Account
        public void UpdateAccount()
        {
            try
            {
                con.Open();
                String query = "update account set username = @username, password= @password  where account_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", user_id);
                cmd.Parameters.AddWithValue("@username", TxtUsername.Text);
                cmd.Parameters.AddWithValue("@password", SHA256Hasher.ComputeSha256Hash(TxtPassword.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryEditAccount(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Get Account Info
        public void GetAccountInfo()
        {
            try
            {
                con.Open();
                String query = "SELECT account_id  FROM account WHERE username = @user ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", TxtUsername.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user_id = reader["account_id"].ToString();
                }
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Retrieve Track
        void RetrieveTrack()
        {
            try
            {
                con.Open();
                String query = "select * from track";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtTrack.Items.Add(reader.GetString("track"));
                }
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Retrieve Strand
        void RetrieveStrand(string track)
        {
            TxtStrand.Items.Clear();
            try
            {
                con.Open();
                String query = "select * from strand where track_id = @track ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@track", track);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtStrand.Items.Add(reader.GetString("strand"));
                }
                con.Close();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Log History Add Account
        void LogHistoryAddAccount(string user_id, string user_type, string user)
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully add account.");
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
        #region Log History Edit Account
        void LogHistoryEditAccount(string user_id, string user_type, string user)
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully edit account.");
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
        #region TxtTrack Selectyed Index Changed
        private void TxtTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveTrackid();
            RetrieveStrand(GlobalVar.track_id);
        }
        #endregion
        #region Retrieve Track id
        public void RetrieveTrackid()
        {
            try
            {
                con.Open();
                String query = "select * from track where track = @track ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@track", TxtTrack.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GlobalVar.track_id = reader["track_id"].ToString();
                }
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
    }
}
