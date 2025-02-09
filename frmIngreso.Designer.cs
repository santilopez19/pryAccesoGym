﻿namespace pryAccesoGym
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(615, 379);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(163, 59);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtDniIngreso
            // 
            txtDniIngreso.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDniIngreso.Location = new Point(512, 310);
            txtDniIngreso.Margin = new Padding(3, 2, 3, 2);
            txtDniIngreso.Multiline = true;
            txtDniIngreso.Name = "txtDniIngreso";
            txtDniIngreso.Size = new Size(368, 56);
            txtDniIngreso.TabIndex = 1;
            txtDniIngreso.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAvisoIngreso
            // 
            lblAvisoIngreso.BackColor = Color.Transparent;
            lblAvisoIngreso.BorderStyle = BorderStyle.Fixed3D;
            lblAvisoIngreso.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAvisoIngreso.Location = new Point(297, 440);
            lblAvisoIngreso.Name = "lblAvisoIngreso";
            lblAvisoIngreso.Size = new Size(798, 117);
            lblAvisoIngreso.TabIndex = 2;
            lblAvisoIngreso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tLbl
            // 
            tLbl.Interval = 10000;
            tLbl.Tick += tLbl_Tick;
            // 
            // lblDniIngrese
            // 
            lblDniIngrese.AutoSize = true;
            lblDniIngrese.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblDniIngrese.ForeColor = Color.Black;
            lblDniIngrese.Location = new Point(489, 243);
            lblDniIngrese.Name = "lblDniIngrese";
            lblDniIngrese.Size = new Size(414, 65);
            lblDniIngrese.TabIndex = 3;
            lblDniIngrese.Text = "INGRESE SU DNI ";
            // 
            // lblAnuncio
            // 
            lblAnuncio.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnuncio.ForeColor = SystemColors.ActiveCaptionText;
            lblAnuncio.Location = new Point(27, 28);
            lblAnuncio.Name = "lblAnuncio";
            lblAnuncio.Size = new Size(462, 347);
            lblAnuncio.TabIndex = 4;
            lblAnuncio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__1_;
            pictureBox1.Location = new Point(440, -50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1472, 715);
            Controls.Add(lblAnuncio);
            Controls.Add(lblAvisoIngreso);
            Controls.Add(lblDniIngrese);
            Controls.Add(btnIngresar);
            Controls.Add(txtDniIngreso);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmIngreso";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            Load += frmIngreso_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}