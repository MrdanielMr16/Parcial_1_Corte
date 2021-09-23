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
    public partial class Modulo6 : Form
    {
        String frase = string.Empty;
        char[] Abecedario;
        char[] fraseSeleccionada;
        int vidas = 7;
        int Oportunidades = 0;
        public Modulo6()
        {
            InitializeComponent();
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            txtFrase.Hide();
            lblFrase.Hide();
            btnIngresar.Hide();
            EmpezarJuego();
        }
        public void EmpezarJuego()
        {
            Abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ".ToCharArray();
            frase = txtFrase.Text;
            fraseSeleccionada = frase.ToUpper().ToCharArray();
            foreach (char letraAbecedario in Abecedario)
            {
                Button btnLetra = new Button();
                btnLetra.Text = letraAbecedario.ToString();
                btnLetra.Name = letraAbecedario.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Comparar;
                btnLetra.Name = letraAbecedario.ToString();
                flpLetras.Controls.Add(btnLetra);
            }
            for (int i = 0; i < fraseSeleccionada.Length; i++)
            {
                Button Letra = new Button();
                Letra.Tag = fraseSeleccionada[i].ToString();
                Letra.Width = 60;
                Letra.Height = 40;
                Letra.Text = "-";
                Letra.Name = "Adivinado" + i.ToString();
                flpPalabra.Controls.Add(Letra);
            }
        }
        public void Comparar(object sender, EventArgs e) 
        {
            bool encontrado = false;
            Button btn = (Button)sender;
            btn.Enabled = false;

            for (int i = 0; i < fraseSeleccionada.Length; i++)
            {
                if (fraseSeleccionada[i] == char.Parse(btn.Text))
                {
                    Button revisar = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    revisar.Text = fraseSeleccionada[i].ToString();
                    fraseSeleccionada[i] = '-';
                    encontrado = true;
                }
            }
            bool Ganaste = false;
            for (int i = 0; i < fraseSeleccionada.Length; i++)
            {
                if (fraseSeleccionada[i] != '-') Ganaste = true;
            }
            if (!Ganaste) 
            {
                MessageBox.Show("Ganaste");
                MessageBox.Show("La palabra era: " + frase);
                flpLetras.Enabled = false;
            }  
            if (!encontrado)
            {
                vidas--;
                txtVidas.Text = vidas.ToString();
                Oportunidades++;
                picboxAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + Oportunidades);
                if (vidas < 1)
                {
                    for (int i = 0; i < fraseSeleccionada.Length; i++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }
                    flpLetras.Enabled = false;
                    MessageBox.Show("Perdiste");
                    MessageBox.Show("La palabra era: " + frase);

                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
