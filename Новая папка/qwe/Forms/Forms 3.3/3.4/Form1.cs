namespace _3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            if (e.KeyChar == '-' && textBox.TextLength == 0)
                return;
            if (e.KeyChar == ',' && textBox.Text.Contains(',') == false)
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF A = new PointF(), B = new PointF();
            A.X = float.Parse(textBox1.Text);
            A.Y = float.Parse(textBox2.Text);
            B.X = float.Parse(textBox3.Text);
            B.Y = float.Parse(textBox4.Text);
            double S = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            label7.Text = $"| A ({A.X}, {A.Y}); B ({B.X}, {B.Y}) | = {S:f3}";
        }
    }
}
