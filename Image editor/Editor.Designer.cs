namespace Image_editor
{
    partial class Editor
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х128ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x320ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x480ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.x640ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x786ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1024ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x768ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(744, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 473);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поворот";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Редактирование выключено";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 25;
            this.trackBar1.Location = new System.Drawing.Point(15, 217);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(193, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 255;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(153, 194);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "20";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 194);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "10";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(79, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "6";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 194);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(8, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 24);
            this.panel3.TabIndex = 1;
            this.panel3.Tag = "";
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "По вертикали";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "По горизонтали";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 473);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Image_editor.Properties.Resources._640x480;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 261);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выбратьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.открытьToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.х128ToolStripMenuItem,
            this.xToolStripMenuItem,
            this.x320ToolStripMenuItem,
            this.x480ToolStripMenuItem,
            this.x480ToolStripMenuItem1,
            this.x640ToolStripMenuItem,
            this.x786ToolStripMenuItem,
            this.x1024ToolStripMenuItem,
            this.x768ToolStripMenuItem});
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            // 
            // х128ToolStripMenuItem
            // 
            this.х128ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._128x128;
            this.х128ToolStripMenuItem.Name = "х128ToolStripMenuItem";
            this.х128ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.х128ToolStripMenuItem.Text = "128х128";
            this.х128ToolStripMenuItem.Click += new System.EventHandler(this.х128ToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Image = global::Image_editor.Properties.Resources._360x240;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.xToolStripMenuItem.Text = "360x240";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // x320ToolStripMenuItem
            // 
            this.x320ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._480x320;
            this.x320ToolStripMenuItem.Name = "x320ToolStripMenuItem";
            this.x320ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.x320ToolStripMenuItem.Text = "480x320";
            this.x320ToolStripMenuItem.Click += new System.EventHandler(this.x320ToolStripMenuItem_Click);
            // 
            // x480ToolStripMenuItem
            // 
            this.x480ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._640x480;
            this.x480ToolStripMenuItem.Name = "x480ToolStripMenuItem";
            this.x480ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.x480ToolStripMenuItem.Text = "640x480";
            this.x480ToolStripMenuItem.Click += new System.EventHandler(this.x480ToolStripMenuItem_Click);
            // 
            // x480ToolStripMenuItem1
            // 
            this.x480ToolStripMenuItem1.Image = global::Image_editor.Properties.Resources._960x480;
            this.x480ToolStripMenuItem1.Name = "x480ToolStripMenuItem1";
            this.x480ToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.x480ToolStripMenuItem1.Text = "960x480";
            this.x480ToolStripMenuItem1.Click += new System.EventHandler(this.x480ToolStripMenuItem1_Click);
            // 
            // x640ToolStripMenuItem
            // 
            this.x640ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._960x640;
            this.x640ToolStripMenuItem.Name = "x640ToolStripMenuItem";
            this.x640ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.x640ToolStripMenuItem.Text = "960x640";
            this.x640ToolStripMenuItem.Click += new System.EventHandler(this.x640ToolStripMenuItem_Click);
            // 
            // x786ToolStripMenuItem
            // 
            this.x786ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._1024x768;
            this.x786ToolStripMenuItem.Name = "x786ToolStripMenuItem";
            this.x786ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.x786ToolStripMenuItem.Text = "1024x768";
            this.x786ToolStripMenuItem.Click += new System.EventHandler(this.x786ToolStripMenuItem_Click);
            // 
            // x1024ToolStripMenuItem
            // 
            this.x1024ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._1024x1024;
            this.x1024ToolStripMenuItem.Name = "x1024ToolStripMenuItem";
            this.x1024ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.x1024ToolStripMenuItem.Text = "1024x1024";
            this.x1024ToolStripMenuItem.Click += new System.EventHandler(this.x1024ToolStripMenuItem_Click);
            // 
            // x768ToolStripMenuItem
            // 
            this.x768ToolStripMenuItem.Image = global::Image_editor.Properties.Resources._1280x768;
            this.x768ToolStripMenuItem.Name = "x768ToolStripMenuItem";
            this.x768ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.x768ToolStripMenuItem.Text = "1280x768";
            this.x768ToolStripMenuItem.Click += new System.EventHandler(this.x768ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "\".jpg\"";
            this.saveFileDialog1.FileName = "MyImage";
            this.saveFileDialog1.Filter = "JPEG(*.jpg)|BMP(*.bmp)|GIF(*.gif)|*gif ";
            this.saveFileDialog1.InitialDirectory = " ";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Сочраннение изображения";
            this.saveFileDialog1.ValidateNames = false;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х128ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x320ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x480ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x480ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem x640ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x786ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1024ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x768ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
    }
}

