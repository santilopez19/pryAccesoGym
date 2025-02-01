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
            button1 = new Button();
            gpbEstado = new GroupBox();
            rbtActivo = new RadioButton();
            rbtInactivo = new RadioButton();
            btnSalir = new Button();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtMail = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            lblFechaIngreso = new Label();
            btnCrearUsuario = new Button();
            btnModificarUsuario = new Button();
            grbListaClientes = new GroupBox();
            rbtActivoFiltro = new RadioButton();
            rbtInactivoFiltro = new RadioButton();
            dgvClientes = new DataGridView();
            btnBuscarDni = new Button();
            txtBuscarClientes = new TextBox();
            grbDatosPersonales.SuspendLayout();
            gpbEstado.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 31);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 33);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(104, 68);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(248, 33);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(17, 71);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(104, 103);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(248, 33);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(17, 106);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 25);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(47, 162);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(56, 25);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(99, 160);
            cmbSexo.Margin = new Padding(3, 2, 3, 2);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(59, 33);
            cmbSexo.TabIndex = 17;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(391, 79);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(133, 25);
            lblFechaNac.TabIndex = 18;
            lblFechaNac.Text = "Fecha de Nac.";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(532, 77);
            dtpFechaNac.Margin = new Padding(3, 2, 3, 2);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(235, 33);
            dtpFechaNac.TabIndex = 19;
            // 
            // grbDatosPersonales
            // 
            grbDatosPersonales.BackColor = SystemColors.Control;
            grbDatosPersonales.Controls.Add(gpbEstado);
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
            grbDatosPersonales.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbDatosPersonales.Location = new Point(12, 18);
            grbDatosPersonales.Margin = new Padding(3, 2, 3, 2);
            grbDatosPersonales.Name = "grbDatosPersonales";
            grbDatosPersonales.Padding = new Padding(3, 2, 3, 2);
            grbDatosPersonales.Size = new Size(1253, 214);
            grbDatosPersonales.TabIndex = 21;
            grbDatosPersonales.TabStop = false;
            grbDatosPersonales.Text = "Datos Personales";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1180, 7);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 28;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gpbEstado
            // 
            gpbEstado.Controls.Add(rbtActivo);
            gpbEstado.Controls.Add(rbtInactivo);
            gpbEstado.Location = new Point(898, 36);
            gpbEstado.Margin = new Padding(3, 2, 3, 2);
            gpbEstado.Name = "gpbEstado";
            gpbEstado.Padding = new Padding(3, 2, 3, 2);
            gpbEstado.Size = new Size(148, 94);
            gpbEstado.TabIndex = 27;
            gpbEstado.TabStop = false;
            gpbEstado.Text = "Estado";
            // 
            // rbtActivo
            // 
            rbtActivo.AutoSize = true;
            rbtActivo.Location = new Point(20, 28);
            rbtActivo.Margin = new Padding(3, 2, 3, 2);
            rbtActivo.Name = "rbtActivo";
            rbtActivo.Size = new Size(86, 29);
            rbtActivo.TabIndex = 1;
            rbtActivo.TabStop = true;
            rbtActivo.Text = "Activo";
            rbtActivo.UseVisualStyleBackColor = true;
            // 
            // rbtInactivo
            // 
            rbtInactivo.AutoSize = true;
            rbtInactivo.Location = new Point(20, 61);
            rbtInactivo.Margin = new Padding(3, 2, 3, 2);
            rbtInactivo.Name = "rbtInactivo";
            rbtInactivo.Size = new Size(101, 29);
            rbtInactivo.TabIndex = 0;
            rbtInactivo.TabStop = true;
            rbtInactivo.Text = "Inactivo";
            rbtInactivo.UseVisualStyleBackColor = true;
            rbtInactivo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Location = new Point(1272, 0);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(90, 26);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(413, 134);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(89, 25);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(508, 132);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(248, 33);
            txtTelefono.TabIndex = 24;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(428, 171);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(67, 25);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(508, 171);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(248, 33);
            txtMail.TabIndex = 26;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(530, 28);
            dtpFechaIngreso.Margin = new Padding(3, 2, 3, 2);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(235, 33);
            dtpFechaIngreso.TabIndex = 22;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(389, 31);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(135, 25);
            lblFechaIngreso.TabIndex = 21;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Anchor = AnchorStyles.None;
            btnCrearUsuario.BackColor = Color.PaleGreen;
            btnCrearUsuario.Location = new Point(1024, 27);
            btnCrearUsuario.Margin = new Padding(3, 2, 3, 2);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(101, 37);
            btnCrearUsuario.TabIndex = 23;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Anchor = AnchorStyles.None;
            btnModificarUsuario.BackColor = Color.Khaki;
            btnModificarUsuario.Location = new Point(1130, 27);
            btnModificarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(123, 37);
            btnModificarUsuario.TabIndex = 24;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = false;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(rbtActivoFiltro);
            grbListaClientes.Controls.Add(btnModificarUsuario);
            grbListaClientes.Controls.Add(rbtInactivoFiltro);
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Controls.Add(btnBuscarDni);
            grbListaClientes.Controls.Add(btnCrearUsuario);
            grbListaClientes.Controls.Add(txtBuscarClientes);
            grbListaClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbListaClientes.Location = new Point(12, 236);
            grbListaClientes.Margin = new Padding(3, 2, 3, 2);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Padding = new Padding(3, 2, 3, 2);
            grbListaClientes.Size = new Size(1258, 419);
            grbListaClientes.TabIndex = 25;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // rbtActivoFiltro
            // 
            rbtActivoFiltro.AutoSize = true;
            rbtActivoFiltro.Location = new Point(322, 52);
            rbtActivoFiltro.Margin = new Padding(3, 2, 3, 2);
            rbtActivoFiltro.Name = "rbtActivoFiltro";
            rbtActivoFiltro.Size = new Size(86, 29);
            rbtActivoFiltro.TabIndex = 3;
            rbtActivoFiltro.TabStop = true;
            rbtActivoFiltro.Text = "Activo";
            rbtActivoFiltro.UseVisualStyleBackColor = true;
            // 
            // rbtInactivoFiltro
            // 
            rbtInactivoFiltro.AutoSize = true;
            rbtInactivoFiltro.Location = new Point(414, 52);
            rbtInactivoFiltro.Margin = new Padding(3, 2, 3, 2);
            rbtInactivoFiltro.Name = "rbtInactivoFiltro";
            rbtInactivoFiltro.Size = new Size(101, 29);
            rbtInactivoFiltro.TabIndex = 2;
            rbtInactivoFiltro.TabStop = true;
            rbtInactivoFiltro.Text = "Inactivo";
            rbtInactivoFiltro.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(7, 87);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(1246, 328);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(204, 49);
            btnBuscarDni.Margin = new Padding(3, 2, 3, 2);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(99, 34);
            btnBuscarDni.TabIndex = 6;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            btnBuscarDni.Click += btnBuscarDni_Click;
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.Location = new Point(7, 50);
            txtBuscarClientes.Margin = new Padding(3, 2, 3, 2);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(191, 33);
            txtBuscarClientes.TabIndex = 12;
            txtBuscarClientes.TextChanged += txtBuscarClientes_TextChanged;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 666);
            Controls.Add(button1);
            Controls.Add(grbListaClientes);
            Controls.Add(grbDatosPersonales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += frmClientes_Load;
            grbDatosPersonales.ResumeLayout(false);
            grbDatosPersonales.PerformLayout();
            gpbEstado.ResumeLayout(false);
            gpbEstado.PerformLayout();
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
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblEmail;
        private TextBox txtMail;
        private Button btnSalir;
        private GroupBox gpbEstado;
        private RadioButton rbtActivo;
        private RadioButton rbtInactivo;
        private RadioButton rbtActivoFiltro;
        private RadioButton rbtInactivoFiltro;
        private Button button1;
    }
}