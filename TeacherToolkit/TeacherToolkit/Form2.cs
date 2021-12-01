using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherToolkit
{
    public partial class Form2 : Form
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int trig = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            minutes = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            seconds = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));

            label1.Text = hours.ToString();
            label2.Text = minutes.ToString();
            label3.Text = seconds.ToString();

            if (trig == 0)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 1000; // 1 second
                trig = 1;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds <= 0)
            {
                if (minutes > 0 || hours > 0)
                {
                    if (minutes == 0)
                    {
                        if (hours >= 0)
                        {
                            hours = hours - 1;
                            minutes = 60;
                            if (hours < 0)
                            {
                                hours = 0;
                            }
                        }
                    }
                    minutes = minutes - 1;
                    seconds = 59;
                    timer1 = new Timer();
                    timer1.Interval = 1000;
                    timer1.Start();
                    label1.Text = hours.ToString();
                    label2.Text = minutes.ToString();
                    label3.Text = seconds.ToString();
                    if (minutes < 0)
                    {
                        minutes = 0;
                    }
                }
                if (seconds < 0)
                {
                    seconds = 0;
                }
                timer1.Stop();
            }
            label1.Text = hours.ToString();
            label2.Text = minutes.ToString();
            label3.Text = seconds.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
    }
}
