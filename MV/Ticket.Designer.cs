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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Entrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Creditos
            // 
            this.Creditos.Location = new System.Drawing.Point(571, 429);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(100, 20);
            this.Creditos.TabIndex = 12;
            this.Creditos.Text = "JOSPROX";
            this.Creditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pruebas
            // 
            this.Pruebas.Location = new System.Drawing.Point(596, 76);
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
            this.Pagar.Location = new System.Drawing.Point(137, 405);
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
            this.Pago_texto.Location = new System.Drawing.Point(149, 317);
            this.Pago_texto.Name = "Pago_texto";
            this.Pago_texto.Size = new System.Drawing.Size(54, 24);
            this.Pago_texto.TabIndex = 22;
            this.Pago_texto.Text = "Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label6.Location = new System.Drawing.Point(24, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total a pagar";
            // 
            // Hora_texto
            // 
            this.Hora_texto.AutoSize = true;
            this.Hora_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.Hora_texto.Location = new System.Drawing.Point(105, 274);
            this.Hora_texto.Name = "Hora_texto";
            this.Hora_texto.Size = new System.Drawing.Size(72, 24);
            this.Hora_texto.TabIndex = 20;
            this.Hora_texto.Text = "Hora(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label5.Location = new System.Drawing.Point(24, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hora(s):";
            // 
            // Salida_texto
            // 
            this.Salida_texto.AutoSize = true;
            this.Salida_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.Salida_texto.Location = new System.Drawing.Point(199, 233);
            this.Salida_texto.Name = "Salida_texto";
            this.Salida_texto.Size = new System.Drawing.Size(104, 16);
            this.Salida_texto.TabIndex = 18;
            this.Salida_texto.Text = "Fecha de salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha de salida: ";
            // 
            // Entrada_texto
            // 
            this.Entrada_texto.AutoSize = true;
            this.Entrada_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.Entrada_texto.Location = new System.Drawing.Point(199, 173);
            this.Entrada_texto.Name = "Entrada_texto";
            this.Entrada_texto.Size = new System.Drawing.Size(113, 16);
            this.Entrada_texto.TabIndex = 16;
            this.Entrada_texto.Text = "Fecha de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label2.Location = new System.Drawing.Point(24, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de entrada: ";
            // 
            // Num_placa_text
            // 
            this.Num_placa_text.AutoSize = true;
            this.Num_placa_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.Num_placa_text.Location = new System.Drawing.Point(123, 106);
            this.Num_placa_text.Name = "Num_placa_text";
            this.Num_placa_text.Size = new System.Drawing.Size(56, 24);
            this.Num_placa_text.TabIndex = 14;
            this.Num_placa_text.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Placas: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(376, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 282);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Esta maquina acepta";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(143, 205);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(133, 70);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(207, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 205);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(133, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(149, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 108);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(57, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(146, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(88, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Entrada
            // 
            this.Entrada.Location = new System.Drawing.Point(117, 366);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(114, 20);
            this.Entrada.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ingrese sus billetes";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox Entrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}