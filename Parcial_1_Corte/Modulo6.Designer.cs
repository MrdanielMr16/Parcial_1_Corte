
namespace Parcial_1_Corte
{
    partial class Modulo6
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.flpLetras = new System.Windows.Forms.FlowLayoutPanel();
            this.picboxAhorcado = new System.Windows.Forms.PictureBox();
            this.flpPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVidas = new System.Windows.Forms.Label();
            this.txtVidas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(12, 9);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(83, 13);
            this.lblFrase.TabIndex = 0;
            this.lblFrase.Text = "Ingresa tu frase:";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(15, 27);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(100, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(121, 25);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // flpLetras
            // 
            this.flpLetras.Location = new System.Drawing.Point(12, 98);
            this.flpLetras.Name = "flpLetras";
            this.flpLetras.Size = new System.Drawing.Size(445, 256);
            this.flpLetras.TabIndex = 3;
            // 
            // picboxAhorcado
            // 
            this.picboxAhorcado.Location = new System.Drawing.Point(477, 98);
            this.picboxAhorcado.Name = "picboxAhorcado";
            this.picboxAhorcado.Size = new System.Drawing.Size(256, 256);
            this.picboxAhorcado.TabIndex = 4;
            this.picboxAhorcado.TabStop = false;
            // 
            // flpPalabra
            // 
            this.flpPalabra.Location = new System.Drawing.Point(12, 360);
            this.flpPalabra.Name = "flpPalabra";
            this.flpPalabra.Size = new System.Drawing.Size(721, 119);
            this.flpPalabra.TabIndex = 5;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Location = new System.Drawing.Point(499, 50);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(36, 13);
            this.lblVidas.TabIndex = 6;
            this.lblVidas.Text = "Vidas:";
            // 
            // txtVidas
            // 
            this.txtVidas.AutoSize = true;
            this.txtVidas.Location = new System.Drawing.Point(538, 50);
            this.txtVidas.Name = "txtVidas";
            this.txtVidas.Size = new System.Drawing.Size(13, 13);
            this.txtVidas.TabIndex = 7;
            this.txtVidas.Text = "7";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(658, 485);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Modulo6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 520);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtVidas);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.flpPalabra);
            this.Controls.Add(this.picboxAhorcado);
            this.Controls.Add(this.flpLetras);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblFrase);
            this.Name = "Modulo6";
            this.Text = "Modulo6";
            ((System.ComponentModel.ISupportInitialize)(this.picboxAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.FlowLayoutPanel flpLetras;
        private System.Windows.Forms.PictureBox picboxAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flpPalabra;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label txtVidas;
        private System.Windows.Forms.Button btnCerrar;
    }
}