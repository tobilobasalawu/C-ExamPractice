using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_ExamPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            seconds++;
            label1.Text = seconds.ToString();

            if (seconds == 15)
            {
                timer1.Enabled = false;
                MessageBox.Show("Times Up");
            } else if (seconds == 15/2)
            {
                MessageBox.Show("Halfway There!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show($"Elasped time: {seconds}");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 10)
            {
                timer2.Enabled = false;
            }

            label4.Text = seconds.ToString();
;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}
