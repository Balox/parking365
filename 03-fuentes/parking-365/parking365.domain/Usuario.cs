using System;
using parking365.common;

namespace parking365.domain {
  public class Usuario: BaseNotifyPropertyChange {
    
    public int item { get; set; }
    public int idusuario { get; set; }
    public int idperfil { get; set; }
    public string perfil { get; set; }
    public string nombrecompleto { get; set; }
    public string email { get; set; }
    public string telefono { get; set; }
    public string sexo { get; set; }
    public string usuario { get; set; }
    public string clave { get; set; }
    public string saltsecret { get; set; }
    public string estadoregistro { get; set; }
    public int idusuariocrea { get; set; }

    public Usuario() { }
    public Usuario(int i, int idu, int idp, string p, string nom, string e, string t, string s, string u, string c, string sl, string er) {
      this.item = i;
      this.idusuario = idu;
      this.idperfil = idp;
      this.perfil = p;
      this.nombrecompleto = nom;
      this.email = e;
      this.telefono = t;
      this.sexo = s;
      this.usuario = u;
      this.clave = c;
      this.saltsecret = sl;
      this.estadoregistro = er;
    }

    public Usuario(int _idperfil, string _nombrecompleto, string _email, string _telefono, string _usuario, string _clave, int _idusuariocrea) {
      this.idperfil = _idperfil;
      this.nombrecompleto = _nombrecompleto;
      this.email = _email;
      this.telefono = _telefono;
      this.usuario = _usuario;
      this.clave = _clave;
      this.idusuariocrea = _idusuariocrea;
    }

    public Usuario(int _idusuario, int _idperfil,string _nombrecompleto,string _email,string _telefono,string _usuario,string _clave,int _idusuariocrea) {
      this.idusuario = _idusuario;
      this.idperfil = _idperfil;
      this.nombrecompleto = _nombrecompleto;
      this.email = _email;
      this.telefono = _telefono;
      this.usuario = _usuario;
      this.clave = _clave;
      this.idusuariocrea = _idusuariocrea;
    }
  }

  /*
CREATE TABLE admin.usuario
(
  idusuario integer NOT NULL,
  idperfil integer NOT NULL,
  idzonahoraria integer NOT NULL,
  nombrecompleto character varying(300),
  email character varying(320),
  telefono character varying(20),
  sexo character(1), -- (N) NO DEFINIDO...
  usuario character varying(320) NOT NULL,
  clave character varying(150) NOT NULL,
  saltsecret character varying(100) NOT NULL,
  diascaducidadclave integer NOT NULL DEFAULT 185,
  fechaexpiracion timestamp with time zone,
  fechacambioclave timestamp with time zone,
  idtipopregunta integer, -- (1)¿CUÁL ES EL NOMBRE DE TU PADRE?...
  respuestapregunta character varying(150),
  modoconexion character varying(1), -- A=> Aplicativo, P=> Plataforma
  token character varying(64),
  tokengoogle character varying(300),
  estadoregistro character(1) NOT NULL DEFAULT 'A'::bpchar, -- A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado
  auditoria_creacionusuario integer NOT NULL,
  auditoria_creacionfecha timestamp with time zone NOT NULL DEFAULT now(),
  auditoria_actualizacionusuario integer NOT NULL,
  auditoria_actualizacionfecha timestamp with time zone NOT NULL DEFAULT now()
)
*/
}