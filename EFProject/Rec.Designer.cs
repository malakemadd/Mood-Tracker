namespace EFProject
{
    partial class Rec
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
            Recommendations = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Recommendations
            // 
            Recommendations.BackColor = Color.Transparent;
            Recommendations.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Recommendations.Location = new Point(224, 27);
            Recommendations.Name = "Recommendations";
            Recommendations.Size = new Size(427, 42);
            Recommendations.TabIndex = 1;
            Recommendations.Text = "Boost Your Mood";
            Recommendations.TextAlign = ContentAlignment.MiddleCenter;
            Recommendations.Click += Recommendations_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 100);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 2;
            label1.Text = "How are you feeling today?";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(20, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(409, 137);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            listBox2.ForeColor = Color.Blue;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 19;
            listBox2.Location = new Point(20, 410);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(406, 137);
            listBox2.TabIndex = 8;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 370);
            label2.Name = "label2";
            label2.Size = new Size(260, 26);
            label2.TabIndex = 5;
            label2.Text = "Explore Helpful Resources";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 160);
            label3.Name = "label3";
            label3.Size = new Size(197, 26);
            label3.TabIndex = 9;
            label3.Text = "Try These Activities";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.normal_back_arrow_button_ui_element_template_editable_isolated_dashboard_component_flat_user_interface_visual_data_presentation_web_design_widget_for_mobile_application_with_light_theme_vector;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Rec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = Properties.Resources.yarab_Photoroom;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(832, 543);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(Recommendations);
            DoubleBuffered = true;
            Name = "Rec";
            Text = "Rec";
            Load += Rec_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Recommendations;
        private Label label1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}