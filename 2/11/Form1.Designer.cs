namespace _11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            gggq = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(69, 49);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Размер массива:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(255, 224, 192);
            numericUpDown1.Location = new Point(205, 48);
            numericUpDown1.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(38, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gggq });
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(91, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(446, 106);
            dataGridView1.TabIndex = 3;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // gggq
            // 
            gggq.HeaderText = "0";
            gggq.Name = "gggq";
            gggq.SortMode = DataGridViewColumnSortMode.NotSortable;
            gggq.Width = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Enabled = false;
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(295, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввести массив:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11F);
            radioButton2.Location = new Point(30, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Вручную";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.Click += radioButton1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11F);
            radioButton1.Location = new Point(30, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 24);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Случайно";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton1.Click += radioButton1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.Location = new Point(563, 74);
            button1.Name = "button1";
            button1.Size = new Size(147, 58);
            button1.TabIndex = 5;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(91, 340);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Обработка одномерного массива";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private DataGridViewTextBoxColumn gggq;
        private Label label2;
    }
}
