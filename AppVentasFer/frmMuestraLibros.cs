using Data;
using Domain.Negocio;
using Services;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppVentasFer
{
    public partial class frmMuestraLibros : Form
    {
        Libro getLibro  = new Libro();
        public frmMuestraLibros()
        {
            InitializeComponent();
            TodosLosLibros();
            txtFiltro.TextChanged += Filtrar;
            dgvLibros.DoubleClick += delegadoDobleClick;
        }

        private void delegadoDobleClick(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionadas = dgvLibros.CurrentRow;
            var intCodigo = Convert.ToInt32(filaSeleccionadas.Cells["Id"].Value);
            var libroServicio = new LibrosService();
            var libroObtenido = libroServicio.ObtenerLibroPorId(intCodigo);           
            frmRegisterLibro registro = new frmRegisterLibro(libroObtenido);
            registro.StartPosition = FormStartPosition.CenterScreen;
            registro.ShowDialog();
            TodosLosLibros();
        }

        private void Filtrar (object sender, EventArgs e)
        {
            SobreCargaDeLibros(txtFiltro.Text);
        }

        void TodosLosLibros()
        {
            var traerLibros = new LibrosService();
            dgvLibros.DataSource = traerLibros.ObtenerLibros();
        }
        void SobreCargaDeLibros(string filtro)
        {
            var filtrado = new LibrosService();
            dgvLibros.DataSource = filtrado.ObtenerLibrosPorNombre(filtro);
        }
    }
}
