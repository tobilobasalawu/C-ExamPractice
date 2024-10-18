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

        int [] objectArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
        int seconds = 0;
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            i++;
            progressBar1.Maximum = objectArray.Length;
            if (seconds < objectArray.Length && i < objectArray.Length)
            {
                label1.Text = seconds.ToString();
                progressBar1.Value = objectArray[i];
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
