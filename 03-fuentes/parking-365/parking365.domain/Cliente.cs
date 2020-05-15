using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking365.domain {
  public class Cliente {
    public int item { get; set; }
    public Int64 idcliente { get; set; }
    public int idtipocliente { get; set; }
    public string tipocliente { get; set; }
    public int idtipodocumento { get; set; }
    public string tipodocumento { get; set; }
    public string documento { get; set; }
    public string nombre { get; set; }
    public string representante { get; set; }
    public string telefono { get; set; }
    public string email { get; set; }
    public string observacion { get; set; }
    public string estadoregistro { get; set; }
    public int vehiculos { get; set; }
    public int idusuariocrea { get; set; }

    public Cliente() { }

    public Cliente(int i, Int64 id, int idtipo, string tipo,
      int idtipodoc, string tipodoc, string d, string n, string r, string t, string e, string o, string est, int v ) {
      this.item = i;
      this.idcliente = id;
      this.idtipocliente = idtipo;
      this.tipocliente = tipo;
      this.idtipodocumento = idtipodoc;
      this.tipodocumento = tipodoc;
      this.documento = d;
      this.nombre = n;
      this.representante = r;
      this.telefono = t;
      this.email = e;
      this.observacion = o;
      this.estadoregistro = est;
      this.vehiculos = v;
    }
    
    public Cliente(Int64 id, int idtipo,int idtipodoc,string doc, string nombre, string representante, string tel, string email, string obs,int idusu ) {
      this.idcliente = id;
      this.idtipocliente = idtipo;
      this.idtipodocumento = idtipodoc;
      this.documento = doc;
      this.nombre = nombre;
      this.representante = representante;
      this.telefono = tel;
      this.email = email;
      this.observacion = obs;
      this.idusuariocrea = idusu;
    }
  }
}


/*
CREATE TABLE admin.cliente
(
  idcliente bigint NOT NULL,
  idtipocliente integer NOT NULL DEFAULT 1, -- 1->persona natural, 2->persona juridica
  idtipodocumento integer NOT NULL DEFAULT 1, -- 1->DNI,2->RUC
  documento character varying(20) NOT NULL,
  nombre character varying(120) NOT NULL, -- segun el tipo cliente, nombre o razon social)
  representante character varying(120),
  telefono character varying(20),
  email character varying(320),
  observacion character varying(500),
  estadoregistro character(1) NOT NULL DEFAULT 'A'::bpchar,
  auditoria_creacionusuario integer NOT NULL,
  auditoria_creacionfecha timestamp with time zone NOT NULL DEFAULT now(),
  auditoria_actualizacionusuario integer NOT NULL,
  auditoria_actualizacionfecha timestamp with time zone NOT NULL DEFAULT now(),
  CONSTRAINT pk_cliente PRIMARY KEY (idcliente),
  CONSTRAINT uk_cliente_documento UNIQUE (documento)
)
 */
