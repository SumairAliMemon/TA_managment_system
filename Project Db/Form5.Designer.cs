namespace Project_Db
{
    partial class Form5
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
            BackButton = new Button();
            ViewBtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            LoginButton = new Button();
            Studentid = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDark;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(106, 28);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // ViewBtn
            // 
            ViewBtn.BackColor = SystemColors.Highlight;
            ViewBtn.ForeColor = SystemColors.Control;
            ViewBtn.Location = new Point(682, 119);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(106, 28);
            ViewBtn.TabIndex = 18;
            ViewBtn.Text = "View";
            ViewBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(236, 45);
            label1.Name = "label1";
            label1.Size = new Size(253, 31);
            label1.TabIndex = 16;
            label1.Text = "Teacher Asistance List";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 132);
            dataGridView1.TabIndex = 15;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.HotTrack;
            LoginButton.ForeColor = SystemColors.ButtonHighlight;
            LoginButton.Location = new Point(682, 317);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(106, 33);
            LoginButton.TabIndex = 21;
            LoginButton.Text = "Add";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // Studentid
            // 
            Studentid.BackColor = Color.White;
            Studentid.Location = new Point(89, 323);
            Studentid.Name = "Studentid";
            Studentid.Size = new Size(177, 23);
            Studentid.TabIndex = 20;
            Studentid.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(453, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 22;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(89, 300);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 23;
            label2.Text = "Student Id";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(453, 300);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 24;
            label3.Text = "Total Assignments";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(LoginButton);
            Controls.Add(Studentid);
            Controls.Add(BackButton);
            Controls.Add(ViewBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "TA-Mangment";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button ViewBtn;
        private Label label1;
        private DataGridView dataGridView1;
        private Button LoginButton;
        private TextBox Studentid;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}