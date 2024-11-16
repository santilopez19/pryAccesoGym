namespace pryAccesoGym
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            lblFechaNac = new Label();
            dtpFechaNac = new DateTimePicker();
            grbDatosPersonales = new GroupBox();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            btnCrearUsuario = new Button();
            btnModificarUsuario = new Button();
            grbListaClientes = new GroupBox();
            cmbFiltrado = new ComboBox();
            btnBuscarDni = new Button();
            dgvClientes = new DataGridView();
            txtBuscarClientes = new TextBox();
            grbDatosPersonales.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(79, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(283, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(9, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(79, 129);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(283, 27);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(9, 132);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(413, 129);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(41, 20);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(460, 126);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(67, 28);
            cmbSexo.TabIndex = 17;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(413, 83);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(101, 20);
            lblFechaNac.TabIndex = 18;
            lblFechaNac.Text = "Fecha de Nac.";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(517, 78);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(250, 27);
            dtpFechaNac.TabIndex = 19;
            // 
            // grbDatosPersonales
            // 
            grbDatosPersonales.Controls.Add(dtpFechaIngreso);
            grbDatosPersonales.Controls.Add(lblFechaIngreso);
            grbDatosPersonales.Controls.Add(lblNombre);
            grbDatosPersonales.Controls.Add(txtNombre);
            grbDatosPersonales.Controls.Add(dtpFechaNac);
            grbDatosPersonales.Controls.Add(lblApellido);
            grbDatosPersonales.Controls.Add(lblFechaNac);
            grbDatosPersonales.Controls.Add(txtApellido);
            grbDatosPersonales.Controls.Add(cmbSexo);
            grbDatosPersonales.Controls.Add(lblDni);
            grbDatosPersonales.Controls.Add(txtDni);
            grbDatosPersonales.Controls.Add(lblSexo);
            grbDatosPersonales.Location = new Point(12, 12);
            grbDatosPersonales.Name = "grbDatosPersonales";
            grbDatosPersonales.Size = new Size(820, 178);
            grbDatosPersonales.TabIndex = 21;
            grbDatosPersonales.TabStop = false;
            grbDatosPersonales.Text = "Datos Personales";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(535, 40);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(250, 27);
            dtpFechaIngreso.TabIndex = 22;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(413, 41);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(100, 20);
            lblFechaIngreso.TabIndex = 21;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(574, 23);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(115, 29);
            btnCrearUsuario.TabIndex = 23;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(695, 23);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(141, 29);
            btnModificarUsuario.TabIndex = 24;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(cmbFiltrado);
            grbListaClientes.Controls.Add(btnModificarUsuario);
            grbListaClientes.Controls.Add(btnBuscarDni);
            grbListaClientes.Controls.Add(btnCrearUsuario);
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Controls.Add(txtBuscarClientes);
            grbListaClientes.Location = new Point(12, 196);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(842, 377);
            grbListaClientes.TabIndex = 25;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // cmbFiltrado
            // 
            cmbFiltrado.FormattingEnabled = true;
            cmbFiltrado.Items.AddRange(new object[] { "DNI", "Nombre" });
            cmbFiltrado.Location = new Point(9, 25);
            cmbFiltrado.Name = "cmbFiltrado";
            cmbFiltrado.Size = new Size(185, 28);
            cmbFiltrado.TabIndex = 14;
            cmbFiltrado.Text = "Buscar por..";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(372, 24);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(113, 29);
            btnBuscarDni.TabIndex = 6;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(5, 60);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(831, 311);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.Location = new Point(200, 25);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(166, 27);
            txtBuscarClientes.TabIndex = 12;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 585);
            Controls.Add(grbListaClientes);
            Controls.Add(grbDatosPersonales);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += frmClientes_Load;
            grbDatosPersonales.ResumeLayout(false);
            grbDatosPersonales.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            grbListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblFechaNac;
        private DateTimePicker dtpFechaNac;
        private GroupBox grbDatosPersonales;
        private Button btnCrearUsuario;
        private Button btnModificarUsuario;
        private GroupBox grbListaClientes;
        private ComboBox cmbFiltrado;
        private Button btnBuscarDni;
        private DataGridView dgvClientes;
        private TextBox txtBuscarClientes;
        private DateTimePicker dtpFechaIngreso;
        private Label lblFechaIngreso;
    }
}