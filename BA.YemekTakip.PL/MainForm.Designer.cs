namespace BA.DietTrackApp.PL
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            buttonReports = new Button();
            buttonSnacks = new Button();
            buttonDinner = new Button();
            buttonLunch = new Button();
            buttonBreakfast = new Button();
            buttonHome = new Button();
            monthCalendar1 = new MonthCalendar();
            panelCenter = new Panel();
            buttonMaximize = new Button();
            buttonMinimize = new Button();
            buttonClose = new Button();
            panelBar = new Panel();
            labelBar = new Label();
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            panelBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Sienna;
            panelMenu.Controls.Add(buttonReports);
            panelMenu.Controls.Add(buttonSnacks);
            panelMenu.Controls.Add(buttonDinner);
            panelMenu.Controls.Add(buttonLunch);
            panelMenu.Controls.Add(buttonBreakfast);
            panelMenu.Controls.Add(buttonHome);
            panelMenu.Controls.Add(monthCalendar1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(327, 885);
            panelMenu.TabIndex = 0;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.Sienna;
            buttonReports.Dock = DockStyle.Top;
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReports.ForeColor = Color.White;
            buttonReports.Image = (Image)resources.GetObject("buttonReports.Image");
            buttonReports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReports.Location = new Point(0, 733);
            buttonReports.Margin = new Padding(4, 3, 4, 3);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(36, 0, 0, 0);
            buttonReports.Size = new Size(327, 92);
            buttonReports.TabIndex = 6;
            buttonReports.Text = "Raporlar";
            buttonReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonSnacks
            // 
            buttonSnacks.BackColor = Color.Sienna;
            buttonSnacks.Dock = DockStyle.Top;
            buttonSnacks.FlatAppearance.BorderSize = 0;
            buttonSnacks.FlatStyle = FlatStyle.Flat;
            buttonSnacks.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSnacks.ForeColor = Color.White;
            buttonSnacks.Image = (Image)resources.GetObject("buttonSnacks.Image");
            buttonSnacks.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSnacks.Location = new Point(0, 641);
            buttonSnacks.Margin = new Padding(4, 3, 4, 3);
            buttonSnacks.Name = "buttonSnacks";
            buttonSnacks.Padding = new Padding(36, 0, 0, 0);
            buttonSnacks.Size = new Size(327, 92);
            buttonSnacks.TabIndex = 4;
            buttonSnacks.Text = "Ara Öğün";
            buttonSnacks.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSnacks.UseVisualStyleBackColor = false;
            buttonSnacks.Click += buttonSnacks_Click;
            // 
            // buttonDinner
            // 
            buttonDinner.BackColor = Color.Sienna;
            buttonDinner.Dock = DockStyle.Top;
            buttonDinner.FlatAppearance.BorderSize = 0;
            buttonDinner.FlatStyle = FlatStyle.Flat;
            buttonDinner.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDinner.ForeColor = Color.White;
            buttonDinner.Image = (Image)resources.GetObject("buttonDinner.Image");
            buttonDinner.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDinner.Location = new Point(0, 549);
            buttonDinner.Margin = new Padding(4, 3, 4, 3);
            buttonDinner.Name = "buttonDinner";
            buttonDinner.Padding = new Padding(36, 0, 0, 0);
            buttonDinner.Size = new Size(327, 92);
            buttonDinner.TabIndex = 3;
            buttonDinner.Text = "Akşam Yemeği";
            buttonDinner.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDinner.UseVisualStyleBackColor = false;
            buttonDinner.Click += buttonDinner_Click;
            // 
            // buttonLunch
            // 
            buttonLunch.BackColor = Color.Sienna;
            buttonLunch.Dock = DockStyle.Top;
            buttonLunch.FlatAppearance.BorderSize = 0;
            buttonLunch.FlatStyle = FlatStyle.Flat;
            buttonLunch.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLunch.ForeColor = Color.White;
            buttonLunch.Image = (Image)resources.GetObject("buttonLunch.Image");
            buttonLunch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLunch.Location = new Point(0, 457);
            buttonLunch.Margin = new Padding(4, 3, 4, 3);
            buttonLunch.Name = "buttonLunch";
            buttonLunch.Padding = new Padding(36, 0, 0, 0);
            buttonLunch.Size = new Size(327, 92);
            buttonLunch.TabIndex = 2;
            buttonLunch.Text = "Öğle Yemeği";
            buttonLunch.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLunch.UseVisualStyleBackColor = false;
            buttonLunch.Click += buttonLunch_Click;
            // 
            // buttonBreakfast
            // 
            buttonBreakfast.BackColor = Color.Sienna;
            buttonBreakfast.Dock = DockStyle.Top;
            buttonBreakfast.FlatAppearance.BorderSize = 0;
            buttonBreakfast.FlatStyle = FlatStyle.Flat;
            buttonBreakfast.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBreakfast.ForeColor = Color.White;
            buttonBreakfast.Image = (Image)resources.GetObject("buttonBreakfast.Image");
            buttonBreakfast.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBreakfast.Location = new Point(0, 365);
            buttonBreakfast.Margin = new Padding(4, 3, 4, 3);
            buttonBreakfast.Name = "buttonBreakfast";
            buttonBreakfast.Padding = new Padding(36, 0, 0, 0);
            buttonBreakfast.Size = new Size(327, 92);
            buttonBreakfast.TabIndex = 1;
            buttonBreakfast.Text = "Kahvaltı";
            buttonBreakfast.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBreakfast.UseVisualStyleBackColor = false;
            buttonBreakfast.Click += buttonBreakfast_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Sienna;
            buttonHome.Dock = DockStyle.Top;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.White;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 253);
            buttonHome.Margin = new Padding(4, 3, 4, 3);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(36, 0, 0, 0);
            buttonHome.Size = new Size(327, 112);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Anasayfa";
            buttonHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Highlight;
            monthCalendar1.Dock = DockStyle.Top;
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Margin = new Padding(11, 12, 11, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // panelCenter
            // 
            panelCenter.BackColor = Color.Transparent;
            panelCenter.Dock = DockStyle.Fill;
            panelCenter.Location = new Point(327, 52);
            panelCenter.Margin = new Padding(4, 3, 4, 3);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new Size(1082, 833);
            panelCenter.TabIndex = 1;
            panelCenter.Paint += panelCenter_Paint;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.BackgroundImage = (Image)resources.GetObject("buttonMaximize.BackgroundImage");
            buttonMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMaximize.Location = new Point(1011, -3);
            buttonMaximize.Margin = new Padding(14, 3, 14, 3);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(26, 52);
            buttonMaximize.TabIndex = 2;
            buttonMaximize.UseVisualStyleBackColor = true;
            buttonMaximize.Click += buttonMaximize_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize.BackgroundImage = (Image)resources.GetObject("buttonMinimize.BackgroundImage");
            buttonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinimize.Location = new Point(977, -3);
            buttonMinimize.Margin = new Padding(14, 3, 14, 3);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(26, 52);
            buttonMinimize.TabIndex = 1;
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackgroundImage = (Image)resources.GetObject("buttonClose.BackgroundImage");
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(1045, -3);
            buttonClose.Margin = new Padding(14, 3, 14, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(26, 52);
            buttonClose.TabIndex = 0;
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.Transparent;
            panelBar.Controls.Add(labelBar);
            panelBar.Controls.Add(buttonMaximize);
            panelBar.Controls.Add(buttonMinimize);
            panelBar.Controls.Add(buttonClose);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(327, 0);
            panelBar.Margin = new Padding(4, 3, 4, 3);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1082, 52);
            panelBar.TabIndex = 2;
            panelBar.MouseDown += panelBar_MouseDown;
            // 
            // labelBar
            // 
            labelBar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelBar.AutoSize = true;
            labelBar.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBar.ForeColor = Color.White;
            labelBar.Location = new Point(409, 5);
            labelBar.Margin = new Padding(4, 0, 4, 0);
            labelBar.Name = "labelBar";
            labelBar.Size = new Size(126, 29);
            labelBar.TabIndex = 3;
            labelBar.Text = "ANASAYFA";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panelCenter);
            panel1.Controls.Add(panelBar);
            panel1.Controls.Add(panelMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 885);
            panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1409, 885);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1273, 791);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelBar.ResumeLayout(false);
            panelBar.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonClose;
        private Button buttonMaximize;
        private Button buttonMinimize;
        public Panel panelCenter;
        private Panel panelBar;
        private Label labelBar;
        public MonthCalendar monthCalendar1;
        public Button buttonSnacks;
        public Button buttonDinner;
        public Button buttonLunch;
        public Button buttonBreakfast;
        public Button buttonReports;
        public Button buttonHome;
        private Panel panel1;
    }
}