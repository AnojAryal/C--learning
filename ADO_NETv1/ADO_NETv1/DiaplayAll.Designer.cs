namespace ADO_NETv1
{
    partial class DiaplayAll
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
            button1 = new Button();
            close = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(134, 355);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "DisplayAll";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // close
            // 
            close.Location = new Point(533, 350);
            close.Name = "close";
            close.Size = new Size(112, 34);
            close.TabIndex = 1;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(134, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(511, 286);
            dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(288, 350);
            button3.Name = "button3";
            button3.Size = new Size(205, 44);
            button3.TabIndex = 3;
            button3.Text = "export pdf";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DiaplayAll
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(close);
            Controls.Add(button1);
            Name = "DiaplayAll";
            Text = "DisplayAll";
            Load += DiaplayAll_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button close;
        private DataGridView dataGridView1;
        private Button button3;
    }
}