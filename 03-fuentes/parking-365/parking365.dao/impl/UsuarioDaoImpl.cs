using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parking365.dao.iface;
using parking365.domain;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
using NpgsqlTypes;

namespace parking365.dao.impl {
  public class UsuarioDaoImpl : UsuarioDao {

    public NpgsqlConnection cn { get; set; }

    public Usuario obtenerUsuario(string username) {
      Usuario usuario = null;
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_obtener_usuario";
        cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = username;
        NpgsqlDataReader reader = cmd.ExecuteReader();

        if(reader.HasRows) {
          reader.Read();

          usuario = new Usuario();
          usuario.idusuario = Convert.ToInt32(reader["idusuario"]);
          usuario.idperfil = Convert.ToInt32(reader["idperfil"]);
          usuario.perfil = Convert.ToString(reader["perfil"]);
          // usuario.idzonahoraria = Convert.ToInt32(reader["idzonahoraria"]);
          // usuario.zonahoraria = Convert.ToString(reader["zonahoraria"]);
          // usuario.utc_offset = (TimeSpan)reader["utc_offset"];
          usuario.nombrecompleto = Convert.ToString(reader["nombrecompleto"]);
          usuario.email = Convert.ToString(reader["email"]);
          usuario.telefono = Convert.ToString(reader["telefono"]);
          usuario.sexo = Convert.ToString(reader["sexo"]);
          usuario.usuario = Convert.ToString(reader["usuario"]);
          usuario.clave = Convert.ToString(reader["clave"]);
          usuario.saltsecret = Convert.ToString(reader["saltsecret"]);
          // usuario.diascaducidadclave = Convert.ToInt32(reader["diascaducidadclave"]);
          // usuario.fechaexpiracion = Convert.ToString(reader["fechaexpiracion"]);
          // usuario.fechacambioclave = Convert.ToString(reader["fechacambioclave"]);
          // usuario.idtipopregunta = Convert.ToInt32(reader["idtipopregunta"]);
          // usuario.respuestapregunta = Convert.ToString(reader["respuestapregunta"]);
          // usuario.modoconexion = Convert.ToString(reader["modoconexion"]);
          // usuario.token = Convert.ToString(reader["token"]);
          // usuario.tokengoogle = Convert.ToString(reader["tokengoogle"]);
          usuario.estadoregistro = Convert.ToString(reader["estadoregistro"]);
        }

        return usuario;
      } catch(Exception ex) {
        throw ex;
      }
    }

    public List<Usuario> listar(string username) {
      List<Usuario> usuarios = new List<Usuario>();
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_usuarios_listar";
     
        if (username == null) {
          cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = username;
        }
        NpgsqlDataReader reader = cmd.ExecuteReader();

        while(reader.Read()) {
          usuarios.Add(
            new Usuario(
              Convert.ToInt32(reader["item"]),
              Convert.ToInt32(reader["idusuario"]),
              Convert.ToInt32(reader["idperfil"]),
              Convert.ToString(reader["perfil"]),
              Convert.ToString(reader["nombrecompleto"]),
              Convert.ToString(reader["email"]),
              Convert.ToString(reader["telefono"]),
              Convert.ToString(reader["sexo"]),
              Convert.ToString(reader["usuario"]),
              Convert.ToString(reader["clave"]),
              Convert.ToString(reader["saltsecret"]),
              Convert.ToString(reader["estadoregistro"])));
        }

        return usuarios;
      } catch(Exception ex) {
        throw ex;
      }
    }

    public bool emailExiste(string email) {      
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_correo_existe";
        if(email == null) {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = email;
        }        

        return Convert.ToBoolean(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public bool usuarioExiste(string username) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_usuario_existe";
        if(username == null) {
          cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = username;
        }

        return Convert.ToBoolean(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public int insertar(Usuario usuario) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_usuario_insertar";
        cmd.Parameters.Add("@in_idperfil",NpgsqlDbType.Integer).Value = usuario.idperfil;
        cmd.Parameters.Add("@in_nombrecompleto",NpgsqlDbType.Varchar).Value = usuario.nombrecompleto;
        if(usuario.email == null) {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = usuario.email;
        }
        if(usuario.telefono == null) {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = usuario.telefono;
        }
        cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = usuario.usuario;
        cmd.Parameters.Add("@in_clave",NpgsqlDbType.Varchar).Value = usuario.clave;
        cmd.Parameters.Add("@in_idusuario",NpgsqlDbType.Integer).Value = usuario.idusuariocrea;
        
        return Convert.ToInt32(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public bool actualizar(Usuario usuario) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_usuario_actualizar";
        cmd.Parameters.Add("@in_idusuario",NpgsqlDbType.Integer).Value = usuario.idusuario;
        cmd.Parameters.Add("@in_idperfil",NpgsqlDbType.Integer).Value = usuario.idperfil;
        cmd.Parameters.Add("@in_nombrecompleto",NpgsqlDbType.Varchar).Value = usuario.nombrecompleto;
        if(usuario.email == null) {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = usuario.email;
        }
        if(usuario.telefono == null) {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = usuario.telefono;
        }
        cmd.Parameters.Add("@in_usuario",NpgsqlDbType.Varchar).Value = usuario.usuario;
        cmd.Parameters.Add("@in_clave",NpgsqlDbType.Varchar).Value = usuario.clave;
        cmd.Parameters.Add("@in_idusuarioupdate",NpgsqlDbType.Integer).Value = usuario.idusuariocrea;
        
        return Convert.ToBoolean(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public bool eliminar(int idusuario,int idusuariocre) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_usuario_eliminar";
        cmd.Parameters.Add("@in_idusuario",NpgsqlDbType.Integer).Value = idusuario;
        cmd.Parameters.Add("@in_idusuarioupdate",NpgsqlDbType.Integer).Value = idusuariocre;

        return Convert.ToBoolean(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }
  }
}
