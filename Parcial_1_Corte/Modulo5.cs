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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Pangrama_Text.Text.Length);
            String exp;
            bool pangrama = true;
            for (int i = 0; i < n; i++)
            {
                exp = Pangrama_Text.Text.Trim();
                for (char ascii = 'A'; ascii <= 'Z'; ascii++)
                {
                    if (!exp.ToUpper().Contains("" + ascii))
                    {
                        pangrama = false;
                    }
                }
            }
            Bol_Pangrama.Text = (pangrama ? "SI" : "NO");
        }
    }
}

