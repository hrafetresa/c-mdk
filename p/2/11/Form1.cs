using test;

namespace _11
{

    public partial class Form1 : Form
    {
        public double[] array;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;

            while (dataGridView1.ColumnCount < n)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns.Add(column);

                string lastIndex = (dataGridView1.ColumnCount - 1).ToString();
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText = lastIndex;

            }

            if (dataGridView1.ColumnCount > n)
            {
                for (int i = dataGridView1.ColumnCount - 1; i >= n; i--)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyArray myArray = new MyArray();
            array = new double[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                Random random = new Random();
                array[i] = random.NextDouble();
            }

            foreach (var item in array)
            {
                label2.Text += item.ToString() + " ";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
