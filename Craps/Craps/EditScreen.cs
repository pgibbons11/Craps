using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Craps.ChangeForms;

namespace Craps
{
    public partial class EditScreen : Form
    {
        public EditScreen()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
            txtName.Text = Craps.EditDeletePlayer.toEdit;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goToEditDel(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
            string query = "UPDATE Players SET name = @NewName WHERE name = @Player";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@NewName", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Player", Craps.EditDeletePlayer.toEdit);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            if(Craps.EditDeletePlayer.toEdit == Craps.Menu.currPlayer)
                Craps.Menu.currPlayer = txtName.Text.Trim();
            goToMenu(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
            string query = "UPDATE Players SET gamesPlayed = 0, wins = 0, losses = 0, rollSum = 0 WHERE name = @Player";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Player", Craps.EditDeletePlayer.toEdit);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data for " + Craps.EditDeletePlayer.toEdit + " has been cleared.");
                conn.Close();
            }
            goToMenu(this);
        }
    }
}
