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
    public partial class Upsertexpense : Form
    {
        public Upsertexpense()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        private void addExpensebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (amounttxt.Text != "")
                    {
                        string insert = "Insert into expense Values(NULL, @category, "+ id + ",@name,@qtt, @amount, '" + DateTime.Now.ToString("dd/MMMM/yyyy") + "')";
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@amount", amounttxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@qtt", qtttxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@category", sourcecmd.SelectedValue));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            MessageBox.Show("New Expense Added.");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create an Expense.");
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

        void getcategory()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from category";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataReader dataReader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dataReader);
                    sourcecmd.DisplayMember = "Name";
                    sourcecmd.ValueMember = "ID";
                    sourcecmd.DataSource = dataTable;
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

        private void Expense_Load(object sender, EventArgs e)
        {
            getcategory();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal string id;

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Update expense set Amount=@amount, [category ID]=@category, Name=@name, Quantity=@qtt where ID=@id";
                    if (id != null || id != "0")
                    {
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        MessageBox.Show(sourcecmd.SelectedValue.ToString() + " " + amounttxt.Text);
                        command.Parameters.Add(new SQLiteParameter("@amount", amounttxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@qtt", qtttxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@category", sourcecmd.SelectedValue));
                        command.Parameters.Add(new SQLiteParameter("@id", id));
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
    }
}
