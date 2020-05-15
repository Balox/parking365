insert into cliente(documento,nombre,telefono,email,auditoria_creacionusuario,auditoria_actualizacionusuario)
values ('44998748','JAIR RAMIREZ GOMEZ','987487987','jramires.gomez@gmail.com',1,1);
insert into cliente(documento,nombre,telefono,email,auditoria_creacionusuario,auditoria_actualizacionusuario)
values ('4789658','VICTORIA CHAVEZ SALAS','965874889','chvicky.salas@gmail.com',1,1);
insert into cliente(idtipocliente,idtipodocumento,documento,nombre,representante,telefono,email,auditoria_creacionusuario,auditoria_actualizacionusuario)
values (2,2,'10478965483','CONSTRUCCIONES TECHITO SAC','DAVID ALEJANDRO MENDOZA FALLA','(511) 7896548','mdavid.falla@techito.pe',1,1);
GO

insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'GO-2226','NISSAN SENTRA VERDE');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'D1Z658','KIA RIO BLANCO');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'ALX-443','TOYOTA YARIS NEGRO');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'ANX-520','NISSAN SUNNY BLANCO');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'AHO-071','PEUGEOT 208');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'AHH-662','HYUNDAI TERCEL GRIS');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'AIE-552','NISSAN SENTRA ROJO');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'F7L-157','HAFEI NEW MINYI BLANCO');
insert into vehiculo(idtipovehiculo,placa,descripcion) values (1,'P20-856','NISSAN FRONTIER AZUL');
GO

insert into clientevehiculo(idcliente,idvehiculo) values (1,1);
insert into clientevehiculo(idcliente,idvehiculo) values (2,2);
insert into clientevehiculo(idcliente,idvehiculo) values (2,3);
insert into clientevehiculo(idcliente,idvehiculo) values (3,4);
insert into clientevehiculo(idcliente,idvehiculo) values (3,5);
insert into clientevehiculo(idcliente,idvehiculo) values (3,6);
GO
