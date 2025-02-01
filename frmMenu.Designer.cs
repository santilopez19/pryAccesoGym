namespace pryAccesoGym
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            dgvClientes = new DataGridView();
            btnAbrirPuerta = new Button();
            btnAbrirPuerta1min = new Button();
            btnSalir = new Button();
            grbClientes = new GroupBox();
            btnGestionarClientes = new Button();
            btnIngresos = new Button();
            grbClientesPago = new GroupBox();
            dtpFechaPago = new DateTimePicker();
            lblFechaPago = new Label();
            rbtEfectivo = new RadioButton();
            rbtTransferencia = new RadioButton();
            lblMontoPago = new Label();
            lblDniClienteAbono = new Label();
            txtMonto = new TextBox();
            txtDniAbono = new TextBox();
            btnCargarPago = new Button();
            txtBusqueda = new TextBox();
            grbListaClientes = new GroupBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            cmbFiltrado = new ComboBox();
            btnBuscar = new Button();
            btnCartelIngreso = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbClientes.SuspendLayout();
            grbClientesPago.SuspendLayout();
            grbListaClientes.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 68);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(1238, 434);
            dgvClientes.TabIndex = 7;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellContentClick += dgvClientes_CellClick;
            // 
            // btnAbrirPuerta
            // 
            btnAbrirPuerta.FlatAppearance.BorderColor = Color.Black;
            btnAbrirPuerta.FlatAppearance.BorderSize = 2;
            btnAbrirPuerta.FlatStyle = FlatStyle.Flat;
            btnAbrirPuerta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirPuerta.Location = new Point(1087, 93);
            btnAbrirPuerta.Margin = new Padding(3, 2, 3, 2);
            btnAbrirPuerta.Name = "btnAbrirPuerta";
            btnAbrirPuerta.Size = new Size(193, 42);
            btnAbrirPuerta.TabIndex = 0;
            btnAbrirPuerta.Text = "Abrir Puerta";
            btnAbrirPuerta.UseVisualStyleBackColor = true;
            btnAbrirPuerta.Click += btnAbrirPuerta_Click;
            // 
            // btnAbrirPuerta1min
            // 
            btnAbrirPuerta1min.FlatAppearance.BorderColor = Color.Black;
            btnAbrirPuerta1min.FlatAppearance.BorderSize = 2;
            btnAbrirPuerta1min.FlatStyle = FlatStyle.Flat;
            btnAbrirPuerta1min.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbrirPuerta1min.Location = new Point(1087, 47);
            btnAbrirPuerta1min.Margin = new Padding(3, 2, 3, 2);
            btnAbrirPuerta1min.Name = "btnAbrirPuerta1min";
            btnAbrirPuerta1min.Size = new Size(193, 42);
            btnAbrirPuerta1min.TabIndex = 1;
            btnAbrirPuerta1min.Text = "Abrir Puerta 1min";
            btnAbrirPuerta1min.UseVisualStyleBackColor = true;
            btnAbrirPuerta1min.Click += btnAbrirPuerta1min_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(1164, 1);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 42);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // grbClientes
            // 
            grbClientes.BackColor = Color.Transparent;
            grbClientes.Controls.Add(btnGestionarClientes);
            grbClientes.Controls.Add(btnIngresos);
            grbClientes.FlatStyle = FlatStyle.Popup;
            grbClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbClientes.Location = new Point(10, 11);
            grbClientes.Margin = new Padding(3, 2, 3, 2);
            grbClientes.Name = "grbClientes";
            grbClientes.Padding = new Padding(3, 2, 3, 2);
            grbClientes.Size = new Size(162, 147);
            grbClientes.TabIndex = 3;
            grbClientes.TabStop = false;
            grbClientes.Text = "Clientes";
            // 
            // btnGestionarClientes
            // 
            btnGestionarClientes.Location = new Point(9, 72);
            btnGestionarClientes.Margin = new Padding(3, 2, 3, 2);
            btnGestionarClientes.Name = "btnGestionarClientes";
            btnGestionarClientes.Size = new Size(138, 67);
            btnGestionarClientes.TabIndex = 4;
            btnGestionarClientes.Text = "Gestionar Clientes";
            btnGestionarClientes.UseVisualStyleBackColor = true;
            btnGestionarClientes.Click += button1_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(9, 32);
            btnIngresos.Margin = new Padding(3, 2, 3, 2);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(138, 36);
            btnIngresos.TabIndex = 5;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // grbClientesPago
            // 
            grbClientesPago.BackColor = SystemColors.Control;
            grbClientesPago.Controls.Add(dtpFechaPago);
            grbClientesPago.Controls.Add(lblFechaPago);
            grbClientesPago.Controls.Add(rbtEfectivo);
            grbClientesPago.Controls.Add(rbtTransferencia);
            grbClientesPago.Controls.Add(lblMontoPago);
            grbClientesPago.Controls.Add(lblDniClienteAbono);
            grbClientesPago.Controls.Add(txtMonto);
            grbClientesPago.Controls.Add(txtDniAbono);
            grbClientesPago.Controls.Add(btnCargarPago);
            grbClientesPago.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbClientesPago.Location = new Point(178, 11);
            grbClientesPago.Margin = new Padding(3, 2, 3, 2);
            grbClientesPago.Name = "grbClientesPago";
            grbClientesPago.Padding = new Padding(3, 2, 3, 2);
            grbClientesPago.Size = new Size(903, 170);
            grbClientesPago.TabIndex = 6;
            grbClientesPago.TabStop = false;
            grbClientesPago.Text = "Pagos";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(464, 73);
            dtpFechaPago.Margin = new Padding(3, 2, 3, 2);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(292, 33);
            dtpFechaPago.TabIndex = 21;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(464, 48);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(140, 25);
            lblFechaPago.TabIndex = 20;
            lblFechaPago.Text = "Fecha de Pago";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(299, 80);
            rbtEfectivo.Margin = new Padding(3, 2, 3, 2);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(100, 29);
            rbtEfectivo.TabIndex = 11;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtTransferencia
            // 
            rbtTransferencia.AutoSize = true;
            rbtTransferencia.Location = new Point(299, 42);
            rbtTransferencia.Margin = new Padding(3, 2, 3, 2);
            rbtTransferencia.Name = "rbtTransferencia";
            rbtTransferencia.Size = new Size(149, 29);
            rbtTransferencia.TabIndex = 10;
            rbtTransferencia.TabStop = true;
            rbtTransferencia.Text = "Transferencia";
            rbtTransferencia.UseVisualStyleBackColor = true;
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Location = new Point(18, 80);
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(73, 25);
            lblMontoPago.TabIndex = 9;
            lblMontoPago.Text = "Monto";
            // 
            // lblDniClienteAbono
            // 
            lblDniClienteAbono.AutoSize = true;
            lblDniClienteAbono.Location = new Point(18, 43);
            lblDniClienteAbono.Name = "lblDniClienteAbono";
            lblDniClienteAbono.Size = new Size(47, 25);
            lblDniClienteAbono.TabIndex = 8;
            lblDniClienteAbono.Text = "DNI";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(104, 80);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(179, 33);
            txtMonto.TabIndex = 22;
            // 
            // txtDniAbono
            // 
            txtDniAbono.Location = new Point(104, 40);
            txtDniAbono.Margin = new Padding(3, 2, 3, 2);
            txtDniAbono.Name = "txtDniAbono";
            txtDniAbono.Size = new Size(179, 33);
            txtDniAbono.TabIndex = 6;
            // 
            // btnCargarPago
            // 
            btnCargarPago.BackColor = Color.PaleGreen;
            btnCargarPago.Location = new Point(771, 40);
            btnCargarPago.Margin = new Padding(3, 2, 3, 2);
            btnCargarPago.Name = "btnCargarPago";
            btnCargarPago.Size = new Size(116, 91);
            btnCargarPago.TabIndex = 5;
            btnCargarPago.Text = "Cargar Pago";
            btnCargarPago.UseVisualStyleBackColor = false;
            btnCargarPago.Click += btnCargarPago_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(193, 30);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(181, 33);
            txtBusqueda.TabIndex = 12;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(btnModificar);
            grbListaClientes.Controls.Add(btnEliminar);
            grbListaClientes.Controls.Add(cmbFiltrado);
            grbListaClientes.Controls.Add(btnBuscar);
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Controls.Add(txtBusqueda);
            grbListaClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbListaClientes.Location = new Point(10, 175);
            grbListaClientes.Margin = new Padding(3, 2, 3, 2);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Padding = new Padding(3, 2, 3, 2);
            grbListaClientes.Size = new Size(1258, 506);
            grbListaClientes.TabIndex = 14;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Pagos";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Khaki;
            btnModificar.Location = new Point(984, 22);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 38);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Location = new Point(1118, 22);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 38);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbFiltrado
            // 
            cmbFiltrado.FormattingEnabled = true;
            cmbFiltrado.Location = new Point(6, 30);
            cmbFiltrado.Margin = new Padding(3, 2, 3, 2);
            cmbFiltrado.Name = "cmbFiltrado";
            cmbFiltrado.Size = new Size(181, 33);
            cmbFiltrado.TabIndex = 14;
            cmbFiltrado.Text = "Buscar por..";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(389, 26);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 38);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnCartelIngreso
            // 
            btnCartelIngreso.FlatAppearance.BorderColor = Color.Black;
            btnCartelIngreso.FlatAppearance.BorderSize = 2;
            btnCartelIngreso.FlatStyle = FlatStyle.Flat;
            btnCartelIngreso.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCartelIngreso.Location = new Point(1087, 139);
            btnCartelIngreso.Margin = new Padding(3, 2, 3, 2);
            btnCartelIngreso.Name = "btnCartelIngreso";
            btnCartelIngreso.Size = new Size(193, 42);
            btnCartelIngreso.TabIndex = 15;
            btnCartelIngreso.Text = "Cartel Ingreso";
            btnCartelIngreso.UseVisualStyleBackColor = true;
            btnCartelIngreso.Click += btnCartelIngreso_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 689);
            Controls.Add(grbClientesPago);
            Controls.Add(btnCartelIngreso);
            Controls.Add(grbListaClientes);
            Controls.Add(grbClientes);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrirPuerta1min);
            Controls.Add(btnAbrirPuerta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbClientes.ResumeLayout(false);
            grbClientesPago.ResumeLayout(false);
            grbClientesPago.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            grbListaClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirPuerta;
        private Button btnAbrirPuerta1min;
        private Button btnSalir;
        private GroupBox grbClientes;
        private Button btnGestionarClientes;
        private Button btnIngresos;
        private GroupBox grbClientesPago;
        private Button btnCargarPago;
        private Label lblMontoPago;
        private Label lblDniClienteAbono;
        private TextBox txtMonto;
        private TextBox txtDniAbono;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTransferencia;
        private DataGridView dgvClientes;
        private TextBox txtBusqueda;
        private GroupBox grbListaClientes;
        private Button btnBuscar;
        private ComboBox cmbFiltrado;
        private Button btnEliminar;
        private Button btnModificar;
        private DateTimePicker dtpFechaPago;
        private Label lblFechaPago;
        private Button btnCartelIngreso;
    }
}