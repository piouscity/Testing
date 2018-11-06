using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphic1 = Graphics.FromImage(pictureBox1.Image);
            Graphics graphic2 = Graphics.FromImage(pictureBox2.Image);
            Pen blackpen = new Pen(Color.Black, 3);
            Rectangle rect = new Rectangle(10, 10, 50, 60);

            graphic1.DrawRectangle(blackpen, rect);
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
        }
    }
}
