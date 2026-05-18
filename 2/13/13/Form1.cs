namespace _13
{
    public partial class Form1 : Form
    {
        int w = 80, h = 80;
        int x = 1, y = 100;
        int dx = 20;

        enum STATUS { Left, Right };
        STATUS flag;
        SolidBrush brush = new SolidBrush(Color.Red);
        Rectangle rc;

        public Form1()
        {
            InitializeComponent();
        }

        public int MySpeed
        {
            get
            {
                return 100 - timer1.Interval;
            }
            set
            {
                timer1.Interval = 100 - value;
            }
        }

        public Color MyColor
        {
            get
            {
                return brush.Color;
            }
            set
            {
                brush.Color = value;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            rc = new Rectangle(x, y, w, h);
            this.Invalidate(rc, true);
            if (flag == STATUS.Left)
                x -= dx;
            if (flag == STATUS.Right)
                x += dx;
            if (x >= this.ClientSize.Width - w)
                flag = STATUS.Left;
            else if (x <= 1)
                flag = STATUS.Right;

            rc = new Rectangle(x, y, w, h);
            this.Invalidate(rc, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(brush, rc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
