namespace ADO_NET.V2
{
    partial class NewStudent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FullNameForm = new TextBox();
            MADForm = new TextBox();
            OOPForm = new TextBox();
            IDForm = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 114);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "FULL NAME :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 170);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "LEVEL :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 233);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "SECTION :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 289);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 4;
            label5.Text = "MAD :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 337);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "OOP :";
            label6.Click += label6_Click;
            // 
            // FullNameForm
            // 
            FullNameForm.Location = new Point(202, 108);
            FullNameForm.Name = "FullNameForm";
            FullNameForm.Size = new Size(285, 31);
            FullNameForm.TabIndex = 6;
            // 
            // MADForm
            // 
            MADForm.Location = new Point(202, 283);
            MADForm.Name = "MADForm";
            MADForm.Size = new Size(150, 31);
            MADForm.TabIndex = 7;
            // 
            // OOPForm
            // 
            OOPForm.Location = new Point(202, 331);
            OOPForm.Name = "OOPForm";
            OOPForm.Size = new Size(150, 31);
            OOPForm.TabIndex = 8;
            // 
            // IDForm
            // 
            IDForm.Location = new Point(202, 56);
            IDForm.Name = "IDForm";
            IDForm.Size = new Size(150, 31);
            IDForm.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(191, 403);
            button1.Name = "button1";
            button1.Size = new Size(186, 34);
            button1.TabIndex = 12;
            button1.Text = "CalculateResult";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 488);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 13;
            label7.Text = "TOTAL :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 547);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 14;
            label8.Text = "RESULT :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 607);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 15;
            label9.Text = "PERCENTAGE :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 482);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 541);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 601);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BBS", "BSC CSSE" });
            comboBox1.Location = new Point(202, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "L4", "L5", "L6" });
            comboBox2.Location = new Point(202, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(375, 655);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 21;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(540, 655);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 22;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // NewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 701);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(IDForm);
            Controls.Add(OOPForm);
            Controls.Add(MADForm);
            Controls.Add(FullNameForm);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewStudent";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += NewStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox FullNameForm;
        private TextBox MADForm;
        private TextBox OOPForm;
        private TextBox IDForm;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
    }
}