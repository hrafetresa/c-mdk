namespace Forms_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                label1.Text = $"{a} + {b} = {a + b}\n";
                label1.Text += $"{a} - {b} = {a - b}\n";
                label1.Text += $"{a} * {b} = {a * b}\n";
                label1.Text += $"{a} : {b} = {a / b} (ост. {a % b})";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат введенных данных!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Нельзя делить на ноль!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
