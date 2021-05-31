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

namespace lab4
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            menuSave.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private int openDoc;

        private void menuNew_Click(object sender, EventArgs e)
        {
            Blank frm = new Blank();
            frm.DocName = "Документ " + ++openDoc;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuArrange_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void menuTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)(this.ActiveMdiChild);
            frm.Cut();
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)(this.ActiveMdiChild);
            frm.Copy();
        }

        private void menuSelectAll_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)(this.ActiveMdiChild);
            frm.SelectAll();
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)(this.ActiveMdiChild);
            frm.Paste();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)(this.ActiveMdiChild);
            frm.Delete();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank frm = new Blank();
                frm.Open(openFileDialog1.FileName);

                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
                frm.isSaved = true;        
            }
            menuSave.Enabled = true;
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)(this.ActiveMdiChild);
            frm.Save(frm.DocName);
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|AllFiles(*.*) | *.* ";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank frm = (Blank)(this.ActiveMdiChild);
                frm.Save(saveFileDialog1.FileName);

                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.isSaved = true;
            }

            menuSave.Enabled = true;
        }
    }
}

