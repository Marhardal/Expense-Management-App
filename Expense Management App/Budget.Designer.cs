namespace Expense_Management_App
{
    partial class Budget
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            this.label5 = new System.Windows.Forms.Label();
            this.nametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cancelbtn = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.addbudgetbtn = new Guna.UI.WinForms.GunaButton();
            this.desctxt = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amnttxt = new Guna.UI.WinForms.GunaNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.desctxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 42;
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
            this.nametxt.Location = new System.Drawing.Point(17, 105);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(389, 35);
            this.nametxt.TabIndex = 41;
            this.nametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.cancelbtn.Location = new System.Drawing.Point(216, 352);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.cancelbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelbtn.OnHoverImage = null;
            this.cancelbtn.OnPressedColor = System.Drawing.Color.Black;
            this.cancelbtn.Size = new System.Drawing.Size(190, 40);
            this.cancelbtn.TabIndex = 38;
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
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fill in all fields before contining.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Create a Budget.";
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
            this.gunaButton2.Location = new System.Drawing.Point(16, 352);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(191, 40);
            this.gunaButton2.TabIndex = 40;
            this.gunaButton2.Text = "Update";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.Visible = false;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // addbudgetbtn
            // 
            this.addbudgetbtn.AnimationHoverSpeed = 0.07F;
            this.addbudgetbtn.AnimationSpeed = 0.03F;
            this.addbudgetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addbudgetbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(237)))), ((int)(((byte)(245)))));
            this.addbudgetbtn.BorderColor = System.Drawing.Color.Black;
            this.addbudgetbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addbudgetbtn.FocusedColor = System.Drawing.Color.Empty;
            this.addbudgetbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbudgetbtn.ForeColor = System.Drawing.Color.Black;
            this.addbudgetbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbudgetbtn.Image")));
            this.addbudgetbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addbudgetbtn.Location = new System.Drawing.Point(17, 352);
            this.addbudgetbtn.Name = "addbudgetbtn";
            this.addbudgetbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addbudgetbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addbudgetbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addbudgetbtn.OnHoverImage = null;
            this.addbudgetbtn.OnPressedColor = System.Drawing.Color.Black;
            this.addbudgetbtn.Size = new System.Drawing.Size(190, 40);
            this.addbudgetbtn.TabIndex = 37;
            this.addbudgetbtn.Text = "Create";
            this.addbudgetbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addbudgetbtn.Click += new System.EventHandler(this.addbudgetbtn_Click);
            // 
            // desctxt
            // 
            this.desctxt.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.desctxt.AutoIndentChars = false;
            this.desctxt.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.desctxt.AutoScrollMinSize = new System.Drawing.Size(0, 19);
            this.desctxt.BackBrush = null;
            this.desctxt.BackColor = System.Drawing.Color.Transparent;
            this.desctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desctxt.CharHeight = 19;
            this.desctxt.CharWidth = 10;
            this.desctxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.desctxt.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.desctxt.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.desctxt.IsReplaceMode = false;
            this.desctxt.Location = new System.Drawing.Point(17, 242);
            this.desctxt.Name = "desctxt";
            this.desctxt.Paddings = new System.Windows.Forms.Padding(0);
            this.desctxt.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.desctxt.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("desctxt.ServiceColors")));
            this.desctxt.ShowLineNumbers = false;
            this.desctxt.Size = new System.Drawing.Size(389, 104);
            this.desctxt.TabIndex = 46;
            this.desctxt.WordWrap = true;
            this.desctxt.Zoom = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Amount";
            // 
            // amnttxt
            // 
            this.amnttxt.BaseColor = System.Drawing.Color.White;
            this.amnttxt.BorderColor = System.Drawing.Color.Black;
            this.amnttxt.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(100)))), ((int)(((byte)(221)))));
            this.amnttxt.ButtonForeColor = System.Drawing.Color.White;
            this.amnttxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.amnttxt.ForeColor = System.Drawing.Color.Black;
            this.amnttxt.Location = new System.Drawing.Point(17, 176);
            this.amnttxt.Maximum = ((long)(9999999999));
            this.amnttxt.Minimum = ((long)(0));
            this.amnttxt.Name = "amnttxt";
            this.amnttxt.Size = new System.Drawing.Size(389, 30);
            this.amnttxt.TabIndex = 48;
            this.amnttxt.Value = ((long)(0));
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 402);
            this.Controls.Add(this.amnttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addbudgetbtn);
            this.Controls.Add(this.gunaButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Budget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.Budget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.desctxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox nametxt;
        private Guna.UI.WinForms.GunaButton cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton addbudgetbtn;
        protected internal FastColoredTextBoxNS.FastColoredTextBox desctxt;
        private System.Windows.Forms.Label label3;
        protected internal Guna.UI.WinForms.GunaNumeric amnttxt;
    }
}