-- ============================================================
-- ACTUALIZAR FUNCIONES DE CLIENTE
-- ============================================================ 

-- Function: admin.fn_desktop_cliente_actualizar(bigint, integer, integer, character varying, character varying, character varying, character varying, character varying, character varying, integer)
-- DROP FUNCTION admin.fn_desktop_cliente_actualizar(bigint, integer, integer, character varying, character varying, character varying, character varying, character varying, character varying, integer);
CREATE OR REPLACE FUNCTION admin.fn_desktop_cliente_actualizar(
	IN in_idcliente bigint,
	IN in_idtipocliente integer,
	IN in_idtipodocumento integer,
	IN in_documento character varying,
	IN in_nombre character varying,
	IN in_representante character varying,
	IN in_telefono character varying,
	IN in_email character varying,
	IN in_observacion character varying,
	IN in_idusuario	integer)
  RETURNS boolean AS
$BODY$
BEGIN
	
	update admin.cliente
	set idtipocliente = in_idtipocliente,
		idtipodocumento = in_idtipodocumento,
		documento = in_documento,
		nombre = in_nombre,
		representante = in_representante,
		telefono = in_telefono,
		email = in_email,
		observacion = in_observacion,
		auditoria_actualizacionusuario = in_idusuario
	where idcliente = in_idcliente;	
	
	return FOUND;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  
-- Function: admin.fn_desktop_cliente_listar(character varying)	
-- DROP FUNCTION admin.fn_desktop_cliente_listar(character varying);
CREATE OR REPLACE FUNCTION admin.fn_desktop_cliente_listar(IN in_documento character varying)
  RETURNS TABLE (
	item integer,
	idcliente bigint,
	idtipocliente integer,
	tipocliente character varying,
	idtipodocumento integer,
	tipodocumento character varying,
	documento character varying,
	nombre character varying,
	representante character varying,
	telefono character varying,
	email character varying,
	observacion character varying,
	estadoregistro character,
	vehiculos integer
  ) AS
$BODY$
BEGIN
	return query	
		select
			(row_number() Over(order by c.idcliente))::integer as item,
			c.idcliente,
			c.idtipocliente,
			(case when c.idtipocliente = 1 then 'NATURAL' else 'JURIDICA' end)::character varying as tipocliente,
			c.idtipodocumento,
			(case when c.idtipodocumento = 1 then 'DNI' else 'RUC' end)::character varying as tipodocumento,
			c.documento,
			c.nombre,
			c.representante,
			c.telefono,
			c.email,
			c.observacion,
			c.estadoregistro,
			coalesce(v.vehiculos,0)::integer
		from admin.cliente c
		left join (
			select t.idcliente, count(1) as vehiculos 
			from admin.clientevehiculo t
			where t.estadoregistro = 'A' 
			group by t.idcliente
		) v on c.idcliente = v.idcliente
		where c.estadoregistro = 'A'
		  and (c.documento like in_documento || '%' or in_documento is null);
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100
  ROWS 100;

-- ============================================================
-- FUNCIONES DE VEHICULO
-- ============================================================   
  
-- Function: admin.fn_desktop_vehiculo_listar(boolean,character varying)	
-- DROP FUNCTION admin.fn_desktop_vehiculo_listar(boolean, character varying);
CREATE OR REPLACE FUNCTION admin.fn_desktop_vehiculo_listar(
	IN in_porplaca boolean,
	IN in_texto character varying)
  RETURNS TABLE (
	item integer,
	idvehiculo bigint,
	placa character varying,
	idtipovehiculo integer,
	tipovehiculo character varying,
	descripcion character varying,
	estadoregistro character,
	idclientevehiculo bigint,
	idcliente bigint,
	propietario character varying
  ) AS
$BODY$
BEGIN
	if (in_porplaca) then
		return query
			select
				(row_number() Over(order by v.idvehiculo))::integer as item,
				v.idvehiculo,
				v.placa,
				t.idtipovehiculo,
				t.nombre as tipovehiculo,
				v.descripcion,
				v.estadoregistro,
				coalesce(cv.idclientevehiculo,0)::bigint,
				coalesce(cv.idcliente,0)::bigint,
				c.nombre as propietario
			from admin.vehiculo v
			inner join admin.tipovehiculo t on v.idtipovehiculo = t.idtipovehiculo
			left join admin.clientevehiculo cv on v.idvehiculo = cv.idvehiculo
			left join admin.cliente c on cv.idcliente = c.idcliente and c.estadoregistro = 'A'
			where v.estadoregistro = 'A'
			  and (v.placa like in_texto || '%' or in_texto is null);	
	else
		return query
			select
				(row_number() Over(order by v.idvehiculo))::integer as item,
				v.idvehiculo,
				v.placa,
				t.idtipovehiculo,
				t.nombre as tipovehiculo,
				v.descripcion,
				v.estadoregistro,
				cv.idclientevehiculo,
				cv.idcliente,
				c.nombre as propietario
			from admin.vehiculo v
			inner join admin.tipovehiculo t on v.idtipovehiculo = t.idtipovehiculo
			inner join admin.clientevehiculo cv on v.idvehiculo = cv.idvehiculo
			inner join admin.cliente c on cv.idcliente = c.idcliente
			where v.estadoregistro = 'A' and c.estadoregistro = 'A'
			  and (c.nombre like in_texto || '%' or in_texto is null);
	end if;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100
  ROWS 100;


-- Function: admin.fn_desktop_vehiculo_insertar(integer, character varying, character varying, bigint)
-- DROP FUNCTION admin.fn_desktop_vehiculo_insertar(integer, character varying, character varying, bigint);
CREATE OR REPLACE FUNCTION admin.fn_desktop_vehiculo_insertar(
	IN in_idtipovehiculo integer,
	IN in_placa character varying,
	IN in_descripcion character varying,
	IN in_idcliente	bigint)
  RETURNS bigint AS
$BODY$
DECLARE v_idvehiculo bigint:=0;
BEGIN
	-- insertar vehiculo
	insert into admin.vehiculo(idvehiculo,idtipovehiculo,placa,descripcion)
	values (nextval('admin.seq_vehiculo_pk'),in_idtipovehiculo,in_placa,in_descripcion)
	returning idvehiculo into v_idvehiculo;

	if (v_idvehiculo > 0) then
		if (in_idcliente > 0) then
			-- insertar clientevehiculo
			insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo)
			values (nextval('admin.seq_clientevehiculo_pk'),in_idcliente,v_idvehiculo);
		end if;
	end if;
	
	return v_idvehiculo;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  

-- Function: admin.fn_desktop_vehiculo_actualizar(bigint, integer, character varying, character varying, bigint, bigint);
-- DROP FUNCTION admin.fn_desktop_vehiculo_actualizar(bigint, integer, character varying, character varying, bigint, bigint);
CREATE OR REPLACE FUNCTION admin.fn_desktop_vehiculo_actualizar(
	IN in_idvehiculo bigint,
	IN in_idtipovehiculo integer,
	IN in_placa character varying,
	IN in_descripcion character varying,
	IN in_idclientevehiculo bigint,
	IN in_idcliente	bigint)
  RETURNS bigint AS
$BODY$
declare v_idcliente bigint:=0;
BEGIN
	-- actualizar vehiculo
	update admin.vehiculo
	set idtipovehiculo = in_idtipovehiculo,
		placa = in_placa,
		descripcion = in_descripcion
	where idvehiculo = in_idvehiculo;
	
	if (in_idclientevehiculo > 0) then
		update admin.clientevehiculo
		set idcliente = in_idcliente,
			idvehiculo = in_idvehiculo
		where idclientevehiculo = in_idclientevehiculo;
	else
		if (in_idcliente > 0) then
			-- insertar nuevo propietario
			insert into admin.clientevehiculo(idclientevehiculo,idcliente,idvehiculo)
			values (nextval('admin.seq_clientevehiculo_pk'),in_idcliente,in_idvehiculo);
		end if;
	end if;
	
	return FOUND;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;  


-- Function: admin.fn_desktop_vehiculo_eliminar(bigint, bigint)
-- DROP FUNCTION admin.fn_desktop_vehiculo_eliminar(bigint, bigint);
CREATE OR REPLACE FUNCTION admin.fn_desktop_vehiculo_eliminar(
	IN in_idvehiculo bigint,
	IN in_idclientevehiculo bigint)
  RETURNS boolean AS
$BODY$
BEGIN
	update admin.vehiculo
	set estadoregistro = 'E'
	where idvehiculo = in_idvehiculo;
	
	update admin.clientevehiculo
	set estadoregistro = 'E'
	where idclientevehiculo = in_idclientevehiculo;
	
	return FOUND;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  
  
  

select idtipovehiculo,nombre from admin.tipovehiculo;


select idvehiculo,idtipovehiculo,placa,descripcion from admin.vehiculo;
select idclientevehiculo,idcliente,idvehiculo from admin.clientevehiculo;

select * from admin.cliente;
--update admin.cliente set estadoregistro = 'A' where idcliente = 3

select * from admin.fn_desktop_vehiculo_listar('true', 'A');
select * from admin.fn_desktop_vehiculo_listar('false', 'V');
-- admin.fn_desktop_vehiculo_insertar(integer, character varying, character varying, integer);

  
-- ============================================================
-- Tabla modulo
-- ============================================================ 

create table admin.modulo (
	idmodulo integer not nul,
	serialnumber varchar(64),
	et
	token varchar(64) not null,
	macabonado varchar(20) not null,
	ip varchar(20),
	port varchar(10),
	conectado integer default 0 not null,

);

--- ip, puerto, conectado, sincronizado, token, 

-- VER ESTE LINK 
-- https://www.youtube.com/watch?v=6VdIEovint8
-- ver proceso de ingreso y salida