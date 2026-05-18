using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace секундомер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Location = new Point(120, 100);
        }

        int min = 0, sec = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec > 0)
            {
                sec--;
            }
            else
            {
                if (min > 0)
                {
                    min--;
                    sec = 59;
                }
                else
                {
                    panel1.Visible = true;
                    timer1.Stop();
                    button1.Text = "Пуск";
                    label3.Visible = false;
                    numericUpDown1.Value = min;
                    numericUpDown2.Value = sec;
                }
            }
            label3.Text = $"{min:d2} : {sec:d2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Пуск")
            {
                min = int.Parse(numericUpDown1.Value.ToString());
                sec = int.Parse(numericUpDown2.Value.ToString());
                panel1.Visible = false;
                timer1.Start();
                button1.Text = "Стоп";
                label3.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                timer1.Stop();
                button1.Text = "Пуск";
                label3.Visible = false;
                numericUpDown1.Value = min;
                numericUpDown2.Value = sec;
            }
        }
    }
}
