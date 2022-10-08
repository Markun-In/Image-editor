using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image_editor.Properties;

namespace Image_editor
{
    public partial class Editor : Form
    {
        int oldY;
        int oldX;
        int penSize;
        Color penColor;
        bool penOnOff;
        public Editor()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Location = new Point(0, 0);
            penSize = 3;
            penColor = Color.Red;
            penOnOff = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newImg = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    newImg.SetPixel(newImg.Width - x - 1, y, c);
                }
            pictureBox1.Image = newImg;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newImg = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    newImg.SetPixel(x, newImg.Height - y - 1, c);
                }
            pictureBox1.Image = newImg;
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(saveFileDialog1.FileName, System.IO.FileMode.Append);
            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case 2:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case 3:
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
            fs.Close();
        }

        private void х128ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._128x128;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._360x240;
        }

        private void x320ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._480x320;
        }

        private void x480ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._640x480;
        }

        private void x480ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._960x480;
        }

        private void x640ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._960x640;
        }

        private void x786ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._1024x768;
        }

        private void x1024ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._1024x1024;
        }

        private void x768ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources._1280x768;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penColor = Color.FromArgb(trackBar1.Value, penColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (penOnOff == false)
            {
                penOnOff = true;
                button1.Text = "Редактирование включено";
            }
            else
            {
                penOnOff = false;
                button1.Text = "Редактирование выключено";
            }        
        }


        private void panel3_Click(object sender, EventArgs e)
        {

            DialogResult dr = colorDialog1.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                penColor = colorDialog1.Color;
                panel3.BackColor = penColor;
            }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            penSize = Convert.ToInt32(((RadioButton)sender).Text);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (penOnOff == false)
                return;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            Bitmap bm = new Bitmap(pictureBox1.Image);
            Graphics g = Graphics.FromImage(bm);
            g.DrawLine(new Pen(penColor, penSize), oldX, oldY, e.X, e.Y);
            oldX = e.X;
            oldY = e.Y;
            pictureBox1.Image = bm;
            pictureBox1.Update();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X;
            oldY = e.Y;
        }

    }
}
