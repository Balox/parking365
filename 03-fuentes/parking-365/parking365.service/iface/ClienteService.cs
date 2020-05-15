using System;
using System.Collections.Generic;
using parking365.domain;


namespace parking365.service.iface {
  public interface ClienteService {
    List<Cliente> listar(string documento);
    bool insertar(Cliente cliente);
    bool actualizar(Cliente cliente);
    bool eliminar(Int64 idcliente,int idusuariocre);
  }
}
