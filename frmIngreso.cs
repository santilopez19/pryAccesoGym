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
                if (string.IsNullOrWhiteSpace(txtDniIngreso.Text))
                {
                    lblAvisoIngreso.Text = "Por favor, ingrese un DNI válido.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    IniciarTemporizador();
                    return;
                }

                string dni = txtDniIngreso.Text.Trim();

                string query = @"
            SELECT TOP 1 FechaPago 
            FROM Pagos 
            WHERE DNI = @DNI
            ORDER BY FechaPago DESC";

                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@DNI", dni)
                };

                object result = DatabaseHelper.ExecuteScalar(query, parameters);

                if (result == null || result == DBNull.Value)
                {
                    lblAvisoIngreso.Text = "El cliente no tiene registros de pago.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                    IniciarTemporizador();
                    return;
                }

                DateTime fechaPago = Convert.ToDateTime(result);
                DateTime fechaActual = DateTime.Now;
                TimeSpan diferencia = fechaActual - fechaPago;

                if (diferencia.TotalDays <= 30)
                {
                    lblAvisoIngreso.Text = "Ingreso permitido. Cuota al día.";
                    lblAvisoIngreso.ForeColor = Color.Green;
                }
                else if (diferencia.TotalDays > 30 && diferencia.TotalDays <= 35)
                {
                    lblAvisoIngreso.Text = $"Cuota vencida desde el {fechaPago:dd/MM/yyyy}.";
                    lblAvisoIngreso.ForeColor = Color.Orange;
                }
                else
                {
                    lblAvisoIngreso.Text = "Acceso denegado. Cuota vencida.";
                    lblAvisoIngreso.ForeColor = Color.Red;
                }

                IniciarTemporizador();
            }
            catch (Exception ex)
            {
                lblAvisoIngreso.Text = "Error al validar el ingreso.";
                lblAvisoIngreso.ForeColor = Color.Red;
                IniciarTemporizador();
            }
            finally
            {
                txtDniIngreso.Text = "";
                txtDniIngreso.Focus();
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
