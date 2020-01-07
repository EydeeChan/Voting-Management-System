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
using System.IO;
#endregion

namespace Voting_Management_System
{
    public partial class FrmRegisterCandidate : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmRegisterCandidate()
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
        #region Cancel Button
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseTransparent();
        }
        #endregion
        #region Close Transparent
        public void CloseTransparent()
        {
            TransparentCandidate a = new TransparentCandidate();
            a.Hide();
            this.Hide();
        }
        #endregion
        #region Place Holder
        private void TxtStudentLName_Enter(object sender, EventArgs e)
        {
            if (TxtStudentLName.Text == "E.G. MERCADO RIZAL")
            {
                TxtStudentLName.Text = "";
            }
        }
        private void TxtStudentLName_Leave(object sender, EventArgs e)
        {
            if (TxtStudentLName.Text == "")
            {
                TxtStudentLName.Text = "E.G. MERCADO RIZAL";
            }
        }
        private void TxtStudentFName_Enter(object sender, EventArgs e)
        {
            if (TxtStudentFName.Text == "E.G. JOSE PROTASIO JR.")
            {
                TxtStudentFName.Text = "";
            }
        }
        private void TxtStudentFName_Leave(object sender, EventArgs e)
        {
            if (TxtStudentFName.Text == "")
            {
                TxtStudentFName.Text = "E.G. JOSE PROTASIO JR.";
            }
        }
        private void TxtStudentMName_Enter(object sender, EventArgs e)
        {
            if (TxtStudentMName.Text == "E.G. ALONSO REALONDA")
            {
                TxtStudentMName.Text = "";
            }
        }
        private void TxtStudentMName_Leave(object sender, EventArgs e)
        {
            if (TxtStudentMName.Text == "")
            {
                TxtStudentMName.Text = "E.G. ALONSO REALONDA";
            }
        }
        #endregion
        #region Register Candidate Button
        private void BtnRegisterTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MemoryStream ms = new MemoryStream();
                StudentPicture.Image.Save(ms, StudentPicture.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                String query = "insert into candidate(img, last_name, first_name, middle_name, birthdate, gender, age, grade, track, strand, partylist, position, platform) values (@img, @last_name, @first_name, @middle_name, @birthdate, @gender, @age, @grade, @track, @strand, @partylist, @position, @platform)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = a;
                cmd.Parameters.AddWithValue("@last_name", TxtStudentLName.Text);
                cmd.Parameters.AddWithValue("@first_name", TxtStudentFName.Text);
                cmd.Parameters.AddWithValue("@middle_name", TxtStudentMName.Text);
                cmd.Parameters.AddWithValue("@birthdate", TxtBirthdate.Text);
                if (GenderFemaleCheckBox.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Female");
                }
                else if (GenderMaleCheckBox.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Male");
                }
                cmd.Parameters.AddWithValue("@age", TxtAge.Text);
                cmd.Parameters.AddWithValue("@grade", TxtGrade.Text);
                cmd.Parameters.AddWithValue("@track", TxtTrack.Text);
                cmd.Parameters.AddWithValue("@strand", TxtStrand.Text);
                cmd.Parameters.AddWithValue("@partylist", TxtPartylist.Text);
                cmd.Parameters.AddWithValue("@position", TxtPosition.Text);
                cmd.Parameters.AddWithValue("@platform", TxtPlatform.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                NotificationAddedSuccess b = new NotificationAddedSuccess();
                b.ShowDialog();
                LogHistory(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
                CloseTransparent();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Edit Candidate Button
        private void BtnEditTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MemoryStream ms = new MemoryStream();
                StudentPicture.Image.Save(ms, StudentPicture.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                String query = "update candidate set img = @img, gender = @gender, age = @age, grade = @grade, track = @track, strand = @strand, partylist = @partylist, position = @position, platform = @platform where candidate_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id",lblcandidateid.Text);
                cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = a;
                if (GenderFemaleCheckBox.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Female");
                }
                else if (GenderMaleCheckBox.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", "Male");
                }
                cmd.Parameters.AddWithValue("@age", TxtAge.Text);
                cmd.Parameters.AddWithValue("@grade", TxtGrade.Text);
                cmd.Parameters.AddWithValue("@track", TxtTrack.Text);
                cmd.Parameters.AddWithValue("@strand", TxtStrand.Text);
                cmd.Parameters.AddWithValue("@partylist", TxtPartylist.Text);
                cmd.Parameters.AddWithValue("@position", TxtPosition.Text);
                cmd.Parameters.AddWithValue("@platform", TxtPlatform.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LogHistoryEdit(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.user);
                NotificationEditSuccess d = new NotificationEditSuccess();
                d.ShowDialog();
                CloseTransparent();
            }
            catch
            {
                NotificationConnectionError a = new NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Browse File Button
        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                StudentPicture.Image = new Bitmap(open.FileName);
                // image file path  
                String FilePath = open.FileName;
            }
        }
        #endregion
        #region Form Load
        private void FrmRegisterCandidate_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            RetrievePartylist();
            RetrievePosition();
            RetrieveTrack();
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
        #region Log History Added
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully add candidate.");
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
        #region Log History Edit
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
                cmd3.Parameters.AddWithValue("logs", user + " has been succesfully edit candidate.");
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
        #region Retrieve Partylist
        void RetrievePartylist()
        {
            try
            {
                con.Open();
                String query = "select * from partylist";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtPartylist.Items.Add(reader.GetString("partylist"));
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
        #region Retrieve Position
        void RetrievePosition()
        {
            try
            {
                con.Open();
                String query = "select * from position";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TxtPosition.Items.Add(reader.GetString("position"));
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
        #region Gender Male CheckBox On Change
        private void GenderMaleCheckBox_OnChange(object sender, EventArgs e)
        {
            if (GenderMaleCheckBox.Checked == true)
            {
                GenderFemaleCheckBox.Checked = false;
            }
        }
        #endregion
        #region Gender Female CheckBox On Change
        private void GenderFemaleCheckBox_OnChange(object sender, EventArgs e)
        {
            if (GenderFemaleCheckBox.Checked == true)
            {
                GenderMaleCheckBox.Checked = false;
            }
        }
        #endregion
        #region TxtTrack Selected Index Changed
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
    }
}