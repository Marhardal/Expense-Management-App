namespace Expense_Management_App
{
    partial class Income
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amounttxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addincomebtn = new Guna.UI.WinForms.GunaButton();
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.sourcecmd = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add an Income.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill in all fields before contining.";
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
            this.amounttxt.Location = new System.Drawing.Point(18, 117);
            this.amounttxt.Margin = new System.Windows.Forms.Padding(4);
            this.amounttxt.MaxLength = 32767;
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(390, 35);
            this.amounttxt.TabIndex = 9;
            this.amounttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Income Source";
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
            this.addincomebtn.Location = new System.Drawing.Point(18, 242);
            this.addincomebtn.Name = "addincomebtn";
            this.addincomebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addincomebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addincomebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addincomebtn.OnHoverImage = null;
            this.addincomebtn.OnPressedColor = System.Drawing.Color.Black;
            this.addincomebtn.Size = new System.Drawing.Size(190, 40);
            this.addincomebtn.TabIndex = 13;
            this.addincomebtn.Text = "Create";
            this.addincomebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addincomebtn.Click += new System.EventHandler(this.addincomebtn_Click);
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
            this.cancelbtn.Location = new System.Drawing.Point(217, 242);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelbtn.OnHoverImage = null;
            this.cancelbtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelbtn.Size = new System.Drawing.Size(190, 40);
            this.cancelbtn.TabIndex = 18;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
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
            this.sourcecmd.Location = new System.Drawing.Point(18, 191);
            this.sourcecmd.Name = "sourcecmd";
            this.sourcecmd.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sourcecmd.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sourcecmd.Size = new System.Drawing.Size(390, 31);
            this.sourcecmd.StartIndex = 0;
            this.sourcecmd.TabIndex = 19;
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
            this.gunaButton2.Location = new System.Drawing.Point(17, 242);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(191, 40);
            this.gunaButton2.TabIndex = 20;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Visible = false;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 305);
            this.Controls.Add(this.sourcecmd);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addincomebtn);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton addincomebtn;
        private Guna.UI.WinForms.GunaButton cancelbtn;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox amounttxt;
        internal Guna.UI.WinForms.GunaComboBox sourcecmd;
        internal Guna.UI.WinForms.GunaButton gunaButton2;
    }
}