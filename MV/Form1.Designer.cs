namespace estacionamiento
{
    partial class Estacionamiento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estacionamiento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Precio_vista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Placa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Button();
            this.Placa_text_1 = new System.Windows.Forms.Label();
            this.Placa_text_2 = new System.Windows.Forms.Label();
            this.Placas_registradas = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Mostrar_ticket = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Precio_vista);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estacionamiento";
            // 
            // Precio_vista
            // 
            this.Precio_vista.AutoSize = true;
            this.Precio_vista.Location = new System.Drawing.Point(91, 45);
            this.Precio_vista.Name = "Precio_vista";
            this.Precio_vista.Size = new System.Drawing.Size(37, 13);
            this.Precio_vista.TabIndex = 1;
            this.Precio_vista.Text = "Precio";
            this.Precio_vista.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costo por hora:";
            // 
            // Placa
            // 
            this.Placa.Location = new System.Drawing.Point(358, 148);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(118, 20);
            this.Placa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.label2.Location = new System.Drawing.Point(300, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de placa";
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(374, 191);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 3;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Placa_text_1
            // 
            this.Placa_text_1.AutoSize = true;
            this.Placa_text_1.Location = new System.Drawing.Point(320, 232);
            this.Placa_text_1.Name = "Placa_text_1";
            this.Placa_text_1.Size = new System.Drawing.Size(86, 13);
            this.Placa_text_1.TabIndex = 4;
            this.Placa_text_1.Text = "Placa registrada:";
            this.Placa_text_1.Visible = false;
            // 
            // Placa_text_2
            // 
            this.Placa_text_2.AutoSize = true;
            this.Placa_text_2.Location = new System.Drawing.Point(412, 232);
            this.Placa_text_2.Name = "Placa_text_2";
            this.Placa_text_2.Size = new System.Drawing.Size(88, 13);
            this.Placa_text_2.TabIndex = 5;
            this.Placa_text_2.Text = "Número de placa";
            this.Placa_text_2.Visible = false;
            // 
            // Placas_registradas
            // 
            this.Placas_registradas.Location = new System.Drawing.Point(673, 94);
            this.Placas_registradas.Name = "Placas_registradas";
            this.Placas_registradas.Size = new System.Drawing.Size(75, 23);
            this.Placas_registradas.TabIndex = 6;
            this.Placas_registradas.Text = "Placas registradas";
            this.Placas_registradas.UseVisualStyleBackColor = true;
            this.Placas_registradas.Visible = false;
            this.Placas_registradas.Click += new System.EventHandler(this.Placas_registradas_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(673, 239);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 7;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Mostrar_ticket
            // 
            this.Mostrar_ticket.Location = new System.Drawing.Point(669, 147);
            this.Mostrar_ticket.Name = "Mostrar_ticket";
            this.Mostrar_ticket.Size = new System.Drawing.Size(84, 51);
            this.Mostrar_ticket.TabIndex = 8;
            this.Mostrar_ticket.Text = "Volver a generar el ticket";
            this.Mostrar_ticket.UseVisualStyleBackColor = true;
            this.Mostrar_ticket.Visible = false;
            this.Mostrar_ticket.Click += new System.EventHandler(this.Mostrar_ticket_Click);
            // 
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 320);
            this.ControlBox = false;
            this.Controls.Add(this.Mostrar_ticket);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Placas_registradas);
            this.Controls.Add(this.Placa_text_2);
            this.Controls.Add(this.Placa_text_1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            this.Load += new System.EventHandler(this.Estacionamiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Precio_vista;
        private System.Windows.Forms.TextBox Placa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label Placa_text_1;
        private System.Windows.Forms.Label Placa_text_2;
        private System.Windows.Forms.Button Placas_registradas;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Mostrar_ticket;
    }
}

