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
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string str = txtName.Text.Trim();

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlayerInfo.mdf;Integrated Security = True";
            string query = "INSERT INTO Players (name) VALUES (@Name);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                if (str != "")
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Name", str);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("That name already exists. Please enter a different one.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a name first.");
                    return;
                }
                conn.Close();
            }

            Craps.Menu.currPlayer = str;

            goToMenu(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            goToMenu(this);
        }
    }
}
