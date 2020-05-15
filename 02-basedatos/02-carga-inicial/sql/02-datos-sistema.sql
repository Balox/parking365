-- ============================
-- PRE-REQUISITOS
-- ============================
-- Cargar tablas:
--  UbigeoTipo
--  Ubigeo
--  Perfil
--  TipoPregunta



-- ADMIN

declare @idubigeo int;
declare @idperfil int;
declare @claveadmin varchar(50);
declare @fechaexpadmin datetime;
declare @respuestapreguntaadmin varchar(50);
declare @idzonahoraria int;
declare @saltsecret varchar(100);
begin
	select @idubigeo = idubigeo from ubigeo where codigoubigeo = '150103';
	select @idperfil = idperfil from perfil where idpadre = 0 and nombre = 'ADMINISTRADOR';
	select @fechaexpadmin = DATEADD(year,100, GETDATE());
	select @idzonahoraria = idzonahoraria from zonahoraria where nombre = 'America/Lima';

	set @RespuestaPreguntaAdmin = CONVERT(VARCHAR(150),HashBytes('MD5', 'P4k1ng365'),2);
	set @saltsecret = DATEDIFF(SECOND,'1970-01-01', GETUTCDATE());
	set @ClaveAdmin = CONVERT(VARCHAR(150),HashBytes('MD5', '4dm1n@Park1ng365'+@saltsecret),2);

	-- insertar usuario
	insert into usuario
		(idperfil,idzonahoraria,nombrecompleto,sexo,usuario,clave,saltsecret,diascaducidadclave,fechaexpiracion,fechacambioclave,idtipopregunta,respuestapregunta,modoconexion,token,tokengoogle,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values
		(@idperfil,@idzonahoraria,'Administrador Parking365','M','AdminParking',@ClaveAdmin,@saltsecret,999,@fechaexpadmin,@fechaexpadmin,1,@RespuestaPreguntaAdmin,'P',null,null,1,1);

end
-- password: 4dm1n@Park1ng365


-- OPERADOR
declare @idubigeo int;
declare @idperfil int;
declare @claveadmin varchar(50);
declare @fechaexpadmin datetime;
declare @respuestapreguntaadmin varchar(50);
declare @idzonahoraria int;
declare @saltsecret varchar(100);
begin
	select @idubigeo = idubigeo from ubigeo where codigoubigeo = '150103';
	select @idperfil = idperfil from perfil where idpadre = 0 and nombre = 'OPERADOR';
	select @fechaexpadmin = DATEADD(year,100, GETDATE());
	select @idzonahoraria = idzonahoraria from zonahoraria where nombre = 'America/Lima';

	set @RespuestaPreguntaAdmin = CONVERT(VARCHAR(150),HashBytes('MD5', 'P4k1ng365'),2);
	set @saltsecret = DATEDIFF(SECOND,'1970-01-01', GETUTCDATE());
	set @ClaveAdmin = CONVERT(VARCHAR(150),HashBytes('MD5', '123456@2019'+@saltsecret),2);
	
	-- insertar usuario
	insert into usuario
		(idperfil,idzonahoraria,nombrecompleto,sexo,usuario,clave,saltsecret,diascaducidadclave,fechaexpiracion,fechacambioclave,idtipopregunta,respuestapregunta,modoconexion,token,tokengoogle,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values
		(@idperfil,@idzonahoraria,'Operador Parking365','M','operador',@ClaveAdmin,@saltsecret,999,@fechaexpadmin,@fechaexpadmin,1,@RespuestaPreguntaAdmin,'P',null,null,1,1);

end
-- password: 123456@2019


