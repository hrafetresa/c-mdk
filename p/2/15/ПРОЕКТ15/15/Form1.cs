using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Arr arr1 = new Arr();
        public Arr arr2 = new Arr();
        public Arr arr3 = new Arr();
        public Form1()
        {
            InitializeComponent();
        }

        private bool InputMethod(Arr array, string n1, string n2, GroupBox gb)
        {
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)gb.Controls[i];
                if (rb.Checked && i == 3)
                {
                    array.RndInput();
                    return true;
                }
                if (rb.Checked && i == 2)
                {
                    if (n1 == "")
                    {
                        MessageBox.Show("Введите N1!");
                        return false;
                    }
                    array.RndInput(Convert.ToInt32(n1));
                    return true;
                }
                if (rb.Checked && i == 1)
                {
                    if (n1 == "")
                    {
                        MessageBox.Show("Введите N1!");
                        return false;
                    }
                    if (n2 == "")
                    {
                        MessageBox.Show("Введите N2!");
                        return false;
                    }
                    array.RndInput(Convert.ToInt32(n1), Convert.ToInt32(n2));
                    return true;
                }
            }
            return true;
        }

        private void OnOffButtons()
        {
            bool arr1Exists = (arr1.Size > 0);
            bool arr2Exists = (arr2.Size > 0);

            button2.Enabled = arr1Exists;
            button3.Enabled = arr1Exists;
            button4.Enabled = arr1Exists;
            button5.Enabled = arr1Exists;
            textBox3.Enabled = arr1Exists;
            label10.Visible = arr1Exists;

            button9.Enabled = arr2Exists;
            button8.Enabled = arr2Exists;
            button7.Enabled = arr2Exists;
            button6.Enabled = arr2Exists;
            textBox4.Enabled = arr2Exists;
            label11.Visible = arr2Exists;

            bool bothExist = arr1Exists && arr2Exists;
            button11.Enabled = bothExist;
            button12.Enabled = bothExist;
            button13.Enabled = bothExist;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                arr1 = new Arr((int)numericUpDown1.Value);

                if (!InputMethod(arr1, textBox1.Text, textBox2.Text, groupBox1)) 
                    return;

                arr1.Print(dataGridView1);
                OnOffButtons();
            }
            if (sender == button10)
            {
                arr2 = new Arr((int)numericUpDown2.Value);

                if (!InputMethod(arr2, textBox6.Text, textBox5.Text, groupBox2)) 
                    return;

                arr2.Print(dataGridView2);
                OnOffButtons();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                numericUpDown1.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                button15.Enabled = false;
            }
            else if (radioButton3.Checked)
            {
                numericUpDown1.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button15.Enabled = false;
            }
            else if (radioButton4.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                numericUpDown1.Enabled = false;
                button15.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button15.Enabled = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                textBox6.Enabled = true;
                textBox5.Enabled = false;
                numericUpDown2.Enabled = true;
                button16.Enabled = false;
            }
            else if (radioButton6.Checked)
            {
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                numericUpDown2.Enabled = true;
                button16.Enabled = false;
            }
            else if (radioButton5.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                numericUpDown2.Enabled = false;
                button16.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = true;
                textBox6.Enabled = false;
                textBox5.Enabled = false;
                button16.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sender == button2)
            {
                arr1++;
                arr1.Print(dataGridView1);
            }
            if (sender == button9)
            {
                arr2++;
                arr2.Print(dataGridView2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender == button3)
            {
                arr1--;
                arr1.Print(dataGridView1);
            }
            if (sender == button8)
            {
                arr2--;
                arr2.Print(dataGridView2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sender == button4)
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите a!");
                    return;
                }
                arr1 = arr1 + (int.Parse(textBox3.Text));
                arr1.Print(dataGridView1);
            }
            if (sender == button7)
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите a!");
                    return;
                }
                arr2 = arr2 + (int.Parse(textBox4.Text));
                arr2.Print(dataGridView2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sender == button5)
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите a!");
                    return;
                }
                arr1 = arr1 - (int.Parse(textBox3.Text));
                arr1.Print(dataGridView1);
            }
            if (sender == button6)
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите a!");
                    return;
                }
                arr2 = arr2 - (int.Parse(textBox4.Text));
                arr2.Print(dataGridView2);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            arr3 = arr1 + arr2;
            arr3.Print(dataGridView3);
            label9.Text = "Сумма массивов:";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            arr3 = arr1 - arr2;
            arr3.Print(dataGridView3);
            label9.Text = "Разность массивов:";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if (numericUpDown.Value > 0 && numericUpDown == numericUpDown1 && !radioButton4.Checked)
            {
                button1.Enabled = true;
            }
            else if (numericUpDown.Value == 0)
            {
                button1.Enabled = false;
            }

            if (numericUpDown.Value > 0 && numericUpDown == numericUpDown2 && !radioButton5.Checked)
            {
                button10.Enabled = true;
            }
            else if(numericUpDown.Value == 0)
            {
                button10.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Arr temp = new Arr();
            temp = arr2;
            arr2 = arr1;
            arr1 = temp;
            arr1.Print(dataGridView1);
            arr2.Print(dataGridView2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            arr1.Clear();
            arr1.Print(dataGridView1);

            arr2.Clear();
            arr2.Print(dataGridView2);

            arr3.Clear();
            arr3.Print(dataGridView3);

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

            OnOffButtons();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (sender == button15)
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.Filter = "Текстовые файлы(*.txt) | *.txt";
                    ofd.Title = "Выберите текстовый файл с массивом";

                    label10.Text = $"Файл: {ofd.SafeFileName}";

                    arr1 = new Arr();
                    arr1.LoadFromFile(ofd.FileName);
                    arr1.Print(dataGridView1);

                    numericUpDown1.Value = arr1.Size;
                    button1.Enabled = false;

                    OnOffButtons();
                }
            }

            if (sender == button16)
            {
                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ofd.Filter = "Текстовые файлы(*.txt) | *.txt";
                    ofd.Title = "Выберите текстовый файл с массивом";

                    label11.Text = $"Файл: {ofd.SafeFileName}";

                    arr2 = new Arr();
                    arr2.LoadFromFile(ofd.FileName);
                    arr2.Print(dataGridView2);

                    numericUpDown2.Value = arr2.Size;
                    button10.Enabled = false;

                    OnOffButtons();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            arr1.LabTask();
            
            arr1.Print(dataGridView3);

            int first = -1, last  = -1;
            for (int i = 0; i < arr1.Size; i++) 
            {
                if (arr1[i] % 3 == 0)
                {
                    if (first == -1) first = i;
                    last = i;
                }
            }
            if (first != -1)
            {
                dataGridView3.Rows[0].Cells[first].Style.BackColor = Color.LightGreen;
                dataGridView3.Rows[0].Cells[last].Style.BackColor = Color.LightGreen;
            }
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == красныйToolStripMenuItem)
                this.BackColor = Color.Red;
            if (sender == белыйToolStripMenuItem)
                this.BackColor = Color.White;
            if (sender == поУмолчаниюToolStripMenuItem)
                this.BackColor = Color.FromArgb( 255, 224, 192);
        }

        private void textBox1_EnabledChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            tb.BorderStyle = tb.Enabled ? BorderStyle.FixedSingle : BorderStyle.None;
        }
    }
}
