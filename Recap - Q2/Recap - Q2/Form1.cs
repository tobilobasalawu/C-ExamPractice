using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap___Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = $"Seconds: {seconds.ToString()}";
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            if (seconds == 20) {
                timer1.Enabled = false;
                MessageBox.Show("20 Seconds");
            }

            if (seconds % 3 == 0)
            {
                this.BackColor = Color.Blue;
                this.ForeColor = Color.White;
            }

            if (seconds % 5 == 0)
            {
                MessageBox.Show("5 SECONDS");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
