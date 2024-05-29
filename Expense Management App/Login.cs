using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Management_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (usnmtxt.Text != null && psstxt.Text != null)
                    {
                        SQLiteCommand command = new SQLiteCommand("SELECT * from users where Password=@password and Username=@username", connection);
                        command.Parameters.Add(new SQLiteParameter("@username", usnmtxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@password", psstxt.Text));
                        SQLiteDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            MessageBox.Show("Welcome Back User " + reader[3].ToString());
                            Hide();
                            Form1 form = new Form1();
                            form.controlcmd.Items.Add(reader[2].ToString());
                            form.controlcmd.Items.Add("Logout");
                            form.controlcmd.SelectedIndex = 0;
                            form.id = Convert.ToInt32(reader[0].ToString());
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please make sure you filled in the correct details and make sure that you are registerd.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make sure that you filled the password field.");
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered and error while logging you in " + error);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
