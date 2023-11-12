using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            bitmapG = Graphics.FromImage(myBitmap);
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
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitmap, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "run")
            {
                string richText = richTextBox1.Text;
                Parser parser = new Parser(bitmapG);
                parser.parserCommand(richText);
                pictureBox1.Refresh();
            }
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            String file = @"C:\\Users\\greg_\\Documents\\projects\\GraphicsAssignment\\mytext.txt";
            TextReader txt = File.OpenText(file);
            String txt1 = txt.ReadToEnd();
            richTextBox1.Text = txt1;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\Users\\greg_\\Documents\\projects\\GraphicsAssignment\\mytext.txt");
            txt.Write(richTextBox1.Text);
            txt.Close();
            richTextBox1.Clear();
        }
    }
}
