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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFProject
{
    public partial class History : Form
    {
        TrackerContext context = new TrackerContext();

        public History()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {

            var usermood = context.UserMoods.Select(s => new
            {
                id = s.MoodId,
                title = s.Moodtitle,
                trigger = s.Trigger,
                intensity = s.Intensity,
                details = s.Details,
                datetime = s.MoodDate


            }).ToList();
            dataGridView1.DataSource = usermood;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var searchedtex = textBox1.Text;
            var search = context.UserMoods.Where(s => s.Moodtitle.StartsWith(searchedtex)).Select(m => new
            {
                id = m.MoodId,
                title = m.Moodtitle,
                trigger = m.Trigger,
                intensity = m.Intensity,
                details = m.Details,
                datetime = m.MoodDate
            }).ToList();
            dataGridView1.DataSource = search;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedMoodId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    var usermood = context.UserMoods.FirstOrDefault(m => m.MoodId == selectedMoodId);
                    if (usermood != null)
                    {
                        var confirm = MessageBox.Show($"Are you sure you want to delete the mood '{usermood.Moodtitle}'?",
                     "Confirm Deletion",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            context.Remove(usermood);
                            context.SaveChanges();
                        }

                        var updatedusermoods = context.UserMoods.Select(s => new
                        {
                            id = s.MoodId,
                            title = s.Moodtitle,
                            trigger = s.Trigger,
                            intensity = s.Intensity,
                            details = s.Details,
                            datetime = s.MoodDate

                        }).ToList();
                        dataGridView1.DataSource = updatedusermoods;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the mood: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    int selectedMoodId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    var usermood = context.UserMoods.FirstOrDefault(m => m.MoodId == selectedMoodId);
                    if (usermood != null)
                    {
                        Home h = new Home();
                        h.Tag = usermood;
                        h.Show();
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating the mood {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); 
            this.Hide();
        }
    }
}
