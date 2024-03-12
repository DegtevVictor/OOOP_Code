using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[] arr = new int[16];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 16; i++)
            {
                arr[i] = rand.Next(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Text += "arr[" + i + "] = " + (Math.Round(Math.Exp(arr[i]) + 2 * Math.Exp(arr[i]), 2)).ToString() + Environment.NewLine;
                textBox2.Text += "arr[" + i + "] = " + (Math.Round(5 + Math.Sin(arr[i]), 2)).ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "[";
            for (int i = 0; i < 15; i++)
            {
                message += arr[i].ToString() + ", ";
            }
            message += arr[15] + "]";
            MessageBox.Show(message);
        }
    }
}
