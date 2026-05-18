namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                float d = (float)a / b;
                int z = a / b;
                int div = a % b;
                label3.Text = $"Частное: {d} \nЦелая часть: {z} \nОстаток от деления: {div}";
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("На ноль делить нельзя!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Вы ввели не цифры!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Число слишком большое!");
            }
        }
    }
}
