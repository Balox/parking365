-- ============================
-- PRE-REQUISITOS
-- ============================
-- Cargar tablas:
--  UbigeoTipo
--  Ubigeo
--  Perfil
--  TipoPregunta



-- ADMIN
do $$
declare p_idubigeo int;
declare p_idperfil int;
declare p_claveadmin varchar(50);
declare p_fechaexpadmin timestamp;
declare p_respuestapreguntaadmin varchar(50);
declare p_idzonahoraria int;
declare p_saltsecret character varying;
begin
	select idubigeo into p_idubigeo from admin.ubigeo where codigoubigeo = '150103';
	select idperfil into p_idperfil from admin.perfil where idpadre = 0 and nombre = 'ADMINISTRADOR';
	select (current_timestamp + interval '100 year') into p_fechaexpadmin;
	select idzonahoraria into p_idzonahoraria from admin.zonahoraria where nombre = 'America/Lima';

	select md5('P4k1ng365') into p_RespuestaPreguntaAdmin;
	select round(extract(epoch from now())::numeric,0)::character varying into p_saltsecret;
	select md5('4dm1n@Park1ng365'||p_saltsecret) into p_ClaveAdmin;

	-- insertar usuario
	insert into admin.usuario
		(idusuario,idperfil,idzonahoraria,nombrecompleto,sexo,usuario,clave,saltsecret,diascaducidadclave,fechaexpiracion,fechacambioclave,idtipopregunta,respuestapregunta,modoconexion,token,tokengoogle,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values
		(nextval('admin.seq_usuario_pk'),p_idperfil,p_idzonahoraria,'Administrador Parking365','M','AdminParking',p_ClaveAdmin,p_saltsecret,999,p_fechaexpadmin,p_fechaexpadmin,1,p_RespuestaPreguntaAdmin,'P',null,null,1,1);

end$$
-- password: 4dm1n@Park1ng365


-- OPERADOR
do $$
declare p_idubigeo int;
declare p_idperfil int;
declare p_claveadmin varchar(50);
declare p_fechaexpadmin timestamp;
declare p_respuestapreguntaadmin varchar(50);
declare p_idzonahoraria int;
declare p_saltsecret character varying;
begin
	select idubigeo into p_idubigeo from admin.ubigeo where codigoubigeo = '150103';
	select idperfil into p_idperfil from admin.perfil where idpadre = 0 and nombre = 'OPERADOR';
	select (current_timestamp + interval '20 year') into p_fechaexpadmin;
	select idzonahoraria into p_idzonahoraria from admin.zonahoraria where nombre = 'America/Lima';

	select md5('P4k1ng365') into p_RespuestaPreguntaAdmin;
	select round(extract(epoch from now())::numeric,0)::character varying into p_saltsecret;
	select md5('123456@2019'||p_saltsecret) into p_ClaveAdmin;

	-- insertar usuario
	insert into admin.usuario
		(idusuario,idperfil,idzonahoraria,nombrecompleto,sexo,usuario,clave,saltsecret,diascaducidadclave,fechaexpiracion,fechacambioclave,idtipopregunta,respuestapregunta,modoconexion,token,tokengoogle,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values
		(nextval('admin.seq_usuario_pk'),p_idperfil,p_idzonahoraria,'Operador Parking365','M','operador',p_ClaveAdmin,p_saltsecret,999,p_fechaexpadmin,p_fechaexpadmin,1,p_RespuestaPreguntaAdmin,'P',null,null,1,1);

end$$
-- password: 123456@2019


