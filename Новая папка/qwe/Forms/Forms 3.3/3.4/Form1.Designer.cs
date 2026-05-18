namespace _3._4
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(102, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Координаты\r\n точки А";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(239, 36);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 1;
            label2.Text = "Координаты \r\nточки B";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(102, 99);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(103, 138);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 3;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(239, 138);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 5;
            label5.Text = "Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(238, 99);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 4;
            label6.Text = "X";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(123, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(58, 23);
            textBox1.TabIndex = 6;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox2.Location = new Point(123, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(58, 23);
            textBox2.TabIndex = 6;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox3.Location = new Point(262, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(58, 23);
            textBox3.TabIndex = 6;
            textBox3.KeyPress += textBox1_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox4.Location = new Point(262, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(58, 23);
            textBox4.TabIndex = 6;
            textBox4.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(157, 196);
            button1.Name = "button1";
            button1.Size = new Size(130, 57);
            button1.TabIndex = 7;
            button1.Text = "Вычислить расстояние между точками";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(118, 281);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 395);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label7;
    }
}
