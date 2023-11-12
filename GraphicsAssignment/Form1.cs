using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAssignment
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap = new Bitmap(640, 480);
        Graphics bitmapG;
        private Parser parser;
        public Form1()
        {
            InitializeComponent();
            parser = new Parser(bitmapG);
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            parser.parseCommand(mytext);
            textBox1.Clear();
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
