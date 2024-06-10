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
using Microsoft.VisualBasic;
using System.Globalization;
using LiveCharts.Wpf;
using LiveCharts;

namespace Expense_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());
        
        internal int id;
        
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
                    MessageBox.Show("Connection Closed");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered this error " + error);
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            getbalance();
            getmonthly();
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

        void getUsers()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Users";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        userdgv.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered this error " + error);
            }
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            getUsers();
            pages.SetPage("User");
            headerlbl.Text = "Users";
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
            //MessageBox.Show(id);
            getUser();
            pages.SetPage("Setting");
            headerlbl.Text = "Setting";
        }

        void recenttransaction()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "SELECT coalesce(expenses, incomes) as Name, Amount, date FROM all_trans WHERE Status='Completed' ORDER BY ID DESC LIMIT 5;";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        rectransdgv.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered this error " + error);
            }
        }

        void pendingtransaction()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "SELECT coalesce(expenses, incomes) as Name, Amount, date FROM all_trans WHERE Status='Completed' ORDER BY ID DESC LIMIT 5;";
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        rectransdgv.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered this error " + error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getmonthly();
            getbalance();
            getexpenses();
            recenttransaction();
        }

        void pendingnotifications()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "";
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        void getexpenses()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    cartesianChart.Series.Clear();
                    cartesianChart.AxisX.Clear();
                    cartesianChart.AxisY.Clear();
                    var series = new LineSeries
                    {
                        Title = "Expenses",
                        Values = new ChartValues<double>(),
                        DataLabels = true
                    };
                    cartesianChart.Series.Add(series);
                    var xLabels = new List<string>();
                    var yValues = new ChartValues<double>();
                        connection.Open();
                        string query = "SELECT cat.name as Name, sum(exp.Amount) as Total FROM Expense as exp, Category as cat " +
                                       "WHERE cat.ID=exp.[Category ID] GROUP BY cat.name ORDER BY Total DESC LIMIT 4";
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    xLabels.Add(reader["Name"].ToString());
                                    yValues.Add(Convert.ToDouble(reader["Total"]));
                                }
                            }
                        }
                    foreach (var value in yValues)
                    {
                        series.Values.Add(value);
                    }
                    cartesianChart.AxisX.Add(new Axis
                    {
                        Title = "Category",
                        Labels = xLabels
                    });
                    cartesianChart.AxisY.Add(new Axis
                    {
                        Title = "Amount"
                    });
                    cartesianChart.LegendLocation = LegendLocation.Right;
                    cartesianChart.Refresh();
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        void getmonthly()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    var today = DateTime.Now.ToString("yyyy-MM-dd");
                    connection.Open();
                    string query = "SELECT COALESCE(SUM(CASE WHEN Incomes IS NOT NULL THEN Amount ELSE 0 END), 0) AS Incomes," +
                            "COALESCE(SUM(CASE WHEN Expenses IS NOT NULL THEN Amount ELSE 0 END), 0) AS Expenses, COALESCE(SUM(CASE WHEN Incomes IS NOT NULL THEN Amount ELSE 0 END), 0) -  " +
                            "COALESCE(SUM(CASE WHEN Expenses IS NOT NULL THEN Amount ELSE 0 END), 0) AS Balance," +
                            " strftime('%m-%Y', Date) AS MonthYear FROM all_trans WHERE Status = 'Completed'" +
                            " ORDER BY MonthYear; ";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    SeriesCollection series = new SeriesCollection();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        ttlincomelbl.Text = "This month you have made a Total Income of " + Convert.ToDecimal(reader[0]).ToString("C", new CultureInfo("en-MW"));
                        ttlmontlyexplbl.Text = "This month you have made a Total Income of " + Convert.ToDecimal(reader[1]).ToString("C", new CultureInfo("en-MW"));
                        double incomes = Convert.ToDouble(reader["Incomes"]);
                        double expenses = Convert.ToDouble(reader["Expenses"]);

                        series.Add(new PieSeries
                        {
                            Title = "Incomes",
                            Values = new ChartValues<double> { incomes },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})"
                        });

                        series.Add(new PieSeries
                        {
                            Title = "Expenses",
                            Values = new ChartValues<double> { expenses },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})"
                        });
                    }
                    pieChart.Series = series;
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error "+error.Message);
            }
        }
        
        void getbalance()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT COALESCE(SUM(CASE WHEN Incomes IS NOT NULL THEN Amount ELSE 0 END), 0) - COALESCE(SUM(CASE WHEN Expenses IS NOT NULL " +
                        "THEN Amount ELSE 0 END), 0) AS Balance FROM all_trans WHERE Status = 'Completed'; ";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        ttlballbl.Text = "You have a balance of " + Convert.ToDecimal(reader[0]).ToString("C", new CultureInfo("en-MW"));
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
            User user = new User();
            user.Show();
        }

        private void updateexpensebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Password = Interaction.InputBox("Enter your Password:", "Input Box", "", 100, 100);
                if (!string.IsNullOrEmpty(Password))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * from users where Password=" + Password, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("The password for user " + userdgv.CurrentRow.Cells[2].Value.ToString() + " is " + userdgv.CurrentRow.Cells[4].Value.ToString());
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
                MessageBox.Show(error.Message);
            }
        }

        private void deleteexpensebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                    string insert = "Delete from user where ID=@id";
                    if (userdgv.CurrentRow.Cells[0].Value.ToString() != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a User?", "System Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            string Password = Interaction.InputBox("Enter your Password:", "Input Box", "", 100, 100);
                            if (!string.IsNullOrEmpty(Password))
                            {
                                SQLiteCommand command = new SQLiteCommand("SELECT MAX(*) from users where Password="+Password, connection);
                                SQLiteDataReader reader = command.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    reader.Close();
                                    command = new SQLiteCommand(insert, connection);
                                    command.Parameters.Add(new SQLiteParameter("@id", userdgv.CurrentRow.Cells[0].Value.ToString()));
                                    var execute = command.ExecuteNonQuery();
                                    if (execute > 0)
                                    {
                                        MessageBox.Show("User deleted.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to deleted a User.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please make sure that you filled the password field.");
                            }
                        }
                    }
                    connection.Close();
                    getUsers();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error " + error.Message);
            }
        }

        private void expensetxt_Leave(object sender, EventArgs e)
        {
            getUsers();
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
            budget.desctxt.Text = budgetdgv.CurrentRow.Cells[3].Value.ToString();
            budget.amnttxt.Text = budgetdgv.CurrentRow.Cells[4].Value.ToString();
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
            if (transdgv.CurrentRow.Cells[1].Value.ToString() != null && transdgv.CurrentRow.Cells[2].Value.ToString() == null)
            { 
                trans.budgetcmd.SelectedItem = transdgv.CurrentRow.Cells[1].Value.ToString();
                trans.budgetcmd.Show();
            }
            else if (transdgv.CurrentRow.Cells[2].Value.ToString() != null && transdgv.CurrentRow.Cells[1].Value.ToString() == null)
            {
                trans.incomecmd.SelectedItem = transdgv.CurrentRow.Cells[2].Value.ToString();
                trans.incomecmd.Show();
            }
            trans.sourcecmd.SelectedItem = transdgv.CurrentRow.Cells[3].Value.ToString();
            trans.id = transdgv.CurrentRow.Cells[0].Value.ToString();
            trans.incomecmd.Enabled = false;
            trans.budgetcmd.Enabled = false;
            trans.gunaButton2.Show();
            trans.gunaButton2.BringToFront();
            trans.Show();
        }

        private void transtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT * FROM all_trans WHERE Date like '%" + transtxt.Text + "%' or [Budget Name] like '%" + transtxt.Text + "%' or [Income Source] like '%" + transtxt.Text + "%' ORDER BY Date desc";
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
                    string insert = "Delete from Transactions where ID=@id";
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete the Income Source?", "System Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SQLiteCommand command = new SQLiteCommand(insert, connection);
                            command.Parameters.Add(new SQLiteParameter("@id", transdgv.CurrentRow.Cells[0].Value.ToString()));
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

        private void userdgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void usertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE Date like '%" + usertxt.Text + "%' or Name like '%" + usertxt.Text + "%' or Role like '%" +usertxt.Text + "%' or Username like '%" + usertxt.Text + "%'";
                    DataTable dataTable = new DataTable();
                    SQLiteCommand com = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
                    sda.Fill(dataTable);
                    userdgv.DataSource = dataTable;
                    dataTable.Dispose();
                    sda.Dispose();
                    connection.Close();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void controlcmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controlcmd.SelectedIndex == 1)
            {
                Login login = new Login();
                Hide();
                login.Show();
            }
        }

        void getUser()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from Users Where ID="+id;
                    SQLiteCommand command = new SQLiteCommand(select, connection);
                    SQLiteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nametxt.Text = reader[2].ToString();
                        rolecmd.Items.Add(reader[1].ToString());
                        usnmtxt.Text = reader[3].ToString();
                        pwordtxt.Text = reader[4].ToString();
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered this error " + error);
            }
        }

        private void acclbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingspages.SetPage("Account");
            getUser();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingspages.SetPage("Company");
        }

        private void backlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingspages.SetPage("Backup");
        }

        private void aboutlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingspages.SetPage("About");
        }

        private void helplbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingspages.SetPage("Help");
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    if (nametxt.Text != "" && usnmtxt.Text != "" && pwordtxt.Text != "")
                    {
                        string insert = "Update user Set name=@name, username=@usnm, password=@pword where ID ="+id; 
                        SQLiteCommand command = new SQLiteCommand(insert, connection);
                        command.Parameters.Add(new SQLiteParameter("@name", nametxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@usnm", usnmtxt.Text));
                        command.Parameters.Add(new SQLiteParameter("@pword", pwordtxt.Text));
                        var execute = command.ExecuteNonQuery();
                        if (execute > 0)
                        {
                            MessageBox.Show("User Updated.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Update user.");
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

        private void incomedgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == incomedgv.Columns["Date"].Index)
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime date = (DateTime)e.Value;
                    e.Value = date.ToString("dd-MMM-yyyy");
                }
            } 
        }
    }
}
