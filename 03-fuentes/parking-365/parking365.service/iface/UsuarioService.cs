using System.ComponentModel;
using parking365.domain;


namespace parking365.service.iface {
  public interface UsuarioService {
    Usuario Login (string username,string password);
    bool compararclave(string password,string salt,string hash);
    BindingList<Usuario> listar(string username);
    BindingList<Perfil> listarPerfiles();
    bool insertar(Usuario usuario);
    bool actualizar(Usuario usuario, string emailOld, string usernameOld);
    bool eliminar(int idusuario,int idusuariocre);
  }
}
