using Domain.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppVentasFer
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void registrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterLibro frmRegistarLibro = new frmRegisterLibro();
            frmRegistarLibro.ShowDialog();
        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDatosCliente frmDatosCliente = new frmDatosCliente();
            frmDatosCliente.ShowDialog();
        }
    }
}
