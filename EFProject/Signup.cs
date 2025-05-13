using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Models;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFProject
{
    public partial class Signup : Form
    {
        TrackerContext context = new TrackerContext();
        public Signup()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void signn_Click(object sender, EventArgs e)
        {
            var first_name = username.Text;
            var last_name = lname.Text;
            var user_name = fname.Text;
            var password = pw.Text;
            var retype = re.Text;

            try
            {
                var user = new Models.User()
                {
                    FName = first_name,
                    LName = last_name,
                    username = user_name,
                    Password = password
                };
                if (retype != password)
                {
                    MessageBox.Show("Password doesn't Match!");
                    return;

                }

                context.User.Add(user);
                context.SaveChanges();

                MessageBox.Show("User registered successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            Form3 home = new Form3();
            home.Show();
            this.Hide();



        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pw.PasswordChar == '*') // If password is masked
            {
                pw.PasswordChar = '\0'; // Show the password
                pictureBox2.Image = Properties.Resources.o_Photoroom; // Change to "eye-closed" icon
            }
            else
            {
                pw.PasswordChar = '*'; // Mask the password
                pictureBox2.Image = Properties.Resources.c_Photoroom; // Change to "eye-open" icon
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (re.PasswordChar == '*') // If password is masked
            {
                re.PasswordChar = '\0'; // Show the password
                pictureBox3.Image = Properties.Resources.c_Photoroom; // Change to "eye-closed" icon
            }
            else
            {
                re.PasswordChar = '*'; // Mask the password
                pictureBox3.Image = Properties.Resources.o_Photoroom; // Change to "eye-open" icon
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
