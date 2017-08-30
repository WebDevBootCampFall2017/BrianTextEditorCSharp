using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditorC
{
    public partial class Form1 : Form
    {

        string path; string[] patharray;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program Info
            MessageBox.Show("Text Editor in C#" +
                "\nBrian Port" +
                "\nVersion: 1.04" +    //update as needed
                "\nCoding Boot Camp");
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change font dialog
            //show color option in font dialog
            fontDialog1.ShowColor = true;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            

        }

        private void wordWrapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            switch (wordWrapToolStripMenuItem.Checked)
            {
                case true:
                    wordWrapToolStripMenuItem.Checked = false;
                    richTextBox1.WordWrap = false;
                    richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
                    break;
                case false:
                    wordWrapToolStripMenuItem.Checked = true;
                    richTextBox1.WordWrap = true;
                    richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
                    break;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save As Function
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (.txt)|*.txt";
            sfd.Title = "Save file as...";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
        }

        private void openToolStripMenuOpen_Click(object sender, EventArgs e)
        {
            //open file function
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (.txt)|*.txt";
            ofd.Title = "Open a file...";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //StreamReader sr = new StreamReader(ofd.FileName);
                path = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(path);
                patharray = File.ReadAllLines(path);
                //sr.Close();
                Form1.ActiveForm.Text = string.Format("{0}" , path);
            }
        }

        private void saveToolStripMenu1_Click(object sender, EventArgs e)
        {
            /*string path = ofd.FileName;
            try
            {
                File.WriteAllText(path , richTextBox1.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }*/
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    
    }
}
