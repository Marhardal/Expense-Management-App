namespace Expense_Management_App
{
    partial class Upsertexpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Upsertexpense));
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.sourcecmd = new Guna.UI.WinForms.GunaComboBox();
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.addExpensebtn = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amounttxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.qtttxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
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
            this.gunaButton2.Location = new System.Drawing.Point(11, 382);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(191, 40);
            this.gunaButton2.TabIndex = 29;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Visible = false;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
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
            "Select a source of income."});
            this.sourcecmd.Location = new System.Drawing.Point(13, 345);
            this.sourcecmd.Name = "sourcecmd";
            this.sourcecmd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sourcecmd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sourcecmd.Size = new System.Drawing.Size(390, 31);
            this.sourcecmd.StartIndex = 0;
            this.sourcecmd.TabIndex = 28;
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
            this.cancelbtn.Location = new System.Drawing.Point(213, 382);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelbtn.OnHoverImage = null;
            this.cancelbtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelbtn.Size = new System.Drawing.Size(190, 40);
            this.cancelbtn.TabIndex = 27;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
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
            this.addExpensebtn.Location = new System.Drawing.Point(12, 382);
            this.addExpensebtn.Name = "addExpensebtn";
            this.addExpensebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addExpensebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addExpensebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addExpensebtn.OnHoverImage = null;
            this.addExpensebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addExpensebtn.Size = new System.Drawing.Size(190, 40);
            this.addExpensebtn.TabIndex = 26;
            this.addExpensebtn.Text = "Create";
            this.addExpensebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addExpensebtn.Click += new System.EventHandler(this.addExpensebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Income Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Amount";
            // 
            // amounttxt
            // 
            this.amounttxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.amounttxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.amounttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amounttxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.amounttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amounttxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.amounttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amounttxt.HintForeColor = System.Drawing.Color.DimGray;
            this.amounttxt.HintText = "Search for an Income.";
            this.amounttxt.isPassword = false;
            this.amounttxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.amounttxt.LineIdleColor = System.Drawing.Color.Gray;
            this.amounttxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.amounttxt.LineThickness = 3;
            this.amounttxt.Location = new System.Drawing.Point(13, 195);
            this.amounttxt.Margin = new System.Windows.Forms.Padding(4);
            this.amounttxt.MaxLength = 32767;
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(390, 35);
            this.amounttxt.TabIndex = 23;
            this.amounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fill in all fields before contining.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add an Expense.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name";
            // 
            // nametxt
            // 
            this.nametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametxt.HintForeColor = System.Drawing.Color.DimGray;
            this.nametxt.HintText = "Search for an Income.";
            this.nametxt.isPassword = false;
            this.nametxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.nametxt.LineIdleColor = System.Drawing.Color.Gray;
            this.nametxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nametxt.LineThickness = 3;
            this.nametxt.Location = new System.Drawing.Point(13, 120);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(390, 35);
            this.nametxt.TabIndex = 30;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quantity";
            // 
            // qtttxt
            // 
            this.qtttxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.qtttxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.qtttxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtttxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.qtttxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtttxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.qtttxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.qtttxt.HintForeColor = System.Drawing.Color.DimGray;
            this.qtttxt.HintText = "Search for an Income.";
            this.qtttxt.isPassword = false;
            this.qtttxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.qtttxt.LineIdleColor = System.Drawing.Color.Gray;
            this.qtttxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.qtttxt.LineThickness = 3;
            this.qtttxt.Location = new System.Drawing.Point(13, 270);
            this.qtttxt.Margin = new System.Windows.Forms.Padding(4);
            this.qtttxt.MaxLength = 32767;
            this.qtttxt.Name = "qtttxt";
            this.qtttxt.Size = new System.Drawing.Size(390, 35);
            this.qtttxt.TabIndex = 32;
            this.qtttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Upsertexpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 431);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qtttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.sourcecmd);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.addExpensebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Upsertexpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI.WinForms.GunaButton gunaButton2;
        internal Guna.UI.WinForms.GunaComboBox sourcecmd;
        private Guna.UI.WinForms.GunaButton cancelbtn;
        private Guna.UI.WinForms.GunaButton addExpensebtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox amounttxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private System.Windows.Forms.Label label6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox qtttxt;
    }
}