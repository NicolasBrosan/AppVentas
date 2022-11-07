using Data;
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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.Autor = txtAutor.Text;
            libro.Editorial = txtEditorial.Text;
            libro.Precio = Convert.ToDecimal(txtPrecio.Text);
            libro.Stock = Convert.ToInt32(txtStock.Text);
            libro.Sinopsis = txtSinopsis.Text;

            var librosService = new LibrosService();
            librosService.GuardarLibro(libro);

            //Ver codigo para que no pueda guardar la info si hay
            //algun dato nulo.
            if(libro != null)
            {
                Limpiar();
            }
            else
            {
                Console.WriteLine("Error al ingresar datos del libro");
            }
            
        }

        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtAutor.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtSinopsis.Text = string.Empty;
            txtStock.Text = string.Empty;
        }
    }
}
