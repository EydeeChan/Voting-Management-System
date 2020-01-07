#region Imports
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
#endregion

namespace Voting_Management_System
{
    public partial class ViewLogHistory : UserControl
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public ViewLogHistory()
        {
            InitializeComponent();
        }
        #region Form Load
        private void ViewLogHistory_Load(object sender, System.EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        #endregion
    }
}
