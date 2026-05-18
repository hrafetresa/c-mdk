using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace _15
{
    public partial class Form1 : Form
    {
        public Arr arr1;
        public Arr arr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                arr1 = new Arr((int)numericUpDown1.Value);
                arr1.Print(dataGridView1);
            }
            if (sender == button10)
            {
                arr2 = new Arr((int)numericUpDown2.Value);
                arr2.Print(dataGridView2);
            }
        }
    }
}
