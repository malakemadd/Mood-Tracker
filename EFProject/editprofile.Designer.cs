namespace EFProject
{
    partial class editprofile
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
            lname = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            newpw = new TextBox();
            fname = new TextBox();
            label1 = new Label();
            label6 = new Label();
            re = new TextBox();
            label7 = new Label();
            current = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            newusername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lname
            // 
            lname.Location = new Point(245, 192);
            lname.Name = "lname";
            lname.PlaceholderText = "Enter your last name";
            lname.Size = new Size(240, 27);
            lname.TabIndex = 29;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(38, 191);
            label5.Name = "label5";
            label5.Size = new Size(161, 27);
            label5.TabIndex = 30;
            label5.Text = "Last Name";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(38, 142);
            label2.Name = "label2";
            label2.Size = new Size(161, 27);
            label2.TabIndex = 28;
            label2.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(38, 348);
            label4.Name = "label4";
            label4.Size = new Size(151, 26);
            label4.TabIndex = 25;
            label4.Text = "New Password";
            // 
            // newpw
            // 
            newpw.Location = new Point(245, 347);
            newpw.Name = "newpw";
            newpw.PasswordChar = '*';
            newpw.PlaceholderText = "Enter your new password";
            newpw.Size = new Size(240, 27);
            newpw.TabIndex = 23;
            // 
            // fname
            // 
            fname.Location = new Point(245, 143);
            fname.Name = "fname";
            fname.PlaceholderText = "Enter your username";
            fname.Size = new Size(240, 27);
            fname.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(222, 36);
            label1.TabIndex = 21;
            label1.Text = "Mood Tracker";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(38, 398);
            label6.Name = "label6";
            label6.Size = new Size(172, 26);
            label6.TabIndex = 32;
            label6.Text = "Retype Password";
            // 
            // re
            // 
            re.Location = new Point(245, 399);
            re.Name = "re";
            re.PasswordChar = '*';
            re.PlaceholderText = "Retype your new password";
            re.Size = new Size(240, 27);
            re.TabIndex = 31;
            re.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(38, 297);
            label7.Name = "label7";
            label7.Size = new Size(179, 26);
            label7.TabIndex = 34;
            label7.Text = "Current Password";
            // 
            // current
            // 
            current.Location = new Point(245, 297);
            current.Name = "current";
            current.PasswordChar = '*';
            current.PlaceholderText = "Enter your password";
            current.Size = new Size(240, 27);
            current.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.normal_back_arrow_button_ui_element_template_editable_isolated_dashboard_component_flat_user_interface_visual_data_presentation_web_design_widget_for_mobile_application_with_light_theme_vector;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Impact", 18F);
            button1.Location = new Point(209, 477);
            button1.Name = "button1";
            button1.Size = new Size(455, 54);
            button1.TabIndex = 36;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 240);
            label3.Name = "label3";
            label3.Size = new Size(161, 27);
            label3.TabIndex = 37;
            label3.Text = "Username";
            // 
            // newusername
            // 
            newusername.Location = new Point(245, 241);
            newusername.Name = "newusername";
            newusername.PlaceholderText = "Enter your new username";
            newusername.Size = new Size(240, 27);
            newusername.TabIndex = 38;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.c_Photoroom;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.c_Photoroom;
            pictureBox2.Location = new Point(432, 295);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 27);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.BackgroundImage = Properties.Resources.c_Photoroom;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.c_Photoroom;
            pictureBox3.Location = new Point(432, 347);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 27);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.BackgroundImage = Properties.Resources.c_Photoroom;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Image = Properties.Resources.c_Photoroom;
            pictureBox4.Location = new Point(432, 399);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 27);
            pictureBox4.TabIndex = 41;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(762, 9);
            label8.Name = "label8";
            label8.Size = new Size(58, 18);
            label8.TabIndex = 42;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // editprofile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = Properties.Resources.yarab_Photoroom;
            ClientSize = new Size(832, 543);
            Controls.Add(label8);
            Controls.Add(fname);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(newusername);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(current);
            Controls.Add(label6);
            Controls.Add(re);
            Controls.Add(lname);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(newpw);
            Controls.Add(label1);
            Name = "editprofile";
            Text = "editprofile";
            Load += editprofile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lname;
        private Label label5;
        private Label label2;
        private Label label4;
        private TextBox newpw;
        private TextBox fname;
        private Label label1;
        private Label label6;
        private TextBox re;
        private Label label7;
        private TextBox current;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private TextBox newusername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label8;
    }
}