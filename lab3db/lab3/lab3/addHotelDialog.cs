using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class addHotelDialog : Form
    {
        public addHotelDialog()
        {
            InitializeComponent();
        }

        public String Surname
        {
            get { return (boxSurname.Text); }
            set { boxSurname.Text = value; }
        }

        public String Name
        {
            get { return (boxName.Text); }
            set { boxName.Text = value; }
        }

        public String Rank
        {
            get { return (boxRank.Text); }
            set { boxRank.Text = value; }
        }

        public int Number
        {
            get { return Convert.ToInt32(boxNumber.Text); }
            set { boxNumber.Text = value.ToString(); }
        }
        




        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
