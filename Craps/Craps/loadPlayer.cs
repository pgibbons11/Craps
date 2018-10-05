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
    public partial class LoadPlayer : Form
    {
        
        public LoadPlayer()
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
                        lstboxPlayers.Items.Add(reader["name"]).ToString();
                    }
                }
                conn.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (lstboxPlayers.SelectedIndex >= 0)
            {
                Craps.Menu.currPlayer = lstboxPlayers.SelectedItem.ToString();
                goToMenu(this);
            }
            else
            {
                MessageBox.Show("Please select a profile.");
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            goToNew(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goToMenu(this);
        }

        private void lstboxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
