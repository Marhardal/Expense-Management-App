using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Expense_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        void getincome()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from income";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        incomedgv.DataSource = dataTable;
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Home");
            headerlbl.Text = "Home";
        }

        private void incomebtn_Click(object sender, EventArgs e)
        {
            getincome();
            pages.SetPage("Income");
            headerlbl.Text = "Income";
        }

        private void budgetbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Budget");
            headerlbl.Text = "Budget";
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Expense");
            headerlbl.Text = "Expense";
        }

        private void reportsbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Report");
        }

        private void transbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Transaction");
            headerlbl.Text = "Transaction";
        }

        private void notibtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Notification");
        }

        private void setibtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Setting");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sourcebtn_Click(object sender, EventArgs e)
        {
            Source source = new Source();
            source.Show();
        }

        private void updateincomebtn_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.amounttxt.Text = incomedgv.CurrentRow.Cells[2].Value.ToString();
            income.sourcecmd.SelectedValue = incomedgv.CurrentRow.Cells[1].Value.ToString();
            income.id = incomedgv.CurrentRow.Cells[0].Value.ToString();
            income.gunaButton2.Visible = true;
            income.gunaButton2.BringToFront();
            income.Show();
        }

        private void addincomebtn_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Show();
        }

        private void deleteincomebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Delete from Income where ID=@id";
                    if (incomedgv.CurrentRow.Cells[1].Value.ToString() != null || incomedgv.CurrentRow.Cells[1].Value.ToString() != "0")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the Income Source?", "System Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SQLiteCommand command = new SQLiteCommand(insert, connection);
                            command.Parameters.Add(new SQLiteParameter("@id", incomedgv.CurrentRow.Cells[0].Value.ToString()));
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
                    getincome();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }
    }
}
