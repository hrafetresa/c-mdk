using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Создание_компонентов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<TextBox> textBoxes = new List<TextBox>();
        int numberOfTextBoxes = 0;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numberOfTextBoxes)
            {
                textBoxes.Add(new TextBox());
                panel1.Controls.Add(textBoxes[numberOfTextBoxes]);
                textBoxes[numberOfTextBoxes].Enter += new EventHandler(textBoxes_Enter);
                textBoxes[numberOfTextBoxes].Leave += new EventHandler(textBoxes_Leave);
                textBoxes[numberOfTextBoxes].Top = numberOfTextBoxes * 40;
                textBoxes[numberOfTextBoxes].Left = 20;
                numberOfTextBoxes++;
            }
            else
                if (numericUpDown1.Value < numberOfTextBoxes)
            {
                numberOfTextBoxes--;
                textBoxes.RemoveAt(numberOfTextBoxes);
                panel1.Controls.RemoveAt(numberOfTextBoxes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxes.Count > 0)
            {
                int max = int.Parse(textBoxes[0].Text);
                int maxIndex = 0;
                int currentIndex = 0;
                foreach (TextBox item in textBoxes)
                {
                    if (int.Parse(item.Text) > max)
                    {
                        max = int.Parse(item.Text);
                        maxIndex = currentIndex;
                    }
                   currentIndex++;
                }
                textBoxes[maxIndex].BackColor = Color.Red;
                label2.Text = $"Максимальное значение: {max}";
            }
        }

        private void textBoxes_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Pink;
        }

        private void textBoxes_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
