namespace Project_Db
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            Password = new TextBox();
            LoginBox = new TextBox();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(113, 39);
            label1.Name = "label1";
            label1.Size = new Size(545, 37);
            label1.TabIndex = 0;
            label1.Text = "Fast TA and Ld Mangment System ";
            label1.Click += label1_Click;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Location = new Point(275, 327);
            Password.Name = "Password";
            Password.Size = new Size(208, 21);
            Password.TabIndex = 1;
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginBox
            // 
            LoginBox.BackColor = Color.White;
            LoginBox.Location = new Point(275, 277);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(208, 21);
            LoginBox.TabIndex = 2;
            LoginBox.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.HotTrack;
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(319, 382);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(106, 33);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Log-In";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(198, 327);
            label3.Name = "label3";
            label3.Size = new Size(58, 16);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(198, 277);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 5;
            label2.Text = "Login-Id";
            label2.Click += label2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(722, 480);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBox);
            Controls.Add(Password);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "LoginForm";
            Text = "LoginPage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Label label1;
        private TextBox Password;
        private TextBox LoginBox;
        private PictureBox pictureBox1;
        private Button LoginButton;
        private Label label3;
        private Label label2;
    }
}