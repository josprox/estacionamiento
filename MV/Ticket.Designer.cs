namespace estacionamiento
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.Creditos = new System.Windows.Forms.TextBox();
            this.Pruebas = new System.Windows.Forms.Button();
            this.Pagar = new System.Windows.Forms.Button();
            this.Pago_texto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hora_texto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Salida_texto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Entrada_texto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_placa_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Creditos
            // 
            this.Creditos.Location = new System.Drawing.Point(360, 418);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(100, 20);
            this.Creditos.TabIndex = 12;
            this.Creditos.Text = "JOSPROX";
            this.Creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pruebas
            // 
            this.Pruebas.Location = new System.Drawing.Point(395, 81);
            this.Pruebas.Name = "Pruebas";
            this.Pruebas.Size = new System.Drawing.Size(75, 54);
            this.Pruebas.TabIndex = 24;
            this.Pruebas.Text = "Modo desarrollador";
            this.Pruebas.UseVisualStyleBackColor = true;
            this.Pruebas.Visible = false;
            this.Pruebas.Click += new System.EventHandler(this.Pruebas_Click_1);
            // 
            // Pagar
            // 
            this.Pagar.Location = new System.Drawing.Point(217, 380);
            this.Pagar.Name = "Pagar";
            this.Pagar.Size = new System.Drawing.Size(75, 23);
            this.Pagar.TabIndex = 23;
            this.Pagar.Text = "Pagar";
            this.Pagar.UseVisualStyleBackColor = true;
            this.Pagar.Click += new System.EventHandler(this.Pagar_Click_1);
            // 
            // Pago_texto
            // 
            this.Pago_texto.AutoSize = true;
            this.Pago_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.Pago_texto.Location = new System.Drawing.Point(261, 332);
            this.Pago_texto.Name = "Pago_texto";
            this.Pago_texto.Size = new System.Drawing.Size(47, 20);
            this.Pago_texto.TabIndex = 22;
            this.Pago_texto.Text = "Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label6.Location = new System.Drawing.Point(136, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total a pagar";
            // 
            // Hora_texto
            // 
            this.Hora_texto.AutoSize = true;
            this.Hora_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.Hora_texto.Location = new System.Drawing.Point(246, 289);
            this.Hora_texto.Name = "Hora_texto";
            this.Hora_texto.Size = new System.Drawing.Size(67, 20);
            this.Hora_texto.TabIndex = 20;
            this.Hora_texto.Text = "Hora(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label5.Location = new System.Drawing.Point(165, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hora(s):";
            // 
            // Salida_texto
            // 
            this.Salida_texto.AutoSize = true;
            this.Salida_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.Salida_texto.Location = new System.Drawing.Point(241, 242);
            this.Salida_texto.Name = "Salida_texto";
            this.Salida_texto.Size = new System.Drawing.Size(82, 13);
            this.Salida_texto.TabIndex = 18;
            this.Salida_texto.Text = "Fecha de salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label4.Location = new System.Drawing.Point(66, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de salida: ";
            // 
            // Entrada_texto
            // 
            this.Entrada_texto.AutoSize = true;
            this.Entrada_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.Entrada_texto.Location = new System.Drawing.Point(241, 182);
            this.Entrada_texto.Name = "Entrada_texto";
            this.Entrada_texto.Size = new System.Drawing.Size(91, 13);
            this.Entrada_texto.TabIndex = 16;
            this.Entrada_texto.Text = "Fecha de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label2.Location = new System.Drawing.Point(66, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de entrada: ";
            // 
            // Num_placa_text
            // 
            this.Num_placa_text.AutoSize = true;
            this.Num_placa_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.Num_placa_text.Location = new System.Drawing.Point(165, 115);
            this.Num_placa_text.Name = "Num_placa_text";
            this.Num_placa_text.Size = new System.Drawing.Size(51, 20);
            this.Num_placa_text.TabIndex = 14;
            this.Num_placa_text.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label1.Location = new System.Drawing.Point(84, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placas: ";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.Pruebas);
            this.Controls.Add(this.Pagar);
            this.Controls.Add(this.Pago_texto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Hora_texto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Salida_texto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Entrada_texto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num_placa_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Creditos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Creditos;
        private System.Windows.Forms.Button Pruebas;
        private System.Windows.Forms.Button Pagar;
        private System.Windows.Forms.Label Pago_texto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Hora_texto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Salida_texto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Entrada_texto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Num_placa_text;
        private System.Windows.Forms.Label label1;
    }
}