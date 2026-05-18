namespace Forms_3._3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century", 9F, FontStyle.Bold);
            textBox1.Location = new Point(127, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century", 9F, FontStyle.Bold);
            textBox2.Location = new Point(265, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.Font = new Font("Century", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(131, 120);
            button1.Name = "button1";
            button1.Size = new Size(234, 56);
            button1.TabIndex = 2;
            button1.Text = "Арифметические операции с числами";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(135, 209);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(507, 422);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
    }
}
