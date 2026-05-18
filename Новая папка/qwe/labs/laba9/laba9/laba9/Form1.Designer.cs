namespace _laba9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.гласныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.согласныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заглавныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строчныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(44, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 141);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(376, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите текст";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1.Text = "Гласные";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton2.Text = "Согласные";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton3.Text = "Заглавные";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton4.Text = "Строчные";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(138, 22);
            this.toolStripButton5.Text = "Посчитать с фильтром";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.языкToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.CheckOnClick = true;
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.английскийToolStripMenuItem,
            this.русскийToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.языкToolStripMenuItem.Text = "Язык";
            this.языкToolStripMenuItem.Click += new System.EventHandler(this.языкToolStripMenuItem_Click);
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.CheckOnClick = true;
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.английскийToolStripMenuItem.Text = "Английский";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.языкToolStripMenuItem_Click);
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.CheckOnClick = true;
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.языкToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гласныеToolStripMenuItem,
            this.согласныеToolStripMenuItem,
            this.заглавныеToolStripMenuItem,
            this.строчныеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Фильтр";
            // 
            // гласныеToolStripMenuItem
            // 
            this.гласныеToolStripMenuItem.CheckOnClick = true;
            this.гласныеToolStripMenuItem.Name = "гласныеToolStripMenuItem";
            this.гласныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.гласныеToolStripMenuItem.Text = "Гласные";
            this.гласныеToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            // 
            // согласныеToolStripMenuItem
            // 
            this.согласныеToolStripMenuItem.CheckOnClick = true;
            this.согласныеToolStripMenuItem.Name = "согласныеToolStripMenuItem";
            this.согласныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.согласныеToolStripMenuItem.Text = "Согласные";
            this.согласныеToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            // 
            // заглавныеToolStripMenuItem
            // 
            this.заглавныеToolStripMenuItem.CheckOnClick = true;
            this.заглавныеToolStripMenuItem.Name = "заглавныеToolStripMenuItem";
            this.заглавныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заглавныеToolStripMenuItem.Text = "Заглавные";
            this.заглавныеToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            // 
            // строчныеToolStripMenuItem
            // 
            this.строчныеToolStripMenuItem.CheckOnClick = true;
            this.строчныеToolStripMenuItem.Name = "строчныеToolStripMenuItem";
            this.строчныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.строчныеToolStripMenuItem.Text = "Строчные";
            this.строчныеToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolStripMenuItem1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите язык";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 130);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Нет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фильтр:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(718, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Вычисление кол-ва букв";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem английскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гласныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem согласныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заглавныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строчныеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

