﻿using Data;
using Domain.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class UsuariosService
    {
        UsuarioHandler usuarioHandler = new UsuarioHandler();
        public void RegistrarUsuario(Usuario usuario)
        {
            usuarioHandler.RegistrarUsuario(usuario);
        }

        public bool LoginUsuario(string mail, string pass)
        {
            return usuarioHandler.LoginUsuario(mail, pass);
        }
        public List<Usuario> BuscarPorMail(string usuarioRepetido)
        {
            var usuario = usuarioHandler.Get();
            var resultado = usuario.Where(usuario => usuario.Mail.Contains(usuarioRepetido));

            return resultado.ToList();
        }

    }
}
