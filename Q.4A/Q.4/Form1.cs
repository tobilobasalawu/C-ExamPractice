using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;
        int[] arrayNumbers = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Maximum = arrayNumbers.Length;
            label1.Text= index.ToString();
            if (index < arrayNumbers.Length)
            {
                arrayNumbers[index] = 0;
                index++;
                progressBar1.Value = index;
            }

            if (index == arrayNumbers.Length)
            {
                timer1.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
