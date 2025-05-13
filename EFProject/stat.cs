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


namespace EFProject
{
    public partial class stat : Form
    {
        TrackerContext context = new TrackerContext();
        public stat()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stat_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            // Group Mood data and calculate counts
            var moodCounts = context.UserMoods
                .GroupBy(m => m.Moodtitle)
                .Select(g => new
                {
                    MoodId = g.Key,
                    Count = g.Count(),
                    Title = context.UserMoods.FirstOrDefault(m => m.Moodtitle == g.Key).Moodtitle
                }).ToList();

            // Calculate total entries
            int totalEntries = moodCounts.Sum(x => x.Count);

            // Add a new series
            var series = chart1.Series.Add("Mood Distribution");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            // Add data points with percentages
            foreach (var usermood in moodCounts)
            {
                double percentage = (usermood.Count / (double)totalEntries) * 100;
                series.Points.AddXY(usermood.Title, percentage);
                series.Points.Last().Label = $"{usermood.Title}: {percentage:F2}%";
            }

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage(object sender, Microsoft.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chart1.Series.Clear();

            //// Group Mood data and calculate counts
            //var moodCounts = context.UserMoods
            //    .GroupBy(m => m.Moodtitle)
            //    .Select(g => new
            //    {
            //        MoodId = g.Key,
            //        Count = g.Count(),
            //        Title = context.UserMoods.FirstOrDefault(m => m.Moodtitle == g.Key).Moodtitle
            //    }).ToList();

            //// Calculate total entries
            //int totalEntries = moodCounts.Sum(x => x.Count);

            //// Add a new series
            //var series = chart1.Series.Add("Mood Distribution");
            //series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //// Add data points with percentages
            //foreach (var usermood in moodCounts)
            //{
            //    double percentage = (usermood.Count / (double)totalEntries) * 100;
            //    series.Points.AddXY(usermood.Title, percentage);
            //    series.Points.Last().Label = $"{usermood.Title}: {percentage:F2}%";
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
