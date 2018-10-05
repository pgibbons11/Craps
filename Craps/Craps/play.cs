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
    public partial class Play : Form
    {
        int point = 0;
        int rollSum = 0;
        int x = 0, y = 0;

        public Play()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
            string query = "SELECT * from Players WHERE name = @Player";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Player", Craps.Menu.currPlayer);
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

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x = rnd.Next(1, 7);
            y = rnd.Next(1, 7);
            updateDicePics(x, y);
            int res = checkResult(x + y);
            rollSum += (x + y);

            // if win/lose
            if (res != 0)
            {
                string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
                string queryU = "";
                string queryS = "SELECT * from Players WHERE name = @Player";
                switch (res)
                {
                    case -1:
                        queryU = "UPDATE Players SET losses = losses + 1, gamesPlayed = gamesPlayed + 1, rollSum = rollSum + @RollSum WHERE name = @Player";
                        break;
                    case 1:
                        queryU = "UPDATE Players SET wins = wins + 1, gamesPlayed = gamesPlayed + 1, rollSum = rollSum + @RollSum WHERE name = @Player";
                        break;
                }
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmdU = new SqlCommand(queryU, conn))
                using (SqlCommand cmdS = new SqlCommand(queryS, conn))
                {
                    conn.Open();
                    cmdU.Parameters.AddWithValue("@RollSum", rollSum);
                    cmdU.Parameters.AddWithValue("@Player", Craps.Menu.currPlayer);
                    cmdU.ExecuteNonQuery();
                    cmdS.Parameters.AddWithValue("@Player", Craps.Menu.currPlayer);
                    using (SqlDataReader reader = cmdS.ExecuteReader())
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
                point = 0;
                rollSum = 0;
            }
        }

        private int checkResult(int sum)
        {
            // 1st roll
            if (point == 0)
            {
                switch (sum)
                {
                    case 7:
                    case 11:
                        lblShow.Text = "You won!";
                        lblShow.Location = new Point(203, 270);
                        return 1;
                    case 2:
                    case 3:
                    case 12:
                        lblShow.Text = "You lost!";
                        lblShow.Location = new Point(203, 270);
                        return -1;
                    default:
                        point = sum;
                        lblShow.Text = "Point: " + sum.ToString();
                        lblShow.Location = new Point(205,270);
                        return 0;
                }
            }
            // 2nd+ roll
            else
            {
                if(sum == 7)
                {
                    lblShow.Text = "You lost!";
                    lblShow.Location = new Point(203, 270);
                    return -1;
                }
                else if (sum == point)
                {
                    lblShow.Text = "You won!";
                    lblShow.Location = new Point(203, 270);
                    return 1;
                }
                else
                    return 0;
            }
        }

        private void updateDicePics(int x, int y)
        {
            switch (x)
            {
                case 1:
                    die1.Image = Properties.Resources.s1;
                    break;
                case 2:
                    die1.Image = Properties.Resources.s2;
                    break;
                case 3:
                    die1.Image = Properties.Resources.s3;
                    break;
                case 4:
                    die1.Image = Properties.Resources.s4;
                    break;
                case 5:
                    die1.Image = Properties.Resources.s5;
                    break;
                case 6:
                    die1.Image = Properties.Resources.s6;
                    break;
            }

            switch (y)
            {
                case 1:
                    die2.Image = Properties.Resources.s1;
                    break;
                case 2:
                    die2.Image = Properties.Resources.s2;
                    break;
                case 3:
                    die2.Image = Properties.Resources.s3;
                    break;
                case 4:
                    die2.Image = Properties.Resources.s4;
                    break;
                case 5:
                    die2.Image = Properties.Resources.s5;
                    break;
                case 6:
                    die2.Image = Properties.Resources.s6;
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (rollSum > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Leaving early will not save data after last complete game. Are you sure?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    goToMenu(this);
                else if (dialogResult == DialogResult.No)
                    return;
            }
            else
                goToMenu(this);
        }
    }
}
