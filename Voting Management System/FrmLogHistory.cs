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
    public partial class FrmLogHistory : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmLogHistory()
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
            this.Hide();
            FrmAdmin a = new FrmAdmin();
            a.Show();
        }
        #endregion
        #region Form Load
        private void FrmLogHistory_Load(object sender, EventArgs e)
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
        #region Place Holder
        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "Search here..")
            {
                TxtSearch.Text = "";
                TxtSearch.Clear();
                TxtSearch.ForeColor = Color.Black;
            }
        }
        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (TxtSearch.Text == "")
            {
                TxtSearch.Text = "Search here..";
                TxtSearch.Clear();
                TxtSearch.ForeColor = Color.Black;
            }
        }
        #endregion
        #region Refresh Button
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Retrieve();
        }
        #endregion
        #region Search Button
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(TxtSearchBy.Text == "Log ID")
            {
                GlobalVar.LogSearch = "log_id";
            }
            if(TxtSearchBy.Text == "Account ID")
            {
                GlobalVar.LogSearch = "account_id";
            }
            if(TxtSearchBy.Text == "Username")
            {
                GlobalVar.LogSearch = "log_id";
            }
            if(TxtSearchBy.Text == "Logs")
            {
                GlobalVar.LogSearch = "logs";
            }
            if(TxtSearchBy.Text == "Last Update")
            {
                GlobalVar.LogSearch = "last_update";
            }
            RetrieveOne(GlobalVar.LogSearch);
        }
        #endregion
        #region Retrieve
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from loghistory";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewLogHistory a = new ViewLogHistory();
                    a.lbllogid.Text = dt.Rows[i]["log_id"].ToString();
                    a.lblaccountid.Text = dt.Rows[i]["account_id"].ToString();
                    a.lblaccounttype.Text = dt.Rows[i]["account_type"].ToString();
                    a.lblusername.Text = dt.Rows[i]["username"].ToString();
                    a.lbllog.Text = dt.Rows[i]["log"].ToString();
                    a.lbllastupdate.Text = dt.Rows[i]["last_update"].ToString();
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
        #region Retrieve One
        public void RetrieveOne(string SearchString)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from loghistory where " + SearchString + " = @Search" ;
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@Search", TxtSearch.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewLogHistory a = new ViewLogHistory();
                    a.lbllogid.Text = dt.Rows[i]["log_id"].ToString();
                    a.lblaccountid.Text = dt.Rows[i]["account_id"].ToString();
                    a.lblaccounttype.Text = dt.Rows[i]["account_type"].ToString();
                    a.lblusername.Text = dt.Rows[i]["username"].ToString();
                    a.lbllog.Text = dt.Rows[i]["log"].ToString();
                    a.lbllastupdate.Text = dt.Rows[i]["last_update"].ToString();
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
