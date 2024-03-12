using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            Pen p = new Pen(Color.Red, 6);
            g.DrawRectangle(p, 100, 100, 50, 100);

            Point[] polygon =
            {
                new Point(200, 250),
                new Point(250, 220),
                new Point(270, 270),
                new Point(200, 300),
                new Point(200, 250)
            };

            Pen p2 = new Pen(Color.Green, 3);
            Pen p3 = new Pen(Color.Blue, 5);

            g.DrawEllipse(p2, 200, 100, 200, 100);
            g.DrawPolygon(p3, polygon);
            pictureBox1.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageFormat img = ImageFormat.Jpeg;
            saveFileDialog1.ShowDialog();
            switch (saveFileDialog1.FilterIndex)
            {
                case 0: img = ImageFormat.Jpeg; break;
                case 1: img = ImageFormat.Bmp; break;
                case 2: img = ImageFormat.Png; break;
            }                
            bitmap.Save(saveFileDialog1.FileName, img);
        }
    }
}
