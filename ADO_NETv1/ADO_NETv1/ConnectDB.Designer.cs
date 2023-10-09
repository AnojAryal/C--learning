namespace ADO_NETv1
{
    partial class ConnectDB
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
            menuStrip1 = new MenuStrip();
            connectToolStripMenuItem = new ToolStripMenuItem();
            connectDBToolStripMenuItem = new ToolStripMenuItem();
            insertRecordToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            displayAllToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectDBToolStripMenuItem, insertRecordToolStripMenuItem, searchToolStripMenuItem, displayAllToolStripMenuItem });
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(78, 29);
            connectToolStripMenuItem.Text = "Forms";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // connectDBToolStripMenuItem
            // 
            connectDBToolStripMenuItem.Name = "connectDBToolStripMenuItem";
            connectDBToolStripMenuItem.Size = new Size(270, 34);
            connectDBToolStripMenuItem.Text = "ConnectDB";
            connectDBToolStripMenuItem.Click += connectDBToolStripMenuItem_Click;
            // 
            // insertRecordToolStripMenuItem
            // 
            insertRecordToolStripMenuItem.Name = "insertRecordToolStripMenuItem";
            insertRecordToolStripMenuItem.Size = new Size(270, 34);
            insertRecordToolStripMenuItem.Text = "InsertRecord";
            insertRecordToolStripMenuItem.Click += insertRecordToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(270, 34);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // displayAllToolStripMenuItem
            // 
            displayAllToolStripMenuItem.Name = "displayAllToolStripMenuItem";
            displayAllToolStripMenuItem.Size = new Size(270, 34);
            displayAllToolStripMenuItem.Text = "DisplayAll";
            displayAllToolStripMenuItem.Click += displayAllToolStripMenuItem_Click;
            // 
            // ConnectDB
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ConnectDB";
            Text = "MainWindow";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem connectDBToolStripMenuItem;
        private ToolStripMenuItem insertRecordToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem displayAllToolStripMenuItem;
    }
}