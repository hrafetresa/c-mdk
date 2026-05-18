namespace _3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string race = comboBox1.SelectedItem as string;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(race);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            if (textBox1.Text == "")
                name = "незнакомец";
            else
                name = textBox1.Text;
            string race = comboBox1.Text;
            label3.Text = $"Приветствую тебя, {race} {name}";
            if (checkBox1.Checked)
                label3.Text += ", владеющий копьём";
            if (checkBox2.Checked)
                label3.Text += ", разящий мечем";
            if (checkBox3.Checked)
                label3.Text += ", познавший тайны магии";
            label3.Text += "!";
        }
    }
}
