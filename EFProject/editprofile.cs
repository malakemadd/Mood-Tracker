using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace EFProject
{
    public partial class editprofile : Form
    {
        TrackerContext context = new TrackerContext();
        public editprofile()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();

        }

        private void signn_Click(object sender, EventArgs e)
        {
            var user_name = Tag as string;
            var f_name = fname.Text;
            var l_name = lname.Text;
            var current_pw = current.Text;
            var new_pw = newpw.Text;
            var retyped_pw = re.Text;
            if (!string.IsNullOrEmpty(user_name))
            {
                var user = context.User.FirstOrDefault(s => s.username == user_name);
                if (user != null)
                {
                    if (user.Password != current_pw)
                    {
                        MessageBox.Show("Current password is incorrect.");
                        return;

                    }

                    if (retyped_pw != new_pw)
                    {
                        MessageBox.Show("Password doesn't Match!");
                        return;

                    }
                    user.FName = f_name;
                    user.LName = l_name;
                    user.Password = new_pw;
                    context.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("User information updated successfully!");


                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editprofile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var user_name = this.Tag as string;
            var f_name = fname.Text;
            var l_name = lname.Text;
            var new_username = newusername.Text;
            var current_pw = current.Text;
            var new_pw = newpw.Text;
            var retyped_pw = re.Text;

            if (string.IsNullOrEmpty(user_name))
            {
                MessageBox.Show("Invalid user. Please try again.");
                return;
            }

            var user = context.User.FirstOrDefault(s => s.username == user_name);
            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            // Validate current password
            if (!string.IsNullOrEmpty(current_pw) && user.Password != current_pw)
            {
                MessageBox.Show("Current password is incorrect.");
                return;
            }

            // Validate new password and confirmation
            if (!string.IsNullOrEmpty(new_pw) || !string.IsNullOrEmpty(retyped_pw))
            {
                if (new_pw != retyped_pw)
                {
                    MessageBox.Show("New password and confirmation do not match.");
                    return;
                }
                user.Password = new_pw; // Update password if matched
            }

            // Check for duplicate username if a new username is provided
            if (!string.IsNullOrEmpty(new_username))
            {
                if (context.User.Any(s => s.username == new_username))
                {
                    MessageBox.Show("Username is already taken. Please choose another.");
                    return;
                }
                user.username = new_username;
            }

            // Update optional fields
            if (!string.IsNullOrEmpty(f_name))
                user.FName = f_name;

            if (!string.IsNullOrEmpty(l_name))
                user.LName = l_name;

            // Save changes
            context.User.Update(user);
            context.SaveChanges();

            MessageBox.Show("User information updated successfully!");


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (current.PasswordChar == '*') // If password is masked
            {
                current.PasswordChar = '\0'; // Show the password
                pictureBox2.Image = Properties.Resources.o_Photoroom; // Change to "eye-closed" icon
            }
            else
            {
                current.PasswordChar = '*'; // Mask the password
                pictureBox2.Image = Properties.Resources.c_Photoroom; // Change to "eye-open" icon
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (newpw.PasswordChar == '*') // If password is masked
            {
                newpw.PasswordChar = '\0'; // Show the password
                pictureBox3.Image = Properties.Resources.o_Photoroom; // Change to "eye-closed" icon
            }
            else
            {
                newpw.PasswordChar = '*'; // Mask the password
                pictureBox3.Image = Properties.Resources.c_Photoroom; // Change to "eye-open" icon
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (re.PasswordChar == '*') // If password is masked
            {
                re.PasswordChar = '\0'; // Show the password
                pictureBox4.Image = Properties.Resources.o_Photoroom; // Change to "eye-closed" icon
            }
            else
            {
                re.PasswordChar = '*'; // Mask the password
                pictureBox4.Image = Properties.Resources.c_Photoroom; // Change to "eye-open" icon
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
