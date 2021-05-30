﻿using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addHotelDialog dlg = new addHotelDialog();
            dlg.ShowDialog();
            if (dlg.HotelName != "")
            {
                labelCity.Text = dlg.City;
                labelHotelName.Text = dlg.HotelName;
                labelRoomsNumber.Text = dlg.Rooms.ToString();
                labelRating.Text = dlg.Rate.ToString();
            }
            else
            {
                MessageBox.Show("Введите данные", "Hotel Broker Administration", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
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
    }
    }