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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var libro = new Libro();
            libro.Nombre = txtNombre.Text;
            libro.Autor = txtAutor.Text;
            libro.Editorial = txtEditorial.Text;
            libro.Precio = Convert.ToDecimal(txtPrecio.Text);
            libro.Stock = Convert.ToInt32(txtStock.Text);
            libro.Sinopsis = txtSinopsis.Text;

            ValidarNulo();

            var insertarEnBD = ValidarNulo();
            if (insertarEnBD)
            {
                var librosService = new LibrosService();
                librosService.GuardarLibro(libro);
                Limpiar();
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

        private bool ValidarNulo()
        {
            bool validar = true;
            if (txtNombre.Text == "")
            {
                validar = false;
                errorNombre.SetError(txtNombre, "Ingresar un nombre");
            }
            if (txtAutor.Text == "")
            {
                validar = false;
                errorNombre.SetError(txtAutor, "Ingresar un autor");
            }
            if (txtEditorial.Text == "")
            {
                validar = false;
                errorNombre.SetError(txtEditorial, "Ingresar una editorial");
            }
            if (txtPrecio.Text == "")
            {
                validar = false;
                errorNombre.SetError(txtPrecio, "Ingresar el monto");
            }
            if (txtStock.Text == "")
            {
                validar = false;
                errorNombre.SetError(txtStock, "Ingresar el stock");
            }
            if (txtSinopsis.Text == "")
            {
                validar = false;
                errorNombre.SetError(txtSinopsis, "Ingresar descripcion");
            }
            return validar;
        }

        private void tlpRegistro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
