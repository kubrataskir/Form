﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasiVeriAktarimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;
        public string sifre;

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciAdi;
            label2.Text=sifre;
        }
    }
}
