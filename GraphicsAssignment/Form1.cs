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
    /// <summary>
    /// This class is the main form for the graphics
    /// </summary>
    public partial class Form1 : Form
    {
        Bitmap myBitmap = new Bitmap(640, 480);
        Graphics bitmapG;
        private Parser parser;
        /// <summary>
        /// Initialises a new instance of Form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            bitmapG = Graphics.FromImage(myBitmap);
            parser = new Parser(bitmapG);
        }
        /// <summary>
        /// This is what occurs when the run button is clicked
        /// </summary>
        private void Run_Button_Click(object sender, EventArgs e)
        {
            string mytext = textBox1.Text;
            parser.parseCommand(mytext, 0);
            textBox1.Clear();
            pictureBox1.Refresh();
        }
        /// <summary>
        /// The picture is painted on this picturebox
        /// </summary>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(myBitmap, 0, 0);
        }
        /// <summary>
        /// When text is typed into this textbox events can happen
        /// </summary>
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
        /// <summary>
        /// When the open button is clicked it opens a folder
        /// </summary>
        private void Open_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\greg_\Documents\projects\GraphicsAssignment";
            if(open.ShowDialog() == DialogResult.OK)
            {
                string filePath = open.FileName;

                string txt = File.ReadAllText(filePath);

                richTextBox1.Text = txt;
            }
        }
        /// <summary>
        /// When the save button is clicked it saves a file in the folder with a name of your choice
        /// </summary>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.InitialDirectory = @"C:\Users\greg_\Documents\projects\GraphicsAssignment";
            save.DefaultExt = "txt";
            if(save.ShowDialog() == DialogResult.OK)
            {
                string filePath = save.FileName;
                File.WriteAllText(filePath, richTextBox1.Text);
                richTextBox1.Clear();
            }
        }

        private void Syntax_Button_Click(object sender, EventArgs e)
        {
            string checkSyntax = richTextBox1.Text;

            errorCheck errorCheck = new errorCheck();
            List<string> errors = errorCheck.checkSyntax(checkSyntax);

            if(errors.Count == 0)
            {
                MessageBox.Show("No errors found");
            }
            else
            {
                string errorString = "";
                foreach(string error in errors)
                {
                    errorString += error + "\n";
                }
                MessageBox.Show(errorString);
            }
        }
    }
}
