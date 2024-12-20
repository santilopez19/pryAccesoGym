namespace pryAccesoGym
{
    partial class frmIngreso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            btnIngresar = new Button();
            txtDniIngreso = new TextBox();
            lblAvisoIngreso = new Label();
            tLbl = new System.Windows.Forms.Timer(components);
            lblDniIngrese = new Label();
            lblAnuncio = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(563, 337);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(178, 55);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDniIngreso
            // 
            txtDniIngreso.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniIngreso.Location = new Point(517, 269);
            txtDniIngreso.Multiline = true;
            txtDniIngreso.Name = "txtDniIngreso";
            txtDniIngreso.Size = new Size(270, 46);
            txtDniIngreso.TabIndex = 1;
            txtDniIngreso.TextAlign = HorizontalAlignment.Center;
            txtDniIngreso.TextChanged += txtDniIngreso_TextChanged;
            // 
            // lblAvisoIngreso
            // 
            lblAvisoIngreso.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvisoIngreso.Location = new Point(338, 414);
            lblAvisoIngreso.Name = "lblAvisoIngreso";
            lblAvisoIngreso.Size = new Size(629, 111);
            lblAvisoIngreso.TabIndex = 2;
            lblAvisoIngreso.TextAlign = ContentAlignment.MiddleCenter;
            lblAvisoIngreso.Click += lblAvisoIngreso_Click;
            // 
            // tLbl
            // 
            tLbl.Interval = 5000;
            tLbl.Tick += tLbl_Tick;
            // 
            // lblDniIngrese
            // 
            lblDniIngrese.AutoSize = true;
            lblDniIngrese.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniIngrese.Location = new Point(489, 193);
            lblDniIngrese.Name = "lblDniIngrese";
            lblDniIngrese.Size = new Size(345, 54);
            lblDniIngrese.TabIndex = 3;
            lblDniIngrese.Text = "INGRESE SU DNI ";
            // 
            // lblAnuncio
            // 
            lblAnuncio.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnuncio.ForeColor = SystemColors.ActiveCaptionText;
            lblAnuncio.Location = new Point(12, 120);
            lblAnuncio.Name = "lblAnuncio";
            lblAnuncio.Size = new Size(460, 213);
            lblAnuncio.TabIndex = 4;
            lblAnuncio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 721);
            Controls.Add(lblAnuncio);
            Controls.Add(lblAvisoIngreso);
            Controls.Add(lblDniIngrese);
            Controls.Add(btnIngresar);
            Controls.Add(txtDniIngreso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += frmIngreso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtDniIngreso;
        private Label lblAvisoIngreso;
        private System.Windows.Forms.Timer tLbl;
        private Label lblDniIngrese;
        private Label lblAnuncio;
    }
}