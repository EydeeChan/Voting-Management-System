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
#endregion

namespace Voting_Management_System
{
    public partial class ViewPartylist : UserControl
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public ViewPartylist()
        {
            InitializeComponent();
        }
        #region Edit Button
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TransparentPosition b = new TransparentPosition();
            FrmAddPartylist a = new FrmAddPartylist();
            try
            {
                a.label8.Text = "Edit Partylist";
                a.lblpartylistid.Text = lblpartylistid.Text;
                a.BtnAddPosition.Visible = false;
                con.Open();
                String query = "select * from partylist where position_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", lblpartylistid.Text);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    a.TxtPosition.Text = (dr["partylist"]).ToString();
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
            GlobalVar.Delete = "partylist";
            NotificationDelete a = new NotificationDelete();
            a.lblid.Text = lblpartylistid.Text;
            a.lbltitle.Text = "Are you sure you want to delete position " + lblpartylist.Text + " ?";
            a.ShowDialog();
        }
        #endregion
        #region Form Load
        private void ViewPartylist_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
    }
}
