namespace Project_Db
{
    partial class Form6
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
            label2 = new Label();
            LoginButton = new Button();
            Studentid = new TextBox();
            BackButton = new Button();
            ViewBtn = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(89, 339);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 32;
            label2.Text = "Student Id";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.HotTrack;
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(682, 356);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(106, 33);
            LoginButton.TabIndex = 30;
            LoginButton.Text = "Add";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // Studentid
            // 
            Studentid.BackColor = Color.White;
            Studentid.Location = new Point(89, 362);
            Studentid.Name = "Studentid";
            Studentid.Size = new Size(177, 23);
            Studentid.TabIndex = 29;
            Studentid.TextAlign = HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDark;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(106, 28);
            BackButton.TabIndex = 28;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // ViewBtn
            // 
            ViewBtn.BackColor = SystemColors.Highlight;
            ViewBtn.ForeColor = SystemColors.Control;
            ViewBtn.Location = new Point(682, 158);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(106, 28);
            ViewBtn.TabIndex = 27;
            ViewBtn.Text = "View";
            ViewBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(203, 61);
            label1.Name = "label1";
            label1.Size = new Size(346, 31);
            label1.TabIndex = 26;
            label1.Text = "Lab Demostrator Asistance List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 132);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(541, 360);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 20);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Mark Present";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(Studentid);
            Controls.Add(BackButton);
            Controls.Add(ViewBtn);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form6";
            Text = "Ld Mangment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button LoginButton;
        private TextBox Studentid;
        private Button BackButton;
        private Button ViewBtn;
        private Label label1;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
    }
}