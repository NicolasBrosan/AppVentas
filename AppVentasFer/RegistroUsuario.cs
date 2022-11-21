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
            else if (ValidarNulo(txtMail.Text, "Sin ingresar datos"))
            {
                var usuarioService = new UsuariosService();
                usuarioService.RegistrarUsuario(usuario);
                Limpiar();
                frmDatosCliente datosCliente = new frmDatosCliente();
                datosCliente.Usuario = usuario;
                datosCliente.ShowDialog();

            }

        }

        private bool ValidarNulo(string txtForm, string message)
        {
            #region CodigoUno
            //var resultado = true;
            //if (txtMail.Text == "")
            //{
            //    resultado = false;
            //    MessageBox.Show("Ingrese su mail");
            //}
            //if (txtContraseña.Text == "")
            //{
            //    resultado = false;
            //    MessageBox.Show("Ingrese su contraseña");
            //}

            //return resultado;
            #endregion

            if(txtForm == string.Empty)
            {
                MessageBox.Show(message);
                return true;
            }

            return false;
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
            txtContraseña.Text = string.Empty;
            txtMail.Text = string.Empty;
        }
    }
}
