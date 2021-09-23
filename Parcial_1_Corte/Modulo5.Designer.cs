
namespace Parcial_1_Corte
{
    partial class Modulo5
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
            this.ContadorLetras = new System.Windows.Forms.Label();
            this.Pangrama_Text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Bol_Pangrama = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresa tu texto";
            // 
            // ContadorLetras
            // 
            this.ContadorLetras.AutoSize = true;
            this.ContadorLetras.Location = new System.Drawing.Point(39, 165);
            this.ContadorLetras.Name = "ContadorLetras";
            this.ContadorLetras.Size = new System.Drawing.Size(87, 13);
            this.ContadorLetras.TabIndex = 5;
            this.ContadorLetras.Text = "Es un pangrama:";
            // 
            // Pangrama_Text
            // 
            this.Pangrama_Text.Location = new System.Drawing.Point(28, 79);
            this.Pangrama_Text.Name = "Pangrama_Text";
            this.Pangrama_Text.Size = new System.Drawing.Size(691, 20);
            this.Pangrama_Text.TabIndex = 6;
            this.Pangrama_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bol_Pangrama
            // 
            this.Bol_Pangrama.Location = new System.Drawing.Point(132, 162);
            this.Bol_Pangrama.Name = "Bol_Pangrama";
            this.Bol_Pangrama.Size = new System.Drawing.Size(100, 20);
            this.Bol_Pangrama.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Verificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modulo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 209);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bol_Pangrama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pangrama_Text);
            this.Controls.Add(this.ContadorLetras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulo5";
            this.Text = "Modulo5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ContadorLetras;
        private System.Windows.Forms.TextBox Pangrama_Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Bol_Pangrama;
        private System.Windows.Forms.Button button2;
    }
}