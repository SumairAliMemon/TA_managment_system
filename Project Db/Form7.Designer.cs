namespace Project_Db
{
    partial class TaRequest
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
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(229, 158);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 40;
            label2.Text = "Course Name";
            label2.Click += label2_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.HotTrack;
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(336, 302);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(106, 33);
            LoginButton.TabIndex = 39;
            LoginButton.Text = "Add";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // Studentid
            // 
            Studentid.BackColor = Color.White;
            Studentid.Location = new Point(336, 158);
            Studentid.Name = "Studentid";
            Studentid.Size = new Size(177, 23);
            Studentid.TabIndex = 38;
            Studentid.TextAlign = HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDark;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(106, 28);
            BackButton.TabIndex = 37;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(229, 103);
            label1.Name = "label1";
            label1.Size = new Size(313, 31);
            label1.TabIndex = 35;
            label1.Text = "Teacher Assistance Request";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(229, 217);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 43;
            label3.Text = "Faculty Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(337, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 42;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TaRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(Studentid);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Name = "TaRequest";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button LoginButton;
        private TextBox Studentid;
        private Button BackButton;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
    }
}