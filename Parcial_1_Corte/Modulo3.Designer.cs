
namespace Parcial_1_Corte
{
    partial class Modulo3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFrase = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escribe tu frase";
            // 
            // TxtFrase
            // 
            this.TxtFrase.Location = new System.Drawing.Point(228, 112);
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.Size = new System.Drawing.Size(230, 20);
            this.TxtFrase.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(312, 189);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(72, 13);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "Las letras son";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modulo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 349);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtFrase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulo3";
            this.Text = "Modulo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFrase;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button button2;
    }
}