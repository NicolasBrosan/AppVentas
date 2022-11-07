using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppVentasFer
{
    public partial class frmDataLibros : Form
    {
        LibroHandler datosLibros = new LibroHandler();
        public frmDataLibros()
        {
            InitializeComponent();
        }

       
        private void Filtrar(object sender, EventArgs e)
        {

        }

        void TraerLibros()
        {
            var getLibros = new LibroHandler();
            dgvDatosLibros.DataSource = getLibros.Get();
        }

        void TraerLibros(string filtro)
        {
            dgvDatosLibros.DataSource = datosLibros.Get(filtro);
        }
    }
}
