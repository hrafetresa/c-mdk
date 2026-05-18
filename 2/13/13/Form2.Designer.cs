namespace _13
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Скорость движения:";
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(8, 28);
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(194, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickStyle = TickStyle.TopLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вид фигуры:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F);
            radioButton3.Location = new Point(21, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "ромб";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Segoe UI", 9F);
            radioButton2.Location = new Point(21, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "квадрат";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F);
            radioButton1.Location = new Point(21, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "круг";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 248);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 2;
            label1.Text = "Прямое \r\nнаправление:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(55, 391);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 3;
            button1.Text = "Сброс настроек";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(131, 248);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 2;
            label2.Text = "Обратное \r\nнаправление:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Paint += Form2_Paint;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}