using System;
using System.Collections.Generic;
using Npgsql;
using parking365.common;
using parking365.domain;
using parking365.dao;
using parking365.service.iface;

namespace parking365.service.impl {
  public class ClienteServiceImpl : ClienteService {

    ConfigurationDao dao = new ConfigurationDao();
    private string connectionString = DataBase.ConnectionString;

    public List<Cliente> listar(string documento) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          return dao.clienteDao(cn).listar(documento.Length == 0 ? null : documento);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public bool insertar(Cliente cliente) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {          
          return (dao.clienteDao(cn).insertar(cliente) > 0);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public bool actualizar(Cliente cliente) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          return dao.clienteDao(cn).actualizar(cliente);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }

    public bool eliminar(Int64 idcliente,int idusuariocre) {
      using(NpgsqlConnection cn = new NpgsqlConnection(connectionString)) {
        cn.Open();
        try {
          return dao.clienteDao(cn).eliminar(idcliente,idusuariocre);
        } catch(Exception exp) {
          throw exp;
        }
      }
    }
  } 
}
