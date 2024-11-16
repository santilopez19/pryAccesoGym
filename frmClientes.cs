using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using static pryAccesoGym.bdGimnasio;

    namespace pryAccesoGym
    {
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += VolverPagina_KeyDown;
            CargarClientes();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

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
        private void CargarClientes()
        {
            try
            {
                string query = "USE dbGimnasio; SELECT DNI, Nombre, Apellido, FechaNacimiento, Sexo, FechaIngreso, FechaPago, MontoPagado, MetodoPago FROM Clientes";
                DataTable dataTable = DatabaseHelper.ExecuteQuery(query);
                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

