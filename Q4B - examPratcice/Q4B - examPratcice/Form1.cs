using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4B___examPratcice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int [] objectArray = {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int i = 0;
        int j = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBar1.Maximum = objectArray.Length - 1;
           if (i < objectArray.Length - 1)
            {
                objectArray[i] = 0;
                i++;
                objectArray[i] = 1;
                progressBar1.Value = i;
                label1.Text = "The object 1 position is: " + i;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Maximum = objectArray.Length - 1;
            if (j < objectArray.Length - 1)
            {
                objectArray[j] = 0;
                j++;
                objectArray[j] = 1;
                progressBar2.Value = j;
                label2.Text = "The object 2 position is: " + j;
            }
            else
            {
                timer2.Enabled = false;
            }
        }
    }
}
