using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14true
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate double Fun(double x);

        private void Table(Fun F, double Xn, double Xk, double dX,
        out double[] xValue, out double[] yValue)
        {
            int count = (int)((Xk - Xn) / dX) + 1;
            if (count > 0)
            {
                xValue = new double[count];
                yValue = new double[count];
                int i = 0;
                for (double x = Xn; x < Xk; x += dX)
                {
                    double y;

                    switch (comboBox1.SelectedIndex)
                    {
                        case 0: y = F(x); break;
                        case 1: y = -F(x); break;
                        case 2: y= -F(x)/2; break;
                        default: throw new ArgumentException("Не выбрана функция!");
                    }

                    xValue[i] = x;
                    yValue[i] = y;
                    i++;
                }
            }
            else
            {
                throw new ArgumentException("Параметры графика не верны!");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fun F = Math.Log;

                if (radioButton1.Checked) F = Math.Log;
                else if (radioButton2.Checked) F = Math.Log10;

                double Xn = double.Parse(textBox1.Text);
                double Xk = double.Parse(textBox2.Text);
                double dX = double.Parse(textBox3.Text);

                double[] xValue;
                double[] yValue;

                string name = comboBox1.Text;

                Table(F, Xn, Xk, dX, out xValue, out yValue);
                dataGridView1.RowCount = xValue.Length;
                for (int i = 0; i < xValue.Length; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = xValue[i].ToString("F3");
                    dataGridView1.Rows[i].Cells[1].Value = yValue[i].ToString("F3");
                }

                Form2 form2 = new Form2();
                form2.X = xValue;
                form2.Y = yValue;

                form2.Show();
                form2.Draw();
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
