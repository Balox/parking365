using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking365.domain {
  public class Vehiculo {
    public int item { get; set; }
    public Int64 idvehiculo { get; set; }
    public string placa { get; set; }
    public int idtipovehiculo { get; set; }
    public string tipovehiculo { get; set; }
    public string descripcion { get; set; }
    public string estadoregistro { get; set; }
    public Int64 idclientevehiculo { get; set; }
    public Int64 idcliente { get; set; }
    public string propietario { get; set; }

    public Vehiculo() { }
  }
}

/*
CREATE TABLE admin.vehiculo
(
  idvehiculo bigint NOT NULL,
  idtipovehiculo integer NOT NULL,
  placa character varying(10) NOT NULL,
  descripcion character varying(500),
  estadoregistro character(1) NOT NULL DEFAULT 'A'::bpchar,
  fechacreacion timestamp with time zone NOT NULL DEFAULT now(),
  CONSTRAINT pk_vehiculo PRIMARY KEY (idvehiculo),
  CONSTRAINT fk_tipovehiculo FOREIGN KEY (idtipovehiculo)
      REFERENCES admin.tipovehiculo (idtipovehiculo) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT uk_vehiculo_placa UNIQUE (placa)
) 
*/
