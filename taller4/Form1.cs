﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double total;
            total = ((double.Parse(txtnota1.Text) + double.Parse(txtnota2.Text) + double.Parse(txtnota3.Text)) / 3);
            lbltotal.Text = total.ToString();
        }
    }
}
