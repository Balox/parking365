-- ==================================================
-- USE PARKING_PROD
-- ==================================================
use parking_prod;
go

-- ==================================================
-- DROP TABLES
-- ==================================================
	drop table acceso;
	drop table perfil;
	drop table perfilacceso;
	drop table ubigeo;
	drop table ubigeotipo;
	drop table usuario;
	drop table usuarioacceso;
	drop table usuariosession;
	drop table zonahoraria;
	drop table tipovehiculo;
	
-- =================================================
-- crear tablas
-- =================================================
CREATE TABLE acceso
  (
    idacceso                       INTEGER IDENTITY(1,1) NOT NULL ,
    nombre                         VARCHAR (100) NOT NULL ,
    descripcion                    VARCHAR (300) ,
    estadoregistro                 CHAR (1) DEFAULT 'A' NOT NULL ,
    auditoria_creacionusuario      INTEGER NOT NULL ,
    auditoria_creacionfecha        DATETIME DEFAULT GETDATE() NOT NULL ,
    auditoria_actualizacionusuario INTEGER NOT NULL ,
    auditoria_actualizacionfecha   DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'acceso',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_acceso_001 ON acceso(nombre ASC) ;
CREATE INDEX ix_acceso_002 ON acceso(estadoregistro ASC) ;
ALTER TABLE acceso ADD CONSTRAINT pk_acceso PRIMARY KEY ( idacceso ) ;
GO

CREATE TABLE perfil
  (
    idperfil                       INTEGER IDENTITY(1,1) NOT NULL ,
    idpadre                        INTEGER DEFAULT 0 NOT NULL ,
    nombre                         VARCHAR (100) NOT NULL ,
    descripcion                    VARCHAR (250) ,
    estadoregistro                 CHAR (1) DEFAULT 'A' NOT NULL ,
    auditoria_creacionusuario      INTEGER NOT NULL ,
    auditoria_creacionfecha        DATETIME DEFAULT GETDATE() NOT NULL ,
    auditoria_actualizacionusuario INTEGER NOT NULL ,
    auditoria_actualizacionfecha   DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'(1) ADMINISTRADOR (2) OPERADOR', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'perfil',
	@level2type=N'COLUMN', @level2name=N'nombre' ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'perfil',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_perfil_001 ON perfil(idpadre ASC) ;
CREATE INDEX ix_perfil_002 ON perfil(estadoregistro ASC) ;
CREATE INDEX ix_perfil_003 ON perfil(nombre ASC) ;
ALTER TABLE perfil ADD CONSTRAINT pk_perfil PRIMARY KEY ( idperfil ) ;
GO


CREATE TABLE perfilacceso
  (
    idperfilacceso INTEGER IDENTITY(1,1) NOT NULL ,
    idperfil       INTEGER NOT NULL ,
    idacceso       INTEGER NOT NULL ,
    estadoregistro CHAR (1) DEFAULT 'A' NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'perfilacceso',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_perfilacceso_001 ON perfilacceso(idperfil ASC) ;
CREATE INDEX ix_perfilacceso_002 ON perfilacceso(idacceso ASC) ;
CREATE INDEX ix_perfilacceso_003 ON perfilacceso(estadoregistro ASC) ;
ALTER TABLE perfilacceso ADD CONSTRAINT pk_perfilacceso PRIMARY KEY ( idperfilacceso ) ;
GO

CREATE TABLE ubigeo
  (
    idubigeo                    INTEGER IDENTITY(1,1) NOT NULL ,
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
    fechacreacion               DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'Código de País', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeo',
	@level2type=N'COLUMN', @level2name=N'ubigeonivel01' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'Código de Departamento', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeo',
	@level2type=N'COLUMN', @level2name=N'ubigeonivel02' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'Código de Provincia', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeo',
	@level2type=N'COLUMN', @level2name=N'ubigeonivel03' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'Código de Distrito', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeo',
	@level2type=N'COLUMN', @level2name=N'ubigeonivel04' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeo',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_ubigeo_001 ON ubigeo( idubigeotipo ASC ) ;
CREATE INDEX ix_ubigeo_002 ON ubigeo( ubigeonivel01 ASC ) ;
CREATE INDEX ix_ubigeo_003 ON ubigeo( nombre ASC ) ;
CREATE INDEX ix_ubigeo_004 ON ubigeo( descripcion ASC ) ;
CREATE INDEX ix_ubigeo_005 ON ubigeo( codigoiso ASC ) ;
CREATE INDEX ix_ubigeo_006 ON ubigeo( nombregoogle ASC ) ;
CREATE INDEX ix_ubigeo_007 ON ubigeo(administrative_area_level_1 ASC ) ;
CREATE INDEX ix_ubigeo_008 ON ubigeo( ubigeonivel02 ASC ) ;
CREATE INDEX ix_ubigeo_009 ON ubigeo( ubigeonivel03 ASC ) ;
CREATE INDEX ix_ubigeo_010 ON ubigeo( ubigeonivel04 ASC ) ;
CREATE INDEX ix_ubigeo_011 ON ubigeo( estadoregistro ASC ) ;
ALTER TABLE ubigeo ADD CONSTRAINT pk_ubigeo PRIMARY KEY ( idubigeo ) ;
GO

CREATE TABLE ubigeotipo
  (
    idubigeotipo   INTEGER IDENTITY(1,1) NOT NULL ,
    idpadre        INTEGER DEFAULT 0 NOT NULL ,
    descripcion    VARCHAR (100) NOT NULL ,
    estadoregistro CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion  DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'PAÍS,DEPARTAMENTO,PROVINCIA,DISTRITO,REGIÓN,COMUNA', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeotipo',
	@level2type=N'COLUMN', @level2name=N'descripcion' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'ubigeotipo',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_ubigeotipo_001 ON ubigeotipo( idpadre ASC ) ;
CREATE INDEX ix_ubigeotipo_002 ON ubigeotipo( descripcion ASC ) ;
CREATE INDEX ix_ubigeotipo_003 ON ubigeotipo( estadoregistro ASC ) ;
ALTER TABLE ubigeotipo ADD CONSTRAINT pk_ubigeotipo PRIMARY KEY ( idubigeotipo ) ;
GO

CREATE TABLE usuario
  (
    idusuario                      INTEGER IDENTITY(1,1) NOT NULL ,
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
    fechaexpiracion                DATETIME ,
    fechacambioclave               DATETIME ,
    idtipopregunta                 INTEGER ,
    respuestapregunta              VARCHAR (150) ,
    modoconexion                   VARCHAR (1) ,
    token                          VARCHAR (64) ,
    tokengoogle                    VARCHAR (300) ,
    estadoregistro                 CHAR (1) DEFAULT 'A' NOT NULL ,
    auditoria_creacionusuario      INTEGER NOT NULL ,
    auditoria_creacionfecha        DATETIME DEFAULT GETDATE() NOT NULL ,
    auditoria_actualizacionusuario INTEGER NOT NULL ,
    auditoria_actualizacionfecha   DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'(1)¿CUÁL ES EL NOMBRE DE TU PADRE?
(2)¿CUÁL ES EL NOMBRE DE TU PLATO FAVORITO?
(3)¿CUÁL ES EL NOMBRE DE TU MEJOR AMIGO?
(4)¿CUÁL ES EL NOMBRE DE TU MASCOTA?
(5)¿CUÁL ES EL NOMBRE DE TU LUGAR FAVORITO?
(6)DEBE CAMBIAR PREGUNTA SECRETA', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuario',
	@level2type=N'COLUMN', @level2name=N'idtipopregunta' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'(N) NO DEFINIDO (M) MASCULINO (F) FEMENINO', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuario',
	@level2type=N'COLUMN', @level2name=N'sexo' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Aplicativo, P=> Plataforma', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuario',
	@level2type=N'COLUMN', @level2name=N'modoconexion' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuario',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_usuario_001 ON usuario( idperfil ASC ) ;
CREATE INDEX ix_usuario_002 ON usuario( idzonahoraria ASC ) ;
CREATE INDEX ix_usuario_003 ON usuario( nombrecompleto ASC ) ;
CREATE INDEX ix_usuario_004 ON usuario( email ASC ) ;
CREATE INDEX ix_usuario_005 ON usuario( telefono ASC ) ;
CREATE INDEX ix_usuario_006 ON usuario( sexo ASC ) ;
CREATE INDEX ix_usuario_007 ON usuario( usuario ASC ) ;
CREATE INDEX ix_usuario_008 ON usuario( clave ASC ) ;
CREATE INDEX ix_usuario_009 ON usuario( saltsecret ASC ) ;
CREATE INDEX ix_usuario_010 ON usuario( idtipopregunta ASC ) ;
CREATE INDEX ix_usuario_011 ON usuario( respuestapregunta ASC ) ;
CREATE INDEX ix_usuario_012 ON usuario( token ASC ) ;
CREATE INDEX ix_usuario_013 ON usuario( tokengoogle ASC ) ;
CREATE INDEX ix_usuario_014 ON usuario( tokengoogle ASC ) ;
CREATE INDEX ix_usuario_015 ON usuario( estadoregistro ASC ) ;
ALTER TABLE usuario ADD CONSTRAINT pk_usuario PRIMARY KEY ( idusuario ) ;
GO

CREATE TABLE usuarioacceso
  (
    idusuarioacceso INTEGER IDENTITY(1,1) NOT NULL ,
    estadoregistro  CHAR (1) DEFAULT 'A' NOT NULL ,
    idusuario       INTEGER NOT NULL ,
    idacceso        INTEGER NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuarioacceso',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;
GO

CREATE INDEX ix_usuarioacceso_001 ON usuarioacceso( estadoregistro ASC ) ;
CREATE INDEX ix_usuarioacceso_002 ON usuarioacceso( idusuario ASC ) ;
CREATE INDEX ix_usuarioacceso_003 ON usuarioacceso( idacceso ASC ) ;
ALTER TABLE usuarioacceso ADD CONSTRAINT pk_usuarioacceso PRIMARY KEY ( idusuarioacceso ) ;
GO

CREATE TABLE usuariosession
  (
    idusuariosession INTEGER IDENTITY(1,1) NOT NULL ,
    idusuario        INTEGER NOT NULL ,
    idsession        VARCHAR (500) NOT NULL ,
    idsocketnode     VARCHAR (500) NOT NULL ,
    tokenjwt         VARCHAR (500) NOT NULL ,
    estadosession    CHAR (1) NOT NULL ,
    estadoregistro   CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion    DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'TOKEN DE SESSION', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuariosession',
	@level2type=N'COLUMN', @level2name=N'idsession' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'TOKEN IDSOCKET CLIENTE', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuariosession',
	@level2type=N'COLUMN', @level2name=N'idsocketnode' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'TOKEN Aut2.0 JWT', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuariosession',
	@level2type=N'COLUMN', @level2name=N'tokenjwt' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'(0) SESSION CERRADA
(1) SESSION ABIERTA', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuariosession',
	@level2type=N'COLUMN', @level2name=N'estadosession' ;
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'usuariosession',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;	
GO

CREATE INDEX ix_usuariosession_001 ON usuariosession( idusuario ASC ) ;
CREATE INDEX ix_usuariosession_002 ON usuariosession( idsession ASC ) ;
CREATE INDEX ix_usuariosession_003 ON usuariosession( idsocketnode ASC ) ;
CREATE INDEX ix_usuariosession_004 ON usuariosession( tokenjwt ASC ) ;
CREATE INDEX ix_usuariosession_005 ON usuariosession( estadoregistro ASC ) ;
ALTER TABLE usuariosession ADD CONSTRAINT pk_sessionusuario PRIMARY KEY ( idusuariosession ) ;
GO

CREATE TABLE zonahoraria
  (
    idzonahoraria INTEGER IDENTITY(1,1) NOT NULL ,
    nombre        VARCHAR (150) NOT NULL ,
    abreviatura   VARCHAR (20) ,
    utc_offset	  VARCHAR (20) ,
    pais           VARCHAR (150) ,
    rutaimagen     VARCHAR (500) ,
    estadoregistro CHAR (1) DEFAULT 'A' NOT NULL ,
    fechacreacion  DATETIME DEFAULT GETDATE() NOT NULL
  ) ;
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'A=> Activo, I=> Inactivo, B=> Bloqueado, E=> Eliminado', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'zonahoraria',
	@level2type=N'COLUMN', @level2name=N'estadoregistro' ;	
GO

CREATE INDEX ix_zonahoraria_001 ON zonahoraria( nombre ASC ) ;
CREATE INDEX ix_zonahoraria_002 ON zonahoraria( abreviatura ASC ) ;
CREATE INDEX ix_zonahoraria_003 ON zonahoraria( utc_offset ASC ) ;
CREATE INDEX ix_zonahoraria_004 ON zonahoraria( pais ASC ) ;
CREATE INDEX ix_zonahoraria_005 ON zonahoraria( estadoregistro ASC ) ;
ALTER TABLE zonahoraria ADD CONSTRAINT pk_zonahoraria PRIMARY KEY ( idzonahoraria ) ;
GO

-- creacion de unique
ALTER TABLE usuario ADD CONSTRAINT uk_usuario_usuario UNIQUE (usuario);
GO

-- ==================================================
-- FOREIGN KEY
-- ==================================================

ALTER TABLE perfilacceso ADD CONSTRAINT fk_acceso_perfilacceso FOREIGN KEY ( idacceso ) REFERENCES acceso ( idacceso ) ;
ALTER TABLE usuarioacceso ADD CONSTRAINT fk_acceso_usuarioacceso FOREIGN KEY ( idacceso ) REFERENCES acceso ( idacceso ) ;
ALTER TABLE perfilacceso ADD CONSTRAINT fk_perfil_perfilacceso FOREIGN KEY ( idperfil ) REFERENCES perfil ( idperfil ) ;
ALTER TABLE usuario ADD CONSTRAINT fk_perfil_usuario FOREIGN KEY ( idperfil ) REFERENCES perfil ( idperfil ) ;
ALTER TABLE ubigeo ADD CONSTRAINT fk_ubigeotipo_ubigeo FOREIGN KEY ( idubigeotipo ) REFERENCES ubigeotipo ( idubigeotipo ) ;
ALTER TABLE usuarioacceso ADD CONSTRAINT fk_usuario_usuarioacceso FOREIGN KEY ( idusuario ) REFERENCES usuario ( idusuario ) ;
ALTER TABLE usuariosession ADD CONSTRAINT fk_usuario_usuariosession FOREIGN KEY ( idusuario ) REFERENCES usuario ( idusuario ) ;
ALTER TABLE usuario ADD CONSTRAINT fk_zonahoraria_usuario FOREIGN KEY ( idzonahoraria ) REFERENCES zonahoraria ( idzonahoraria ) ;



-- ============================================================
-- Tabla tipovehiculo
-- ============================================================ 

create table tipovehiculo (
	idtipovehiculo integer identity(1,1) not null,
	nombre varchar (100) not null,
	estadoregistro char(1) default 'A' not null,
	fechacreacion DATETIME DEFAULT GETDATE() not null
);
GO

alter table tipovehiculo add constraint pk_tipovehiculo primary key (idtipovehiculo);
GO

-- ============================================================
-- Tabla cliente
-- ============================================================ 

create table cliente (
	idcliente bigint identity(1,1) not null,
	idtipocliente integer not null default 1,
	idtipodocumento integer not null default 1,
	documento varchar(20) not null,
	nombre varchar(120) not null,
	representante varchar(120),
	telefono varchar(20),
	email varchar(320),
	observacion varchar(500),
	estadoregistro char(1) default 'A' not null,
	auditoria_creacionusuario integer not null,
	auditoria_creacionfecha DATETIME DEFAULT GETDATE() not null,
	auditoria_actualizacionusuario integer not null,
	auditoria_actualizacionfecha DATETIME DEFAULT GETDATE() not null
);
GO

EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'1->persona natural, 2->persona juridica', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'cliente',
	@level2type=N'COLUMN', @level2name=N'idtipocliente' ;	
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'1->DNI,2->RUC', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'cliente',
	@level2type=N'COLUMN', @level2name=N'idtipodocumento' ;	
EXEC sys.sp_addextendedproperty 
	@name=N'MS_Description', @value=N'segun el tipo cliente, nombre o razon social)', 
	@level0type=N'SCHEMA', @level0name=N'dbo',
	@level1type=N'TABLE', @level1name=N'cliente',
	@level2type=N'COLUMN', @level2name=N'nombre' ;
GO

alter table cliente add constraint uk_cliente_documento unique(documento);
alter table cliente add constraint pk_cliente primary key(idcliente);
create index ix_cliente_001 on cliente(idtipocliente);
create index ix_cliente_002 on cliente(idtipodocumento);
create index ix_cliente_003 on cliente(documento asc);
create index ix_cliente_004 on cliente(nombre asc);
GO

-- ============================================================
-- Tabla vehiculo
-- ============================================================ 

create table vehiculo (
	idvehiculo bigint identity(1,1) not null,
	idtipovehiculo integer not null,
	placa varchar(10) not null,
	descripcion varchar(500),
	estadoregistro char(1) default 'A' not null, 
	fechacreacion DATETIME DEFAULT GETDATE() not null
);
GO

alter table vehiculo add constraint pk_vehiculo primary key (idvehiculo);
alter table vehiculo add constraint fk_tipovehiculo foreign key (idtipovehiculo) references tipovehiculo(idtipovehiculo);
alter table vehiculo add constraint uk_vehiculo_placa unique(placa);
create index ix_vehiculo_001 on vehiculo(idtipovehiculo);
create index ix_vehiculo_002 on vehiculo(placa);
GO


-- ============================================================
-- Tabla clientevehiculo
-- ============================================================ 

create table clientevehiculo (
	idclientevehiculo bigint identity(1,1) not null,
	idcliente bigint not null,
	idvehiculo bigint not null,
	estadoregistro char(1) default 'A' not null, 
	fechacreacion DATETIME DEFAULT GETDATE() not null
);
GO

alter table clientevehiculo add constraint pk_clientevehiculo primary key (idclientevehiculo);
create index ix_clientevehiculo_001 on clientevehiculo(idcliente);
create index ix_clientevehiculo_002 on clientevehiculo(idvehiculo);
GO

