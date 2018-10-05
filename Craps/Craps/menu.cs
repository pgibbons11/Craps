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
    public partial class Menu : Form
    {
        public static string currPlayer = "";

        public Menu()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
            lblPlayingAs.Text += currPlayer;

            if (currPlayer != "")
            {
                string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
                string query = "SELECT * from Players WHERE name = @Player";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Player", currPlayer);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblStats.Text = "Games Played: " + reader["gamesPlayed"].ToString() +
                                            "   Wins: " + reader["wins"].ToString() +
                                            "   Losses: " + reader["losses"].ToString() +
                                            "   Roll Sum: " + reader["rollSum"].ToString();
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(currPlayer == "")
            {
                MessageBox.Show("Please select or create a profile before playing.");
                return;
            }
            goToPlay(this);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            goToNew(this);
        }

        private void btnLoadPlayer_Click(object sender, EventArgs e)
        {
            goToLoad(this);
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            goToEditDel(this);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
