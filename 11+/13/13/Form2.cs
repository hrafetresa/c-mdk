using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form2 : Form
    {

        SolidBrush brush1 = new SolidBrush(Color.Red);
        SolidBrush brush2 = new SolidBrush(Color.Blue);
        Rectangle rc1 = new Rectangle(23, 292, 80, 80);
        Rectangle rc2 = new Rectangle(138, 292, 80, 80);


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brush1, rc1);
            e.Graphics.FillEllipse(brush2, rc2);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;

            RadioButton radioButton = (RadioButton)sender;

            mainForm.Shape = radioButton.Text;

            this.Invalidate();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;

            mainForm.MySpeed = trackBar1.Value;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                brush1.Color = colorDialog1.Color;
            }

            mainForm.DirectColor = colorDialog1.Color;

            this.Invalidate();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;

            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                brush2.Color = colorDialog2.Color;
            }

            mainForm.ReverseColor = colorDialog2.Color;

            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;

            trackBar1.Value = 99;
            brush1.Color = Color.Red;
            brush2.Color = Color.Blue;
            radioButton2.Checked = true;

            mainForm.DirectColor = Color.Red;
            mainForm.ReverseColor = Color.Blue;
        }
    }
}
