using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingDemo.domain {
  public class Salida {
    public Int32 Id { get; set; }
    public String Ticket { get; set; }
    public String Fecha { get; set; }
    public String Hora { get; set; }
    public String Placa { get; set; }
    public String Puerta { get; set; }
    public String Tiempo { get; set; }

    public Salida(int id,string t,string f,string h,string p, string pu) {
      this.Id = id;
      this.Ticket = t;
      this.Fecha = f;
      this.Hora = h;
      this.Placa = p;
      this.Puerta = pu;

    }
  }
}
