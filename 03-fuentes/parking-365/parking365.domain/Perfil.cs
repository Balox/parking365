using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking365.domain {
  public class Perfil {
    public int idperfil { get; set; }
    public string perfil { get; set; }

    public Perfil(int i, string p) {
      this.idperfil = i;
      this.perfil = p;
    }
  }
}

/*
 CREATE TABLE admin.perfil
(
  idperfil integer NOT NULL,
  idpadre integer NOT NULL DEFAULT 0,
  nombre character varying(100) NOT NULL, -- (1) ADMINISTRADOR...
  descripcion character varying(250),
  estadoregistro character(1) NOT NULL DEFAULT 'A'::bpchar, -- A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado
  auditoria_creacionusuario integer NOT NULL,
  auditoria_creacionfecha timestamp with time zone NOT NULL DEFAULT now(),
  auditoria_actualizacionusuario integer NOT NULL,
  auditoria_actualizacionfecha timestamp with time zone NOT NULL DEFAULT now()
)
*/
