    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace pryAccesoGym
    {
        public partial class frmClientes : Form
        {
            public frmClientes()
            {
                InitializeComponent();
                this.KeyPreview = true;
                this.KeyDown += VolverPagina_KeyDown;
            }

            private void frmClientes_Load(object sender, EventArgs e)
            {

            }
            private void VolverPagina_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Show();
                    this.Hide();
                }
            }
        }
    }
