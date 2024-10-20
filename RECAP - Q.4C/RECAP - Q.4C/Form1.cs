using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECAP___Q._4C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int second = 0;
        int[] gameArray = new int[31];
        int points = 0;
        Random randomTime = new Random();
        int windowTime = 0;
        bool inBonusRound = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            label1.Text = $"Seconds: {second}";
            points++;
            label3.Text = points.ToString();
            gameArray[second] = points;
            button2.Enabled = false;

            int randomTimeWindow = randomTime.Next(10,25);

            if (second == 30) { 
                timer1.Enabled = false;
                MessageBox.Show($"The total points is: {points}");
            }

            if (second == randomTimeWindow && !inBonusRound)
            {
                inBonusRound = true;
                windowTime = second;

                MessageBox.Show("3 - Second bonus window");
                points += 4;
                button2.Enabled = true;
            }

            if (inBonusRound && second == windowTime + 3)
            {
                button2.Enabled = false;
                inBonusRound = false;
            }

            if (second % 5 == 0) {
                points -= 3;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
