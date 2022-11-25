using Domain.Autenticacion;
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
    public partial class frmDatosCliente : Form
    {
        public frmDatosCliente()
        {
            InitializeComponent();
        }

        public Usuario Usuario { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = Usuario.IdCliente;
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;           
            cliente.Direccion = txtDireccion.Text;
            cliente.Localidad = txtLocalidad.Text;
            cliente.Provincia = txtProvincia.Text;
            if (int.TryParse(txtTelefono.Text, out var nuevoTelefono))
            {
                cliente.Telefono = nuevoTelefono;
            }
            if (long.TryParse(txtTarjeta.Text, out var nuevaTarjeta))
            {
                cliente.Tarjeta = nuevaTarjeta;
            }

            var dniRepetido = ClienteRepetido(cliente.Id);
            if (dniRepetido)
            {
                MessageBox.Show("Cliente ya existente");
            }
            else
            {
                var clienteService = new ClienteService();
                clienteService.GuardarCliente(cliente);
                
            }

            

        }

        private bool ClienteRepetido(Guid id)
        {
            #region Comentarios de lo que necesitaba
            // se necesita ingresar DNI a las properties de Cliente para poder validar datos repetidos,
            // dado que tanto Nombre y Apellido se pueden repetir.
            #endregion
            var clienteService = new ClienteService();
            var clientes = clienteService.BuscarXDNI(id);
            var valorRepetido = clientes.Any(clientes => clientes.Id == id);
            return valorRepetido;
        }
    }
}
