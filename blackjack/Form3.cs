﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form3 : Form
    {
        public Form3(Form1 f)
        {
            InitializeComponent();
            this.rodzic = f;
            this.label2.Text = $"Your earnings: {rodzic.bet_size}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            rodzic.rozdaj();
        }
    }
}
