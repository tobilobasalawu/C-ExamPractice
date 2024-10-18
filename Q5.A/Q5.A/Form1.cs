using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seconds = 0;
        int count = 0;
        List<int> timeStamps = new List<int>(); 
        bool buttonCliked = false;
        int whenClicked = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonCliked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = seconds.ToString();


            if (buttonCliked == true)
            {
                count++;
                timeStamps.Add(seconds);
                buttonCliked = false;
            }

            if (seconds == 10)
            {
                timer1.Enabled = false;
                MessageBox.Show($"Total Clicks: {count}");
                CalculateAverageTimeBetweenClicks();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void CalculateAverageTimeBetweenClicks()
        {

            int totalDifference = 0;

            // Calculate the total time differences between consecutive clicks
            for (int i = 1; i < timeStamps.Count; i++)
            {
                totalDifference += (timeStamps[i] - timeStamps[i - 1]);
            }

            // Calculate the average
            double averageTime = (double)totalDifference / (count - 1);

            // Display the average time
            MessageBox.Show($"Average time between clicks: {averageTime:F2} seconds");
        }
    }
}
