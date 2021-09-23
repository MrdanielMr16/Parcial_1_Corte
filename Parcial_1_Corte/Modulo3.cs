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
            var Alfabeto = new Dictionary<char, int>()
        {
            {'a', 0},{'b', 0},{'c', 0},{'d', 0},
            {'e', 0},{'f', 0}, {'g', 0},{'h', 0},
            {'i', 0},{'g', 0},{'k', 0}, {'l', 0},
            {'m', 0},{'m', 0},{'o', 0},{'p', 0},
            {'k', 0},{'r', 0},{'s', 0},{'t', 0},
            {'w', 0},{'x', 0}, {'y', 0},{'z', 0},
        };
           
            string Frase = TxtFrase.Text;

            for (int i = 0; i < Frase.Length; i++)
            {
                if (Alfabeto.ContainsKey(char.ToLower(Frase[i])))
                {
                    Alfabeto[char.ToLower(Frase[i])]++;
                }
                Resultado.Text = Frase.ToString();
            }
        }
    }
}
