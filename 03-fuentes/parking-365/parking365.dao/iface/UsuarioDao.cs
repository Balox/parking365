using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parking365.domain;

namespace parking365.dao.iface {
  public interface UsuarioDao {
    Usuario obtenerUsuario(string username);
    List<Usuario> listar(string username);
    bool emailExiste(string email);
    bool usuarioExiste(string username);
    int insertar(Usuario usuario);
    bool actualizar(Usuario usuario);
    bool eliminar(int idusuario,int idusuariocre);
  }
}
