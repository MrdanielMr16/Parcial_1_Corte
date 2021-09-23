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
    public partial class Modulo5 : Form
    {
        public Modulo5()
        {
            InitializeComponent();
            
    }
        private string Letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string CaracteresPuntuacion = " .,-:;!?'\"()[]{}/";
        private StringBuilder Pangrama = new StringBuilder();
        private void Verificar_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StringBuilder Letras_Faltantes = new StringBuilder();
            Pangrama = new StringBuilder(Pangrama_Text.Text.ToUpper());

            foreach (char Cp in CaracteresPuntuacion)

            Pangrama.Replace(Cp.ToString(), "".ToString());
            ContadorLetras.Text = "Total Letters = " +
            Pangrama.Length.ToString();

            foreach (char Le in Letras.ToCharArray())
            {
                if (!Pangrama.ToString().Contains(Le))
                {
                    Letras_Faltantes.Append(Le);
                    Letras_Faltantes.Append(" ");
                }
                
            }

            Faltan.Text = Letras_Faltantes.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

