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
            btnIngresar = new Button();
            txtDniIngreso = new TextBox();
            lblAvisoIngreso = new Label();
            tLbl = new System.Windows.Forms.Timer(components);
            lblDniIngrese = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(321, 204);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(160, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDniIngreso
            // 
            txtDniIngreso.Location = new Point(308, 157);
            txtDniIngreso.Name = "txtDniIngreso";
            txtDniIngreso.Size = new Size(187, 27);
            txtDniIngreso.TabIndex = 1;
            txtDniIngreso.TextAlign = HorizontalAlignment.Center;
            txtDniIngreso.TextChanged += txtDniIngreso_TextChanged;
            // 
            // lblAvisoIngreso
            // 
            lblAvisoIngreso.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAvisoIngreso.Location = new Point(104, 255);
            lblAvisoIngreso.Name = "lblAvisoIngreso";
            lblAvisoIngreso.Size = new Size(595, 94);
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
            lblDniIngrese.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniIngrese.Location = new Point(297, 106);
            lblDniIngrese.Name = "lblDniIngrese";
            lblDniIngrese.Size = new Size(208, 33);
            lblDniIngrese.TabIndex = 3;
            lblDniIngrese.Text = "INGRESE SU DNI ";
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAvisoIngreso);
            Controls.Add(lblDniIngrese);
            Controls.Add(btnIngresar);
            Controls.Add(txtDniIngreso);
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
    }
}