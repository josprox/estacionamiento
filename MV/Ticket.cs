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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            Num_placa_text.Text = Datos_generales.placa.ToString();
            DateTime hora_salida = Datos_generales.HoraSalida;
            DateTime hora_entrada = Datos_generales.HoraEntrada;
            TimeSpan tiempo_transcurrido = hora_salida - hora_entrada;
            double horas = tiempo_transcurrido.TotalHours;
            double costo = Datos_generales.precio;
            double total = costo * horas;
            Entrada_texto.Text = Datos_generales.HoraEntrada.ToString();
            Salida_texto.Text = Datos_generales.HoraSalida.ToString();
            Hora_texto.Text = horas.ToString("F2");
            Pago_texto.Text = total.ToString("F0");
        }
    }
}
