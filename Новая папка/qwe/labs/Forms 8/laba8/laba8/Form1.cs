using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _laba8
{
    public partial class Form1 : Form
    {
        private string language=null;
        private int upper = 0;
        private int lower = 0;
        private int vowUS = 0;
        private int vowRU = 0;
        private int consRU = 0;
        private int consUS = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string text = textBox1.Text;

            ClearCounter(ref vowRU, ref vowUS, ref consRU, ref consUS, ref upper, ref lower);

            string vowelsRU = "аоуиэыяеёю";
            string vowelsUS = "aeiou";
            string symbols = "!?.,-: \n\r";

            int vow = 0;
            int cons = 0;

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
                    else if (!symbols.Contains(text[i]))
                        consUS++;
                }

                if (русскийToolStripMenuItem.Checked)
                {
                    if (vowelsRU.Contains(Char.ToLower(text[i])))
                        vowRU++;
                    else if (!symbols.Contains(text[i]))
                        consRU++;
                }
            }

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

        private void LangError(ToolStripMenuItem sender)
        {
            string lang = sender.Text;
            MessageBox.Show($"Выбран язык ввода: {lang}. \n" +
                        $"Для ввода английских символов смените язык!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка языка
            if (language == "RU")
            {
                // Буквы русского алфавита разрешены
                if (Char.ToLower(e.KeyChar) >= 'а' && Char.ToLower(e.KeyChar) <= 'я')
                    return;

                // Если вводятся буквы не того языка, который выбран, выдается ошибка
                if (Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
                {
                    LangError(русскийToolStripMenuItem);
                }
            }

            // Проверка языка
            if (language == "US")
            {
                // Буквы английского алфавита разрешены
                if (Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
                    return;

                // Если вводятся буквы не того языка, который выбран, выдается ошибка
                if (Char.ToLower(e.KeyChar) >= 'а' && Char.ToLower(e.KeyChar) <= 'я')
                {
                    LangError(английскийToolStripMenuItem);
                }
            }

            // Символы, пробел, кнопка удаления и Enter разрешены
            if (e.KeyChar == ' ' ||
                e.KeyChar == (char)Keys.Back ||
                e.KeyChar == (char)Keys.Enter ||
                e.KeyChar == '!' ||
                e.KeyChar == '?' ||
                e.KeyChar == '.' ||
                e.KeyChar == ',' ||
                e.KeyChar == '-' ||
                e.KeyChar == ':'
                )
                return;

            // Остальные символы запрещены
            e.KeyChar = '\0';
        }

        // Метод изменения языка
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

        // Метод по блокировке кнопок
        // Событие: текст изменен в поле textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Если поле ввода пустое
            if (textBox1.Text == "")
            {
                label2.Text = "Введите текст";

                // Кнопка "Вычислить" выключена
                button1.Enabled = false;
                
                // Форма с выбором выключена
                checkedListBox1.Enabled = false;
            }

            // Если поле ввода не пустое
            if (textBox1.Text != "")
            {
                label2.Text = "";

                // Кнопка "Вычислить" включена
                button1.Enabled = true;

                // Форма с выбором включена
                checkedListBox1.Enabled = true;
            }
        }
    }
}
