using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class addHotelDialog : Form
    {
        public String City
        {
            get { return textCity.Text; }
            set { textCity.Text = value; }
        }
        public String HotelName
        {
            get { return (textHotelName.Text); }
            set { textHotelName.Text = value; }
        }

        public int Rooms
        {
            get { return Convert.ToInt32(textRoomsNumber.Text); }
            set { textRoomsNumber.Text = value.ToString(); }
        }
        public double Rate
        {
            get { return Convert.ToDouble(textRating.Text); }
            set { textRating.Text = value.ToString(); }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        { 
            Close();
        }
        public addHotelDialog()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
