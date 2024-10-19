using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap___Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seconds = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = $"Time Elasped: {seconds}s";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = $"seconds: {seconds.ToString()}";

            if (seconds == 15)
            {
                timer1.Stop();
                MessageBox.Show("Time's Up");
            }

            if (seconds == 15/2)
            {
                MessageBox.Show("Halfway There!");
            }

        }
    }
}
