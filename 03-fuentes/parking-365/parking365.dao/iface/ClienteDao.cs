using System;
using System.Collections.Generic;
using parking365.domain;

namespace parking365.dao.iface {
  public interface ClienteDao {
    List<Cliente> listar(string documento);
    Int64 insertar(Cliente usuario);
    bool actualizar(Cliente usuario);
    bool eliminar(Int64 idcliente,int idusuariocre);
  }
}
