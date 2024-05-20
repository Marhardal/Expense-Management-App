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
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        void getsource()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Source";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        sourcedgv.DataSource = dataTable;
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


        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addincomebtn_Click(object sender, EventArgs e)
        {
            Height = 540;
            addincomebtn.Enabled = false;
            updateincomebtn.Enabled = false;
            deleteincomebtn.Enabled = false;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Height = 445;
            addincomebtn.Enabled = true;
            updateincomebtn.Enabled = true;
            deleteincomebtn.Enabled = true; 
            gunaButton2.SendToBack();
            gunaButton2.Visible = false;
        }

        private void Source_Load(object sender, EventArgs e)
        {
            gunaButton2.SendToBack();
            getsource();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Insert into Source Values(NULL, @name)";
                    SQLiteCommand command = new SQLiteCommand(insert, connection);
                    command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                    var execute = command.ExecuteNonQuery();
                    if (execute > 0)
                    {
                        Height = 445;
                        addincomebtn.Enabled = true;
                        updateincomebtn.Enabled = true;
                        deleteincomebtn.Enabled = true;
                        MessageBox.Show("New income source created.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to create an income source.");
                    }
                    connection.Close();
                    getsource();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Update Source set name=@name where ID=@id";
                    if (sourcedgv.CurrentRow.Cells[1].Value.ToString() != null || sourcedgv.CurrentRow.Cells[1].Value.ToString() != "0")
                    {
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@id", sourcedgv.CurrentRow.Cells[0].Value.ToString()));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            Height = 445;
                            addincomebtn.Enabled = true;
                            updateincomebtn.Enabled = true;
                            deleteincomebtn.Enabled = true;
                            label2.Text = "insert an Income Source.";
                            MessageBox.Show("Income source updated.");
                            gunaButton2.SendToBack();
                            gunaButton2.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update an income source.");
                        } 
                    }
                    connection.Close();
                    getsource();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void updateincomebtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Update an Income Source.";
            Height = 540;
            gunaButton2.Visible = true;
            gunaButton2.BringToFront();
            addincomebtn.Enabled = false;
            updateincomebtn.Enabled = false;
            deleteincomebtn.Enabled = false;
            nametxt.Text = sourcedgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void deleteincomebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Delete from Source where ID=@id";
                    if (sourcedgv.CurrentRow.Cells[1].Value.ToString() != null || sourcedgv.CurrentRow.Cells[1].Value.ToString() != "0")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the Income Source?", "System Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SQLiteCommand command = new SQLiteCommand(insert, connection);
                            command.Parameters.Add(new SQLiteParameter("@id", sourcedgv.CurrentRow.Cells[0].Value.ToString()));
                            var execute = command.ExecuteNonQuery();
                            if (execute > 0)
                            {
                                MessageBox.Show("Income source deleted.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to deleted an income source.");
                            } 
                        }
                    }
                    connection.Close();
                    getsource();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }
    }
}
