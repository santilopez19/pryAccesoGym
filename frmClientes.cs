using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
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
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                string query = "SELECT * FROM Clientes ORDER BY Nombre ASC";
                DataTable dataTable = DatabaseHelper.ExecuteQuery(query);
                dgvClientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) || cmbSexo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar el nuevo cliente
                string query = @"
        INSERT INTO Clientes (DNI, Nombre, Apellido, FechaNacimiento, Sexo, FechaIngreso)
        VALUES (@DNI, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @FechaIngreso)";

                SqlParameter[] parameters = new SqlParameter[]
                {   
            new SqlParameter("@DNI", txtDni.Text.Trim()),
            new SqlParameter("@Nombre", txtNombre.Text.Trim()),
            new SqlParameter("@Apellido", txtApellido.Text.Trim()),
            new SqlParameter("@FechaNacimiento", dtpFechaNac.Value),
            new SqlParameter("@Sexo", cmbSexo.SelectedItem.ToString()),
            new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Cliente creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes(); // Actualizar la grilla
                LimpiarCampos();  // Limpiar los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                txtDni.Text = row.Cells["DNI"].Value?.ToString() ?? "";
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
                txtApellido.Text = row.Cells["Apellido"].Value?.ToString() ?? "";
                dtpFechaNac.Value = row.Cells["FechaNacimiento"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["FechaNacimiento"].Value) : DateTime.Now;
                cmbSexo.SelectedItem = row.Cells["Sexo"].Value?.ToString() ?? "";
                dtpFechaIngreso.Value = row.Cells["FechaIngreso"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["FechaIngreso"].Value) : DateTime.Now;
            }
        }

        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNac.Value = DateTime.Now;
            cmbSexo.SelectedIndex = -1;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("M"); // Masculino
            cmbSexo.Items.Add("F"); // Femenino
            cmbSexo.SelectedIndex = -1;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) || cmbSexo.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar los datos del cliente
                string query = @"
    UPDATE Clientes 
    SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, 
        Sexo = @Sexo, FechaIngreso = @FechaIngreso
    WHERE DNI = @DNI";

                SqlParameter[] parameters = new SqlParameter[]
                {
        new SqlParameter("@DNI", txtDni.Text.Trim()),
        new SqlParameter("@Nombre", txtNombre.Text.Trim()),
        new SqlParameter("@Apellido", txtApellido.Text.Trim()),
        new SqlParameter("@FechaNacimiento", dtpFechaNac.Value),
        new SqlParameter("@Sexo", cmbSexo.SelectedItem.ToString()),
        new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show("Cliente modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes(); // Actualizar la grilla
                LimpiarCampos();  // Limpiar los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay una fila seleccionada en el DataGridView
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    // Obtén el DNI del cliente seleccionado (suponiendo que la columna "DNI" es la primera)
                    string dni = dgvClientes.SelectedRows[0].Cells["DNI"].Value.ToString();

                    // Confirmar la eliminación
                    DialogResult result = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este cliente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Consulta SQL para eliminar el cliente basado en su DNI
                        string query = "DELETE FROM Clientes WHERE DNI = @DNI";

                        // Ejecutar la consulta
                        int filasAfectadas = DatabaseHelper.ExecuteNonQuery(query, new SqlParameter[]
                        {
                    new SqlParameter("@DNI", dni)
                        });

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarClientes(); // Actualizar la lista después de eliminar
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
