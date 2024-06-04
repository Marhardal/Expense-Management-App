namespace Expense_Management_App
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.addExpensebtn = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sourcecmd = new Guna.UI.WinForms.GunaComboBox();
            this.budgetcmd = new Guna.UI.WinForms.GunaComboBox();
            this.incomecmd = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.AnimationHoverSpeed = 0.07F;
            this.cancelbtn.AnimationSpeed = 0.03F;
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.cancelbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.cancelbtn.BorderColor = System.Drawing.Color.Black;
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelbtn.FocusedColor = System.Drawing.Color.Empty;
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.Black;
            this.cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelbtn.Image")));
            this.cancelbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelbtn.Location = new System.Drawing.Point(213, 276);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelbtn.OnHoverImage = null;
            this.cancelbtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelbtn.Size = new System.Drawing.Size(190, 40);
            this.cancelbtn.TabIndex = 40;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fill in all fields before contining.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Add an Expense.";
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(12, 276);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(191, 40);
            this.gunaButton2.TabIndex = 42;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Visible = false;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // addExpensebtn
            // 
            this.addExpensebtn.AnimationHoverSpeed = 0.07F;
            this.addExpensebtn.AnimationSpeed = 0.03F;
            this.addExpensebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addExpensebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addExpensebtn.BorderColor = System.Drawing.Color.Black;
            this.addExpensebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addExpensebtn.FocusedColor = System.Drawing.Color.Empty;
            this.addExpensebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpensebtn.ForeColor = System.Drawing.Color.Black;
            this.addExpensebtn.Image = ((System.Drawing.Image)(resources.GetObject("addExpensebtn.Image")));
            this.addExpensebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addExpensebtn.Location = new System.Drawing.Point(13, 276);
            this.addExpensebtn.Name = "addExpensebtn";
            this.addExpensebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addExpensebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addExpensebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addExpensebtn.OnHoverImage = null;
            this.addExpensebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addExpensebtn.Size = new System.Drawing.Size(190, 40);
            this.addExpensebtn.TabIndex = 39;
            this.addExpensebtn.Text = "Create";
            this.addExpensebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addExpensebtn.Click += new System.EventHandler(this.addExpensebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Income ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "Budget";
            // 
            // sourcecmd
            // 
            this.sourcecmd.BackColor = System.Drawing.Color.Transparent;
            this.sourcecmd.BaseColor = System.Drawing.Color.White;
            this.sourcecmd.BorderColor = System.Drawing.Color.Black;
            this.sourcecmd.BorderSize = 1;
            this.sourcecmd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sourcecmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourcecmd.FocusedColor = System.Drawing.Color.Empty;
            this.sourcecmd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sourcecmd.ForeColor = System.Drawing.Color.Black;
            this.sourcecmd.FormattingEnabled = true;
            this.sourcecmd.Items.AddRange(new object[] {
            "Select a transaction status.",
            "Failed",
            "Pending",
            "Completed"});
            this.sourcecmd.Location = new System.Drawing.Point(13, 239);
            this.sourcecmd.Name = "sourcecmd";
            this.sourcecmd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sourcecmd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sourcecmd.Size = new System.Drawing.Size(390, 31);
            this.sourcecmd.StartIndex = 0;
            this.sourcecmd.TabIndex = 41;
            // 
            // budgetcmd
            // 
            this.budgetcmd.BackColor = System.Drawing.Color.Transparent;
            this.budgetcmd.BaseColor = System.Drawing.Color.White;
            this.budgetcmd.BorderColor = System.Drawing.Color.Black;
            this.budgetcmd.BorderSize = 1;
            this.budgetcmd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.budgetcmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.budgetcmd.FocusedColor = System.Drawing.Color.Empty;
            this.budgetcmd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.budgetcmd.ForeColor = System.Drawing.Color.Black;
            this.budgetcmd.FormattingEnabled = true;
            this.budgetcmd.Items.AddRange(new object[] {
            "Select a source of income."});
            this.budgetcmd.Location = new System.Drawing.Point(13, 114);
            this.budgetcmd.Name = "budgetcmd";
            this.budgetcmd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.budgetcmd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.budgetcmd.Size = new System.Drawing.Size(390, 31);
            this.budgetcmd.StartIndex = 0;
            this.budgetcmd.TabIndex = 46;
            // 
            // incomecmd
            // 
            this.incomecmd.BackColor = System.Drawing.Color.Transparent;
            this.incomecmd.BaseColor = System.Drawing.Color.White;
            this.incomecmd.BorderColor = System.Drawing.Color.Black;
            this.incomecmd.BorderSize = 1;
            this.incomecmd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.incomecmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incomecmd.FocusedColor = System.Drawing.Color.Empty;
            this.incomecmd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.incomecmd.ForeColor = System.Drawing.Color.Black;
            this.incomecmd.FormattingEnabled = true;
            this.incomecmd.Items.AddRange(new object[] {
            "Select a source of income."});
            this.incomecmd.Location = new System.Drawing.Point(13, 178);
            this.incomecmd.Name = "incomecmd";
            this.incomecmd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.incomecmd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.incomecmd.Size = new System.Drawing.Size(390, 31);
            this.incomecmd.StartIndex = 0;
            this.incomecmd.TabIndex = 44;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 330);
            this.Controls.Add(this.budgetcmd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.incomecmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourcecmd);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addExpensebtn);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton addExpensebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        internal Guna.UI.WinForms.GunaComboBox sourcecmd;
        internal Guna.UI.WinForms.GunaComboBox budgetcmd;
        internal Guna.UI.WinForms.GunaComboBox incomecmd;
    }
}