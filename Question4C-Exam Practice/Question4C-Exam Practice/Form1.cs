using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question4C_Exam_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 0;
        int[] gameArray = { };
        int points = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label4.Text = $"{seconds.ToString()} seconds";
            points ++;
            gameArray.Append(points);
            label2.Text = points.ToString();
            label3.Text = "";

            if (seconds == 30)
            {
                timer1.Enabled = false;
                MessageBox.Show("Your final points is " + points.ToString());
            }

            if (seconds % 5 == 0)
            {
                label3.Text = "3 points deducted";
                points -= 3; 
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
