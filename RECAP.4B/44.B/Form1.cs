using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44.B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;
        int indexTwo = 0;
        int[] multipleObjectArray = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = $"Seconds: {index}";
            progressBar1.Maximum = multipleObjectArray.Length;
            if (index < multipleObjectArray.Length)
            {
                multipleObjectArray[index] = 0;
                index++;
                progressBar1.Value = index;
            }

            if (index == multipleObjectArray.Length)
            {
                timer1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label2.Text = $"Seconds: {indexTwo}";
            progressBar2.Maximum = multipleObjectArray.Length;
            if (indexTwo < multipleObjectArray.Length)
            {
                multipleObjectArray[indexTwo] = 0;
                indexTwo++;
                progressBar2.Value = indexTwo;
            }

            if (indexTwo == multipleObjectArray.Length)
            {
                timer2.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
