namespace Expense_Management_App
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.rolecmd = new Guna.UI.WinForms.GunaComboBox();
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.addincomebtn = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.usnmtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.pwordtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // rolecmd
            // 
            this.rolecmd.BackColor = System.Drawing.Color.Transparent;
            this.rolecmd.BaseColor = System.Drawing.Color.White;
            this.rolecmd.BorderColor = System.Drawing.Color.Black;
            this.rolecmd.BorderSize = 1;
            this.rolecmd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rolecmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolecmd.FocusedColor = System.Drawing.Color.Empty;
            this.rolecmd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rolecmd.ForeColor = System.Drawing.Color.Black;
            this.rolecmd.FormattingEnabled = true;
            this.rolecmd.Items.AddRange(new object[] {
            "Select a user role."});
            this.rolecmd.Location = new System.Drawing.Point(18, 192);
            this.rolecmd.Name = "rolecmd";
            this.rolecmd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rolecmd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.rolecmd.Size = new System.Drawing.Size(390, 31);
            this.rolecmd.StartIndex = 0;
            this.rolecmd.TabIndex = 28;
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
            this.cancelbtn.Location = new System.Drawing.Point(218, 386);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
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
            this.nametxt.Location = new System.Drawing.Point(18, 115);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(390, 35);
            this.nametxt.TabIndex = 23;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fill in all fields before contining.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Registry";
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
            this.gunaButton2.Location = new System.Drawing.Point(18, 386);
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
            this.addincomebtn.Location = new System.Drawing.Point(18, 386);
            this.addincomebtn.Name = "addincomebtn";
            this.addincomebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addincomebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addincomebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addincomebtn.OnHoverImage = null;
            this.addincomebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addincomebtn.Size = new System.Drawing.Size(190, 40);
            this.addincomebtn.TabIndex = 26;
            this.addincomebtn.Text = "Register";
            this.addincomebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addincomebtn.Click += new System.EventHandler(this.addincomebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Username";
            // 
            // usnmtxt
            // 
            this.usnmtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usnmtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usnmtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usnmtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usnmtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usnmtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usnmtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usnmtxt.HintForeColor = System.Drawing.Color.DimGray;
            this.usnmtxt.HintText = "Search for an Income.";
            this.usnmtxt.isPassword = false;
            this.usnmtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.usnmtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.usnmtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usnmtxt.LineThickness = 3;
            this.usnmtxt.Location = new System.Drawing.Point(18, 265);
            this.usnmtxt.Margin = new System.Windows.Forms.Padding(4);
            this.usnmtxt.MaxLength = 32767;
            this.usnmtxt.Name = "usnmtxt";
            this.usnmtxt.Size = new System.Drawing.Size(390, 35);
            this.usnmtxt.TabIndex = 30;
            this.usnmtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Password";
            // 
            // pwordtxt
            // 
            this.pwordtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pwordtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwordtxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwordtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwordtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwordtxt.HintForeColor = System.Drawing.Color.DimGray;
            this.pwordtxt.HintText = "Search for an Income.";
            this.pwordtxt.isPassword = false;
            this.pwordtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.pwordtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.pwordtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pwordtxt.LineThickness = 3;
            this.pwordtxt.Location = new System.Drawing.Point(18, 342);
            this.pwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.pwordtxt.MaxLength = 32767;
            this.pwordtxt.Name = "pwordtxt";
            this.pwordtxt.Size = new System.Drawing.Size(390, 35);
            this.pwordtxt.TabIndex = 32;
            this.pwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 440);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pwordtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usnmtxt);
            this.Controls.Add(this.rolecmd);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addincomebtn);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI.WinForms.GunaComboBox rolecmd;
        private Guna.UI.WinForms.GunaButton cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton addincomebtn;
        private System.Windows.Forms.Label label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox usnmtxt;
        private System.Windows.Forms.Label label6;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox pwordtxt;
    }
}