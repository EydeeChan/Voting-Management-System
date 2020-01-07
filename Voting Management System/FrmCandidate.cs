#region Imports
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
#endregion

namespace Voting_Management_System
{
    public partial class FrmCandidate : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmCandidate()
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
        private void FrmCandidate_Load(object sender, EventArgs e)
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
        #region Register Button
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            TransparentCandidate a = new TransparentCandidate();
            FrmRegisterCandidate b = new FrmRegisterCandidate();
            a.Show();
            b.ShowDialog();
            a.Hide();
        }
        #endregion
        #region Search Button
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TxtSearchBy.Text == "First Name")
            {
                GlobalVar.CandidateSearch = "first_name";
            }
            if (TxtSearchBy.Text == "Middle Name")
            {
                GlobalVar.CandidateSearch = "middle_name";
            }
            if (TxtSearchBy.Text == "Last Name")
            {
                GlobalVar.CandidateSearch = "last_name";
            }
            if (TxtSearchBy.Text == "Grade")
            {
                GlobalVar.CandidateSearch = "grade";
            }
            if (TxtSearchBy.Text == "Track")
            {
                GlobalVar.CandidateSearch = "track";
            }
            if (TxtSearchBy.Text == "Strand")
            {
                GlobalVar.CandidateSearch = "Strand";
            }
            if (TxtSearchBy.Text == "Position")
            {
                GlobalVar.CandidateSearch = "position";
            }
            if (TxtSearchBy.Text == "Platform")
            {
                GlobalVar.CandidateSearch = "platform";
            }
            if (TxtSearchBy.Text == "Partylist")
            {
                GlobalVar.CandidateSearch = "partylist";
            }
            RetrieveOne(GlobalVar.CandidateSearch);
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
            this.Hide();
            FrmAdmin a = new FrmAdmin();
            a.Show();
        }
        #endregion
        #region Retrieve
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from candidate";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewCandidate a = new ViewCandidate();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[i]["img"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.lblcandidate.Text = dt.Rows[i]["candidate_id"].ToString();
                    a.lblastname.Text = dt.Rows[i]["last_name"].ToString();
                    a.lblfirstname.Text = dt.Rows[i]["first_name"].ToString();
                    a.lblmiddlename.Text = dt.Rows[i]["middle_name"].ToString();
                    a.lblgender.Text = dt.Rows[i]["gender"].ToString();
                    a.lblage.Text = dt.Rows[i]["age"].ToString();
                    a.lblgrade.Text = dt.Rows[i]["grade"].ToString();
                    String Track = dt.Rows[i]["track"].ToString();
                    String Strand = dt.Rows[i]["strand"].ToString();
                    a.lbltrackstrand.Text = Track + " " + Strand;
                    a.lblpartylist.Text = dt.Rows[i]["partylist"].ToString();
                    a.lblposition.Text = dt.Rows[i]["position"].ToString();
                    a.lblplatform.Text = dt.Rows[i]["platform"].ToString();
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
        #region RetrieveOne
        public void RetrieveOne(string CandidateSearch)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
            try
            {
                String query = "select * from candidate where " + CandidateSearch + " = @Search";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@Search", TxtSearch.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewCandidate a = new ViewCandidate();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[i]["img"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.lblcandidate.Text = dt.Rows[i]["candidate_id"].ToString();
                    a.lblastname.Text = dt.Rows[i]["last_name"].ToString();
                    a.lblfirstname.Text = dt.Rows[i]["first_name"].ToString();
                    a.lblmiddlename.Text = dt.Rows[i]["middle_name"].ToString();
                    a.lblgender.Text = dt.Rows[i]["gender"].ToString();
                    a.lblage.Text = dt.Rows[i]["age"].ToString();
                    a.lblgrade.Text = dt.Rows[i]["grade"].ToString();
                    String Track = dt.Rows[i]["track"].ToString();
                    String Strand = dt.Rows[i]["strand"].ToString();
                    a.lbltrackstrand.Text = Track + " " + Strand;
                    a.lblpartylist.Text = dt.Rows[i]["partylist"].ToString();
                    a.lblposition.Text = dt.Rows[i]["position"].ToString();
                    a.lblplatform.Text = dt.Rows[i]["platform"].ToString();
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
        #region PlaceHolder
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
    }
}
