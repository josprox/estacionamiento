using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estacionamiento
{
    public partial class Estacionamiento : Form
    {
        public Estacionamiento()
        {
            InitializeComponent();
        }

        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            float precio = Datos_generales.precio;
            Precio_vista.Text = Convert.ToString(precio);
            Precio_vista.Visible = true;
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Placa.Text))
            {
                MessageBox.Show("Llena los datos");
            }

            if ((Datos_generales.HoraEntrada == null && Datos_generales.placa == "") || (Datos_generales.placa != Placa.Text))
            {
                Datos_generales.HoraEntrada = DateTime.Now;
                Datos_generales.HoraSalida = DateTime.MinValue;
                Datos_generales.placa = Placa.Text;
                string registrada = Datos_generales.placa;
                Placa_text_2.Text = Datos_generales.placa;
                Placa_text_1.Show();
                Placa_text_2.Show();
                MessageBox.Show($"Placa registrada: {registrada}, con fecha: {Datos_generales.HoraEntrada}");
                Mostrar_ticket.Visible = false;
            }
            else
            {
                Datos_generales.HoraSalida = DateTime.Now;
                DateTime hora_salida = Datos_generales.HoraSalida;
                DateTime hora_entrada = Datos_generales.HoraEntrada;
                TimeSpan tiempo_transcurrido = hora_salida - hora_entrada;
                double horas = tiempo_transcurrido.TotalHours;
                double costo = Datos_generales.precio;
                double total = costo * horas;
                MessageBox.Show($"Hora de entrada: {hora_entrada}, hora de salida {hora_salida}, Horas transcurridas: {horas.ToString("F2")}, total a pagar: {total.ToString("F0")}");
                Ticket ticket = new Ticket();
                ticket.Visible = true;
                Mostrar_ticket.Visible = true;
            }
            Placas_registradas.Show();
        }

        private void Placas_registradas_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (Datos_generales.HoraSalida == DateTime.MinValue)
            {
                mensaje = "Actualmente no ha salido";
            }
            else
            {
                mensaje = Datos_generales.HoraSalida.ToString();
            }
            MessageBox.Show($"Placa registrada: {Datos_generales.placa}, Hora de entrada: {Datos_generales.HoraEntrada}, Hora de salida: {mensaje}");
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mostrar_ticket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Visible = true;
        }
    }
}
