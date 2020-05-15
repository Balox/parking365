
-- ============================================================
-- Tabla tipovehiculo
-- ============================================================ 

create table admin.tipovehiculo (
	idtipovehiculo integer not null,
	nombre varchar (100) not null,
	estadoregistro char(1) default 'A' not null,
	fechacreacion timestamp with time zone default current_timestamp not null
);
alter table admin.tipovehiculo add constraint pk_tipovehiculo primary key (idtipovehiculo);

insert into admin.tipovehiculo(idtipovehiculo,nombre) values (1,'AUTO');
insert into admin.tipovehiculo(idtipovehiculo,nombre) values (2,'CAMION');
insert into admin.tipovehiculo(idtipovehiculo,nombre) values (3,'CAMIONETA');
insert into admin.tipovehiculo(idtipovehiculo,nombre) values (4,'MOTO');
insert into admin.tipovehiculo(idtipovehiculo,nombre) values (5,'TRAILER');
insert into admin.tipovehiculo(idtipovehiculo,nombre) values (6,'TRIMOVIL');
insert into admin.tipovehiculo(idtipovehiculo,nombre) values (7,'VOLVO');

-- ============================================================
-- Tabla cliente
-- ============================================================ 

create table admin.cliente (
	idcliente bigint not null,
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
	auditoria_creacionfecha timestamp with time zone default now() not null,
	auditoria_actualizacionusuario integer not null,
	auditoria_actualizacionfecha timestamp with time zone default now() not null
);
comment on column admin.cliente.idtipocliente is '1->persona natural, 2->persona juridica';
comment on column admin.cliente.idtipodocumento is '1->DNI,2->RUC';
comment on column admin.cliente.nombre is 'segun el tipo cliente, nombre o razon social)';

alter table admin.cliente add constraint uk_cliente_documento unique(documento);
alter table admin.cliente add constraint pk_cliente primary key(idcliente);

create index ix_cliente_001 on admin.cliente(idtipocliente);
create index ix_cliente_002 on admin.cliente(idtipodocumento);
create index ix_cliente_003 on admin.cliente(documento asc);
create index ix_cliente_004 on admin.cliente(nombre asc);

create sequence admin.seq_cliente_pk increment 1 start 1 minvalue 1 maxvalue 999999999999;

insert into admin.cliente(idcliente,documento,nombre,telefono,email,auditoria_creacionusuario,auditoria_actualizacionusuario)
values (nextval('admin.seq_cliente_pk'),'44998748','JAIR RAMIREZ GOMEZ','987487987','jramires.gomez@gmail.com',1,1);
insert into admin.cliente(idcliente,documento,nombre,telefono,email,auditoria_creacionusuario,auditoria_actualizacionusuario)
values (nextval('admin.seq_cliente_pk'),'4789658','VICTORIA CHAVEZ SALAS','965874889','chvicky.salas@gmail.com',1,1);
insert into admin.cliente(idcliente,idtipocliente,idtipodocumento,documento,nombre,representante,telefono,email,auditoria_creacionusuario,auditoria_actualizacionusuario)
values (nextval('admin.seq_cliente_pk'),2,2,'10478965483','CONSTRUCCIONES TECHITO SAC','DAVID ALEJANDRO MENDOZA FALLA','(511) 7896548','mdavid.falla@techito.pe',1,1);

-- ============================================================
-- Tabla vehiculo
-- ============================================================ 

create table admin.vehiculo (
	idvehiculo bigint not null,
	idtipovehiculo integer not null,
	placa varchar(10) not null,
	descripcion varchar(500),
	estadoregistro char(1) default 'A' not null, 
	fechacreacion timestamp with time zone default current_timestamp not null
);
alter table admin.vehiculo add constraint pk_vehiculo primary key (idvehiculo);
alter table admin.vehiculo add constraint fk_tipovehiculo foreign key (idtipovehiculo) references admin.tipovehiculo(idtipovehiculo);
alter table admin.vehiculo add constraint uk_vehiculo_placa unique(placa);

create index ix_vehiculo_001 on admin.vehiculo(idtipovehiculo);
create index ix_vehiculo_002 on admin.vehiculo(placa);

create sequence admin.seq_vehiculo_pk increment 1 start 1 minvalue 1 maxvalue 999999999999;

insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'GO-2226','NISSAN SENTRA VERDE');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'D1Z658','KIA RIO BLANCO');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'ALX-443','TOYOTA YARIS NEGRO');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'ANX-520','NISSAN SUNNY BLANCO');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'AHO-071','PEUGEOT 208');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'AHH-662','HYUNDAI TERCEL GRIS');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'AIE-552','NISSAN SENTRA ROJO');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'F7L-157','HAFEI NEW MINYI BLANCO');
insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion) values (nextval('admin.seq_vehiculo_pk'),1,'P20-856','NISSAN FRONTIER AZUL');

-- ============================================================
-- Tabla clientevehiculo
-- ============================================================ 

create table admin.clientevehiculo (
	idclientevehiculo bigint not null,
	idcliente bigint not null,
	idvehiculo bigint not null,
	estadoregistro char(1) default 'A' not null, 
	fechacreacion timestamp with time zone default current_timestamp not null
);
alter table admin.clientevehiculo add constraint pk_clientevehiculo primary key (idclientevehiculo);

create index ix_clientevehiculo_001 on admin.clientevehiculo(idcliente);
create index ix_clientevehiculo_002 on admin.clientevehiculo(idvehiculo);

create sequence admin.seq_clientevehiculo_pk increment 1 start 1 minvalue 1 maxvalue 999999999999;

insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo) values (nextval('admin.seq_clientevehiculo_pk'),1,1);
insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo) values (nextval('admin.seq_clientevehiculo_pk'),2,2);
insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo) values (nextval('admin.seq_clientevehiculo_pk'),2,3);
insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo) values (nextval('admin.seq_clientevehiculo_pk'),3,4);
insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo) values (nextval('admin.seq_clientevehiculo_pk'),3,5);
insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo) values (nextval('admin.seq_clientevehiculo_pk'),3,6);
