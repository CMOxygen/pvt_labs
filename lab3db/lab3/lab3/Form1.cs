using System;
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
            oleDbSelectCommand1.CommandText = "SELECT Код, Фамилия FROM Личный_состав\r\n"
                + "WHERE (Фамилия LIKE ? + '%')";
            oleDbSelectCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter());
            oleDbSelectCommand1.Parameters[0].Value = "";

            oleDbDataAdapter1.Fill(dataSet11);
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            NewLoad();
        }

        void NewLoad()
        {
            String text = searchText.Text.Trim();
            searchText.Text = text;
            oleDbSelectCommand1.Parameters[0].Value = text;

            dataSet11.Clear();
            oleDbDataAdapter1.Fill(dataSet11);

            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NewLoad();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSet31.Clear();

            if (listBox.SelectedIndex != -1)
            {
                oleDbSelectCommand2.Parameters[0].Value = listBox.SelectedValue;
                oleDbDataAdapter2.Fill(dataSet31);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void SaveRecord()
        {
            this.BindingContext[dataSet31, "Личный_состав"].EndCurrentEdit();
            oleDbDataAdapter2.Update(dataSet31, "Личный_состав");

            int index = listBox.SelectedIndex;

            NewLoad();

            int count = listBox.Items.Count - 1;
            index = index < count ? index : count;
            listBox.SelectedIndex = index;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet31, "Личный_состав"].CancelCurrentEdit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet31, "Личный_состав"].AddNew(); 
            
            addHotelDialog dlg = new addHotelDialog();
            dlg.ShowDialog();

            if (dlg.Surname != "")
            {
                surnameText.Text = dlg.Surname;
                nameText.Text = dlg.Name;
                rankText.Text = dlg.Rank;
                numberText.Text = dlg.Number.ToString();
            }
            else
            {
                MessageBox.Show("Введите данные", "Hotel Broker Administration", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            SaveRecord();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count <= 0)
                return;

            int index = this.BindingContext[dataSet31, "Личный_состав"].Position;
            this.BindingContext[dataSet31, "Личный_состав"].RemoveAt(index);

            SaveRecord();
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {

        }
    }
}
