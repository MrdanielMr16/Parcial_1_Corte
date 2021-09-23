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
    public partial class Modulo1 : Form
    {
        public Modulo1()
        {
            InitializeComponent();
        }

        private void Btn_Comparar_Click(object sender, EventArgs e)
        {
            int Numero1;
            int Numero2;
            int NumMenor;

            Numero1 = Convert.ToInt32(Num1.Text);
            Numero2 = Convert.ToInt32(Num2.Text);

            if (Numero1 > Numero2)
            {
                NumMenor = Numero2;
                label4.Text = ("El numero menor es: " + NumMenor);
            }
            else if (Numero2 > Numero1)
            {
                NumMenor = Numero1;
                label4.Text = ("El numero menor es: " + NumMenor);
            }
            else
            {
                label4.Text = ("Los numeros son iguales");
            } 
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
