using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parking365.dao.iface;
using parking365.dao.impl;
using Npgsql;

namespace parking365.dao {
  public class ConfigurationDao {

    public UsuarioDao usuarioDao (NpgsqlConnection conexion) {
      UsuarioDaoImpl usuarioDaoImpl = new UsuarioDaoImpl();
      usuarioDaoImpl.cn = conexion;

      return usuarioDaoImpl;
    }

    public ClienteDao clienteDao(NpgsqlConnection conexion) {
      ClienteDaoImpl clienteDaoImpl = new ClienteDaoImpl();
      clienteDaoImpl.cn = conexion;

      return clienteDaoImpl;
    }
  }
}
