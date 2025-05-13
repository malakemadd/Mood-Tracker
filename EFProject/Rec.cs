using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFProject.Models;
using EFProject.Properties;

namespace EFProject
{
    public partial class Rec : Form
    {
        TrackerContext context = new TrackerContext();
        public Rec()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void Rec_Load(object sender, EventArgs e)
        {
            var mood = context.Mood.ToList();
            comboBox1.DataSource = mood;
            comboBox1.DisplayMember = "Moodtitle";
            comboBox1.ValueMember = "MoodId";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue is int selectedmood)
            {
                var recommend = context.Recommendations
                .Where(r => r.moodid == selectedmood)
                .Select(r => r.recommend)
                .ToList();
                DisplayRecommendations(recommend);
                // Retrieve the resource link for the selected mood
                //var resource = context.Recommendations
                //    .Where(r => r.moodid == selectedmood)
                //    .Select(r => r.resource)
                //    .ToList();

                //if (!string.IsNullOrEmpty(resource) && Uri.IsWellFormedUriString(resource, UriKind.Absolute))
                //{
                var resource = context.Recommendations
               .Where(r => r.moodid == selectedmood)
               .Select(r => r.resource)
               .ToList();
                DisplayResources(resource);


                //linkLabel1.Visible = true;  // Make the link visible
                //}
                //else
                //{
                //    linkLabel1.Visible = false; // Hide the link if no valid resource is found
                //}

            }



        }
        private void DisplayRecommendations(List<string> recommendations)
        {

            listBox1.Items.Clear();  // Clear previous recommendations

            if (recommendations.Any())
            {
                foreach (var recommendation in recommendations)
                {
                    listBox1.Items.Add(recommendation);

                }
            }
            else
            {
                listBox1.Items.Add("No recommendations available for this mood.");
            }
        }
        private void DisplayResources(List<string> resources)
        {

            listBox2.Items.Clear();  // Clear previous recommendations

            if (resources.Any())
            {
                foreach (var resource in resources)
                {
                    listBox2.Items.Add(resource);

                }
            }
            else
            {
                listBox2.Items.Add("No recommendations available for this mood.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        //private void visitlink()
        //{
        //    try
        //    {
        //        if (comboBox1.SelectedValue is int selectedmood)
        //        {

        //            var resource = context.Recommendations
        //            .Where(r => r.moodid == selectedmood)
        //            .Select(r => r.resource)
        //            .ToList();


        //            if (resource != null)
        //            {
        //                listBox2.Text = resource;
        //                linkLabel1.Visible = true;

        //                if (Uri.IsWellFormedUriString(resource, UriKind.Absolute))
        //                {
        //                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        //                    {
        //                        FileName = resource,
        //                        UseShellExecute = true,

        //                    });
        //                }
        //                else
        //                {
        //                    linkLabel1.Text = "null";
        //                }

        //            }
        //            else
        //            {
        //                MessageBox.Show("No resources found for this mood.");
        //            }



        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Error opening the link: " + e.Message);
        //    }
        //}

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Open the selected link in the default browser
            if (listBox2.SelectedItem is string selectedLink &&
                Uri.IsWellFormedUriString(selectedLink, UriKind.Absolute))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = selectedLink,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening the link: {ex.Message}");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Recommendations_Click(object sender, EventArgs e)
        {

        }
    }
}

