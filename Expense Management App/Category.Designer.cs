namespace Expense_Management_App
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.deletecategorybtn = new Guna.UI.WinForms.GunaButton();
            this.updatecategorybtn = new Guna.UI.WinForms.GunaButton();
            this.addsourcebtn = new Guna.UI.WinForms.GunaButton();
            this.categorydgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.categorydgv)).BeginInit();
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
            this.cancelbtn.Location = new System.Drawing.Point(246, 625);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelbtn.OnHoverImage = null;
            this.cancelbtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelbtn.Size = new System.Drawing.Size(191, 40);
            this.cancelbtn.TabIndex = 28;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
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
            this.nametxt.Location = new System.Drawing.Point(8, 583);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(429, 35);
            this.nametxt.TabIndex = 26;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Create an Expense Category.";
            // 
            // deletecategorybtn
            // 
            this.deletecategorybtn.AnimationHoverSpeed = 0.07F;
            this.deletecategorybtn.AnimationSpeed = 0.03F;
            this.deletecategorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.deletecategorybtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.deletecategorybtn.BorderColor = System.Drawing.Color.Black;
            this.deletecategorybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletecategorybtn.FocusedColor = System.Drawing.Color.Empty;
            this.deletecategorybtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecategorybtn.ForeColor = System.Drawing.Color.Black;
            this.deletecategorybtn.Image = ((System.Drawing.Image)(resources.GetObject("deletecategorybtn.Image")));
            this.deletecategorybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deletecategorybtn.Location = new System.Drawing.Point(843, 50);
            this.deletecategorybtn.Name = "deletecategorybtn";
            this.deletecategorybtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deletecategorybtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletecategorybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deletecategorybtn.OnHoverImage = null;
            this.deletecategorybtn.OnPressedColor = System.Drawing.Color.Black;
            this.deletecategorybtn.Size = new System.Drawing.Size(235, 40);
            this.deletecategorybtn.TabIndex = 24;
            this.deletecategorybtn.Text = "Delete";
            this.deletecategorybtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deletecategorybtn.Click += new System.EventHandler(this.deletecategorybtn_Click);
            // 
            // updatecategorybtn
            // 
            this.updatecategorybtn.AnimationHoverSpeed = 0.07F;
            this.updatecategorybtn.AnimationSpeed = 0.03F;
            this.updatecategorybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.updatecategorybtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.updatecategorybtn.BorderColor = System.Drawing.Color.Black;
            this.updatecategorybtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updatecategorybtn.FocusedColor = System.Drawing.Color.Empty;
            this.updatecategorybtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecategorybtn.ForeColor = System.Drawing.Color.Black;
            this.updatecategorybtn.Image = ((System.Drawing.Image)(resources.GetObject("updatecategorybtn.Image")));
            this.updatecategorybtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updatecategorybtn.Location = new System.Drawing.Point(427, 50);
            this.updatecategorybtn.Name = "updatecategorybtn";
            this.updatecategorybtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updatecategorybtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updatecategorybtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updatecategorybtn.OnHoverImage = null;
            this.updatecategorybtn.OnPressedColor = System.Drawing.Color.Black;
            this.updatecategorybtn.Size = new System.Drawing.Size(235, 40);
            this.updatecategorybtn.TabIndex = 23;
            this.updatecategorybtn.Text = "Update";
            this.updatecategorybtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updatecategorybtn.Click += new System.EventHandler(this.updatecategorybtn_Click);
            // 
            // addsourcebtn
            // 
            this.addsourcebtn.AnimationHoverSpeed = 0.07F;
            this.addsourcebtn.AnimationSpeed = 0.03F;
            this.addsourcebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addsourcebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addsourcebtn.BorderColor = System.Drawing.Color.Black;
            this.addsourcebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addsourcebtn.FocusedColor = System.Drawing.Color.Empty;
            this.addsourcebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsourcebtn.ForeColor = System.Drawing.Color.Black;
            this.addsourcebtn.Image = ((System.Drawing.Image)(resources.GetObject("addsourcebtn.Image")));
            this.addsourcebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addsourcebtn.Location = new System.Drawing.Point(5, 50);
            this.addsourcebtn.Name = "addsourcebtn";
            this.addsourcebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addsourcebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addsourcebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addsourcebtn.OnHoverImage = null;
            this.addsourcebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addsourcebtn.Size = new System.Drawing.Size(235, 40);
            this.addsourcebtn.TabIndex = 22;
            this.addsourcebtn.Text = "Create";
            this.addsourcebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addsourcebtn.Click += new System.EventHandler(this.addsourcebtn_Click);
            // 
            // categorydgv
            // 
            this.categorydgv.AllowUserToAddRows = false;
            this.categorydgv.AllowUserToDeleteRows = false;
            this.categorydgv.AllowUserToOrderColumns = true;
            this.categorydgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categorydgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.categorydgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categorydgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.categorydgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categorydgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categorydgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.categorydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorydgv.DoubleBuffered = true;
            this.categorydgv.EnableHeadersVisualStyles = false;
            this.categorydgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            this.categorydgv.HeaderForeColor = System.Drawing.Color.White;
            this.categorydgv.Location = new System.Drawing.Point(5, 96);
            this.categorydgv.MultiSelect = false;
            this.categorydgv.Name = "categorydgv";
            this.categorydgv.ReadOnly = true;
            this.categorydgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categorydgv.RowHeadersWidth = 51;
            this.categorydgv.RowTemplate.Height = 24;
            this.categorydgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categorydgv.Size = new System.Drawing.Size(1071, 445);
            this.categorydgv.TabIndex = 21;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(1032, 5);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Expense Management System\\Expense\\Category";
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
            this.gunaButton2.Location = new System.Drawing.Point(8, 625);
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
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(7, 625);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(191, 40);
            this.gunaButton1.TabIndex = 27;
            this.gunaButton1.Text = "Create";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 550);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletecategorybtn);
            this.Controls.Add(this.updatecategorybtn);
            this.Controls.Add(this.addsourcebtn);
            this.Controls.Add(this.categorydgv);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorydgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton cancelbtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton deletecategorybtn;
        private Guna.UI.WinForms.GunaButton updatecategorybtn;
        private Guna.UI.WinForms.GunaButton addsourcebtn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid categorydgv;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}