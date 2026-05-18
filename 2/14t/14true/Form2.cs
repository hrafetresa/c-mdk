using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14true
{
    public partial class Form2 : Form
    {
        public double[] X { get; set; }
        public double[] Y { get; set; }
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Draw()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.DataBindXY(X, Y);
        }
    }
}
