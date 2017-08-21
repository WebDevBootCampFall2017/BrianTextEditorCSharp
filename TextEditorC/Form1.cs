using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorC
{
    public partial class Form1 : Form
    {
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
            MessageBox.Show("Text Editor in C#." +
                "\nBrian Port" +
                "\nVersion: 1.00" +
                "\nCoding Boot Camp");
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
