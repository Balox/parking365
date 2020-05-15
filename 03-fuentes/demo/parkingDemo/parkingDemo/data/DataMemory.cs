using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parkingDemo.domain;
using System.ComponentModel;

namespace parkingDemo.data {
  public class DataMemory : BaseNotifyPropertyChange {

    private BindingList<Ingreso> listadoIngreso { get; set; }
    


    public DataMemory() {
      Ingresos = new BindingList<Ingreso>();
      //this.contadorIngreso = 0;
    }


    public BindingList<Ingreso> Ingresos {
      get { return listadoIngreso; }
      set { listadoIngreso = value; OnPropertyChanged("Ingresos"); }
    }
  }
}
