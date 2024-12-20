using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static pryAccesoGym.bdGimnasio;
using static System.Windows.Forms.DataFormats;
using Microsoft.Data.SqlClient;
using System.IO.Ports;

namespace pryAccesoGym
{
    public partial class frmIngreso : Form
    {

        private SerialPort arduinoPort;
        public frmIngreso()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += VolverPagina_KeyDown;
            this.KeyDown += EnterKey_KeyDown;

        }
        private void EnterKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            txtDniIngreso.Focus();
        }

        private void lblAvisoIngreso_Click(object sender, EventArgs e)
        {

        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            txtDniIngreso.Focus();
        }
        private void VolverPagina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                this.Hide();
            }
        }
        private void IniciarTemporizador()
        {
            tLbl.Stop();
            tLbl.Start();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDniIngreso.Text.Trim();
                txtDniIngreso.Text = "";
                IniciarTemporizador();
                if (string.IsNullOrWhiteSpace(dni))
                {
                    lblAvisoIngreso.Text = "Por favor, ingrese un DNI válido.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                string clienteQuery = "SELECT Nombre FROM Clientes WHERE DNI = @DNI";
                object nombreClienteObj = DatabaseHelper.ExecuteScalar(clienteQuery, new SqlParameter[]
                {
            new SqlParameter("@DNI", dni)
                });

                if (nombreClienteObj == null || nombreClienteObj == DBNull.Value)
                {
                    lblAvisoIngreso.Text = "El DNI no está registrado en el sistema.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                string nombreCliente = nombreClienteObj.ToString();

                string pagoQuery = @"
        SELECT TOP 1 FechaPago 
        FROM Pagos 
        WHERE DNI = @DNI 
        ORDER BY FechaPago DESC";

                object fechaPagoObj = DatabaseHelper.ExecuteScalar(pagoQuery, new SqlParameter[]
                {
            new SqlParameter("@DNI", dni)
                });

                if (fechaPagoObj == null || fechaPagoObj == DBNull.Value)
                {
                    lblAvisoIngreso.Text = $"No se encontraron pagos registrados para {nombreCliente}.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }
                txtDniIngreso.Text = "";
                DateTime fechaPago = Convert.ToDateTime(fechaPagoObj);
                DateTime fechaProximoPago = fechaPago.AddMonths(1);

                TimeSpan diferencia = fechaProximoPago - DateTime.Now;

                if (diferencia.TotalDays > 3)
                {
                    lblAvisoIngreso.Text = $"{nombreCliente}, su cuota venció el {fechaProximoPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                }
                else
                {
                    lblAvisoIngreso.Text = $"{nombreCliente}, tiene que pagar su cuota antes del {fechaProximoPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Green;
                    //AbrirPuerta(5000);
                }
                else if (diferencia.TotalDays <= 3 && diferencia.TotalDays >= 0)
                {
                    lblAvisoIngreso.Text = $"{nombreCliente}, tiene que pagar su cuota antes del {fechaProximoPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Orange;
                }
                else
                {
                    lblAvisoIngreso.Text = $"{nombreCliente}, su cuota venció el {fechaProximoPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al verificar el ingreso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDniIngreso_TextChanged(object sender, EventArgs e)
        {

        }
        private void tLbl_Tick(object sender, EventArgs e)
        {

            tLbl.Stop();
            lblAvisoIngreso.Text = "";
        }
        private void AbrirPuerta(int tiempoEnMilisegundos)
        {
            try
            {
                // Abrir el puerto serie si no está abierto
                if (!arduinoPort.IsOpen)
                {
                    arduinoPort.Open();
                }

                // Enviar el comando para abrir la puerta
                arduinoPort.WriteLine("OPEN");
                MessageBox.Show($"Puerta abierta por {tiempoEnMilisegundos / 1000} segundos.", "Puerta abierta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Esperar el tiempo indicado antes de cerrar la puerta
                Thread.Sleep(tiempoEnMilisegundos);

                // Enviar el comando para cerrar la puerta
                arduinoPort.WriteLine("CLOSE");
                MessageBox.Show("Puerta cerrada.", "Puerta cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el puerto serie
                arduinoPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al controlar la puerta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Asegurarse de que el puerto esté cerrado al finalizar
                if (arduinoPort.IsOpen)
                {
                    arduinoPort.Close();
                }
            }
        }
    }
}
