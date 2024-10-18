using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4_ExamPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int [] objectArray = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < objectArray.Length - 1)
            {
                objectArray[i] = 0;
                i++;
                objectArray[i] = 1;

                label1.Text = "The position is " + i;
                progressBar1.Value = i;

            }

            else
            {
                timer1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
