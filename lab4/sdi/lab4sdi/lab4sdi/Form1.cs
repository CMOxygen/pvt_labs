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

namespace lab4sdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            String fileName = openFileDialog1.FileName;
            FileStream filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            if (filestream != null)
            {
                StreamReader streamreader = new StreamReader(filestream);
                textBox.Text = streamreader.ReadToEnd();
                filestream.Close();
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            String fileName = saveFileDialog1.FileName;
            FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);

            if (filestream != null)
            {
                StreamWriter streamwriter = new StreamWriter(filestream);
                streamwriter.Write(textBox.Text);
                streamwriter.Flush();
                filestream.Close();
            }
        }
    }
}
