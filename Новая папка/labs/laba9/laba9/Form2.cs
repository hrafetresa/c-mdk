using _laba9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba9
{
    public partial class Form2 : Form
    {
       

        // Конструктор получает ссылку на Form1, чтобы знать её текущий цвет
        public Form2()
        {
            
            InitializeComponent();
           
        }

        // Свойство для получения размера из текстбоксов с защитой от ошибок
        public Size FormSize
        {
            get
            {
                try
                {
                    return new Size(Int32.Parse(textBox1.Text),
                                    Int32.Parse(textBox2.Text));
                }
                catch
                {
                    // Если ошиблись со вводом, возвращаем стандарт
                    return new Size(734, 429);
                }
            }
        }

        public Color ClFon
        {
            get { return label2.BackColor; }
            set { label2.BackColor = value; }
        }

        // Проверка состояния окна (развернуто или нет)
        public FormWindowState Maximized
        {
            get
            {
                if (comboBox1.SelectedIndex == 3)
                {
                    return FormWindowState.Maximized;
                }
                else
                    return FormWindowState.Normal;
            }
        }

        // Расчет позиции Form1 на экране на основе выбора в комбобоксе
        public Point FormPosition
        {
            get
            {
                int selectedIndex = comboBox1.SelectedIndex;
                Screen screen = Screen.PrimaryScreen;
                int screenWidth = screen.Bounds.Width;
                int screenHeight = screen.Bounds.Height;


                int formWidth = FormSize.Width;
                int formHeight = FormSize.Height;

                switch (selectedIndex)
                {
                    case 0:
                        return new Point(
                            (screenWidth / 2) - (formWidth / 2),
                            (screenHeight / 2) - (formHeight / 2)
                        );
                    case 1:
                        return new Point(
                            (screenWidth / 2) - (formWidth / 2),
                            0
                        );
                    case 2:
                        return new Point(
                            (screenWidth / 2) - (formWidth / 2),
                            screenHeight - formHeight - 40
                        );
                }
                return new Point(0,0);
            }
            set
            { }
        }

        // Выбор цвета фона через стандартный диалог
        private void label2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = label2.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.BackColor = colorDialog1.Color;
            }
        }

        // Применение всех настроек к главной форме по кнопке
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Блокировка настроек размера, если выбрано "Развернуть на весь экран"
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = (comboBox1.SelectedIndex != 3);
        }

        // Разрешаем вводить в поля размера только цифры
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}