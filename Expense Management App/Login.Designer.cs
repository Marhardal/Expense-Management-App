namespace Expense_Management_App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.usnmtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.psstxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.cancelbtn.Location = new System.Drawing.Point(219, 247);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Username";
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
            this.usnmtxt.Location = new System.Drawing.Point(20, 123);
            this.usnmtxt.Margin = new System.Windows.Forms.Padding(4);
            this.usnmtxt.MaxLength = 32767;
            this.usnmtxt.Name = "usnmtxt";
            this.usnmtxt.Size = new System.Drawing.Size(390, 35);
            this.usnmtxt.TabIndex = 23;
            this.usnmtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fill in all fields before contining.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Welcome Back";
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
            this.gunaButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton2.Location = new System.Drawing.Point(19, 247);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(191, 40);
            this.gunaButton2.TabIndex = 29;
            this.gunaButton2.Text = "Login";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Password";
            // 
            // psstxt
            // 
            this.psstxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.psstxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.psstxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psstxt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.psstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psstxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.psstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.psstxt.HintForeColor = System.Drawing.Color.DimGray;
            this.psstxt.HintText = "Search for an Income.";
            this.psstxt.isPassword = false;
            this.psstxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.psstxt.LineIdleColor = System.Drawing.Color.Gray;
            this.psstxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.psstxt.LineThickness = 3;
            this.psstxt.Location = new System.Drawing.Point(22, 200);
            this.psstxt.Margin = new System.Windows.Forms.Padding(4);
            this.psstxt.MaxLength = 32767;
            this.psstxt.Name = "psstxt";
            this.psstxt.Size = new System.Drawing.Size(390, 35);
            this.psstxt.TabIndex = 30;
            this.psstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.psstxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usnmtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton cancelbtn;
        private System.Windows.Forms.Label label3;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox usnmtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox psstxt;
    }
}