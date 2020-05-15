using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking365.domain {
  public class TipoVehiculo {
    public int item { get; set; }
    public int idtipovehiculo { get; set; }
    public string nombre { get; set; }
    public string estadoregistro { get; set; }

    public TipoVehiculo() { }
  }
}
/*
 CREATE TABLE admin.tipovehiculo
(
  idtipovehiculo integer NOT NULL,
  nombre character varying(100) NOT NULL,
  estadoregistro character(1) NOT NULL DEFAULT 'A'::bpchar,
  fechacreacion timestamp with time zone NOT NULL DEFAULT now(),
  CONSTRAINT pk_tipovehiculo PRIMARY KEY (idtipovehiculo)
)
*/
