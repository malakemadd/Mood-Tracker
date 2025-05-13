using EFProject.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EFProject
{
    public partial class Form1 : Form
    {
        TrackerContext context = new TrackerContext();
        Form3 f3 = new Form3();
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {

            var user_name = textBox1.Text;
            var pw = textBox2.Text;

            var user = context.User.FirstOrDefault(u => u.username == user_name);

            if (user == null)
            {
                MessageBox.Show("username doesn't exist");
            }
            else
            {
                if (pw != user.Password)
                {
                    MessageBox.Show("Password is incorrect");

                }
                else
                {
                    MessageBox.Show("User logged in successfully.");
                    f3.Tag = user_name;

                    f3.Show();
                    this.Hide();

                }



            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*') // If password is masked
            {
                textBox2.PasswordChar = '\0'; // Show the password
               pictureBox1.Image  = Properties.Resources.o_Photoroom; // Change to "eye-closed" icon
            }
            else
            {
                textBox2.PasswordChar = '*'; // Mask the password
                pictureBox1.Image = Properties.Resources.c_Photoroom; // Change to "eye-open" icon
            }
        }
    }
}
