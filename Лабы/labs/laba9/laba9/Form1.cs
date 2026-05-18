using laba9;
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

        // Перечисление для выбора языка
        public enum Language { None, Russian, English }
        private Language currentLanguage = Language.None;

        // Переменные для хранения результатов подсчета
        private int upper = 0;
        private int lower = 0;
        private int vowUS = 0;
        private int vowRU = 0;
        private int consRU = 0;
        private int consUS = 0;

        // Строки для поиска гласных и знаков препинания
        string vowelsRU = "аоуиэыяеёю";
        string vowelsUS = "aeiou";
        string symbols = "!?.,-: \n\r";

        // Список для хранения названий выбранных фильтров
        private List<string> filterList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Обнуление всех счетчиков перед новым анализом текста
        private void ClearCounter(ref int vowRU, ref int vowUS, ref int consRU, ref int consUS, ref int upper, ref int lower)
        {
            vowRU = 0;
            vowUS = 0;
            consRU = 0;
            consUS = 0;
            upper = 0;
            lower = 0;
        }

        // Вывод конкретного результата в label в зависимости от нажатой кнопки
        private void TextResult(object sender, int vowRU, int vowUS, int consRU, int consUS, int upper, int lower)
        {
            int vow = 0;
            int cons = 0;

            // Выбираем данные по текущему языку
            if (currentLanguage == Language.Russian)
            {
                vow = vowRU;
                cons = consRU;
            }
            if (currentLanguage == Language.English)
            {
                vow = vowUS;
                cons = consUS;
            }

            // Проверяем, какая кнопка вызвала метод, и выводим результат
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
        // Перебор строки и подсчет типов символов
        private void LettersCounter()
        {
            label2.Text = "";
            string text = textBox1.Text;

            ClearCounter(ref vowRU, ref vowUS, ref consRU, ref consUS, ref upper, ref lower);

            for (int i = 0; i < text.Length; i++)
            {
                // Проверка на регистр
                if (Char.IsUpper(text[i]))
                {
                    upper++;
                }
                if (Char.IsLower(text[i]))
                {
                    lower++;
                }

                // Считаем английские буквы, если выбран режим
                if (английскийToolStripMenuItem.Checked)
                {
                    if (vowelsUS.Contains(Char.ToLower(text[i])))
                        vowUS++;
                    else if (!symbols.Contains(text[i]))
                        consUS++;
                }

                // Считаем русские буквы, если выбран режим
                if (русскийToolStripMenuItem.Checked)
                {
                    if (vowelsRU.Contains(Char.ToLower(text[i])))
                        vowRU++;
                    else if (!symbols.Contains(text[i]))
                        consRU++;
                }
            }
        }

        // Обработка кликов по кнопкам на панели инструментов
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LettersCounter();
            TextResult(sender, vowRU, vowUS, consRU, consUS, upper, lower);
        }

        // Логика переключения языка в меню
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
                currentLanguage = Language.English;
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
                currentLanguage = Language.Russian;
                label1.ForeColor = Color.Green;
                label1.Text = "Язык ввода: русский";
            }
        }

        // Окно с предупреждением, если пользователь пишет не на том языке
        private void LangError(ToolStripMenuItem sender)
        {
            string lang = sender.Text;
            MessageBox.Show($"Выбран язык ввода: {lang}. \n" +
                        $"Для ввода английских символов смените язык!");
        }

        // Ограничение ввода: запрет букв чужого алфавита
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentLanguage == Language.Russian)
            {
                if (Char.ToLower(e.KeyChar) >= 'а' && Char.ToLower(e.KeyChar) <= 'я')
                    return;
                if (Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
                {
                    LangError(русскийToolStripMenuItem);
                }
            }

            if (currentLanguage == Language.English)
            {
                if (Char.ToLower(e.KeyChar) >= 'a' && Char.ToLower(e.KeyChar) <= 'z')
                    return;
                if (Char.ToLower(e.KeyChar) >= 'а' && Char.ToLower(e.KeyChar) <= 'я')
                {
                    LangError(английскийToolStripMenuItem);
                }
            }

            // Разрешаем знаки препинания, пробелы, BackSpace и Enter
            if (symbols.Contains(e.KeyChar) ||
                e.KeyChar == (char)Keys.Back ||
                e.KeyChar == (char)Keys.Enter
                )
                return;

            // Блокируем всё остальное
            e.KeyChar = '\0';
        }

        // Включаем или выключаем кнопки в зависимости от наличия текста
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "Введите текст";
                toolStrip1.Enabled = false;
            }
            else
            {
                toolStrip1.Enabled = true;
                label2.Text = "";
            }
        }

        // Обновление списка фильтров при нажатии на чекбоксы в меню
        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;

            if (toolStripMenuItem.Checked)
            {
                filterList.Add(toolStripMenuItem.Text);
            }
            else
            {
                filterList.Remove(toolStripMenuItem.Text);
            }

            // Вывод списка активных фильтров на форму
            label4.Text = "";
            foreach (string item in filterList)
            {
                label4.Text += $"{item} \n";
            }
            if (filterList.Count == 0) label4.Text = "Нет";
        }

        // Кнопка комплексного анализа по списку фильтров
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LettersCounter();

            int vow = 0;
            int cons = 0;

            if (currentLanguage == Language.Russian)
            {
                vow = vowRU;
                cons = consRU;
            }
            else if (currentLanguage == Language.English)
            {
                vow = vowUS;
                cons = consUS;
            }

            // Добавляем строки в label только если фильтр активен
            if (filterList.Contains("Заглавные"))
                label2.Text += $"Кол-во заглавных: {upper}\n";

            if (filterList.Contains("Строчные"))
                label2.Text += $"Кол-во строчных: {lower}\n";

            if (filterList.Contains("Гласные"))
                label2.Text += $"Кол-во гласных: {vow} \n";

            if (filterList.Contains("Согласные"))
                label2.Text += $"Кол-во согласных: {cons} \n";
        }

        // Скрытие и показ панели через меню
        private void показатьскрытьПанельИнструментовToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            toolStrip1.Visible = показатьскрытьПанельИнструментовToolStripMenuItem.Checked;
        }

        // Вызов окна настроек (Form2)
        private void параметрыФормыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form2 form2 = new Form2();
            form2.ClFon = this.BackColor;
            form2.FormPosition = this.Location;

            DialogResult dr = form2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Size = form2.FormSize; // применить настройки размера
                this.WindowState = form2.Maximized; // применить настройки 
                this.BackColor = form2.ClFon;
                this.Location = form2.FormPosition;
            }
        }

        // Вызов окна "О программе"
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog(this);
        }
    }
}