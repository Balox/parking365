using System.ComponentModel;
using parking365.common;
using parking365.domain;

namespace parking_365_app.util {
  public class DataMemory : BaseNotifyPropertyChange {

    private BindingList<Usuario> _listaUsuario;

    public DataMemory() {
      Usuarios = new BindingList<Usuario>();
    }

    public BindingList<Usuario> Usuarios {
      get { return _listaUsuario; }
      set { _listaUsuario = value; OnPropertyChanged("Usuarios"); }
    }


  }
}
