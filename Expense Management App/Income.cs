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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addincomebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Insert into income Values(NULL, @source, @amount, '" + DateTime.Now.ToShortDateString() +"')";
                    SQLiteCommand command = new SQLiteCommand(insert, connection);
                    command.Parameters.Add(new SQLiteParameter("@amount", amounttxt.Text));
                    command.Parameters.Add(new SQLiteParameter("@source", sourcecmd.SelectedValue));
                    var execute = command.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        MessageBox.Show("New Income Added.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create an Income.");
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
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
                    string insert = "Update Income set Amount=@amount, [Source ID]=@source where ID=@id";
                    if (id != null || id != "0")
                    {
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        MessageBox.Show(sourcecmd.SelectedValue.ToString() + " " + amounttxt.Text);
                        command.Parameters.Add(new SQLiteParameter("@amount", amounttxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@source", sourcecmd.SelectedValue));
                        command.Parameters.Add(new SQLiteParameter("@id", id));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            MessageBox.Show("Income updated.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update an income.");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
            Close();
        }

        void getsource()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Source";
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

        private void Income_Load(object sender, EventArgs e)
        {
            getsource();
        }
    }
}
