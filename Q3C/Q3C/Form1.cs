using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] randomNumbers = { 23, 89, 90, 99, 70, 99, 89};
        int i = 0;
        int[] arrrayContent = new int [5];
        int sec = 1;
        string printArr = "The contents are: ";

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label1.Text = sec.ToString();
            if (arrrayContent.Length == i)
            {
                timer1.Enabled = false;
                MessageBox.Show($"{printArr}");
                averageNumbers();
            }

            if (sec % 2 == 0 && i < arrrayContent.Length)
            {
                arrrayContent[i] = randomNumbers[i]; 
                printArr += arrrayContent[i];
                i++;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void averageNumbers()
        {
            int total = 0;
            for (int i =0; i < arrrayContent.Length; i++)
            {
                total += arrrayContent[i];
            }
            int mean = total / arrrayContent.Length;
            MessageBox.Show($"The average is {mean}");
        }
    }
}
