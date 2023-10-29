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
            importToolStripMenuItem1 = new ToolStripMenuItem();
            exportToolStripMenuItem1 = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            bookingNoteToolStripMenuItem = new ToolStripMenuItem();
            statisticToolStripMenuItem = new ToolStripMenuItem();
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
            carToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem1, exportToolStripMenuItem1 });
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(45, 24);
            carToolStripMenuItem.Text = "Car";
            carToolStripMenuItem.Click += carToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem1
            // 
            importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            importToolStripMenuItem1.Size = new Size(137, 26);
            importToolStripMenuItem1.Text = "Import";
            // 
            // exportToolStripMenuItem1
            // 
            exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            exportToolStripMenuItem1.Size = new Size(137, 26);
            exportToolStripMenuItem1.Text = "Export";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(137, 26);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
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
            statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            statisticToolStripMenuItem.Size = new Size(75, 24);
            statisticToolStripMenuItem.Text = "Statistic";
            statisticToolStripMenuItem.Click += statisticToolStripMenuItem_Click;
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
            changePasswordToolStripMenuItem.Size = new Size(203, 26);
            changePasswordToolStripMenuItem.Text = "ChangePassword";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(203, 26);
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
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem1;
        private ToolStripMenuItem exportToolStripMenuItem1;
    }
}