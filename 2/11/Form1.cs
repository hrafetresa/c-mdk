namespace _11
{

    public partial class Form1 : Form
    {
        public double[] array;
        public Form1()
        {
            InitializeComponent();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value; // Количество колонок

            dataGridView1.RowCount = 1; // Устанавливаем одну строку

            // Добавляем недостающие колонки
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

            // Удаляем лишние колонки
            if (dataGridView1.ColumnCount > n)
            {
                for (int i = dataGridView1.ColumnCount - 1; i >= n; i--)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }
            }

            groupBox1.Enabled = numericUpDown1.Value > 0;
        }

        // Кнопка обработки массива
        private void button1_Click(object sender, EventArgs e)
        {
            array = new double[dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                array[i] = Convert.ToDouble(dataGridView1.Rows[0].Cells[i].Value);
            }

            MyArray.ReversePositive(array); //Применяем метод обработки массива к заполненному массиву

            label2.Text = "Обработанный массив: ";

            //Вывод массива
            foreach (var item in array)
            {
                label2.Text += item.ToString() + "   ";
            }
        }

        //Изменение состояния кнопок и ячеек в datGridView в зависимости от того, какая радио кнопка выбрана
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = radioButton1.Checked || radioButton2.Checked;

            dataGridView1.ReadOnly = radioButton1.Checked;
        }

        //Заполнение массива в зависимости от того, какая нажимается радио кнопка
        private void radioButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (sender == radioButton1)
                    dataGridView1.Rows[0].Cells[i].Value = rnd.Next(-101, 100);
                if (sender == radioButton2)
                    dataGridView1.Rows[0].Cells[i].Value = 0;
            }
        }

        //Проверка вводимых в каждую ячейку данных
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string tx = ((Control)sender).Text; 
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) //Цифры разрешены
                return;
            if (e.KeyChar == '-' && tx.Length == 0) //Минус разрешен только в начале строки
                return;
            if (e.KeyChar == '\b') //Разрешена клавиша Backspace
                return;
            if (e.KeyChar == ',' && !tx.Contains(',') && tx.Length != 0) //Разрешена только одна запятая
                return;
            e.KeyChar = '\0';
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

    }
}
