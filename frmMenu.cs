using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static pryAccesoGym.bdGimnasio;

namespace pryAccesoGym
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            CargarPagos();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
            this.Hide();
        }

        private void lblBuscarDni_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            frmIngreso frmIngreso = new frmIngreso();
            frmIngreso.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
        private void CargarPagos()
        {
            try
            {
                // Consulta para obtener los pagos con nombre y apellido
                string query = @"
            SELECT 
                p.DNI AS 'Documento', 
                c.Nombre AS 'Nombre', 
                c.Apellido AS 'Apellido', 
                p.Monto AS 'Monto Pagado', 
                p.MetodoPago AS 'Método de Pago', 
                p.FechaPago AS 'Fecha de Pago' 
            FROM 
                Pagos p
            JOIN 
                Clientes c 
            ON 
                p.DNI = c.DNI
            ORDER BY 
                p.FechaPago DESC";

                // Ejecutar la consulta y obtener los resultados
                DataTable dataTable = DatabaseHelper.ExecuteQuery(query);

                // Asignar los resultados al DataGridView
                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtDniAbono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtTransferencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores ingresados por el usuario
                string dni = txtDniAbono.Text.Trim();
                string montoTexto = txtMonto.Text.Trim();
                decimal monto;

                // Validar que el monto sea un número válido
                if (!decimal.TryParse(montoTexto, out monto))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Determinar el método de pago
                string metodoPago = rbtEfectivo.Checked ? "Efectivo" : rbtTransferencia.Checked ? "Transferencia" : "";

                if (string.IsNullOrEmpty(metodoPago))
                {
                    MessageBox.Show("Debe seleccionar un método de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Consulta para insertar el pago
                string query = "INSERT INTO Pagos (DNI, Monto, MetodoPago, FechaPago) " +
                               "VALUES (@DNI, @Monto, @MetodoPago, @FechaPago)";

                // Ejecutar el comando
                int filasAfectadas = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter[]
                {
            new SqlParameter("@DNI", dni),
            new SqlParameter("@Monto", monto),
            new SqlParameter("@MetodoPago", metodoPago),
            new SqlParameter("@FechaPago", DateTime.Now)
                });

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtDniAbono.Text = "";
            txtMonto.Text = "";
            rbtEfectivo.Checked = false;
            rbtTransferencia.Checked = false;
        }
    }
}