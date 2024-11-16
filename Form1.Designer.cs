namespace pryAccesoGym
{
    partial class frmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            lblContraseña = new Label();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(362, 251);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(159, 48);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // lblContraseña
            // 
            lblContraseña.Anchor = AnchorStyles.Right;
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(175, 201);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(156, 38);
            lblContraseña.TabIndex = 7;
            lblContraseña.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Anchor = AnchorStyles.None;
            txtContrasena.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(350, 199);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(183, 43);
            txtContrasena.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(350, 140);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(183, 43);
            txtUsuario.TabIndex = 8;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(220, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(111, 38);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(lblContraseña);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "frmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblContraseña;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label lblUsuario;
    }
}
