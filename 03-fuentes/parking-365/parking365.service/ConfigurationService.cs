using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parking365.service.iface;
using parking365.service.impl;

namespace parking365.service {
  public class ConfigurationService {
    public ConfigurationService() { }

    public UsuarioService usuarioService() {
      UsuarioServiceImpl usuarioServiceImpl = new UsuarioServiceImpl();

      return usuarioServiceImpl;
    }

    public ClienteService clienteService() {
      ClienteServiceImpl clienteServiceImpl = new ClienteServiceImpl();

      return clienteServiceImpl;
    }
  }
}
