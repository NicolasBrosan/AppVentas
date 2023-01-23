using Domain.Negocio;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppVentasFer
{
    public partial class frmMuestrarioDeLibros : Form
    {
        public frmMuestrarioDeLibros()
        {
            InitializeComponent();
        }

        private void frmMuestrarioDeLibros_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarLibros();
        }
        private void dgvNuestrario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvMuestrario.CurrentRow;
            int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            //int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            var libroSeleccionado = new LibrosService();
            var unLibro = libroSeleccionado.ObtenerLibroPorId(id);
            frmRegisterLibro infoLibro = new frmRegisterLibro(unLibro)
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            infoLibro.ShowDialog();
            MostrarLibros();
        }
        private void MostrarLibros()
        {
            var muestraDeLibros = new LibrosService();
            dgvMuestrario.DataSource = muestraDeLibros.ObtenerLibrosPorNombre(txtFiltro.Text);
        }
    }
}
