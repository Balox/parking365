using System;
using System.Security.Cryptography;
using System.ComponentModel;
using parking365.domain;
using parking365.service.iface;
using parking365.dao;
using parking365.dao.iface;
using parking365.common;
using Npgsql;
using System.Collections.Generic;

namespace parking365.service.impl {
  public class UsuarioServiceImpl : UsuarioService {

    ConfigurationDao dao = new ConfigurationDao();
    private string connectionString = DataBase.ConnectionString;

    public Usuario Login(string username,string password) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        Usuario usuario = null;
        try {
          UsuarioDao usuarioDao = dao.usuarioDao(cn);
          usuario = usuarioDao.obtenerUsuario(username);

          if(usuario == null) {
            new Exception("Credenciales incorrectas.");
          }

          if(!compararclave(password,usuario.saltsecret,usuario.clave)) {
            new Exception("Credenciales incorrectas.");
          }

          return usuario;
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public bool compararclave(string password,string salt,string hash) {
      using(MD5 md5 = MD5.Create()) {
        string data = Global.GetMd5Hash(md5,String.Concat(password,salt));

        if(data == hash)
          return true;
        else
          return false;
      }
    }

    public BindingList<Usuario> listar(string username) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          UsuarioDao usuarioDao = dao.usuarioDao(cn);

          return new BindingList<Usuario>(usuarioDao.listar(username.Length == 0 ? null : username));
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public BindingList<Perfil> listarPerfiles() {
      List<Perfil> perfiles = new List<Perfil>();
      try {

        perfiles.Add(new Perfil(0,"SELECCIONAR"));
        perfiles.Add(new Perfil(1,"ADMINISTRADOR"));
        perfiles.Add(new Perfil(2,"OPERADOR"));

        return new BindingList<Perfil>(perfiles);
      } catch(Exception ex) {
        throw ex;
      }
    }

    public bool insertar(Usuario usuario) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          UsuarioDao usuarioDao = dao.usuarioDao(cn);

          if(usuarioDao.usuarioExiste(usuario.usuario))
            throw new Exception("El nombre de usuario ya existe.");

          usuario.email = (usuario.email.Equals(string.Empty)) ? null : usuario.email;
          if(usuarioDao.emailExiste(usuario.email))
            throw new Exception("Correo ya existe.");

          return (usuarioDao.insertar(usuario) > 0);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public bool actualizar(Usuario usuario,string emailOld,string usernameOld) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          UsuarioDao usuarioDao = dao.usuarioDao(cn);

          if(!usuario.usuario.Equals(usernameOld)) {
            if(usuarioDao.usuarioExiste(usuario.usuario))
              throw new Exception("El nombre de usuario ya existe.");
          }
          
          if(!usuario.email.Equals(emailOld)) {
            usuario.email = (usuario.email.Equals(string.Empty)) ? null : usuario.email;
            if(usuarioDao.emailExiste(usuario.email))
              throw new Exception("Correo ya existe.");
          } else {
            usuario.email = (usuario.email.Equals(string.Empty)) ? null : usuario.email;
          }

          return usuarioDao.actualizar(usuario);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public bool eliminar(int idusuario,int idusuariocre) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          UsuarioDao usuarioDao = dao.usuarioDao(cn);
          
          if (idusuario == Global.IDADMIN) {
            throw new Exception("No se puede eliminar al Super Admin");
          }

          return usuarioDao.eliminar(idusuario,idusuariocre);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }
  }
}
