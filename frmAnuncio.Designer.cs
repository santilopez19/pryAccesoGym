namespace pryAccesoGym
{
    partial class frmAnuncio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnuncio));
            btnSalir = new Button();
            txtAnuncio = new TextBox();
            btnGuardarCambios = new Button();
            rbtRojo = new RadioButton();
            rbtAzul = new RadioButton();
            grbColores = new GroupBox();
            rbtNegro = new RadioButton();
            grbColores.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(859, 9);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 44);
            btnSalir.TabIndex = 27;
            btnSalir.Text = "Volver";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtAnuncio
            // 
            txtAnuncio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnuncio.Location = new Point(65, 40);
            txtAnuncio.Margin = new Padding(3, 2, 3, 2);
            txtAnuncio.Multiline = true;
            txtAnuncio.Name = "txtAnuncio";
            txtAnuncio.Size = new Size(462, 347);
            txtAnuncio.TabIndex = 28;
            txtAnuncio.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.PaleGreen;
            btnGuardarCambios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCambios.Location = new Point(569, 184);
            btnGuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(194, 44);
            btnGuardarCambios.TabIndex = 30;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // rbtRojo
            // 
            rbtRojo.AutoSize = true;
            rbtRojo.Location = new Point(24, 56);
            rbtRojo.Margin = new Padding(3, 2, 3, 2);
            rbtRojo.Name = "rbtRojo";
            rbtRojo.Size = new Size(71, 29);
            rbtRojo.TabIndex = 32;
            rbtRojo.TabStop = true;
            rbtRojo.Text = "Rojo";
            rbtRojo.UseVisualStyleBackColor = true;
            // 
            // rbtAzul
            // 
            rbtAzul.AutoSize = true;
            rbtAzul.Location = new Point(24, 29);
            rbtAzul.Margin = new Padding(3, 2, 3, 2);
            rbtAzul.Name = "rbtAzul";
            rbtAzul.Size = new Size(69, 29);
            rbtAzul.TabIndex = 31;
            rbtAzul.TabStop = true;
            rbtAzul.Text = "Azul";
            rbtAzul.UseVisualStyleBackColor = true;
            // 
            // grbColores
            // 
            grbColores.Controls.Add(rbtNegro);
            grbColores.Controls.Add(rbtAzul);
            grbColores.Controls.Add(rbtRojo);
            grbColores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grbColores.Location = new Point(569, 40);
            grbColores.Margin = new Padding(3, 2, 3, 2);
            grbColores.Name = "grbColores";
            grbColores.Padding = new Padding(3, 2, 3, 2);
            grbColores.Size = new Size(271, 141);
            grbColores.TabIndex = 33;
            grbColores.TabStop = false;
            grbColores.Text = "Colores";
            // 
            // rbtNegro
            // 
            rbtNegro.AutoSize = true;
            rbtNegro.Location = new Point(23, 82);
            rbtNegro.Margin = new Padding(3, 2, 3, 2);
            rbtNegro.Name = "rbtNegro";
            rbtNegro.Size = new Size(87, 29);
            rbtNegro.TabIndex = 33;
            rbtNegro.TabStop = true;
            rbtNegro.Text = "Negro";
            rbtNegro.UseVisualStyleBackColor = true;
            // 
            // frmAnuncio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 418);
            Controls.Add(grbColores);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtAnuncio);
            Controls.Add(btnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAnuncio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anuncio";
            grbColores.ResumeLayout(false);
            grbColores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private TextBox txtAnuncio;
        private Button btnGuardarCambios;
        private RadioButton rbtRojo;
        private RadioButton rbtAzul;
        private GroupBox grbColores;
        private RadioButton rbtNegro;
    }
}