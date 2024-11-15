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
            btnAbrirPuerta = new Button();
            btnAbrirPuerta1min = new Button();
            btnSalir = new Button();
            grbClientes = new GroupBox();
            btnEditarClientes = new Button();
            btnIngresos = new Button();
            grbClientesPago = new GroupBox();
            btnCargarPago = new Button();
            txtDniAbono = new TextBox();
            txtMonto = new TextBox();
            lblDniClienteAbono = new Label();
            lblMontoPago = new Label();
            rbtTransferencia = new RadioButton();
            rbtEfectivo = new RadioButton();
            dataGridView1 = new DataGridView();
            lblBuscarDni = new Label();
            textBox1 = new TextBox();
            grbListaClientes = new GroupBox();
            btnBuscarDni = new Button();
            grbClientes.SuspendLayout();
            grbClientesPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbListaClientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbrirPuerta
            // 
            btnAbrirPuerta.Location = new Point(26, 12);
            btnAbrirPuerta.Name = "btnAbrirPuerta";
            btnAbrirPuerta.Size = new Size(147, 29);
            btnAbrirPuerta.TabIndex = 0;
            btnAbrirPuerta.Text = "Abrir Puerta";
            btnAbrirPuerta.UseVisualStyleBackColor = true;
            // 
            // btnAbrirPuerta1min
            // 
            btnAbrirPuerta1min.Location = new Point(266, 12);
            btnAbrirPuerta1min.Name = "btnAbrirPuerta1min";
            btnAbrirPuerta1min.Size = new Size(139, 29);
            btnAbrirPuerta1min.TabIndex = 1;
            btnAbrirPuerta1min.Text = "Abrir Puerta 1min";
            btnAbrirPuerta1min.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(685, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // grbClientes
            // 
            grbClientes.Controls.Add(btnEditarClientes);
            grbClientes.Controls.Add(btnIngresos);
            grbClientes.Location = new Point(12, 47);
            grbClientes.Name = "grbClientes";
            grbClientes.Size = new Size(172, 115);
            grbClientes.TabIndex = 3;
            grbClientes.TabStop = false;
            grbClientes.Text = "Clientes";
            // 
            // btnEditarClientes
            // 
            btnEditarClientes.Location = new Point(29, 71);
            btnEditarClientes.Name = "btnEditarClientes";
            btnEditarClientes.Size = new Size(113, 29);
            btnEditarClientes.TabIndex = 4;
            btnEditarClientes.Text = "Editar Clientes";
            btnEditarClientes.UseVisualStyleBackColor = true;
            btnEditarClientes.Click += button1_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(29, 36);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(113, 29);
            btnIngresos.TabIndex = 5;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            // 
            // grbClientesPago
            // 
            grbClientesPago.Controls.Add(rbtEfectivo);
            grbClientesPago.Controls.Add(rbtTransferencia);
            grbClientesPago.Controls.Add(lblMontoPago);
            grbClientesPago.Controls.Add(lblDniClienteAbono);
            grbClientesPago.Controls.Add(txtMonto);
            grbClientesPago.Controls.Add(txtDniAbono);
            grbClientesPago.Controls.Add(btnCargarPago);
            grbClientesPago.Location = new Point(218, 47);
            grbClientesPago.Name = "grbClientesPago";
            grbClientesPago.Size = new Size(570, 129);
            grbClientesPago.TabIndex = 6;
            grbClientesPago.TabStop = false;
            grbClientesPago.Text = "Pagos";
            // 
            // btnCargarPago
            // 
            btnCargarPago.Location = new Point(441, 26);
            btnCargarPago.Name = "btnCargarPago";
            btnCargarPago.Size = new Size(113, 89);
            btnCargarPago.TabIndex = 5;
            btnCargarPago.Text = "Cargar Pago";
            btnCargarPago.UseVisualStyleBackColor = true;
            // 
            // txtDniAbono
            // 
            txtDniAbono.Location = new Point(91, 38);
            txtDniAbono.Name = "txtDniAbono";
            txtDniAbono.Size = new Size(166, 27);
            txtDniAbono.TabIndex = 6;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(91, 71);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(166, 27);
            txtMonto.TabIndex = 7;
            // 
            // lblDniClienteAbono
            // 
            lblDniClienteAbono.AutoSize = true;
            lblDniClienteAbono.Location = new Point(17, 41);
            lblDniClienteAbono.Name = "lblDniClienteAbono";
            lblDniClienteAbono.Size = new Size(35, 20);
            lblDniClienteAbono.TabIndex = 8;
            lblDniClienteAbono.Text = "DNI";
            // 
            // lblMontoPago
            // 
            lblMontoPago.AutoSize = true;
            lblMontoPago.Location = new Point(17, 74);
            lblMontoPago.Name = "lblMontoPago";
            lblMontoPago.Size = new Size(53, 20);
            lblMontoPago.TabIndex = 9;
            lblMontoPago.Text = "Monto";
            // 
            // rbtTransferencia
            // 
            rbtTransferencia.AutoSize = true;
            rbtTransferencia.Location = new Point(301, 34);
            rbtTransferencia.Name = "rbtTransferencia";
            rbtTransferencia.Size = new Size(117, 24);
            rbtTransferencia.TabIndex = 10;
            rbtTransferencia.TabStop = true;
            rbtTransferencia.Text = "Transferencia";
            rbtTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(301, 70);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(83, 24);
            rbtEfectivo.TabIndex = 11;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(767, 265);
            dataGridView1.TabIndex = 7;
            // 
            // lblBuscarDni
            // 
            lblBuscarDni.AutoSize = true;
            lblBuscarDni.Location = new Point(11, 29);
            lblBuscarDni.Name = "lblBuscarDni";
            lblBuscarDni.Size = new Size(106, 20);
            lblBuscarDni.TabIndex = 13;
            lblBuscarDni.Text = "Buscar por Dni";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 12;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(btnBuscarDni);
            grbListaClientes.Controls.Add(dataGridView1);
            grbListaClientes.Controls.Add(lblBuscarDni);
            grbListaClientes.Controls.Add(textBox1);
            grbListaClientes.Location = new Point(3, 223);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(795, 338);
            grbListaClientes.TabIndex = 14;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // btnBuscarDni
            // 
            btnBuscarDni.Location = new Point(317, 25);
            btnBuscarDni.Name = "btnBuscarDni";
            btnBuscarDni.Size = new Size(113, 29);
            btnBuscarDni.TabIndex = 6;
            btnBuscarDni.Text = "Buscar";
            btnBuscarDni.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(grbListaClientes);
            Controls.Add(grbClientesPago);
            Controls.Add(grbClientes);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrirPuerta1min);
            Controls.Add(btnAbrirPuerta);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            grbClientes.ResumeLayout(false);
            grbClientesPago.ResumeLayout(false);
            grbClientesPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbListaClientes.ResumeLayout(false);
            grbListaClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrirPuerta;
        private Button btnAbrirPuerta1min;
        private Button btnSalir;
        private GroupBox grbClientes;
        private Button btnEditarClientes;
        private Button btnIngresos;
        private GroupBox grbClientesPago;
        private Button btnCargarPago;
        private Label lblMontoPago;
        private Label lblDniClienteAbono;
        private TextBox txtMonto;
        private TextBox txtDniAbono;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTransferencia;
        private DataGridView dataGridView1;
        private Label lblBuscarDni;
        private TextBox textBox1;
        private GroupBox grbListaClientes;
        private Button btnBuscarDni;
    }
}