using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Blank : Form
    {
        public Blank()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public String DocName;
        private String BufferText;

        public void Cut()
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy()
        {
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste()
        {
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll()
        {
            richTextBox1.SelectAll();
        }

        public void Delete()
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }
    }
}
