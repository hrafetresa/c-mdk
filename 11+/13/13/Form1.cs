namespace _13
{
    public partial class Form1 : Form
    {
        int w = 80, h = 80;
        int x = 1, y = 100;
        int dx = 20;
        bool isMovingForward = true;

        enum STATUS { DownLeft, RightBottom, UpRight, DownRight, LeftBottom, UpLeft };
        STATUS flag = STATUS.DownLeft;
        SolidBrush brush = new SolidBrush(Color.Red);
        Rectangle rc;

        public string Shape { get; set; } = "круг";
        public Color DirectColor { get; set; } = Color.Red;
        public Color ReverseColor { get; set; } = Color.Blue;
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

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate(rc, true);

            brush.Color = isMovingForward ? DirectColor : ReverseColor;

            switch (flag)
            {
                case STATUS.DownLeft:
                    x = 0;
                    y += dx;
                    if (y >= this.ClientSize.Height - h)
                    {
                        y = this.ClientSize.Height - h;
                        flag = STATUS.RightBottom;
                    }
                    break;

                case STATUS.RightBottom:
                    y = this.ClientSize.Height - h;
                    x += dx;
                    if (x >= this.ClientSize.Width - w)
                    {
                        x = this.ClientSize.Width - w;
                        flag = STATUS.UpRight;
                    }
                    break;

                case STATUS.UpRight:
                    x = this.ClientSize.Width - w;
                    y -= dx;
                    if (y <= 0)
                    {
                        y = 0;
                        flag = STATUS.DownRight;
                    }
                    break;

                case STATUS.DownRight:
                    x = this.ClientSize.Width - w;
                    y += dx;
                    if (y >= this.ClientSize.Height - h)
                    {
                        y = this.ClientSize.Height - h;
                        flag = STATUS.LeftBottom;
                    }
                    break;

                case STATUS.LeftBottom:
                    y = this.ClientSize.Height - h;
                    x -= dx;
                    if (x <= 0)
                    {
                        x = 0;
                        flag = STATUS.UpLeft;
                    }
                    break;

                case STATUS.UpLeft:
                    x = 0;
                    y -= dx;
                    if (y <= 0)
                    {
                        y = 0;
                        flag = STATUS.DownLeft;
                    }
                    break;
            }

            rc = new Rectangle(x, y, w, h);
            this.Invalidate(rc, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brush, rc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 existingForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (existingForm != null)
            {
                existingForm.BringToFront();
                existingForm.Activate();
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Owner = this;
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

            button1.Text = timer1.Enabled ? "Стоп" : "Старт";
            button1.BackColor = timer1.Enabled ? Color.Red : Color.LightGreen;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
