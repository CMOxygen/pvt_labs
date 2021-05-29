﻿using System;
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

            if(listBox.SelectedIndex != -1)
            {
                oleDbSelectCommand2.Parameters[0].Value = listBox.SelectedValue;
                oleDbDataAdapter2.Fill(dataSet31);
            }
        }
    }
}