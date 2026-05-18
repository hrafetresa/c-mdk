namespace _3._5
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = Properties.Resources.гном;
            pictureBox1.Location = new Point(27, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(326, 60);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(370, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(326, 100);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Раса";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "гном", "орк", "человек", "эльф" });
            comboBox1.Location = new Point(370, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(540, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 121);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Владеет:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(59, 80);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(74, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "магией";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(59, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(69, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "мечом";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(59, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "копьём";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(370, 151);
            button1.Name = "button1";
            button1.Size = new Size(100, 50);
            button1.TabIndex = 5;
            button1.Text = "Начать игру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(195, 288);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Кто ты?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Label label3;
    }
}
