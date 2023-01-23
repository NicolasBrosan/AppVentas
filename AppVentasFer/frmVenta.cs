using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain.Negocio;

namespace AppVentasFer
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            var serviceVenta = new VentaService();
            dgvMuestrarioLibros.DataSource = serviceVenta.MostrarLibros();
            
            
        }

    }
}
