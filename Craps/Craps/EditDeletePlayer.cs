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
    public partial class EditDeletePlayer : Form
    {
        public static string toEdit = "";
        public EditDeletePlayer()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
            string query = "SELECT name FROM Players";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lstboxPlayers.Items.Add((string)reader["name"]);
                    }
                }
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goToMenu(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lstboxPlayers.SelectedIndex >= 0)
            {
                toEdit = lstboxPlayers.SelectedItem.ToString();
                goToEdit(this);
            }

            else
            {
                MessageBox.Show("Please select a profile.");
                return;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete " + lstboxPlayers.SelectedItem.ToString()+ "?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
                string query = "DELETE FROM Players WHERE name = @Name;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Name", lstboxPlayers.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(lstboxPlayers.SelectedItem.ToString() + " has been deleted.");
                    conn.Close();
                    if (lstboxPlayers.SelectedItem.ToString() == Craps.Menu.currPlayer)
                        Craps.Menu.currPlayer = "";
                    goToMenu(this);
                }
            }
            else if (dialogResult == DialogResult.No)
                return;
        }
    }
}
