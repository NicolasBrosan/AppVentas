using Domain.Negocio;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVentasFer
{
    public partial class frmRegisterLibro : Form
    {
        public frmRegisterLibro(Libro libro)
        {
            InitializeComponent();
            txtCodigo.Text = libro.Id.ToString();
            txtNombre.Text = libro.Nombre;
            txtAutor.Text = libro.Autor;
            txtEditorial.Text = libro.Editorial;
            txtPrecio.Text = libro.Precio.ToString();
            txtStock.Text = libro.Stock.ToString();
            txtSinopsis.Text = libro.Sinopsis;

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Libro libro = new Libro();

            libro.Nombre = txtNombre.Text;
            libro.Autor = txtAutor.Text;
            libro.Editorial = txtEditorial.Text;
            if (decimal.TryParse(txtPrecio.Text, out var nuevoPrecio))
            {
                libro.Precio = nuevoPrecio;
            }
            if (int.TryParse(txtStock.Text, out var nuevoStock))
            {
                libro.Stock = nuevoStock;
            }

            libro.Sinopsis = txtSinopsis.Text;

            var validarRepetido = ValidarRepetido(libro.Nombre);
            if (validarRepetido)
            {
                errorGral.SetError(txtNombre, "Ya existe en la base de datos");
            }
            else
            {
                var validarCampoNulo = ValidarNulo();
                if (validarCampoNulo)
                {
                    var librosService = new LibrosService();
                    librosService.GuardarLibro(libro);
                    Limpiar();
                }
            }

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Libro libroactualizado = new Libro();

            if(int.TryParse(txtCodigo.Text, out var nuevoCodigo))
            {
                libroactualizado.Id = nuevoCodigo;
            }
            libroactualizado.Nombre = txtNombre.Text;
            libroactualizado.Autor = txtAutor.Text;
            libroactualizado.Editorial = txtEditorial.Text;
            if (decimal.TryParse(txtPrecio.Text, out var precioactualizado))
            {
                libroactualizado.Precio = precioactualizado;
            }
            if (int.TryParse(txtStock.Text, out var stockactualizado))
            {
                libroactualizado.Stock = stockactualizado;
            }

            libroactualizado.Sinopsis = txtSinopsis.Text;

            var validarCampoNulo = ValidarNulo();
            if (validarCampoNulo)
            {
                var libroService = new LibrosService();
                libroService.ActualizarLibro(libroactualizado);
                Limpiar();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Libro libroEliminado = new Libro();
            if (int.TryParse(txtCodigo.Text, out var nuevoCodigo))
            {
                libroEliminado.Id = nuevoCodigo;
            }

            var validarCampoNulo = ValidarNulo();
            if (validarCampoNulo)
            {
                var libroService = new LibrosService();
                libroService.EliminarLibro(libroEliminado);
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
                errorGral.SetError(txtNombre, "Ingresar un nombre");
            }
            if (txtAutor.Text == "")
            {
                validar = false;
                errorGral.SetError(txtAutor, "Ingresar un autor");
            }
            if (txtEditorial.Text == "")
            {
                validar = false;
                errorGral.SetError(txtEditorial, "Ingresar una editorial");
            }
            if (txtPrecio.Text == "")
            {
                validar = false;
                errorGral.SetError(txtPrecio, "Ingresar el monto");
            }
            if (txtStock.Text == "")
            {
                validar = false;
                errorGral.SetError(txtStock, "Ingresar el stock");
            }
            if (txtSinopsis.Text == "")
            {
                validar = false;
                errorGral.SetError(txtSinopsis, "Ingresar descripcion");
            }
            return validar;
        }

        private bool ValidarRepetido(string nombre)
        {

            var libroService = new LibrosService();
            var libros = libroService.ObtenerLibrosPorNombre(nombre);
            var validacionDeLibro = libros.Any(libros => libros.Nombre == nombre);

            return validacionDeLibro;
        }

    }
}
