namespace Expense_Management_App
{
    partial class Source
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.sourcedgv = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.deleteincomebtn = new Guna.UI.WinForms.GunaButton();
            this.updateincomebtn = new Guna.UI.WinForms.GunaButton();
            this.addincomebtn = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.sourcedgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expense Management System\\Income\\Source";
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
            this.gunaControlBox1.TabIndex = 5;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // sourcedgv
            // 
            this.sourcedgv.AllowUserToAddRows = false;
            this.sourcedgv.AllowUserToDeleteRows = false;
            this.sourcedgv.AllowUserToOrderColumns = true;
            this.sourcedgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sourcedgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.sourcedgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sourcedgv.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.sourcedgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sourcedgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sourcedgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.sourcedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourcedgv.DoubleBuffered = true;
            this.sourcedgv.EnableHeadersVisualStyles = false;
            this.sourcedgv.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(238)))));
            this.sourcedgv.HeaderForeColor = System.Drawing.Color.White;
            this.sourcedgv.Location = new System.Drawing.Point(6, 96);
            this.sourcedgv.MultiSelect = false;
            this.sourcedgv.Name = "sourcedgv";
            this.sourcedgv.ReadOnly = true;
            this.sourcedgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sourcedgv.RowHeadersWidth = 51;
            this.sourcedgv.RowTemplate.Height = 24;
            this.sourcedgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sourcedgv.Size = new System.Drawing.Size(1071, 445);
            this.sourcedgv.TabIndex = 10;
            // 
            // deleteincomebtn
            // 
            this.deleteincomebtn.AnimationHoverSpeed = 0.07F;
            this.deleteincomebtn.AnimationSpeed = 0.03F;
            this.deleteincomebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.deleteincomebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.deleteincomebtn.BorderColor = System.Drawing.Color.Black;
            this.deleteincomebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteincomebtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteincomebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteincomebtn.ForeColor = System.Drawing.Color.Black;
            this.deleteincomebtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteincomebtn.Image")));
            this.deleteincomebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteincomebtn.Location = new System.Drawing.Point(842, 50);
            this.deleteincomebtn.Name = "deleteincomebtn";
            this.deleteincomebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deleteincomebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteincomebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteincomebtn.OnHoverImage = null;
            this.deleteincomebtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteincomebtn.Size = new System.Drawing.Size(235, 40);
            this.deleteincomebtn.TabIndex = 13;
            this.deleteincomebtn.Text = "Delete";
            this.deleteincomebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deleteincomebtn.Click += new System.EventHandler(this.deleteincomebtn_Click);
            // 
            // updateincomebtn
            // 
            this.updateincomebtn.AnimationHoverSpeed = 0.07F;
            this.updateincomebtn.AnimationSpeed = 0.03F;
            this.updateincomebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.updateincomebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.updateincomebtn.BorderColor = System.Drawing.Color.Black;
            this.updateincomebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateincomebtn.FocusedColor = System.Drawing.Color.Empty;
            this.updateincomebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateincomebtn.ForeColor = System.Drawing.Color.Black;
            this.updateincomebtn.Image = ((System.Drawing.Image)(resources.GetObject("updateincomebtn.Image")));
            this.updateincomebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.updateincomebtn.Location = new System.Drawing.Point(426, 50);
            this.updateincomebtn.Name = "updateincomebtn";
            this.updateincomebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.updateincomebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateincomebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.updateincomebtn.OnHoverImage = null;
            this.updateincomebtn.OnPressedColor = System.Drawing.Color.Black;
            this.updateincomebtn.Size = new System.Drawing.Size(235, 40);
            this.updateincomebtn.TabIndex = 12;
            this.updateincomebtn.Text = "Update";
            this.updateincomebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateincomebtn.Click += new System.EventHandler(this.updateincomebtn_Click);
            // 
            // addincomebtn
            // 
            this.addincomebtn.AnimationHoverSpeed = 0.07F;
            this.addincomebtn.AnimationSpeed = 0.03F;
            this.addincomebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addincomebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addincomebtn.BorderColor = System.Drawing.Color.Black;
            this.addincomebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addincomebtn.FocusedColor = System.Drawing.Color.Empty;
            this.addincomebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addincomebtn.ForeColor = System.Drawing.Color.Black;
            this.addincomebtn.Image = ((System.Drawing.Image)(resources.GetObject("addincomebtn.Image")));
            this.addincomebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addincomebtn.Location = new System.Drawing.Point(7, 50);
            this.addincomebtn.Name = "addincomebtn";
            this.addincomebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addincomebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addincomebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addincomebtn.OnHoverImage = null;
            this.addincomebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addincomebtn.Size = new System.Drawing.Size(235, 40);
            this.addincomebtn.TabIndex = 11;
            this.addincomebtn.Text = "Create";
            this.addincomebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addincomebtn.Click += new System.EventHandler(this.addincomebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Create an Income Source.";
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
            this.nametxt.Location = new System.Drawing.Point(7, 570);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(429, 35);
            this.nametxt.TabIndex = 15;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.gunaButton1.Location = new System.Drawing.Point(6, 612);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(191, 40);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Create";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.cancelbtn.Location = new System.Drawing.Point(245, 612);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelbtn.OnHoverImage = null;
            this.cancelbtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelbtn.Size = new System.Drawing.Size(191, 40);
            this.cancelbtn.TabIndex = 17;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
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
            this.gunaButton2.Location = new System.Drawing.Point(7, 612);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(191, 40);
            this.gunaButton2.TabIndex = 18;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Visible = false;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 550);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteincomebtn);
            this.Controls.Add(this.updateincomebtn);
            this.Controls.Add(this.addincomebtn);
            this.Controls.Add(this.sourcedgv);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Source";
            this.Load += new System.EventHandler(this.Source_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourcedgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid sourcedgv;
        private Guna.UI.WinForms.GunaButton deleteincomebtn;
        private Guna.UI.WinForms.GunaButton updateincomebtn;
        private Guna.UI.WinForms.GunaButton addincomebtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton cancelbtn;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}