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
using System.IO;
#endregion

namespace Voting_Management_System
{
    public partial class ViewCandidate : UserControl
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public ViewCandidate()
        {
            InitializeComponent();
        }
        #region Form Load
        private void ViewCandidate_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
        #region Edit Button
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TransparentCandidate b = new TransparentCandidate();
            FrmRegisterCandidate a = new FrmRegisterCandidate();
            try
            {
                a.lblcandidateid.Text = lblcandidate.Text;
                a.TxtStudentFName.Enabled = false;
                a.TxtStudentMName.Enabled = false;
                a.TxtStudentLName.Enabled = false;
                a.BtnRegisterTeacher.Visible = false;
                con.Close();
                con.Open();
                String query = "select * from candidate where candidate_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", lblcandidate.Text);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        byte[] img = (byte[])(dr["img"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.StudentPicture.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.label8.Text = "Edit Candidate";
                    a.lblcandidateid.Text = (dr["candidate_id"]).ToString();
                    a.TxtStudentLName.Text = (dr["last_name"]).ToString();
                    a.TxtStudentMName.Text = (dr["middle_name"]).ToString();
                    a.TxtStudentFName.Text = (dr["first_name"]).ToString();
                    String gender = (dr["gender"]).ToString();
                    if (gender == "Male")
                    {
                        a.GenderMaleCheckBox.Checked = true;
                    }
                    else if (gender == "Female")
                    {
                        a.GenderFemaleCheckBox.Checked = true;
                    }
                    a.TxtAge.Text = (dr["age"]).ToString();
                    a.TxtGrade.Text = (dr["grade"]).ToString();
                    a.TxtTrack.Text = (dr["track"]).ToString();
                    a.TxtStrand.Text = (dr["strand"]).ToString();
                    a.TxtPartylist.Text = (dr["partylist"]).ToString();
                    a.TxtPosition.Text = (dr["position"]).ToString();
                    a.TxtPlatform.Text = (dr["platform"]).ToString();
                }
                dr.Close();
                con.Close();
                b.Show();
                a.ShowDialog();
                b.Hide();
            }
            catch
            {
                NotificationConnectionError c = new NotificationConnectionError();
                c.ShowDialog();
            }
        }
        #endregion
        #region Delete Button
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            GlobalVar.Delete = "candidate";
            NotificationDelete a = new NotificationDelete();
            a.lblid.Text = lblcandidate.Text;
            a.lbltitle.Text = "Are you sure you want to delete candidate " + lblfirstname.Text + " " + lblastname.Text + " ?";
            a.ShowDialog();
        }
        #endregion
    }
}
