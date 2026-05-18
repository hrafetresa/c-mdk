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
        public Form2(Form mainForm)
        {
            InitializeComponent();
            Form1 _mainForm = this.Owner as Form1;
            label2.BackColor = mainForm.BackColor;
        }

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
                    return new Size(734, 429);
                }
            }
        }


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

        public void FormPosition(Form1 mainForm)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            Screen screen = Screen.PrimaryScreen;

            int screenWidth = screen.Bounds.Width;

            int screenHeight = screen.Bounds.Height;

            mainForm.WindowState = this.Maximized;

            int formWidth = mainForm.Width;

            int formHeight = mainForm.Height;


            switch (selectedIndex)
            {
                case 0:
                    mainForm.Location = new Point(
                        (screenWidth / 2) - (formWidth / 2),
                        (screenHeight / 2) - (formHeight / 2)
                    );
                    break;

                case 1:
                    mainForm.Location = new Point(
                        (screenWidth / 2) - (formWidth / 2),
                        0
                    );
                    break;

                case 2:
                    mainForm.Location = new Point(
                        (screenWidth / 2) - (formWidth / 2),
                        screenHeight  - formHeight - 40
                    );
                    break;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;

            mainForm.BackColor = label2.BackColor;
            mainForm.Size = this.FormSize;
            FormPosition(mainForm);
            this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                groupBox1.Enabled = false;
            }
            else groupBox1.Enabled = true;
        }
    }
}
