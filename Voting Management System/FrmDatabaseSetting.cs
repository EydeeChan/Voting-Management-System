#region Imports
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
#endregion

namespace Voting_Management_System
{
    public partial class FrmDatabaseSetting : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmDatabaseSetting()
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
        private void FrmDatabaseSetting_Load(object sender, EventArgs e)
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
            CloseTransparent();
        }
        #endregion
        #region Close Transparent
        public void CloseTransparent()
        {
            TransparentLogin a = (TransparentLogin)Application.OpenForms["TransparentLogin"];
            a.Close();
            this.Hide();
        }
        #endregion
        #region Retrieve
        void Retrieve()
        {
            TxtServer.Text = Properties.Settings.Default.DatabaseServer;
            TxtDatabase.Text = Properties.Settings.Default.Database;
            TxtDatabaseUsername.Text = Properties.Settings.Default.DatabaseUsername;
            TxtDatabasePassword.Text = Properties.Settings.Default.DatabasePassword;
            TxtDatabasePassword.Text = Properties.Settings.Default.DatabasePort;
        }
        #endregion
        #region Save Button
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TxtServer.Text == "" || TxtDatabase.Text == "" || TxtDatabaseUsername.Text == "" || TxtDatabasePort.Text == "")
            {
                NotificationFillBlank a = new NotificationFillBlank();
                a.Show();
            }
            else
            {
                if (RememberMeCheckBox.Checked)
                {
                    GlobalVar.DatabaseServer = TxtServer.Text;
                    GlobalVar.Database = TxtDatabase.Text;
                    GlobalVar.DatabaseUsername = TxtDatabaseUsername.Text;
                    GlobalVar.DatabasePassword = TxtDatabasePassword.Text;
                    GlobalVar.DatabasePort = TxtDatabasePort.Text;
                    Connection.SetServer(GlobalVar.DatabaseServer);
                    Connection.SetDatabase(GlobalVar.Database);
                    Connection.SetUid(GlobalVar.DatabaseUsername);
                    Connection.SetPassword(GlobalVar.DatabasePassword);
                    Connection.SetPort(GlobalVar.DatabasePort);
                    try
                    {
                        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                        Properties.Settings.Default.DatabaseServer = TxtServer.Text;
                        Properties.Settings.Default.Database = TxtDatabase.Text;
                        Properties.Settings.Default.DatabaseUsername = TxtDatabaseUsername.Text;
                        Properties.Settings.Default.DatabasePassword = TxtDatabasePassword.Text;
                        Properties.Settings.Default.DatabasePort = TxtDatabasePort.Text;
                        Properties.Settings.Default.Save();
                        con.Open();
                        this.Hide();
                        NotificationConnectionSuccess a = new NotificationConnectionSuccess();
                        a.ShowDialog();
                    }
                    catch
                    {
                        NotificationConnectionError a = new NotificationConnectionError();
                        a.Show();
                    }

                }
                else
                {
                    GlobalVar.DatabaseServer = TxtServer.Text;
                    GlobalVar.Database = TxtDatabase.Text;
                    GlobalVar.DatabaseUsername = TxtDatabaseUsername.Text;
                    GlobalVar.DatabasePassword = TxtDatabasePassword.Text;
                    GlobalVar.DatabasePort = TxtDatabasePort.Text;
                    Connection.SetServer(GlobalVar.DatabaseServer);
                    Connection.SetDatabase(GlobalVar.Database);
                    Connection.SetUid(GlobalVar.DatabaseUsername);
                    Connection.SetPassword(GlobalVar.DatabasePassword);
                    Connection.SetPort(GlobalVar.DatabasePort);
                    try
                    {
                        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                        con.Open();
                        this.Hide();
                        NotificationConnectionSuccess a = new NotificationConnectionSuccess();
                        a.Show();
                    }
                    catch
                    {
                        NotificationConnectionError a = new NotificationConnectionError();
                        a.Show();
                    }
                }
            }
        }
        #endregion
        #region Remember Me CheckBox Changed
        private void RememberMeCheckBox_OnChange(object sender, EventArgs e)
        {
            Properties.Settings.Default.DatabaseServer = TxtServer.Text;
            Properties.Settings.Default.Database = TxtDatabase.Text;
            Properties.Settings.Default.DatabaseUsername = TxtDatabaseUsername.Text;
            Properties.Settings.Default.DatabasePassword = TxtDatabasePassword.Text;
            Properties.Settings.Default.DatabasePort = TxtDatabasePort.Text;
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}