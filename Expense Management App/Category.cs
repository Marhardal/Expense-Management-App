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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        void getcategory()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from category";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        categorydgv.DataSource = dataTable;
                    }
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

        private void addsourcebtn_Click(object sender, EventArgs e)
        {
            Height = 550;
            addsourcebtn.Enabled = false;
            updatecategorybtn.Enabled = false;
            deletecategorybtn.Enabled = false;
        }

        private void updatecategorybtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Update an Expense Category.";
            Height = 550;
            gunaButton2.Visible = true;
            gunaButton2.BringToFront();
            addsourcebtn.Enabled = false;
            updatecategorybtn.Enabled = false;
            deletecategorybtn.Enabled = false;
            nametxt.Text = categorydgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void deletecategorybtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Delete from Category where ID=@id";
                    if (categorydgv.CurrentRow.Cells[1].Value.ToString() != null || categorydgv.CurrentRow.Cells[1].Value.ToString() != "0")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the Expense Category?", "System Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SQLiteCommand command = new SQLiteCommand(insert, connection);
                            command.Parameters.Add(new SQLiteParameter("@id", categorydgv.CurrentRow.Cells[0].Value.ToString()));
                            var execute = command.ExecuteNonQuery();
                            if (execute > 0)
                            {
                                MessageBox.Show("Expense Category deleted.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to deleted an Expense Category.");
                            }
                        }
                    }
                    connection.Close();
                    getcategory();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            getcategory();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Update category set name=@name where ID=@id";
                    if (categorydgv.CurrentRow.Cells[1].Value.ToString() != null || categorydgv.CurrentRow.Cells[1].Value.ToString() != "0")
                    {
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@id", categorydgv.CurrentRow.Cells[0].Value.ToString()));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            Height = 445;
                            addsourcebtn.Enabled = true;
                            updatecategorybtn.Enabled = true;
                            deletecategorybtn.Enabled = true;
                            label2.Text = "insert an Expense Category.";
                            MessageBox.Show("Expense Category updated.");
                            gunaButton2.SendToBack();
                            gunaButton2.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update an Expense Category.");
                        }
                    }
                    connection.Close();
                    getcategory();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Height = 445;
            addsourcebtn.Enabled = true;
            updatecategorybtn.Enabled = true;
            deletecategorybtn.Enabled = true;
            gunaButton2.SendToBack();
            gunaButton2.Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Insert into category Values(NULL, @name)";
                    SQLiteCommand command = new SQLiteCommand(insert, connection);
                    command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                    var execute = command.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        Height = 445;
                        addsourcebtn.Enabled = true;
                        updatecategorybtn.Enabled = true;
                        deletecategorybtn.Enabled = true;
                        MessageBox.Show("New Expense Category Created.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create an income source.");
                    }
                    connection.Close();
                    getcategory();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }
    }
}
