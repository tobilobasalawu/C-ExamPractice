using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECAP___Q3C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;
        }
        int seconds = 0;
        Random randomNumber = new Random();
        int[] scoresArray = new int[10];
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            label1.Text = seconds.ToString();
            if (seconds < scoresArray.Length)
            {
                int numberRan = randomNumber.Next(1, 10);
                scoresArray[seconds] = numberRan;
                seconds++;
            }

            if (seconds == scoresArray.Length)
            {
                timer1.Enabled = false;
                displayArray();
                average();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void displayArray()
        {
            String contents = "";
            for (int i = 0; i < scoresArray.Length; i++)
            {
                contents += scoresArray[i].ToString();
            }
            MessageBox.Show($"array values are: {contents}");

        }

        private void average()
        {
            int sum = 0;
            double mean = 0;
            for (int i = 0; i < scoresArray.Length; i++)
            {
                sum += scoresArray[i];
                mean = (double)sum / scoresArray.Length;
            }

            MessageBox.Show($"Mean: {mean.ToString()}");
        }
    }
}
