using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        Rectangle rc1 = new Rectangle(21, 292, 80, 80);
        Rectangle rc2 = new Rectangle(128, 292, 80, 80);
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush1, rc1);
            e.Graphics.FillRectangle(brush2, rc2);
        }
        

 /*       public string Shape
        {
            get
            {
                for (int i = 0; i < groupBox2.Controls.Count; i++) 
                {
                    groupbox
                    if (groupBox2.Controls[i])
                    return groupBox2.Controls[i].Text;
                }
            }
            set
            {

            }
        }*/
    }
}
