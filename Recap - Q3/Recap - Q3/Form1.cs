using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap___Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] timerArray = new int[10];
        int seconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds < 10)
            {
                label1.Text = seconds.ToString();
                timerArray[seconds] = seconds + 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            String content = "";
            for (int i = 0; i < timerArray.Length; i++)
            {
                content += timerArray[i].ToString();
            }
            MessageBox.Show(content);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
