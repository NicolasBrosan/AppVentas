using Domain.Autenticacion;
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
                usuarioService.LoginUsuario(usuarioLogin.Mail, usuarioLogin.Password);
                //if(usuarioService is )
                Limpiar();
                frmDatosCliente cliente = new frmDatosCliente();
                cliente.Show();

            }

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
    }
}
