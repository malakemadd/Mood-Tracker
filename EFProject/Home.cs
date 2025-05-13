using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Migrations;
using EFProject.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFProject
{
    public partial class Home : Form
    {
        TrackerContext context = new TrackerContext();
        int mood_id = 0;

        public Home()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            var mood = context.Mood.ToList();
            c.DataSource = mood;
            c.DisplayMember = "Moodtitle";
            c.ValueMember = "MoodId";

            List<int> intensity = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            comboBox2.DataSource = intensity;

            // If an existing UserMood is passed, populate the form
            if (Tag is UserMood userMood)
            {
                c.SelectedValue = userMood.MoodId;
                c.Text = userMood.Moodtitle;
                comboBox2.SelectedItem = userMood.Intensity;
                trig.Text = userMood.Trigger;
                textBox2.Text = userMood.Details;
                dateTimePicker1.Value = userMood.MoodDate ?? DateTime.Now; 
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            var modelid = (int)c.SelectedValue;
            var moodtitle = c.Text;
            var intensity = comboBox2.Text;
            var trigger = trig.Text;
            var details = textBox2.Text;
            var datee = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(moodtitle) || string.IsNullOrEmpty(intensity) || string.IsNullOrEmpty(trigger))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            var mood = new UserMood
            {
                MoodDate = datee,
                Moodtitle = moodtitle,
                Intensity = int.Parse(comboBox2.Text),
                Trigger = trigger,
                Details = details

            };
            context.UserMoods.Add(mood);

            context.SaveChanges();

            MessageBox.Show("Mood addded successfully");
            Form3 r = new Form3();
            r.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var moodid = (int)c.SelectedValue;
            var moodtitle = c.SelectedItem;
            var intensity = comboBox2.SelectedItem?.ToString();
            var trigger = trig.Text;
            var details = textBox2.Text;
            var datee = dateTimePicker1.Value;

            var updatedmood = context.Mood.FirstOrDefault(s => s.MoodId == moodid);


            if (updatedmood == null)
            {
                MessageBox.Show("Mood not found in the database.");
                return;
            }
            // If an existing UserMood is passed, populate the form
            if (Tag is UserMood userMood)
            {
                var updatedusermood = context.UserMoods.FirstOrDefault(s => s.MoodId == userMood.MoodId);
                if (updatedusermood == null)
                {
                    MessageBox.Show("The selected mood record was not found in the UserMoods database.");
                    return;
                }

                updatedusermood.Moodtitle = updatedmood.Moodtitle;
                updatedusermood.Intensity = int.Parse(intensity);
                updatedusermood.Trigger = trigger;
                updatedusermood.Details = details;
                updatedusermood.MoodDate = datee;

                context.UserMoods.Update(updatedusermood);
                context.SaveChanges();
                Tag = updatedusermood;

                MessageBox.Show("Mood Updated Successfully");
                Form3 r = new Form3();
                r.Show();
                this.Hide();

            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f= new Form3();
            f.Show();
            this.Hide();
        }
    }
}
