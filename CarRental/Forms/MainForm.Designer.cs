namespace CarRental
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
            menuStrip1 = new MenuStrip();
            carToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            bookingNoteToolStripMenuItem = new ToolStripMenuItem();
            statisticToolStripMenuItem = new ToolStripMenuItem();
            dailyToolStripMenuItem = new ToolStripMenuItem();
            monthlyToolStripMenuItem = new ToolStripMenuItem();
            yearlyToolStripMenuItem = new ToolStripMenuItem();
            byCarToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { carToolStripMenuItem, customerToolStripMenuItem, bookingNoteToolStripMenuItem, statisticToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1118, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(45, 24);
            carToolStripMenuItem.Text = "Car";
            carToolStripMenuItem.Click += carToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // bookingNoteToolStripMenuItem
            // 
            bookingNoteToolStripMenuItem.Name = "bookingNoteToolStripMenuItem";
            bookingNoteToolStripMenuItem.Size = new Size(111, 24);
            bookingNoteToolStripMenuItem.Text = "BookingNote";
            bookingNoteToolStripMenuItem.Click += bookingNoteToolStripMenuItem_Click;
            // 
            // statisticToolStripMenuItem
            // 
            statisticToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dailyToolStripMenuItem, monthlyToolStripMenuItem, yearlyToolStripMenuItem, byCarToolStripMenuItem });
            statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            statisticToolStripMenuItem.Size = new Size(75, 24);
            statisticToolStripMenuItem.Text = "Statistic";
            // 
            // dailyToolStripMenuItem
            // 
            dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            dailyToolStripMenuItem.Size = new Size(146, 26);
            dailyToolStripMenuItem.Text = "Daily";
            // 
            // monthlyToolStripMenuItem
            // 
            monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            monthlyToolStripMenuItem.Size = new Size(146, 26);
            monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // yearlyToolStripMenuItem
            // 
            yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            yearlyToolStripMenuItem.Size = new Size(146, 26);
            yearlyToolStripMenuItem.Text = "Yearly";
            // 
            // byCarToolStripMenuItem
            // 
            byCarToolStripMenuItem.Name = "byCarToolStripMenuItem";
            byCarToolStripMenuItem.Size = new Size(146, 26);
            byCarToolStripMenuItem.Text = "By Car";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, logoutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(224, 26);
            changePasswordToolStripMenuItem.Text = "ChangePassword";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 28);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1118, 574);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 602);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarRental";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem carToolStripMenuItem;
        private Panel panelMain;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem bookingNoteToolStripMenuItem;
        private ToolStripMenuItem statisticToolStripMenuItem;
        private ToolStripMenuItem dailyToolStripMenuItem;
        private ToolStripMenuItem monthlyToolStripMenuItem;
        private ToolStripMenuItem yearlyToolStripMenuItem;
        private ToolStripMenuItem byCarToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}