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

namespace pryAccesoGym
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            CargarClientes();
        }
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbGimnasio.mdf;Integrated Security=True";
        static string conexionstring = "server= localhost ; database= master ; integrated security= true ; Encrypt=False;";
        SqlConnection connection = new SqlConnection(conexionstring);

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
        private void CargarClientes()
        {
            try
            {
                using (connection)
                {
                    connection.Open();

                    // Consulta SQL para obtener todos los clientes
                    string query = "USE dbGimnasio; SELECT DNI, Nombre, Apellido, FechaNacimiento, Sexo, FechaIngreso, FechaPago, MontoPagado, MetodoPago FROM Clientes";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvClientes.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
