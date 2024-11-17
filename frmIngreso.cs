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

namespace pryAccesoGym
{
    public partial class frmIngreso : Form
    {
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

                // Validar que el DNI no esté vacío
                if (string.IsNullOrWhiteSpace(dni))
                {
                    lblAvisoIngreso.Text = "Por favor, ingrese un DNI válido.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                // Validar si el cliente está registrado en la base de datos
                string clienteQuery = "SELECT COUNT(*) FROM Clientes WHERE DNI = @DNI";
                int clienteExistente = Convert.ToInt32(DatabaseHelper.ExecuteScalar(clienteQuery, new SqlParameter[]
                {
                    new SqlParameter("@DNI", dni)
                }));

                if (clienteExistente == 0)
                {
                    lblAvisoIngreso.Text = "El DNI no está registrado en el sistema.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                // Consultar la fecha del último pago del cliente
                string pagoQuery = @"
                    SELECT TOP 1 FechaPago 
                    FROM Pagos 
                    WHERE DNI = @DNI 
                    ORDER BY FechaPago DESC";

                object fechaPagoObj = DatabaseHelper.ExecuteScalar(pagoQuery, new SqlParameter[]
                {
                    new SqlParameter("@DNI", dni)
                });

                // Verificar si no se encontró ningún pago
                if (fechaPagoObj == null || fechaPagoObj == DBNull.Value)
                {
                    lblAvisoIngreso.Text = "No se encontraron pagos registrados para este cliente.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    return;
                }

                DateTime fechaPago = Convert.ToDateTime(fechaPagoObj);

                // Calcular la diferencia de días entre hoy y la fecha del último pago
                TimeSpan diferencia = DateTime.Now - fechaPago;

                if (diferencia.TotalDays <= 30)
                {
                    lblAvisoIngreso.Text = "El cliente está habilitado para ingresar.";
                    lblAvisoIngreso.ForeColor = Color.Green;

                    // Aquí puedes agregar lógica para abrir la cerradura, si es necesario
                }
                else
                {
                    lblAvisoIngreso.Text = "El cliente no tiene el abono al día.";
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
    }
}
