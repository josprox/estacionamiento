using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace estacionamiento
{
    public partial class Ticket : MaterialForm
    {
        public static bool desarrollador = false;
        public static int total_pagar;
        public static int[] valores_especificos = new int[] { 1, 2, 5, 10, 20, 50,100, 200 };
        public Ticket()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT; // Tema claro
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, // Color primario
                Primary.BlueGrey900, // Color oscuro primario
                Primary.BlueGrey500, // Color de acento
                Accent.LightBlue200, // Color de acento claro
                TextShade.WHITE
            );
        }
        public bool VerificarTexto(TextBox textBox, string texto, string mensaje)
        {
            if (textBox.Text.Equals(texto, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true; // Devolver true si se activó el modo de pruebas
            }
            else
            {
                return false; // Devolver false si no se activó el modo de pruebas
            }
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
            string total_redondeado = total.ToString("F0");
            Entrada_texto.Text = Datos_generales.HoraEntrada.ToString();
            Salida_texto.Text = Datos_generales.HoraSalida.ToString();
            Hora_texto.Text = horas.ToString("F2");
            Pago_texto.Text = total_redondeado;
            //Modo desarrollador
            if(desarrollador != true)
            {
                total_pagar = int.Parse(total_redondeado);
                if(total_pagar == 0)
                {
                    MessageBox.Show("Aún tiene tiempo para salir de manera gratuita");
                    Pagar.Enabled = false;
                    Entrada.Enabled = false;
                    Pago_texto.Text = "Saldo liquidado.";
                    Hora_texto.Text = "Hora(s) liquidado(s).";
                }
            }else { 
                total_pagar = 1000; 
            }
            Creditos.TextChanged += (s, EventArgs) =>
            {
                bool desarrollador = VerificarTexto(Creditos, "developer", "Modo de prueba activado, da clic en el botón 'Modo desarrollador'");
                Pruebas.Visible = desarrollador;
                Entrada.Enabled = !desarrollador;
            };
        }

        private void Pagar_Click_1(object sender, EventArgs e)
        {
            if (desarrollador == true) {
                Random random = new Random();
                int numeroaleatorio;
                do
                {
                    do
                    {
                        numeroaleatorio = random.Next(1, 201);
                    } while (!valores_especificos.Contains(numeroaleatorio)); // Repite si el número no está en valores_especificos

                    if (total_pagar >= numeroaleatorio)
                    {
                        MessageBox.Show($"Total a pagar: {total_pagar}, Se ha insertado: {numeroaleatorio} pesos");
                        total_pagar -= numeroaleatorio; // Resta numeroaleatorio al total_pagar
                        MessageBox.Show($"Falta pagar: {total_pagar}");
                        Pago_texto.Text = total_pagar.ToString();
                    }
                } while (total_pagar > 0); // Continúa mientras haya saldo pendiente
                Pago_texto.Text = "Saldo liquidado.";
                Hora_texto.Text = "Hora(s) liquidado(s).";
                MessageBox.Show("Se ha pagado el total");
            }
            else if (desarrollador == false)
            {
                int entrada = int.Parse(Entrada.Text);
                if(total_pagar >= entrada) {
                    foreach(int valor in valores_especificos)
                    {
                        if(valor == entrada)
                        {
                            total_pagar = total_pagar - entrada;
                            MessageBox.Show($"Se ha insertado un billete de ${entrada}pesos , faltan ${total_pagar} pesos");
                            if(total_pagar == 0)
                            {
                                Pago_texto.Text = "Saldo liquidado.";
                                Hora_texto.Text = "Hora(s) liquidado(s).";
                                MessageBox.Show("Se ha pagado el total");
                            }
                            break;
                        }
                        else if (valor != entrada)
                        {
                            MessageBox.Show("Detectando valor, presione 'ok' para continuar... Si no recibe respuesta, lo mas probable es que no está metiendo una cantidad correcta");
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"El valor entrante es mayor a la cantidad del total a pagar (${total_pagar}).");
                }
            }
        }

        private void Pruebas_Click_1(object sender, EventArgs e)
        {
            desarrollador = true;
            total_pagar = 1000;
            MessageBox.Show($"Se ha activado el modo desarrollador, total a pagar = {total_pagar}, ya puede iniciar las pruebas");
            Pago_texto.Text = total_pagar.ToString();
            Hora_texto.Text = 50.ToString();
            Pagar.Enabled = true;
        }
    }
}
