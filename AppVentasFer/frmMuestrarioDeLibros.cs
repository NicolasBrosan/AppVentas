using Domain.Negocio;
using Services;
using System.Linq;
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
        private readonly frmRegisterLibro frmRegisterLibro;
        public frmMuestrarioDeLibros()
        {
            frmRegisterLibro = new frmRegisterLibro();
            InitializeComponent();
        }

        private void frmMuestrarioDeLibros_Load(object sender, EventArgs e)
        {
            MostrarLibros();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarLibrosFiltrados();
        }        
        
        private void dgvTodosLosLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSeleccionada = dgvTodosLosLibros.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            var libroService = new LibrosService();
            int.TryParse(filaSeleccionada, out int id);
            Libro libro = libroService.ObtenerLibroPorId(id);
            frmRegisterLibro.cargarDatosLibro(libro);
            frmRegisterLibro.ShowDialog();
        }

        private void MostrarLibrosFiltrados()
        {
            var librosFiltrados = new LibrosService();
            dgvTodosLosLibros.DataSource = librosFiltrados.ObtenerLibrosPorNombre(txtFiltro.Text);
        }
        private void MostrarLibros()
        {
            var todosLosLibros = new LibrosService();
            dgvTodosLosLibros.DataSource = todosLosLibros.ObtenerLibros();
        }

    }
}
