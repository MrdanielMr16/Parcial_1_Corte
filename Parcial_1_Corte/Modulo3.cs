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
    public partial class Modulo3 : Form
    {
        public Modulo3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> Frases = new List<string>();
            string cadena = " ";
            int contador = 0;
            char[] arrayCadena;
            string Quitar = string.Empty;
            cadena = TxtFrase.Text.Replace(" ","");
            arrayCadena = cadena.ToCharArray();
            for (int i = 0; i < arrayCadena.Length; i++)
            {
                for (int j = 0; j < arrayCadena.Length; j++)
                {
                    if (arrayCadena[i] == arrayCadena[j])
                    {
                        contador++;
                    }
                }
                Frases.Add(arrayCadena[i] + " " + contador + "\n");
                Console.WriteLine(Quitar);
                contador = 0;
            }
            HashSet<string> SinFrases = new HashSet<string>(Frases);
            foreach (String var in SinFrases)
            {
                Quitar = Quitar + var.ToString();
            }
            Console.WriteLine(Quitar);
            Resultado.Text = (Quitar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}