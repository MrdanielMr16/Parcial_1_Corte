﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1_Corte
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Modulo1 formulario1 = new Modulo1();
            formulario1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Modulo2 formulario2 = new Modulo2();
            formulario2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulo4 formulario4 = new Modulo4();
            formulario4.Show();
        }
    }
}
