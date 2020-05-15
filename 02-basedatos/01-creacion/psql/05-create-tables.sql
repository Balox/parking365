
-- ==================================================
-- DROP TABLES
-- ==================================================
	--drop table admin.acceso cascade;
	--drop table admin.perfil cascade;
	--drop table admin.perfilacceso cascade;
	--drop table admin.ubigeo cascade;
	--drop table admin.ubigeotipo cascade;
	--drop table admin.usuario cascade;
	--drop table admin.usuarioacceso cascade;
	--drop table admin.usuariosession cascade;
	--drop table admin.zonahoraria cascade;

-- =================================================
-- crear tablas
-- =================================================
CREATE TABLE admin.acceso
  (
    idacceso                       INTEGER NOT NULL ,
    nombre                         VARCHAR (100) NOT NULL ,
    descripcion                    VARCHAR (300) ,
    estadoregistro                 CHAR (1) DEFAULT 'A' NOT NULL ,
    auditoria_creacionusuario      INTEGER NOT NULL ,
    auditoria_creacionfecha        TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL ,
    auditoria_actualizacionusuario INTEGER NOT NULL ,
    auditoria_actualizacionfecha   TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.acceso.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_acceso_001 ON admin.acceso
    ( nombre ASC
    ) ;
  CREATE INDEX ix_acceso_002 ON admin.acceso
    ( estadoregistro ASC
    ) ;
ALTER TABLE admin.acceso ADD CONSTRAINT pk_acceso PRIMARY KEY ( idacceso ) ;

CREATE TABLE admin.perfil
  (
    idperfil                       INTEGER NOT NULL ,
    idpadre                        INTEGER DEFAULT 0 NOT NULL ,
    nombre                         VARCHAR (100) NOT NULL ,
    descripcion                    VARCHAR (250) ,
    estadoregistro                 CHAR (1) DEFAULT 'A' NOT NULL ,
    auditoria_creacionusuario      INTEGER NOT NULL ,
    auditoria_creacionfecha        TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL ,
    auditoria_actualizacionusuario INTEGER NOT NULL ,
    auditoria_actualizacionfecha   TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.perfil.nombre
IS
  '	(1) ADMINISTRADOR
	(2) OPERADOR' ;
  COMMENT ON COLUMN admin.perfil.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_perfil_001 ON admin.perfil
    ( idpadre ASC
    ) ;
  CREATE INDEX ix_perfil_002 ON admin.perfil
    ( estadoregistro ASC
    ) ;
  CREATE INDEX ix_perfil_003 ON admin.perfil
    ( nombre ASC
    ) ;
ALTER TABLE admin.perfil ADD CONSTRAINT pk_perfil PRIMARY KEY ( idperfil ) ;


CREATE TABLE admin.perfilacceso
  (
    idperfilacceso INTEGER NOT NULL ,
    idperfil       INTEGER NOT NULL ,
    idacceso       INTEGER NOT NULL ,
    estadoregistro CHAR (1) DEFAULT 'A' NOT NULL
  ) ;
COMMENT ON COLUMN admin.perfilacceso.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_perfilacceso_001 ON admin.perfilacceso
    (
      idperfil ASC
    ) ;
  CREATE INDEX ix_perfilacceso_002 ON admin.perfilacceso
    (
      idacceso ASC
    ) ;
  CREATE INDEX ix_perfilacceso_003 ON admin.perfilacceso
    (
      estadoregistro ASC
    ) ;
ALTER TABLE admin.perfilacceso ADD CONSTRAINT pk_perfilacceso PRIMARY KEY ( idperfilacceso ) ;

CREATE TABLE admin.ubigeo
  (
    idubigeo                    INTEGER NOT NULL ,
    idubigeotipo                INTEGER NOT NULL ,
    codigoubigeo                VARCHAR (10) NOT NULL ,
    ubigeonivel01               CHAR (4) NOT NULL ,
    ubigeonivel02               VARCHAR (4) NOT NULL ,
    ubigeonivel03               CHAR (4) NOT NULL ,
    ubigeonivel04               CHAR (4) NOT NULL ,
    nombre                      VARCHAR (100) NOT NULL ,
    descripcion                 VARCHAR (150) ,
    latitud                     VARCHAR (30) ,
    longitud                    VARCHAR (30) ,
    codigoiso                   VARCHAR (10) ,
    nombregoogle                VARCHAR (500) ,
    country                     VARCHAR (100) ,
    administrative_area_level_1 VARCHAR (100) ,
    administrative_area_level_2 VARCHAR (100) ,
    locality                    VARCHAR (200) ,
    estadoregistro              CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion               TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.ubigeo.ubigeonivel01
IS
  'Código de País' ;
  COMMENT ON COLUMN admin.ubigeo.ubigeonivel02
IS
  'Código de Departamento' ;
  COMMENT ON COLUMN admin.ubigeo.ubigeonivel03
IS
  'Código de Provincia' ;
  COMMENT ON COLUMN admin.ubigeo.ubigeonivel04
IS
  'Código de Distrito' ;
  COMMENT ON COLUMN admin.ubigeo.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_ubigeo_001 ON admin.ubigeo
    ( idubigeotipo ASC
    ) ;
  CREATE INDEX ix_ubigeo_002 ON admin.ubigeo
    ( ubigeonivel01 ASC
    ) ;
  CREATE INDEX ix_ubigeo_003 ON admin.ubigeo
    ( nombre ASC
    ) ;
  CREATE INDEX ix_ubigeo_004 ON admin.ubigeo
    ( descripcion ASC
    ) ;
  CREATE INDEX ix_ubigeo_005 ON admin.ubigeo
    ( codigoiso ASC
    ) ;
  CREATE INDEX ix_ubigeo_006 ON admin.ubigeo
    ( nombregoogle ASC
    ) ;
  CREATE INDEX ix_ubigeo_007 ON admin.ubigeo
    (
      administrative_area_level_1 ASC
    ) ;
  CREATE INDEX ix_ubigeo_008 ON admin.ubigeo
    ( ubigeonivel02 ASC
    ) ;
  CREATE INDEX ix_ubigeo_009 ON admin.ubigeo
    ( ubigeonivel03 ASC
    ) ;
  CREATE INDEX ix_ubigeo_010 ON admin.ubigeo
    ( ubigeonivel04 ASC
    ) ;
  CREATE INDEX ix_ubigeo_011 ON admin.ubigeo
    ( estadoregistro ASC
    ) ;
ALTER TABLE admin.ubigeo ADD CONSTRAINT pk_ubigeo PRIMARY KEY ( idubigeo ) ;


CREATE TABLE admin.ubigeotipo
  (
    idubigeotipo   INTEGER NOT NULL ,
    idpadre        INTEGER DEFAULT 0 NOT NULL ,
    descripcion    VARCHAR (100) NOT NULL ,
    estadoregistro CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion  TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.ubigeotipo.descripcion
IS
  'PAÍS,DEPARTAMENTO,PROVINCIA,DISTRITO,REGIÓN,COMUNA' ;
  COMMENT ON COLUMN admin.ubigeotipo.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_ubigeotipo_001 ON admin.ubigeotipo
    ( idpadre ASC
    ) ;
  CREATE INDEX ix_ubigeotipo_002 ON admin.ubigeotipo
    (
      descripcion ASC
    ) ;
  CREATE INDEX ix_ubigeotipo_003 ON admin.ubigeotipo
    (
      estadoregistro ASC
    ) ;
ALTER TABLE admin.ubigeotipo ADD CONSTRAINT pk_ubigeotipo PRIMARY KEY ( idubigeotipo ) ;


CREATE TABLE admin.usuario
  (
    idusuario                      INTEGER NOT NULL ,
    idperfil                       INTEGER NOT NULL ,
    idzonahoraria                  INTEGER NOT NULL ,
    nombrecompleto                 VARCHAR (300) ,
    email                          VARCHAR (320) ,
    telefono                       VARCHAR (20) ,
    sexo                           CHAR (1) ,
    usuario                        VARCHAR (320) NOT NULL ,
    clave                          VARCHAR (150) NOT NULL ,
    saltsecret                     VARCHAR (100) NOT NULL ,
    diascaducidadclave             INTEGER DEFAULT 185 NOT NULL ,
    fechaexpiracion                TIMESTAMP WITH TIME ZONE ,
    fechacambioclave               TIMESTAMP WITH TIME ZONE ,
    idtipopregunta                 INTEGER ,
    respuestapregunta              VARCHAR (150) ,
    modoconexion                   VARCHAR (1) ,
    token                          VARCHAR (64) ,
    tokengoogle                    VARCHAR (300) ,
    estadoregistro                 CHAR (1) DEFAULT 'A' NOT NULL ,
    auditoria_creacionusuario      INTEGER NOT NULL ,
    auditoria_creacionfecha        TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL ,
    auditoria_actualizacionusuario INTEGER NOT NULL ,
    auditoria_actualizacionfecha   TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.usuario.idtipopregunta
IS
  '(1)¿CUÁL ES EL NOMBRE DE TU PADRE?
(2)¿CUÁL ES EL NOMBRE DE TU PLATO FAVORITO?
(3)¿CUÁL ES EL NOMBRE DE TU MEJOR AMIGO?
(4)¿CUÁL ES EL NOMBRE DE TU MASCOTA?
(5)¿CUÁL ES EL NOMBRE DE TU LUGAR FAVORITO?
(6)DEBE CAMBIAR PREGUNTA SECRETA
' ;
COMMENT ON COLUMN admin.usuario.sexo
IS
  '(N) NO DEFINIDO
(M) MASCULINO
(F) FEMENINO' ;
  COMMENT ON COLUMN admin.usuario.modoconexion
IS
  'A=> Aplicativo, P=> Plataforma' ;
  COMMENT ON COLUMN admin.usuario.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_usuario_001 ON admin.usuario
    ( idperfil ASC
    ) ;
  CREATE INDEX ix_usuario_002 ON admin.usuario
    ( idzonahoraria ASC
    ) ;
  CREATE INDEX ix_usuario_003 ON admin.usuario
    ( nombrecompleto ASC
    ) ;
  CREATE INDEX ix_usuario_004 ON admin.usuario
    ( email ASC
    ) ;
  CREATE INDEX ix_usuario_005 ON admin.usuario
    ( telefono ASC
    ) ;
  CREATE INDEX ix_usuario_006 ON admin.usuario
    ( sexo ASC
    ) ;
  CREATE INDEX ix_usuario_007 ON admin.usuario
    ( usuario ASC
    ) ;
  CREATE INDEX ix_usuario_008 ON admin.usuario
    ( clave ASC
    ) ;
  CREATE INDEX ix_usuario_009 ON admin.usuario
    ( saltsecret ASC
    ) ;
  CREATE INDEX ix_usuario_010 ON admin.usuario
    ( idtipopregunta ASC
    ) ;
  CREATE INDEX ix_usuario_011 ON admin.usuario
    (
      respuestapregunta ASC
    ) ;
  CREATE INDEX ix_usuario_012 ON admin.usuario
    ( token ASC
    ) ;
  CREATE INDEX ix_usuario_013 ON admin.usuario
    ( tokengoogle ASC
    ) ;
  CREATE INDEX ix_usuario_014 ON admin.usuario
    ( tokengoogle ASC
    ) ;
  CREATE INDEX ix_usuario_015 ON admin.usuario
    ( idapp ASC
    ) ;
  CREATE INDEX ix_usuario_016 ON admin.usuario
    ( estadoregistro ASC
    ) ;
ALTER TABLE admin.usuario ADD CONSTRAINT pk_usuario PRIMARY KEY ( idusuario ) ;


CREATE TABLE admin.usuarioacceso
  (
    idusuarioacceso INTEGER NOT NULL ,
    estadoregistro  CHAR (1) DEFAULT 'A' NOT NULL ,
    idusuario       INTEGER NOT NULL ,
    idacceso        INTEGER NOT NULL
  ) ;
COMMENT ON COLUMN admin.usuarioacceso.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_usuarioacceso_001 ON admin.usuarioacceso
    (
      estadoregistro ASC
    ) ;
  CREATE INDEX ix_usuarioacceso_002 ON admin.usuarioacceso
    (
      idusuario ASC
    ) ;
  CREATE INDEX ix_usuarioacceso_003 ON admin.usuarioacceso
    (
      idacceso ASC
    ) ;
ALTER TABLE admin.usuarioacceso ADD CONSTRAINT pk_usuarioacceso PRIMARY KEY ( idusuarioacceso ) ;


CREATE TABLE admin.usuariosession
  (
    idusuariosession INTEGER NOT NULL ,
    idusuario        INTEGER NOT NULL ,
    idsession        VARCHAR (500) NOT NULL ,
    idsocketnode     VARCHAR (500) NOT NULL ,
    tokenjwt         VARCHAR (500) NOT NULL ,
    idapp            INTEGER NOT NULL ,
    estadosession    CHAR (1) NOT NULL ,
    estadoregistro   CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion    TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.usuariosession.idsession
IS
  'TOKEN DE SESSION' ;
  COMMENT ON COLUMN admin.usuariosession.idsocketnode
IS
  'TOKEN IDSOCKET CLIENTE' ;
  COMMENT ON COLUMN admin.usuariosession.tokenjwt
IS
  'token Aut2.0 JWT' ;
  COMMENT ON COLUMN admin.usuariosession.idapp
IS
  'Campo que indica a que aplicativo pertenece el registro
(1) CALLCENTER
(2) PARTNER
(3) HAGROY' ;
  COMMENT ON COLUMN admin.usuariosession.estadosession
IS
  '(0) SESSION CERRADA
(1) SESSION ABIERTA' ;
  COMMENT ON COLUMN admin.usuariosession.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_usuariosession_001 ON admin.usuariosession
    (
      idusuario ASC
    ) ;
  CREATE INDEX ix_usuariosession_002 ON admin.usuariosession
    (
      idsession ASC
    ) ;
  CREATE INDEX ix_usuariosession_003 ON admin.usuariosession
    (
      idsocketnode ASC
    ) ;
  CREATE INDEX ix_usuariosession_004 ON admin.usuariosession
    (
      tokenjwt ASC
    ) ;
  CREATE INDEX ix_usuariosession_005 ON admin.usuariosession
    (
      idapp ASC
    ) ;
  CREATE INDEX ix_usuariosession_006 ON admin.usuariosession
    (
      estadoregistro ASC
    ) ;
ALTER TABLE admin.usuariosession ADD CONSTRAINT pk_sessionusuario PRIMARY KEY ( idusuariosession ) ;


CREATE TABLE admin.zonahoraria
  (
    idzonahoraria INTEGER NOT NULL ,
    nombre        VARCHAR (150) NOT NULL ,
    abreviatura   VARCHAR (20) ,
    utc_offset	  INTERVAL ,
    pais           VARCHAR (150) ,
    rutaimagen     VARCHAR (500) ,
    estadoregistro CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion  TIMESTAMP WITH TIME ZONE DEFAULT CURRENT_TIMESTAMP NOT NULL
  ) ;
COMMENT ON COLUMN admin.zonahoraria.estadoregistro
IS
  'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado' ;
  CREATE INDEX ix_zonahoraria_001 ON admin.zonahoraria
    ( nombre ASC
    ) ;
  CREATE INDEX ix_zonahoraria_002 ON admin.zonahoraria
    (
      abreviatura ASC
    ) ;
  CREATE INDEX ix_zonahoraria_003 ON admin.zonahoraria
    (
      utc_offset ASC
    ) ;
  CREATE INDEX ix_zonahoraria_004 ON admin.zonahoraria
    ( pais ASC
    ) ;
  CREATE INDEX ix_zonahoraria_005 ON admin.zonahoraria
    (
      estadoregistro ASC
    ) ;
ALTER TABLE admin.zonahoraria ADD CONSTRAINT pk_zonahoraria PRIMARY KEY ( idzonahoraria ) ;


-- creacion de unique
ALTER TABLE admin.usuario ADD CONSTRAINT uk_usuario_usuario UNIQUE (usuario);
ALTER TABLE admin.usuario ADD CONSTRAINT uk_usuario_email UNIQUE (email);
