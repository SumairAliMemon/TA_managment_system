namespace Project_Db
{
    partial class HireTA_Form
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
            textBox2 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            HireButon = new Button();
            viewBtn = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(114, 358);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "StudentId";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(549, 358);
            button2.Name = "button2";
            button2.Size = new Size(106, 28);
            button2.TabIndex = 4;
            button2.Text = "Hire";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(114, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(541, 274);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 31);
            label1.TabIndex = 6;
            label1.Text = "Eligible Candidate For TAship";
            label1.Click += label1_Click;
            // 
            // HireButon
            // 
            HireButon.BackColor = SystemColors.Highlight;
            HireButon.ForeColor = SystemColors.Control;
            HireButon.Location = new Point(673, 98);
            HireButon.Name = "HireButon";
            HireButon.Size = new Size(106, 28);
            HireButon.TabIndex = 7;
            HireButon.Text = "HireBest";
            HireButon.UseVisualStyleBackColor = false;
            // 
            // viewBtn
            // 
            viewBtn.BackColor = SystemColors.Highlight;
            viewBtn.ForeColor = SystemColors.Control;
            viewBtn.Location = new Point(673, 163);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(106, 28);
            viewBtn.TabIndex = 8;
            viewBtn.Text = "view table";
            viewBtn.UseVisualStyleBackColor = false;
            viewBtn.Click += viewBtn_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDark;
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(12, 15);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(106, 28);
            BackButton.TabIndex = 15;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // HireTA_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(viewBtn);
            Controls.Add(HireButon);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Name = "HireTA_Form";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button HireButon;
        private Button viewBtn;
        private Button BackButton;
    }
}