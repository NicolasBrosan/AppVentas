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
            MostrarLibrosFiltrados();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarLibrosFiltrados();
        }
        private void dgvNuestrario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvMuestrario.CurrentRow;
            var id = int.TryParse(filaSeleccionada.Cells["id"].Value.ToString(), out var resultado);//Saltea esta línea
            var libroSeleccionado = new LibrosService();
            var unLibro = libroSeleccionado.ObtenerLibroPorId(resultado);
            frmRegisterLibro infoLibro = new frmRegisterLibro(unLibro);//Saltea esta línea
            infoLibro.ShowDialog();//No muestra los datos solicitados
            MostrarLibros();



        }
        private void MostrarLibrosFiltrados()
        {
            var librosFiltrados = new LibrosService();
            dgvMuestrario.DataSource = librosFiltrados.ObtenerLibrosPorNombre(txtFiltro.Text);
        }
        private void MostrarLibros()
        {
            var todosLosLibros = new LibrosService();
            dgvMuestrario.DataSource = todosLosLibros.ObtenerLibros();
        }
    }
}
