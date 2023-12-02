namespace BA.DietTrackApp.PL
{
    partial class CreateAccount
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
            linkLabel1 = new LinkLabel();
            buttonSign = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Sienna;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(126, 284);
            linkLabel1.Margin = new Padding(0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(249, 26);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Zaten hesabım var";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonSign
            // 
            buttonSign.Anchor = AnchorStyles.None;
            buttonSign.BackColor = Color.Sienna;
            buttonSign.FlatAppearance.BorderSize = 0;
            buttonSign.FlatStyle = FlatStyle.Flat;
            buttonSign.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSign.ForeColor = Color.White;
            buttonSign.Location = new Point(160, 214);
            buttonSign.Margin = new Padding(0);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(183, 50);
            buttonSign.TabIndex = 8;
            buttonSign.Text = "Üye Ol";
            buttonSign.UseVisualStyleBackColor = false;
            buttonSign.Click += buttonSign_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(58, 121);
            textBox3.Margin = new Padding(0);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Şifre";
            textBox3.Size = new Size(387, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(58, 76);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "E-Posta";
            textBox2.Size = new Size(387, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(58, 31);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ad";
            textBox1.Size = new Size(387, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(61, 100);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(61, 146);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(58, 168);
            textBox4.Margin = new Padding(0);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Şifre";
            textBox4.Size = new Size(387, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = DietTrackApp.PL.Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(489, 356);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(buttonSign);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateAccount";
            Text = "CreateAccount";
            Load += CreateAccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button buttonSign;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
    }
}