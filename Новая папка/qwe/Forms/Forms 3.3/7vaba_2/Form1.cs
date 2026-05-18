using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7vaba_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string text = textBox1.Text;
            int upper = 0;
            int lower = 0;
            int vow = 0; 
            int cons = 0;
            string vowelsRU = "аоуиэыяеёю";
            string vowelsUS = "aeiou";
            for (int i = 0; i < text.Length; i++)
            {   
                if (Char.IsUpper(text[i]))
                {
                    upper++;
                }
                if (Char.IsLower(text[i]))
                {
                    lower++;
                }
                if (vowelsRU.Contains(text[i]))
                {
                    vow++;
                }
                else
                {
                    cons++;
                }
            }

            if (checkedListBox1.CheckedItems.Contains("Заглавные"))
            {
                label2.Text += $"Кол-во заглавных: {upper}\n";
            }

            if (checkedListBox1.CheckedItems.Contains("Строчные"))
            {
                label2.Text += $"Кол-во строчных: {lower}\n";
            }

            if (checkedListBox1.CheckedItems.Contains("Гласные"))
            {
                label2.Text += $"Кол-во гласных: {vow} \n";
            }

            if (checkedListBox1.CheckedItems.Contains("Согласные"))
            {
                label2.Text += $"Кол-во согласных: {cons} \n";
            }

        }
    }
}
