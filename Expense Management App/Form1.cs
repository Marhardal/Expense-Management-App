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
                    string select = "Select * from incomes";
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

        void getbudget()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from budget";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        budgetdgv.DataSource = dataTable;
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

        private void budgetbtn_Click(object sender, EventArgs e)
        {
            getbudget();
            pages.SetPage("Budget");
            headerlbl.Text = "Budget";
        }

        void getexpense()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from expenses";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        expensedgv.DataSource = dataTable;
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

        private void expensebtn_Click(object sender, EventArgs e)
        {
            getexpense();
            pages.SetPage("Expense");
            headerlbl.Text = "Expense";
        }

        private void reportsbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Report");
        }

        void gettransaction()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from all_trans";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        transdgv.DataSource = dataTable;
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

        private void transbtn_Click(object sender, EventArgs e)
        {
            gettransaction();
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

        private void incometxt_Enter(object sender, EventArgs e)
        {
            
        }

        private void incometxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT * FROM incomes WHERE Date like '%" + incometxt.Text + "%' or amount like '%" + incometxt.Text + "%' ORDER BY Date desc";
                    DataTable dataTable = new DataTable();
                    SQLiteCommand com = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
                    sda.Fill(dataTable);
                    incomedgv.DataSource = dataTable;
                    dataTable.Dispose();
                    sda.Dispose();
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private void incometxt_Leave(object sender, EventArgs e)
        {
            getincome();
        }

        private void categorybtn_Click(object sender, EventArgs e)
        {
            
        }

        private void addexpensebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void updateexpensebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteexpensebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void expensetxt_Leave(object sender, EventArgs e)
        {
            
        }

        private void addbudgetdgv_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget();
            budget.Show();
        }

        private void updatebudgetbtn_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget();
            budget.nametxt.Text = budgetdgv.CurrentRow.Cells[2].Value.ToString();
            budget.amounttxt.Text = budgetdgv.CurrentRow.Cells[3].Value.ToString();
            budget.desctxt.Text = budgetdgv.CurrentRow.Cells[4].Value.ToString();
            budget.duedatedtp.Value = Convert.ToDateTime(budgetdgv.CurrentRow.Cells[6].Value);
            budget.id = budgetdgv.CurrentRow.Cells[0].Value.ToString();
            budget.gunaButton2.Visible = true;
            budget.gunaButton2.BringToFront();
            budget.Show();
        }

        private void deletebudgetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Delete from budget where ID=@id";
                    if (budgetdgv.CurrentRow.Cells[0].Value.ToString() != null || budgetdgv.CurrentRow.Cells[0].Value.ToString() != "0")
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete a Budget?", "System Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SQLiteCommand command = new SQLiteCommand(insert, connection);
                            command.Parameters.Add(new SQLiteParameter("@id", budgetdgv.CurrentRow.Cells[0].Value.ToString()));
                            var execute = command.ExecuteNonQuery();
                            if (execute > 0)
                            {
                                MessageBox.Show("Budget deleted.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to deleted a Budget.");
                            }
                        }
                    }
                    connection.Close();
                    getbudget();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void budgettxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT * FROM budget WHERE [Due Date] like '%" + budgettxt.Text + "%' or amount like '%" + budgettxt.Text + "%' or Name like '%" + budgettxt.Text + "%' ORDER BY Date desc";
                    DataTable dataTable = new DataTable();
                    SQLiteCommand com = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
                    sda.Fill(dataTable);
                    budgetdgv.DataSource = dataTable;
                    dataTable.Dispose();
                    sda.Dispose();
                    connection.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }

        private void expensesviewbtn_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            expense.id = budgetdgv.CurrentRow.Cells[0].Value.ToString();
            expense.Show();
        }

        private void transaddbtn_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.Show();
        }

        private void transeditbtn_Click(object sender, EventArgs e)
        {
            Transaction trans = new Transaction();
            trans.sourcecmd.SelectedValue = incomedgv.CurrentRow.Cells[5].Value.ToString();
            trans.budgetcmd.SelectedValue = incomedgv.CurrentRow.Cells[1].Value.ToString();
            trans.incomecmd.SelectedValue = incomedgv.CurrentRow.Cells[3].Value.ToString();
            trans.id = incomedgv.CurrentRow.Cells[0].Value.ToString();
            trans.Show();
        }

        private void transtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT * FROM all_trans WHERE Date like '%" + transtxt.Text + "%' or [Budget Name] like '%" + transtxt.Text + "%' or [Income Source] like '%" + budgettxt.Text + "%' ORDER BY Date desc";
                    DataTable dataTable = new DataTable();
                    SQLiteCommand com = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
                    sda.Fill(dataTable);
                    transdgv.DataSource = dataTable;
                    dataTable.Dispose();
                    sda.Dispose();
                    connection.Close();
                    transdgv.Columns[1].Visible = false;
                    transdgv.Columns[3].Visible = false;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void transtxt_Leave(object sender, EventArgs e)
        {
            gettransaction();
        }

        private void transdelbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string insert = "Delete from Transaction where ID=@id";
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
