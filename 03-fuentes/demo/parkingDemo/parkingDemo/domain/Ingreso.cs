using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingDemo.domain {
  public class Ingreso {
    public Int32 Id { get; set; }
    public String Ticket { get; set; }
    public String Fecha { get; set; }
    public String Hora { get; set; }
    public String Placa { get; set; }
    public String Puerta { get; set; }
    public DateTime FeIngreso { get; set; }
    public DateTime FeSalida { get; set; }
    public String HoraSalida { get; set; }
    public Int32 Tiempo { get; set; }
    public Int32 Tarifa { get; set; }
    public Decimal Costo { get; set; }
    
    public Ingreso(int id, string t, string f, string h, string p, DateTime fe) {
      this.Id = id;
      this.Ticket = t;
      this.Fecha = f;
      this.Hora = h;
      this.Placa = p;
      this.Puerta = "PUERTA 01";
      this.FeIngreso = fe;
      this.FeSalida = fe;
      this.HoraSalida = String.Empty;
      this.Tiempo = 0;
      this.Tarifa = 5;
      this.Costo = 0;
    }
  }
}
