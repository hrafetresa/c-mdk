namespace _3._6
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(62, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Рабаритные размеры";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(62, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 114);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Опции";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Ширина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Высота";
            // 
            // button1
            // 
            button1.Location = new Point(320, 126);
            button1.Name = "button1";
            button1.Size = new Size(152, 71);
            button1.TabIndex = 2;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 303);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 3;
            label3.Text = "Стоимость стеклопакета:  ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(16, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(136, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "откидной механизм";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(16, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(146, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "микропроветривание";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(17, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(117, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "москитная сетка";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(534, 420);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Расчёт стоимости стеклопакета";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Label label3;
    }
}
