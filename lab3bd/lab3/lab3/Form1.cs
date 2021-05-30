using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace lab3
{
    public partial class Form1 : Form
    {
        //ArrayList list = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oleDbSelectCommand1.CommandText = "SELECT Hotel_ID, Hotel_Name FROM Hotel_List\r\n"
                + "WHERE (Hotel_Name LIKE ? + '%')";
            oleDbSelectCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter());
            oleDbSelectCommand1.Parameters[0].Value = "";

            oleDbDataAdapter1.Fill(dataSet11);
            listHotel.SelectedIndex = listHotel.Items.Count - 1;

            //Hotel ob1 = new Hotel("Москва", "Россия", 200, 1500);
            //list.Add(ob1);

            //Hotel ob2 = new Hotel("Москва", "Прага", 200, 3000);
            //list.Add(ob2);

            //Hotel ob3 = new Hotel("Новосибирск", "Объ", 150, 1500);
            //list.Add(ob3);

            //Hotel ob4 = new Hotel("Новосибирск", "Тратата", 300, 1200);
            //list.Add(ob4);

            //listHotel.Items.Clear();

            //if (list == null)
            //    return;

            //foreach (Hotel hotel in list)
            //{
            //    // строка для записи в элемент ListBox hotellist
            //    String city = hotel.City.Trim();
            //    String name = hotel.HotelName.Trim();
            //    String rooms = hotel.Rooms.ToString();
            //    String rate = hotel.Rate.ToString();

            //    String str = city + "," + name + "," + rooms + "," + rate;
            //    listHotel.Items.Add(str);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //addHotelDialog dlg = new addHotelDialog();
            //dlg.ShowDialog();

            //if (dlg.HotelName != "")
            //{
            //    labelCity.Text = dlg.City;
            //    labelHotelName.Text = dlg.HotelName;
            //    labelRating.Text = dlg.Rate.ToString();
            //    labelRoomsNumber.Text = dlg.Rooms.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Введите данные", "Hotel Broker Administration", MessageBoxButtons.OK,
            //    MessageBoxIcon.Exclamation);
            //    return;
            //} 
            
            
            //String s = dlg.City + "," + dlg.HotelName + ","
            //         + dlg.Rooms.ToString() + "," + dlg.Rate.ToString();
            //listHotel.Items.Add(s);

            //Hotel ob = new Hotel(dlg.City, dlg.HotelName, dlg.Rooms, dlg.Rate);
            //list.Add(ob);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSet31.Clear();

            if (listHotel.SelectedIndex > -1)
            {
                oleDbSelectCommand2.Parameters[0].Value = listHotel.SelectedValue;
                oleDbDataAdapter2.Fill(dataSet31);
            }
            //if (listHotel.SelectedIndex != -1)
            //{
            //    String selected = listHotel.SelectedItem.ToString();
            //    String[] fields;
            //    fields = selected.Split(',');

            //    labelCity.Text = fields[0];
            //    labelHotelName.Text = fields[1];
            //    labelRoomsNumber.Text = fields[2];
            //    labelRating.Text = fields[3];
            //}
            //else
            //{
            //    labelCity.Text = "";
            //}
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
            oleDbDataAdapter1.Fill(dataSet11);

            listHotel.SelectedIndex = listHotel.Items.Count - 1;
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NewLoad();
        }
    }
    //class Hotel
    //{
    //    public Hotel(String city, String name, int r, double m)
    //    {
    //        City = city; 
    //        HotelName = name;
    //        Rooms = r; 
    //        Rate = m;
    //    }
    //    public String City;
    //    public String HotelName;
    //    public int Rooms;
    //    public double Rate;
    //}
}
