﻿using Project1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Customerform : Form
    {
        public Customerform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Idnumber = random.Next(minValue: 1, maxValue: 1000);


            Customer customer = new Customer();
            customer.Id = Idnumber;
            customer.FirstName = FirstName_textBox.Text;
            customer.LastName  =  LastName_textBox.Text;
            customer.Emaill  =  Emaill_textBox.Text;
            customer.PhoneNumber =PhoneNumber_textBox.Text;
            customer.Creationdate = DateTime.Now;
        }
    }
}
