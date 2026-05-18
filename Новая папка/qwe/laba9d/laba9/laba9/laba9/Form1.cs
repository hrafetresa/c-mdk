using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _laba9
{
    public partial class Form1 : Form
    {
        private string language = "null";

        private int upper = 0;
        private int lower = 0;
        private int vowUS = 0;
        private int vowRU = 0;
        private int consRU = 0;
        private int consUS = 0;

        private List<string> filterList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearCounter(ref int vowRU, ref int vowUS, ref int consRU, ref int consUS, ref int upper, ref int lower)
        {
            vowRU = 0;
            vowUS = 0;
            consRU = 0;
            consUS = 0;
            upper = 0;
            lower = 0;
        }
        private void TextResult(object sender, int vowRU, int vowUS, int consRU, int consUS, int upper, int lower)
        {
            int vow = 0;
            int cons = 0;

            if (language == "RU")
            {
                vow = vowRU;
                cons = consRU;
            }
            if (language == "US")
            {
                vow = vowUS;
                cons = consUS;
            }
            if (sender.Equals(toolStripButton1))
            {
                label2.Text += $"Кол-во гласных: {vow} \n";
            }
            if (sender.Equals(toolStripButton2))
            {
                label2.Text += $"Кол-во согласных: {cons} \n";
            }
            if (sender.Equals(toolStripButton3))
            {
                label2.Text += $"Кол-во заглавных: {upper}\n";
            }
            if (sender.Equals(toolStripButton4))
            {
                label2.Text += $"Кол-во строчных: {lower}\n";
            }
        }

        private void LettersCounter()
        {
            label2.Text = "";
            string text = textBox1.Text;

            ClearCounter(ref vowRU, ref vowUS, ref consRU, ref consUS, ref upper, ref lower);

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

                if (английскийToolStripMenuItem.Checked)
                {
                    if (vowelsUS.Contains(Char.ToLower(text[i])))
                        vowUS++;
                    else if (text[i] != ' ')
                        consUS++;
                }

                if (русскийToolStripMenuItem.Checked)
                {
                    if (vowelsRU.Contains(Char.ToLower(text[i])))
                        vowRU++;
                    else if (text[i] != ' ')
                        consRU++;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LettersCounter();
            TextResult(sender, vowRU, vowUS, consRU, consUS, upper, lower);
        }

        private void языкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem StripItem = sender as ToolStripMenuItem;

            if (StripItem == английскийToolStripMenuItem)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                label2.Visible = true;
                английскийToolStripMenuItem.CheckOnClick = false;
                русскийToolStripMenuItem.CheckOnClick = true;
                русскийToolStripMenuItem.Checked = false;
                language = "US";
                label1.ForeColor = Color.Green;
                label1.Text = "Язык ввода: английский";
            }

            if (StripItem == русскийToolStripMenuItem)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                label2.Visible = true;
                английскийToolStripMenuItem.CheckOnClick = true;
                русскийToolStripMenuItem.CheckOnClick = false;
                английскийToolStripMenuItem.Checked = false;
                language = "RU";
                label1.ForeColor = Color.Green;
                label1.Text = "Язык ввода: русский";
            }
        }

        private void LangError(ToolStripMenuItem sender)
        {
            string lang = sender.Text;
            MessageBox.Show($"Выбран язык ввода: {lang}. \n" +
                        $"Для ввода английских символов смените язык!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (language == "RU")
            {
                if (Char.ToLower(e.KeyChar) >= 'а' && Char.ToLower(e.KeyChar) <= 'я')
                    return;
                if (Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
                {
                    LangError(русскийToolStripMenuItem);
                }
            }

            if (language == "US")
            {
                if (Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
                    return;
                if (Char.ToLower(e.KeyChar) >= 'а' && Char.ToLower(e.KeyChar) <= 'я')
                {
                    LangError(английскийToolStripMenuItem);
                }
            }

            if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
                return;

            e.KeyChar = '\0';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "Введите текст";
                toolStrip1.Enabled = false;
            }
            if (textBox1.Text != "")
            {
                toolStrip1.Enabled = true;
                label2.Text = "";
            }
        }

        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;

            if (toolStripMenuItem.Checked)
            {
                filterList.Add(toolStripMenuItem.Text);
            }
            if (!toolStripMenuItem.Checked)
            {
                filterList.Remove(toolStripMenuItem.Text);
            }
            label4.Text = "";
            foreach (string item in filterList)
            {
                label4.Text += $"{item} \n";
            }
            if (filterList.Count == 0) label4.Text = "Нет";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LettersCounter();

            int vow = 0;
            int cons = 0;

            if (language == "RU")
            {
                vow = vowRU;
                cons = consRU;
            }
            if (language == "US")
            {
                vow = vowUS;
                cons = consUS;
            }

            if (filterList.Contains("Заглавные"))
            {
                label2.Text += $"Кол-во заглавных: {upper}\n";
            }

            if (filterList.Contains("Строчные"))
            {
                label2.Text += $"Кол-во строчных: {lower}\n";
            }

            if (filterList.Contains("Гласные"))
            {
                label2.Text += $"Кол-во гласных: {vow} \n";
            }

            if (filterList.Contains("Согласные"))
            {
                label2.Text += $"Кол-во согласных: {cons} \n";
            }
        }

        private void показатьскрытьПанельИнструментовToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (показатьскрытьПанельИнструментовToolStripMenuItem.Checked)
            {
                toolStrip1.Visible = true;
            }
            else
            {
                toolStrip1.Visible = false;
            }
        }
    }
}
