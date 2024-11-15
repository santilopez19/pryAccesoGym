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
            btnIngresar = new Button();
            txtDniIngreso = new TextBox();
            lblAvisoIngreso = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(332, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(160, 39);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtDniIngreso
            // 
            txtDniIngreso.Location = new Point(320, 172);
            txtDniIngreso.Name = "txtDniIngreso";
            txtDniIngreso.Size = new Size(187, 27);
            txtDniIngreso.TabIndex = 1;
            txtDniIngreso.Text = "Ingrese su DNI aqui";
            txtDniIngreso.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAvisoIngreso
            // 
            lblAvisoIngreso.AutoSize = true;
            lblAvisoIngreso.Location = new Point(377, 315);
            lblAvisoIngreso.Name = "lblAvisoIngreso";
            lblAvisoIngreso.Size = new Size(57, 20);
            lblAvisoIngreso.TabIndex = 2;
            lblAvisoIngreso.Text = "Ingrese";
            lblAvisoIngreso.Click += lblAvisoIngreso_Click;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAvisoIngreso);
            Controls.Add(txtDniIngreso);
            Controls.Add(btnIngresar);
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
    }
}