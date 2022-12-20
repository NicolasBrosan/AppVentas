using Domain.Autenticacion;
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
    public partial class frmLoginUsuarios : Form
    {
        public frmLoginUsuarios()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuarioLogin = new Usuario();
            usuarioLogin.Mail = txtMailLogin.Text;
            usuarioLogin.Password = txtContraseñaLogin.Text;

            ValidarNulo();
            if (ValidarNulo())
            {
                var usuarioService = new UsuariosService();
                var log = usuarioService.LoginUsuario(usuarioLogin.Mail, usuarioLogin.Password);

                Limpiar();
                if (!log)
                {
                    MessageBox.Show("Los datos no se encuentran registrados. Por favor, hacer click en 'Registrarse' para acceder.");
                }
                else
                {
                    frmDatosCliente cliente = new frmDatosCliente();
                    cliente.Show();
                }


            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Mail = txtMailLogin.Text;
            usuario.Password = txtContraseñaLogin.Text;
            usuario.IdCliente = Guid.NewGuid();

            var datosRepetidos = ValidarRepetido(usuario.Mail);
            if (datosRepetidos)
            {
                MessageBox.Show("El mail ingresado ya se encuentra registrado");
                Limpiar();
            }
            else if (ValidarEmpty(txtMailLogin.Text, "Ingrese su mail"))
            {
                Limpiar();
            }
            else if (ValidarEmpty(txtContraseñaLogin.Text, "Ingrese su contraseña") == false)
            {
                var usuarioService = new UsuariosService();
                usuarioService.RegistrarUsuario(usuario);
                Limpiar();
                frmDatosCliente datosCliente = new frmDatosCliente();
                datosCliente.Usuario = usuario;
                datosCliente.Show();

                this.Hide();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarEmpty(string txtForm, string message)
        {
            if (txtForm == string.Empty)
            {
                MessageBox.Show(message);
                return true;
            }

            return false;
        }
        private bool ValidarNulo()
        {
            var resultado = true;
            if (txtMailLogin.Text == "")
            {
                resultado = false;
                MessageBox.Show("Ingrese su mail");
            }
            if (txtContraseñaLogin.Text == "")
            {
                resultado = false;
                MessageBox.Show("Ingrese su contraseña");
            }

            return resultado;
        }
        private void Limpiar()
        {
            txtContraseñaLogin.Text = string.Empty;
            txtMailLogin.Text = string.Empty;
        }
        private bool ValidarRepetido(string mail)
        {
            var usuarioService = new UsuariosService();
            var usuarios = usuarioService.BuscarPorMail(mail);
            var validacionDelUsuario = usuarios.Any(usuarios => usuarios.Mail == mail);

            return validacionDelUsuario;
        }

    }
}
