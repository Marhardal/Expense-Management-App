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
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        private void Budget_Load(object sender, EventArgs e)
        {
            duedatedtp.Value = DateTime.Now;
        }

        private void addbudgetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (nametxt.Text != "" & desctxt.Text != "")
                    {
                        string insert = "Insert into budget Values(NULL, 1 , @name, @desc, '" + DateTime.Now.ToShortDateString() + "', @due)";
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@desc", desctxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@due", duedatedtp.Value.ToString("dd/MMMM/yyyy")));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            MessageBox.Show("New Budget Create.");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Create a Budget.");
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

        internal string id;

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Update budget set Name=@name, Description=@desc, [Due Date]=@due where ID=@id";
                    if (id != null || id != "0" & nametxt.Text != "" & desctxt.Text != "")
                    {
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@desc", desctxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@id", id));
                        command.Parameters.Add(new SQLiteParameter("@due", duedatedtp.Value.ToShortDateString()));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            MessageBox.Show("Expense updated.");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update an expense.");
                        }
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
