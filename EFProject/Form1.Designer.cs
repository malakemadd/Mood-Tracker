namespace EFProject
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            log = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 36);
            label1.TabIndex = 1;
            label1.Text = "Mood Tracker";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI Variable Display", 9F);
            textBox1.Location = new Point(275, 216);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your username";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(192, 495);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 4;
            label2.Text = "Already Have An Account?";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI Variable Display", 9F);
            textBox2.Location = new Point(275, 275);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Enter your password";
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 16.2F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(139, 270);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 16.2F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(142, 216);
            label3.Name = "label3";
            label3.Size = new Size(136, 27);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // log
            // 
            log.BackColor = SystemColors.ActiveCaption;
            log.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            log.ForeColor = Color.Black;
            log.Location = new Point(165, 440);
            log.Name = "log";
            log.Size = new Size(473, 52);
            log.TabIndex = 7;
            log.Text = "Login";
            log.UseVisualStyleBackColor = false;
            log.Click += log_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(490, 495);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.c_Photoroom;
            pictureBox1.Location = new Point(462, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = Properties.Resources.yarab_Photoroom;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(832, 543);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(log);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Variable Display", 9F);
            ForeColor = Color.Honeydew;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button log;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
