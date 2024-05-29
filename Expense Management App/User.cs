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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        void getroles()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Role";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataReader dataReader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    rolecmd.DisplayMember = "Role";
                    rolecmd.ValueMember = "ID";
                    rolecmd.DataSource = dataTable;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Connection to the database is closed");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered this error " + error);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            getroles();
        }

        private void addincomebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (nametxt.Text != "" && usnmtxt.Text != "" && pwordtxt.Text != "")
                    {
                        string insert = "Insert into user Values(NULL, @role, @name, @usnm, @pword, '" + DateTime.Now.ToString("dd/MMMM/yyyy") + "')";
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@usnm", usnmtxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@pword", pwordtxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@role", rolecmd.SelectedValue));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            MessageBox.Show("New User Registered.");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register a new user.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all fields");
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
