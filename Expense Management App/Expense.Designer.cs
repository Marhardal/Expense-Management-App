namespace Expense_Management_App
{
    partial class Expense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            this.expensedgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.categorybtn = new Guna.UI.WinForms.GunaButton();
            this.deleteexpensebtn = new Guna.UI.WinForms.GunaButton();
            this.updateexpensebtn = new Guna.UI.WinForms.GunaButton();
            this.addexpensebtn = new Guna.UI.WinForms.GunaButton();
            this.expensetxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expensetotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.refreshbtn = new Guna.UI.WinForms.GunaButton();
            this.printbtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.expensedgv)).BeginInit();
            this.SuspendLayout();
            // 
            // expensedgv
            // 
            this.expensedgv.AllowUserToAddRows = false;
            this.expensedgv.AllowUserToDeleteRows = false;
            this.expensedgv.AllowUserToOrderColumns = true;
            this.expensedgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.expensedgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.expensedgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expensedgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.expensedgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expensedgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expensedgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.expensedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensedgv.DoubleBuffered = true;
            this.expensedgv.EnableHeadersVisualStyles = false;
            this.expensedgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            this.expensedgv.HeaderForeColor = System.Drawing.Color.White;
            this.expensedgv.Location = new System.Drawing.Point(12, 143);
            this.expensedgv.MultiSelect = false;
            this.expensedgv.Name = "expensedgv";
            this.expensedgv.ReadOnly = true;
            this.expensedgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.expensedgv.RowHeadersWidth = 51;
            this.expensedgv.RowTemplate.Height = 24;
            this.expensedgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expensedgv.Size = new System.Drawing.Size(1176, 632);
            this.expensedgv.TabIndex = 22;
            // 
            // categorybtn
            // 
            this.categorybtn.AnimationHoverSpeed = 0.07F;
            this.categorybtn.AnimationSpeed = 0.03F;
            this.categorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.categorybtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.categorybtn.BorderColor = System.Drawing.Color.Black;
            this.categorybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.categorybtn.FocusedColor = System.Drawing.Color.Empty;
            this.categorybtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorybtn.ForeColor = System.Drawing.Color.Black;
            this.categorybtn.Image = ((System.Drawing.Image)(resources.GetObject("categorybtn.Image")));
            this.categorybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.categorybtn.Location = new System.Drawing.Point(951, 54);
            this.categorybtn.Name = "categorybtn";
            this.categorybtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.categorybtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.categorybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.categorybtn.OnHoverImage = null;
            this.categorybtn.OnPressedColor = System.Drawing.Color.Black;
            this.categorybtn.Size = new System.Drawing.Size(235, 40);
            this.categorybtn.TabIndex = 21;
            this.categorybtn.Text = "Category";
            this.categorybtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.categorybtn.Click += new System.EventHandler(this.categorybtn_Click);
            // 
            // deleteexpensebtn
            // 
            this.deleteexpensebtn.AnimationHoverSpeed = 0.07F;
            this.deleteexpensebtn.AnimationSpeed = 0.03F;
            this.deleteexpensebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.deleteexpensebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.deleteexpensebtn.BorderColor = System.Drawing.Color.Black;
            this.deleteexpensebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteexpensebtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteexpensebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteexpensebtn.ForeColor = System.Drawing.Color.Black;
            this.deleteexpensebtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteexpensebtn.Image")));
            this.deleteexpensebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteexpensebtn.Location = new System.Drawing.Point(638, 54);
            this.deleteexpensebtn.Name = "deleteexpensebtn";
            this.deleteexpensebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deleteexpensebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteexpensebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteexpensebtn.OnHoverImage = null;
            this.deleteexpensebtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteexpensebtn.Size = new System.Drawing.Size(235, 40);
            this.deleteexpensebtn.TabIndex = 19;
            this.deleteexpensebtn.Text = "Delete";
            this.deleteexpensebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deleteexpensebtn.Click += new System.EventHandler(this.deleteexpensebtn_Click);
            // 
            // updateexpensebtn
            // 
            this.updateexpensebtn.AnimationHoverSpeed = 0.07F;
            this.updateexpensebtn.AnimationSpeed = 0.03F;
            this.updateexpensebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.updateexpensebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.updateexpensebtn.BorderColor = System.Drawing.Color.Black;
            this.updateexpensebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateexpensebtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateexpensebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateexpensebtn.ForeColor = System.Drawing.Color.Black;
            this.updateexpensebtn.Image = ((System.Drawing.Image)(resources.GetObject("updateexpensebtn.Image")));
            this.updateexpensebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updateexpensebtn.Location = new System.Drawing.Point(325, 54);
            this.updateexpensebtn.Name = "updateexpensebtn";
            this.updateexpensebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updateexpensebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateexpensebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateexpensebtn.OnHoverImage = null;
            this.updateexpensebtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateexpensebtn.Size = new System.Drawing.Size(235, 40);
            this.updateexpensebtn.TabIndex = 18;
            this.updateexpensebtn.Text = "Update";
            this.updateexpensebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateexpensebtn.Click += new System.EventHandler(this.updateexpensebtn_Click_1);
            // 
            // addexpensebtn
            // 
            this.addexpensebtn.AnimationHoverSpeed = 0.07F;
            this.addexpensebtn.AnimationSpeed = 0.03F;
            this.addexpensebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addexpensebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addexpensebtn.BorderColor = System.Drawing.Color.Black;
            this.addexpensebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addexpensebtn.FocusedColor = System.Drawing.Color.Empty;
            this.addexpensebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addexpensebtn.ForeColor = System.Drawing.Color.Black;
            this.addexpensebtn.Image = ((System.Drawing.Image)(resources.GetObject("addexpensebtn.Image")));
            this.addexpensebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addexpensebtn.Location = new System.Drawing.Point(12, 54);
            this.addexpensebtn.Name = "addexpensebtn";
            this.addexpensebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addexpensebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addexpensebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addexpensebtn.OnHoverImage = null;
            this.addexpensebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addexpensebtn.Size = new System.Drawing.Size(235, 40);
            this.addexpensebtn.TabIndex = 17;
            this.addexpensebtn.Text = "Create";
            this.addexpensebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addexpensebtn.Click += new System.EventHandler(this.addexpensebtn_Click);
            // 
            // expensetxt
            // 
            this.expensetxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.expensetxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.expensetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expensetxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.expensetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expensetxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.expensetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expensetxt.HintForeColor = System.Drawing.Color.DimGray;
            this.expensetxt.HintText = "Search for an Income.";
            this.expensetxt.isPassword = false;
            this.expensetxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.expensetxt.LineIdleColor = System.Drawing.Color.Gray;
            this.expensetxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.expensetxt.LineThickness = 3;
            this.expensetxt.Location = new System.Drawing.Point(12, 101);
            this.expensetxt.Margin = new System.Windows.Forms.Padding(4);
            this.expensetxt.MaxLength = 32767;
            this.expensetxt.Name = "expensetxt";
            this.expensetxt.Size = new System.Drawing.Size(379, 35);
            this.expensetxt.TabIndex = 20;
            this.expensetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.expensetxt.OnValueChanged += new System.EventHandler(this.expensetxt_OnValueChanged);
            this.expensetxt.Leave += new System.EventHandler(this.expensetxt_Leave);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1143, 9);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 24;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Expense Management System\\Expense\\Category";
            // 
            // expensetotal
            // 
            this.expensetotal.AutoEllipsis = true;
            this.expensetotal.AutoSize = false;
            this.expensetotal.CursorType = null;
            this.expensetotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.expensetotal.Location = new System.Drawing.Point(953, 105);
            this.expensetotal.Name = "expensetotal";
            this.expensetotal.Padding = new System.Windows.Forms.Padding(0, 2, 4, 2);
            this.expensetotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expensetotal.Size = new System.Drawing.Size(235, 31);
            this.expensetotal.TabIndex = 26;
            this.expensetotal.Text = "0";
            this.expensetotal.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.expensetotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.expensetotal.Click += new System.EventHandler(this.expensetotal_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.AnimationHoverSpeed = 0.07F;
            this.refreshbtn.AnimationSpeed = 0.03F;
            this.refreshbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.refreshbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.refreshbtn.BorderColor = System.Drawing.Color.Black;
            this.refreshbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshbtn.FocusedColor = System.Drawing.Color.Empty;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.Black;
            this.refreshbtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshbtn.Image")));
            this.refreshbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.refreshbtn.Location = new System.Drawing.Point(12, 788);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.refreshbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshbtn.OnHoverImage = null;
            this.refreshbtn.OnPressedColor = System.Drawing.Color.Black;
            this.refreshbtn.Size = new System.Drawing.Size(235, 40);
            this.refreshbtn.TabIndex = 27;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.AnimationHoverSpeed = 0.07F;
            this.printbtn.AnimationSpeed = 0.03F;
            this.printbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.printbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.printbtn.BorderColor = System.Drawing.Color.Black;
            this.printbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.printbtn.FocusedColor = System.Drawing.Color.Empty;
            this.printbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.Black;
            this.printbtn.Image = ((System.Drawing.Image)(resources.GetObject("printbtn.Image")));
            this.printbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.printbtn.Location = new System.Drawing.Point(953, 788);
            this.printbtn.Name = "printbtn";
            this.printbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.printbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.printbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.printbtn.OnHoverImage = null;
            this.printbtn.OnPressedColor = System.Drawing.Color.Black;
            this.printbtn.Size = new System.Drawing.Size(235, 40);
            this.printbtn.TabIndex = 28;
            this.printbtn.Text = "Print";
            this.printbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 840);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.expensetotal);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expensedgv);
            this.Controls.Add(this.categorybtn);
            this.Controls.Add(this.expensetxt);
            this.Controls.Add(this.deleteexpensebtn);
            this.Controls.Add(this.updateexpensebtn);
            this.Controls.Add(this.addexpensebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expensedgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid expensedgv;
        private Guna.UI.WinForms.GunaButton categorybtn;
        private Guna.UI.WinForms.GunaButton deleteexpensebtn;
        private Guna.UI.WinForms.GunaButton updateexpensebtn;
        private Guna.UI.WinForms.GunaButton addexpensebtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox expensetxt;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel expensetotal;
        private Guna.UI.WinForms.GunaButton refreshbtn;
        private Guna.UI.WinForms.GunaButton printbtn;
    }
}