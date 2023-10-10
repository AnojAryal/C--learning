namespace Week5secB
{
    partial class Form1
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
            connectToolStripMenuItem1 = new ToolStripMenuItem();
            insertRecordToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(816, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem1, insertRecordToolStripMenuItem });
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(102, 29);
            connectToolStripMenuItem.Text = "Database";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // connectToolStripMenuItem1
            // 
            connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            connectToolStripMenuItem1.Size = new Size(270, 34);
            connectToolStripMenuItem1.Text = "Connect";
            // 
            // insertRecordToolStripMenuItem
            // 
            insertRecordToolStripMenuItem.Name = "insertRecordToolStripMenuItem";
            insertRecordToolStripMenuItem.Size = new Size(270, 34);
            insertRecordToolStripMenuItem.Text = "insertRecord";
            insertRecordToolStripMenuItem.Click += insertRecordToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem connectToolStripMenuItem;
        private ToolStripMenuItem connectToolStripMenuItem1;
        private ToolStripMenuItem insertRecordToolStripMenuItem;
    }
}