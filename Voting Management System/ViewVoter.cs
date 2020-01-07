#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
#endregion

namespace Voting_Management_System
{
    public partial class ViewVoter : UserControl
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public ViewVoter()
        {
            InitializeComponent();
        }
        #region Edit Button
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TransparentVoters b = new TransparentVoters();
            FrmAddVoters a = new FrmAddVoters();
            try
            {
                a.lblvotersrid.Text = lblvotersid.Text;
                a.BtnAddPosition.Visible = false;
                con.Close();
                con.Open();
                String query = "select voters.voters_id, voters.first_name, voters.last_name, voters.middle_name, voters.grade, voters.strand, voters.track, account.username from voters inner join account on voters.account_id = account.account_id where voters_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", lblvotersid.Text);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    a.label8.Text = "Edit Voter";
                    a.lblvotersrid.Text = (dr["voters_id"]).ToString();
                    a.TxtFirstName.Text = (dr["first_name"]).ToString();
                    a.TxtLastName.Text = (dr["last_name"]).ToString();
                    a.TxtMiddleName.Text = (dr["middle_name"]).ToString();
                    a.TxtFirstName.Enabled = false;
                    a.TxtLastName.Enabled = false;
                    a.TxtMiddleName.Enabled = false;
                    a.TxtGrade.Text = (dr["grade"]).ToString();
                    a.TxtStrand.Text = (dr["strand"]).ToString();
                    a.TxtTrack.Text = (dr["track"]).ToString();
                    a.TxtUsername.Text = (dr["username"]).ToString();
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
            GlobalVar.Delete = "voter";
            NotificationDelete a = new NotificationDelete();
            a.lblid.Text = lblvotersid.Text;
            a.lbltitle.Text = "Are you sure you want to delete voter " + lblfirstname.Text + " " + lblfirstname.Text + " ?";
            a.ShowDialog();
        }
        #endregion
        #region Form Load
        private void ViewVoter_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
    }
}
