using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q._5.C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 0;
        int t1 = 0;
        int count1 = 0, count2 = 0;
        int[] tickOneCount = new int[21];
        int[] tickTwoCount = new int[11];

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = seconds.ToString();
            count1++;
            label2.Text = $"Timer1 Count: {count1}";
            tickOneCount.Append(count1);

            if (seconds == 20)
            {
                timer1.Enabled = false;
                tickOneArrayDisplay();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t1++;
            if (t1 % 2 == 0)
            {
                count2++;
                label3.Text = $"Timer2 Count: {count2}";
                tickTwoCount.Append(count2);
            }

            if (t1 == 20)
            {
                timer2.Enabled = false;
                tickTwoArrayDisplay();
            }
        }

        private void tickOneArrayDisplay()
        {
            for (int i = 0; i < tickOneCount.Length; i++)
            {
                MessageBox.Show($"The contents of Array 1 are: {i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            count1 = 0;
            timer1.Start();

        }

        private void tickTwoArrayDisplay()
        {
            for (int i = 0; i < tickTwoCount.Length; i++)
            {
                MessageBox.Show($"The contents of Array 2 are: {i}");
            }
        }
    }

}