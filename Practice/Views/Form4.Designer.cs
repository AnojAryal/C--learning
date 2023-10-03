namespace Practice
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.clickMe = new System.Windows.Forms.Button();
            this.agree = new System.Windows.Forms.CheckBox();
            this.disagree = new System.Windows.Forms.CheckBox();
            this.maybe = new System.Windows.Forms.CheckBox();
            this.choise = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clickMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clickMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clickMe.Location = new System.Drawing.Point(321, 381);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(135, 32);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "Click Me";
            this.clickMe.UseVisualStyleBackColor = false;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Location = new System.Drawing.Point(285, 84);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(54, 17);
            this.agree.TabIndex = 1;
            this.agree.Text = "Agree";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // disagree
            // 
            this.disagree.AutoSize = true;
            this.disagree.Location = new System.Drawing.Point(285, 118);
            this.disagree.Name = "disagree";
            this.disagree.Size = new System.Drawing.Size(68, 17);
            this.disagree.TabIndex = 2;
            this.disagree.Text = "Disagree";
            this.disagree.UseVisualStyleBackColor = true;
            // 
            // maybe
            // 
            this.maybe.AutoSize = true;
            this.maybe.Location = new System.Drawing.Point(285, 152);
            this.maybe.Name = "maybe";
            this.maybe.Size = new System.Drawing.Size(58, 17);
            this.maybe.TabIndex = 3;
            this.maybe.Text = "Maybe";
            this.maybe.UseVisualStyleBackColor = true;
            this.maybe.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // choise
            // 
            this.choise.FormattingEnabled = true;
            this.choise.Items.AddRange(new object[] {
            "Agree",
            "Disagree",
            "Maybe"});
            this.choise.Location = new System.Drawing.Point(364, 116);
            this.choise.Name = "choise";
            this.choise.Size = new System.Drawing.Size(121, 21);
            this.choise.TabIndex = 4;
            this.choise.SelectedIndexChanged += new System.EventHandler(this.choise_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(285, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make Your Choises for";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(407, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.google.com";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Agree",
            "Disagree",
            "Maybe"});
            this.listBox1.Location = new System.Drawing.Point(285, 239);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 56);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(395, 239);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(90, 56);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(11, 60);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(555, 118);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // Notification
            // 
            this.Notification.Text = "Notification";
            this.Notification.Visible = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(365, 152);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 401);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(523, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 60);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(121, 301);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 19;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(523, 71);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(259, 44);
            this.webBrowser1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(555, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 55);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(122, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 180);
            this.panel1.TabIndex = 22;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.choise);
            this.Controls.Add(this.maybe);
            this.Controls.Add(this.disagree);
            this.Controls.Add(this.agree);
            this.Controls.Add(this.clickMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.CheckBox agree;
        private System.Windows.Forms.CheckBox disagree;
        private System.Windows.Forms.CheckBox maybe;
        private System.Windows.Forms.ComboBox choise;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NotifyIcon Notification;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}