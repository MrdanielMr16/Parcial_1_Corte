using System;
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
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToInt32(txtBase.Text);
            double Altura = Convert.ToInt32(txtAltura.Text);
            double Area = (Base * Altura) / 2;
            txtArea.Text = Area.ToString();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
