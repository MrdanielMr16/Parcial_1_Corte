
namespace Parcial_1_Corte
{
    partial class Modulo4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPalabra = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnFrase = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtFraseResultado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(238, 37);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(79, 13);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "Ingrese la frase";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(230, 65);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(100, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // btnFrase
            // 
            this.btnFrase.Location = new System.Drawing.Point(255, 211);
            this.btnFrase.Name = "btnFrase";
            this.btnFrase.Size = new System.Drawing.Size(75, 23);
            this.btnFrase.TabIndex = 2;
            this.btnFrase.Text = "Invertir";
            this.btnFrase.UseVisualStyleBackColor = true;
            this.btnFrase.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(252, 106);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(65, 13);
            this.lblFrase.TabIndex = 3;
            this.lblFrase.Text = "La Frase es:";
            // 
            // txtFraseResultado
            // 
            this.txtFraseResultado.AutoSize = true;
            this.txtFraseResultado.Location = new System.Drawing.Point(252, 142);
            this.txtFraseResultado.Name = "txtFraseResultado";
            this.txtFraseResultado.Size = new System.Drawing.Size(0, 13);
            this.txtFraseResultado.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(511, 392);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Modulo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 437);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtFraseResultado);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.btnFrase);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblPalabra);
            this.Name = "Modulo4";
            this.Text = "Modulo4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label txtFraseResultado;
        private System.Windows.Forms.Button btnCerrar;
    }
}