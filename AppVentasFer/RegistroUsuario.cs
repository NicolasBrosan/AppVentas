using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain.Autenticacion;
using Services;

namespace AppVentasFer
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Mail = txtMail.Text;
            usuario.Password = txtContraseña.Text;
            usuario.IdCliente = Guid.NewGuid();

            var validadRepetido = ValidarRepetido(usuario.Mail);
            if (validadRepetido)
            {
                MessageBox.Show("El mail ingresado ya se encuentra registrado");
                Limpiar();
            }
            else if (ValidarNulo())
            {
                var usuarioService = new UsuariosService();
                usuarioService.RegistrarUsuario(usuario);
                Limpiar();
                frmDatosCliente datosCliente = new frmDatosCliente();
                datosCliente.ShowDialog();

            }

        }

        private bool ValidarNulo()
        {
            var resultado = true;
            if (txtMail.Text == "")
            {
                resultado = false;
                MessageBox.Show("Ingrese su mail");
            }
            if (txtContraseña.Text == "")
            {
                resultado = false;
                MessageBox.Show("Ingrese su contraseña");
            }

            return resultado;
        }
        private bool ValidarRepetido(string mail)
        {
            var usuarioService = new UsuariosService();
            var usuarios = usuarioService.BuscarXMail(mail);
            var validacionDelUsuario = usuarios.Any(usuarios => usuarios.Mail == mail);

            return validacionDelUsuario;
        }
        private void Limpiar()
        {
            txtContraseña.Text = String.Empty;
            txtMail.Text = String.Empty;
        }
    }
}
