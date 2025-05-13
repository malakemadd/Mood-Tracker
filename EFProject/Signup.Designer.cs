namespace EFProject
{
    partial class Signup
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
            label3 = new Label();
            lname = new TextBox();
            label1 = new Label();
            fname = new TextBox();
            pw = new TextBox();
            label4 = new Label();
            signn = new Button();
            label2 = new Label();
            username = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            re = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(48, 254);
            label3.Name = "label3";
            label3.Size = new Size(161, 27);
            label3.TabIndex = 14;
            label3.Text = "Username";
            // 
            // lname
            // 
            lname.Location = new Point(215, 197);
            lname.Name = "lname";
            lname.PlaceholderText = "Enter your last name";
            lname.Size = new Size(240, 27);
            lname.TabIndex = 19;
            lname.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(222, 36);
            label1.TabIndex = 10;
            label1.Text = "Mood Tracker";
            // 
            // fname
            // 
            fname.Location = new Point(215, 136);
            fname.Name = "fname";
            fname.PlaceholderText = "Enter your first name";
            fname.Size = new Size(240, 27);
            fname.TabIndex = 11;
            // 
            // pw
            // 
            pw.Location = new Point(215, 317);
            pw.Name = "pw";
            pw.PasswordChar = '*';
            pw.PlaceholderText = "Enter your password";
            pw.Size = new Size(240, 27);
            pw.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(48, 318);
            label4.Name = "label4";
            label4.Size = new Size(102, 26);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // signn
            // 
            signn.BackColor = SystemColors.ActiveCaption;
            signn.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signn.ForeColor = Color.Black;
            signn.Location = new Point(176, 477);
            signn.Name = "signn";
            signn.Size = new Size(455, 54);
            signn.TabIndex = 16;
            signn.Text = "Sign up";
            signn.UseVisualStyleBackColor = false;
            signn.Click += signn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(48, 138);
            label2.Name = "label2";
            label2.Size = new Size(161, 27);
            label2.TabIndex = 18;
            label2.Text = "First Name";
            // 
            // username
            // 
            username.Location = new Point(215, 254);
            username.Name = "username";
            username.PlaceholderText = "Enter a username";
            username.Size = new Size(240, 27);
            username.TabIndex = 17;
            username.TextChanged += fname_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(48, 197);
            label5.Name = "label5";
            label5.Size = new Size(161, 27);
            label5.TabIndex = 20;
            label5.Text = "Last Name";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.normal_back_arrow_button_ui_element_template_editable_isolated_dashboard_component_flat_user_interface_visual_data_presentation_web_design_widget_for_mobile_application_with_light_theme_vector;
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(22, 381);
            label7.Name = "label7";
            label7.Size = new Size(172, 26);
            label7.TabIndex = 23;
            label7.Text = "Retype Password";
            // 
            // re
            // 
            re.Location = new Point(215, 382);
            re.Name = "re";
            re.PasswordChar = '*';
            re.PlaceholderText = "Retype your new password";
            re.Size = new Size(240, 27);
            re.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.c_Photoroom;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(402, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 27);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.c_Photoroom;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(402, 382);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 27);
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = Properties.Resources.yarab_Photoroom;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(832, 543);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(re);
            Controls.Add(pictureBox1);
            Controls.Add(lname);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(signn);
            Controls.Add(label4);
            Controls.Add(pw);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(label3);
            DoubleBuffered = true;
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox lname;
        private Label label1;
        private TextBox fname;
        private TextBox pw;
        private Label label4;
        private Button signn;
        private Label label2;
        private TextBox username;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox re;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}