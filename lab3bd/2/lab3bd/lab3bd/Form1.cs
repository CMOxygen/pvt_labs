using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3bd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oleDbSelectCommand1.CommandText = "SELECT Hotel_ID, City FROM Hotel_List\r\n"
                + "WHERE (City LIKE ? + '%')";
            oleDbSelectCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter());
            oleDbSelectCommand1.Parameters[0].Value = "";

            oleDbDataAdapter1.Fill(dataSet31);

            listHotel.SelectedIndex = listHotel.Items.Count - 1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            NewLoad();
        }

        void NewLoad()
        {
            String text = textSearch.Text.Trim();
            textSearch.Text = text;
            oleDbSelectCommand1.Parameters[0].Value = text;

            dataSet11.Clear();
            oleDbDataAdapter1.Fill(dataSet31);

            listHotel.SelectedIndex = listHotel.Items.Count - 1;
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NewLoad();
        }

        private void listHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSet21.Clear();

            if(listHotel.SelectedIndex != -1)
            {
                oleDbSelectCommand2.Parameters[0].Value = listHotel.SelectedValue;
                oleDbDataAdapter2.Fill(dataSet21);
            }
        }
    }
}
