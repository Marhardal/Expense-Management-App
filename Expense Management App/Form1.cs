using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expense_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Home");
            headerlbl.Text = "Home";
        }

        private void incomebtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Income");
            headerlbl.Text = "Income";
        }

        private void budgetbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Budget");
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Expense");
        }

        private void reportsbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Report");
        }

        private void transbtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Transaction");
        }

        private void notibtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Notification");
        }

        private void setibtn_Click(object sender, EventArgs e)
        {
            pages.SetPage("Setting");
        }

    }
}
