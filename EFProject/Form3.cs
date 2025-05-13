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
    public partial class Form3 : Form
    {
        TrackerContext context = new TrackerContext();



        public Form3()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Recommendations_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rec r = new Rec();
            r.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stat s = new stat();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            editprofile ep = new editprofile();
            var usern = this.Tag;
            ep.Tag = usern;
            ep.Show();
            this.Hide();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
            this.Hide();
        }
    }
}
