using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using NpgsqlTypes;
using parking365.dao.iface;
using parking365.domain;


namespace parking365.dao.impl {
  public class ClienteDaoImpl : ClienteDao {
    public NpgsqlConnection cn { get; set; }

    public bool actualizar(Cliente cliente) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_cliente_actualizar";

        cmd.Parameters.Add("@in_idcliente",NpgsqlDbType.Bigint).Value = cliente.idcliente;
        cmd.Parameters.Add("@in_idtipocliente",NpgsqlDbType.Integer).Value = cliente.idtipocliente;
        cmd.Parameters.Add("@in_idtipodocumento",NpgsqlDbType.Integer).Value = cliente.idtipodocumento;
        cmd.Parameters.Add("@in_documento",NpgsqlDbType.Varchar).Value = cliente.documento;
        cmd.Parameters.Add("@in_nombre",NpgsqlDbType.Varchar).Value = cliente.nombre;

        if(cliente.representante == null) {
          cmd.Parameters.Add("@in_representante",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_representante",NpgsqlDbType.Varchar).Value = cliente.representante;
        }
        if(cliente.telefono == null) {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = cliente.telefono;
        }
        if(cliente.email == null) {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = cliente.email;
        }
        if(cliente.observacion == null) {
          cmd.Parameters.Add("@in_observacion",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_observacion",NpgsqlDbType.Varchar).Value = cliente.observacion;
        }
        cmd.Parameters.Add("@in_idusuario",NpgsqlDbType.Integer).Value = cliente.idusuariocrea;

        return Convert.ToBoolean(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public bool eliminar(Int64 idcliente,int idusuariocre) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_cliente_eliminar";
        cmd.Parameters.Add("@in_idcliente",NpgsqlDbType.Bigint).Value = idcliente;
        cmd.Parameters.Add("@in_idusuarioupdate",NpgsqlDbType.Integer).Value = idusuariocre;

        return Convert.ToBoolean(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public Int64 insertar(Cliente cliente) {
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_cliente_insertar";

        cmd.Parameters.Add("@in_idtipocliente",NpgsqlDbType.Integer).Value = cliente.idtipocliente;
        cmd.Parameters.Add("@in_idtipodocumento",NpgsqlDbType.Integer).Value = cliente.idtipodocumento;
        cmd.Parameters.Add("@in_documento",NpgsqlDbType.Varchar).Value = cliente.documento;
        cmd.Parameters.Add("@in_nombre",NpgsqlDbType.Varchar).Value = cliente.nombre;

        if(cliente.representante == null) {
          cmd.Parameters.Add("@in_representante",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_representante",NpgsqlDbType.Varchar).Value = cliente.representante;
        }
        if(cliente.telefono == null) {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_telefono",NpgsqlDbType.Varchar).Value = cliente.telefono;
        }
        if(cliente.email == null) {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_email",NpgsqlDbType.Varchar).Value = cliente.email;
        }
        if(cliente.observacion == null) {
          cmd.Parameters.Add("@in_observacion",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_observacion",NpgsqlDbType.Varchar).Value = cliente.observacion;
        }
        cmd.Parameters.Add("@in_idusuario",NpgsqlDbType.Integer).Value = cliente.idusuariocrea;
       
        return Convert.ToInt64(cmd.ExecuteScalar());
      } catch(Exception ex) {
        throw ex;
      }
    }

    public List<Cliente> listar(string documento) {
      List<Cliente> clientes = new List<Cliente>();
      try {
        NpgsqlCommand cmd = new NpgsqlCommand();
        cmd.Connection = cn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "admin.fn_desktop_cliente_listar";

        if(documento == null) {
          cmd.Parameters.Add("@in_documento",NpgsqlDbType.Varchar).Value = DBNull.Value;
        } else {
          cmd.Parameters.Add("@in_documento",NpgsqlDbType.Varchar).Value = documento;
        }
        NpgsqlDataReader reader = cmd.ExecuteReader();

        while(reader.Read()) {
          clientes.Add(
            new Cliente(
              Convert.ToInt32(reader["item"]),
              Convert.ToInt64(reader["idcliente"]),
              Convert.ToInt32(reader["idtipocliente"]),
              Convert.ToString(reader["tipocliente"]),
              Convert.ToInt32(reader["idtipodocumento"]),
              Convert.ToString(reader["tipodocumento"]),
              Convert.ToString(reader["documento"]),
              Convert.ToString(reader["nombre"]),
              Convert.ToString(reader["representante"]),
              Convert.ToString(reader["telefono"]),
              Convert.ToString(reader["email"]),
              Convert.ToString(reader["observacion"]),
              Convert.ToString(reader["estadoregistro"]),
              Convert.ToInt32(reader["vehiculos"])));
        }

        return clientes;
      } catch(Exception ex) {
        throw ex;
      }
    }
  }
}
