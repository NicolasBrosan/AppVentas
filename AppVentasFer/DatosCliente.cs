using Domain.Autenticacion;
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
    public partial class frmDatosCliente : Form
    {
        public frmDatosCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            
            cliente.Id = Guid.NewGuid();// averiguar como copiar el mismo código que IdCliente de la clase Usuario
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            if (int.TryParse(txtTelefono.Text, out var nuevoTelefono))
            {
                cliente.Telefono = nuevoTelefono;
            }
            cliente.Direccion = txtDireccion.Text;
            cliente.Localidad = txtLocalidad.Text;
            cliente.Provincia = txtProvincia.Text;
            if (int.TryParse(txtTarjeta.Text, out var nuevaTarjeta))
            {
                cliente.Tarjeta = nuevaTarjeta;
            }

            var clienteService = new ClienteService();
            clienteService.GuardarCliente(cliente);
        }
    }
}
