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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oleDbSelectCommand1.CommandText = "SELECT Фамилия FROM Личный_состав\r\n"
                + "WHERE (Фамилия LIKE ? + '%')";

            oleDbSelectCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter());
            oleDbSelectCommand1.Parameters[0].Value = "В";

            oleDbDataAdapter1.Fill(dataSet11);

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewLoad();
        }

        void NewLoad()
        {
            String text = textBox1.Text.Trim();
            textBox1.Text = text;

            oleDbSelectCommand1.Parameters[0].Value = text;

            dataSet11.Clear();
            oleDbDataAdapter1.Fill(dataSet11);

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NewLoad();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSet41.Clear();
            
            if(listBox1.SelectedIndex != -1)
            {
                oleDbSelectCommand2.Parameters[0].Value = listBox1.SelectedValue;
                oleDbDataAdapter2.Fill(dataSet41);
            }
        }

        private void oleDbDataAdapter2_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            this.BindingContext[dataSet41, "Личный_состав"].EndCurrentEdit();

            oleDbDataAdapter2.Update(dataSet41, "Личный_состав");

            int index = listBox1.SelectedIndex;

            NewLoad();

            int count = listBox1.Items.Count - 1;

            index = index < count ? index : count;
            listBox1.SelectedIndex = index;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet41, "Личный_состав"].CancelCurrentEdit();
        }
    }
}
