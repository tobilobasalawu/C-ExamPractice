using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECAP___Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seconds = 0;
        int[] arrayTimeStamps = new int[10];
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = $"Time: {seconds}s, Clicks: {count}";

            if (seconds == 10){
                timer1.Stop();
                timeStamps();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count < arrayTimeStamps.Length) {
                arrayTimeStamps[count] = seconds;
                count++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timeStamps()
        {
            for (int i = 0; i < arrayTimeStamps.Length; i++)
            {
                if (arrayTimeStamps[i] > 0)
                {
                    MessageBox.Show($"TimeStamps are: {arrayTimeStamps[i]}");
                }
            }
        }
    }
}
