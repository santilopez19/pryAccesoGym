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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
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
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtMail = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            btnCrearUsuario = new Button();
            btnModificarUsuario = new Button();
            grbListaClientes = new GroupBox();
            btnEliminar = new Button();
            btnBuscarDni = new Button();
            dgvClientes = new DataGridView();
            txtBuscarClientes = new TextBox();
            btnSalir = new Button();
            grbDatosPersonales.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(119, 83);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(283, 31);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(22, 86);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(119, 129);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(283, 31);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(22, 132);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(45, 25);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(436, 136);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(53, 25);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(495, 133);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(67, 33);
            cmbSexo.TabIndex = 17;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(436, 90);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(130, 25);
            lblFechaNac.TabIndex = 18;
            lblFechaNac.Text = "Fecha de Nac.";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(572, 87);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(268, 31);
            dtpFechaNac.TabIndex = 19;
            // 
            // grbDatosPersonales
            // 
            grbDatosPersonales.BackColor = SystemColors.Control;
            grbDatosPersonales.Controls.Add(btnSalir);
            grbDatosPersonales.Controls.Add(lblTelefono);
            grbDatosPersonales.Controls.Add(txtTelefono);
            grbDatosPersonales.Controls.Add(lblEmail);
            grbDatosPersonales.Controls.Add(txtMail);
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
            grbDatosPersonales.FlatStyle = FlatStyle.System;
            grbDatosPersonales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbDatosPersonales.Location = new Point(17, 12);
            grbDatosPersonales.Name = "grbDatosPersonales";
            grbDatosPersonales.Size = new Size(1289, 178);
            grbDatosPersonales.TabIndex = 21;
            grbDatosPersonales.TabStop = false;
            grbDatosPersonales.Text = "Datos Personales";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(884, 45);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 25);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(976, 45);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(283, 31);
            txtTelefono.TabIndex = 24;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(895, 90);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(976, 87);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(283, 31);
            txtMail.TabIndex = 26;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(572, 45);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(268, 31);
            dtpFechaIngreso.TabIndex = 22;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(436, 48);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(130, 25);
            lblFechaIngreso.TabIndex = 21;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.PaleGreen;
            btnCrearUsuario.Location = new Point(850, 22);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(115, 39);
            btnCrearUsuario.TabIndex = 23;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.BackColor = Color.Khaki;
            btnModificarUsuario.Location = new Point(971, 22);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(141, 39);
            btnModificarUsuario.TabIndex = 24;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(btnEliminar);
            grbListaClientes.Controls.Add(btnModificarUsuario);
            grbListaClientes.Controls.Add(btnBuscarDni);
            grbListaClientes.Controls.Add(btnCrearUsuario);
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Controls.Add(txtBuscarClientes);
            grbListaClientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbListaClientes.Location = new Point(12, 196);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(1294, 513);
            grbListaClientes.TabIndex = 25;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Location = new Point(1118, 22);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 39);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(219, 28);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(113, 35);
            btnBuscarDni.TabIndex = 6;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(5, 73);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(1283, 434);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.Location = new Point(9, 30);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(204, 31);
            txtBuscarClientes.TabIndex = 12;
            txtBuscarClientes.TextChanged += txtBuscarClientes_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Location = new Point(1186, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 35);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 721);
            Controls.Add(grbListaClientes);
            Controls.Add(grbDatosPersonales);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnBuscarDni;
        private DataGridView dgvClientes;
        private TextBox txtBuscarClientes;
        private DateTimePicker dtpFechaIngreso;
        private Label lblFechaIngreso;
        private Button btnEliminar;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtMail;
        private Button btnSalir;
    }
}