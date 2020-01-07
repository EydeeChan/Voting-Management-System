#region Imports
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
#endregion


namespace Voting_Management_System
{
    public partial class FrmPosition : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmPosition()
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
        private void FrmPosition_Load(object sender, EventArgs e)
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
        #region Add Position Button
        private void BtnAddPosition_Click(object sender, EventArgs e)
        {
            TransparentPosition a = new TransparentPosition();
            FrmAddPosition b = new FrmAddPosition();
            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Retrieve
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from position";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewPosition a = new ViewPosition();
                    a.lblpositionid.Text = dt.Rows[i]["position_id"].ToString();
                    a.lblposition.Text = dt.Rows[i]["position"].ToString();
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
        #region Refresh Button
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Retrieve();
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
            TransparentAdmin a = (TransparentAdmin)Application.OpenForms["TransparentAdmin"];
            a.Close();
            this.Hide();
        }
        #endregion
    }
}
