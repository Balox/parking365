-- ============================================================
-- Funciones CLIENTE
-- ============================================================ 

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
		  and c.documento like in_documento || '%' or in_documento is null;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100
  ROWS 100;

-- Function: admin.fn_desktop_cliente_insertar(integer, integer, character varying, character varying, character varying, character varying, character varying, character varying, integer)
-- DROP FUNCTION admin.fn_desktop_cliente_insertar(integer, integer, character varying, character varying, character varying, character varying, character varying, character varying, integer);
CREATE OR REPLACE FUNCTION admin.fn_desktop_cliente_insertar(
	IN in_idtipocliente integer,
	IN in_idtipodocumento integer,
	IN in_documento character varying,
	IN in_nombre character varying,
	IN in_representante character varying,
	IN in_telefono character varying,
	IN in_email character varying,
	IN in_observacion character varying,
	IN in_idusuario	integer)
  RETURNS bigint AS
$BODY$
DECLARE p_cliente bigint:=0;
BEGIN

	insert into admin.cliente(idcliente,idtipocliente,idtipodocumento,documento,nombre,representante,telefono,email,observacion,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values(nextval('admin.seq_cliente_pk'),in_idtipocliente,in_idtipodocumento,in_documento,in_nombre,in_representante,in_telefono,in_email,in_observacion,in_idusuario,in_idusuario)
	returning idcliente into p_cliente;
	
	return p_cliente;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;

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

-- Function: admin.fn_desktop_cliente_eliminar(bigint, integer)
-- DROP FUNCTION admin.fn_desktop_cliente_eliminar(bigint, integer);
CREATE OR REPLACE FUNCTION admin.fn_desktop_cliente_eliminar(
	IN in_idcliente	bigint,
	IN in_idusuarioupdate integer)
  RETURNS boolean AS
$BODY$
BEGIN
	update admin.cliente
	set estadoregistro = 'E',
		auditoria_actualizacionusuario = in_idusuarioupdate
	where idcliente = in_idcliente;	
	
	return FOUND;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  
-- ============================================================
-- agregar permisos
-- ============================================================ 

GRANT SELECT, INSERT, UPDATE, DELETE ON admin.tipovehiculo TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.cliente TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.vehiculo TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.clientevehiculo TO parkingadmin;

GRANT USAGE, SELECT ON SEQUENCE admin.seq_cliente_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_vehiculo_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_clientevehiculo_pk TO parkingadmin;


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