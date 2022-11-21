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

            ValidarNulo(); //// NO SE USA
            if (ValidarNulo())/// negarlo para que tenga sentido !ValidarNulo = No es nulo 
            {
                var usuarioService = new UsuariosService();
                usuarioService.LoginUsuario(usuarioLogin.Mail, usuarioLogin.Password);
                Limpiar();

            }

        }


        private bool ValidarNulo() //// este codigo se puede mejorar 
        {
            var resultado = true; //// true indicaria que es nulo, deberia decir false y las otras condiciones true

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

        //ejemplo mejora:
        // SALIDA DE METODO VALIDAR NULO
        // return ValidarTexto(txtMailLogin.Text, "Ingrese su mail") ? true : ValidarTexto(txtContraseñaLogin.Text, "Ingrese su contraseña") 

        //private bool ValidarTexto(string txtForm, string message)
        //{
        //    if (txtForm == string.Empty)
        //    {
        //        MessageBox.Show(message);
        //        return true;
        //    }
        // return false;
        //}

        private void Limpiar()
        {
            txtContraseñaLogin.Text = String.Empty; //// no usar String, deberias usar string
            txtMailLogin.Text = String.Empty;
        }
    }
}
