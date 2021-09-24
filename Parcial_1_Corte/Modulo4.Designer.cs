
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabra.Location = new System.Drawing.Point(239, 66);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(96, 16);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "Ingrese la frase";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(183, 85);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(205, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // btnFrase
            // 
            this.btnFrase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrase.Location = new System.Drawing.Point(242, 186);
            this.btnFrase.Name = "btnFrase";
            this.btnFrase.Size = new System.Drawing.Size(93, 30);
            this.btnFrase.TabIndex = 2;
            this.btnFrase.Text = "Invertir";
            this.btnFrase.UseVisualStyleBackColor = true;
            this.btnFrase.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(239, 108);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(81, 16);
            this.lblFrase.TabIndex = 3;
            this.lblFrase.Text = "La Frase es:";
            // 
            // txtFraseResultado
            // 
            this.txtFraseResultado.AutoSize = true;
            this.txtFraseResultado.Location = new System.Drawing.Point(239, 141);
            this.txtFraseResultado.Name = "txtFraseResultado";
            this.txtFraseResultado.Size = new System.Drawing.Size(0, 13);
            this.txtFraseResultado.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(469, 262);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(85, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "MODULO 4";
            // 
            // Modulo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 297);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}