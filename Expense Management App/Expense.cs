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
    public partial class Expense : Form
    {
        public Expense()
        {
            InitializeComponent();
        }

        SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["lite"].ToString());

        void getexpense()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string select = "Select * from expenses where [Budget ID] = " + id;
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

        private void categorybtn_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
        }

        private void addexpensebtn_Click(object sender, EventArgs e)
        {
            Upsertexpense expense = new Upsertexpense();
            expense.id = id;
            expense.Show();
        }

        internal string id;

        private void updateexpensebtn_Click(object sender, EventArgs e)
        {
            Upsertexpense expense = new Upsertexpense();
            expense.nametxt.Text = expensedgv.CurrentRow.Cells[2].Value.ToString();
            expense.amounttxt.Text = expensedgv.CurrentRow.Cells[3].Value.ToString();
            expense.sourcecmd.SelectedValue = expensedgv.CurrentRow.Cells[1].Value.ToString();
            expense.id = expensedgv.CurrentRow.Cells[0].Value.ToString();
            expense.gunaButton2.Visible = true;
            expense.gunaButton2.BringToFront();
            expense.Show();
        }

        private void expensetxt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    string query = "SELECT * FROM expense WHERE Category like '%" + expensetxt.Text + "%' or amount like '%" + expensetxt.Text + "%' or Name like '%" + expensetxt.Text + "%' ORDER BY Date desc";
                    DataTable dataTable = new DataTable();
                    SQLiteCommand com = new SQLiteCommand(query, connection);
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
                    sda.Fill(dataTable);
                    expensedgv.DataSource = dataTable;
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

        private void expensetxt_Leave(object sender, EventArgs e)
        {
            getexpense();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            getexpense();
            expensedgv.Columns[1].Visible = false;
        }

        private void expensetxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateexpensebtn_Click_1(object sender, EventArgs e)
        {
            Upsertexpense expense = new Upsertexpense();
            expense.nametxt.Text = expensedgv.CurrentRow.Cells[4].Value.ToString();
            expense.amounttxt.Text = expensedgv.CurrentRow.Cells[5].Value.ToString();
            expense.qtttxt.Text = expensedgv.CurrentRow.Cells[6].Value.ToString();
            expense.sourcecmd.SelectedItem = expensedgv.CurrentRow.Cells[2].Value.ToString();
            expense.id = expensedgv.CurrentRow.Cells[0].Value.ToString();
            expense.gunaButton2.Visible = true;
            expense.gunaButton2.BringToFront();
            expense.Show();
        }
    }
}
