/*
*	N° 1
*	autor: Eduardo Palomino
*	fecha: 05/03/2019
*	descripcion: obtener usuario
*/
-- Function: admin.fn_desktop_obtener_usuario(character varying)
-- DROP FUNCTION admin.fn_desktop_obtener_usuario(character varying);
CREATE OR REPLACE FUNCTION admin.fn_desktop_obtener_usuario(IN in_usuario character varying)
  RETURNS TABLE (
	idusuario integer,
	idperfil integer,
	perfil character varying,
	idzonahoraria integer,
	zonahoraria character varying,
	utc_offset interval,
	nombrecompleto character varying,
	email character varying,
	telefono character varying,
	sexo character,
	usuario character varying,
	clave character varying,
	saltsecret character varying,
	diascaducidadclave integer,
	fechaexpiracion character varying,
	fechacambioclave character varying,
	idtipopregunta integer,
	respuestapregunta character varying,
	modoconexion character varying,
	token character varying,
	tokengoogle character varying,
	estadoregistro character
  ) AS
$BODY$
BEGIN
	return query	
		select 
			u.idusuario,
			u.idperfil,
			p.nombre as perfil,
			u.idzonahoraria,
			z.nombre as zonahoraria,
			z.utc_offset,
			u.nombrecompleto,
			u.email,
			u.telefono,
			u.sexo,
			u.usuario,
			u.clave,
			u.saltsecret,
			u.diascaducidadclave,
			to_char(u.fechaexpiracion, 'YYYY-MM-DD HH24:MI:SS:MS')::character varying,
			to_char(u.fechacambioclave, 'YYYY-MM-DD HH24:MI:SS:MS')::character varying,
			u.idtipopregunta,
			u.respuestapregunta,
			u.modoconexion,
			u.token,
			u.tokengoogle,
			u.estadoregistro
		from admin.usuario u
		inner join admin.perfil p on u.idperfil = p.idperfil
		inner join admin.zonahoraria z on u.idzonahoraria = z.idzonahoraria
		where u.estadoregistro = 'A'
		  and u.usuario = in_usuario;

END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;

  
/*
*	N° 2
*	autor: Eduardo Palomino
*	fecha: 27/03/2019
*	descripcion: obtener usuarios
*/
-- Function: admin.fn_desktop_obtener_usuarios()
-- DROP FUNCTION admin.fn_desktop_obtener_usuarios();
CREATE OR REPLACE FUNCTION admin.fn_desktop_obtener_usuarios()
  RETURNS TABLE (
	item integer,
	idusuario integer,
	idperfil integer,
	perfil character varying,
	idzonahoraria integer,
	zonahoraria character varying,
	utc_offset interval,
	nombrecompleto character varying,
	email character varying,
	telefono character varying,
	sexo character,
	usuario character varying,
	diascaducidadclave integer,
	fechaexpiracion character varying,
	fechacambioclave character varying,
	estadoregistro character
  ) AS
$BODY$
BEGIN
	return query	
		select
			(row_number() Over(order by u.idusuario))::integer as item,
			u.idusuario,
			u.idperfil,
			p.nombre as perfil,
			u.idzonahoraria,
			z.nombre as zonahoraria,
			z.utc_offset,
			u.nombrecompleto,
			u.email,
			u.telefono,
			u.sexo,
			u.usuario,
			u.diascaducidadclave,
			to_char(u.fechaexpiracion, 'YYYY-MM-DD HH24:MI:SS:MS')::character varying,
			to_char(u.fechacambioclave, 'YYYY-MM-DD HH24:MI:SS:MS')::character varying,
			u.estadoregistro
		from admin.usuario u
		inner join admin.perfil p on u.idperfil = p.idperfil
		inner join admin.zonahoraria z on u.idzonahoraria = z.idzonahoraria
		where u.estadoregistro = 'A';
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100
  ROWS 100;
  
  
/*
*	N° 3
*	autor: Eduardo Palomino
*	fecha: 03/04/2019
*	descripcion: obtener usuario
*/
-- Function: admin.fn_desktop_obtener_usuario_v2(character varying)
-- DROP FUNCTION admin.fn_desktop_obtener_usuario_v2(character varying);
CREATE OR REPLACE FUNCTION admin.fn_desktop_obtener_usuario_v2(IN in_usuario character varying)
  RETURNS TABLE (
	idusuario integer,
	idperfil integer,
	perfil character varying,
	nombrecompleto character varying,
	email character varying,
	telefono character varying,
	sexo character,
	usuario character varying,
	clave character varying,
	saltsecret character varying,
	estadoregistro character
  ) AS
$BODY$
BEGIN
	return query	
		select 
			u.idusuario,
			u.idperfil,
			p.nombre as perfil,
			u.nombrecompleto,
			u.email,
			u.telefono,
			u.sexo,
			u.usuario,
			u.clave,
			u.saltsecret,
			u.estadoregistro
		from admin.usuario u
		inner join admin.perfil p on u.idperfil = p.idperfil
		where u.estadoregistro = 'A'
		  and u.usuario = in_usuario;

END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  
  
/*
*	N° 4
*	autor: Eduardo Palomino
*	fecha: 04/04/2019
*	descripcion: listar usuarios
*/
-- Function: admin.fn_desktop_usuarios_listar(character varying)
-- DROP FUNCTION admin.fn_desktop_usuarios_listar(character varying);
CREATE OR REPLACE FUNCTION admin.fn_desktop_usuarios_listar(IN in_usuario character varying)
  RETURNS TABLE (
	item integer,
	idusuario integer,
	idperfil integer,
	perfil character varying,
	nombrecompleto character varying,
	email character varying,
	telefono character varying,
	sexo character,
	usuario character varying,
	clave character varying,
	saltsecret character varying,
	estadoregistro character
  ) AS
$BODY$
BEGIN
	return query
		select 
			(row_number() Over(order by u.idusuario))::integer as item,
			u.idusuario,
			u.idperfil,
			p.nombre,
			u.nombrecompleto,
			u.email,
			u.telefono,
			u.sexo,
			u.usuario,
			u.clave,
			u.saltsecret,
			u.estadoregistro
		from admin.usuario u
		inner join admin.perfil p on u.idperfil = p.idperfil
		where u.estadoregistro = 'A'
		  and u.usuario like in_usuario || '%' or in_usuario is null;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100
  ROWS 100;
  
  
/*
*	N° 5
*	autor: Eduardo Palomino
*	fecha: 04/10/2019
*	descripcion: insertar usuario
*/
CREATE OR REPLACE FUNCTION admin.fn_desktop_usuario_insertar(
	IN in_idperfil integer,
	IN in_nombrecompleto character varying,
	IN in_email character varying,
	IN in_telefono character varying,
	IN in_usuario character varying,
	IN in_clave character varying,
	IN in_idusuario	integer)
  RETURNS integer AS
$BODY$
DECLARE p_saltsecret character varying;
DECLARE p_idusuario integer:=0;
BEGIN
	select round(extract(epoch from now())::numeric,0)::character varying into p_saltsecret;

	insert into admin.usuario(idusuario,idperfil,idzonahoraria,nombrecompleto,email,telefono,sexo,usuario,clave,saltsecret,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values(nextval('admin.seq_usuario_pk'),in_idperfil,146,in_nombrecompleto,in_email,in_telefono,'N',in_usuario,md5(in_clave||p_saltsecret),p_saltsecret,in_idusuario,in_idusuario)
	returning idusuario into p_idusuario;
	
	return p_idusuario;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;

/*
*	N° 6
*	autor: Eduardo Palomino
*	fecha: 10/04/2018
*	descripcion: ver si el email existe
*/
CREATE OR REPLACE FUNCTION admin.fn_desktop_correo_existe(IN in_email character varying)
	RETURNS boolean AS
$BODY$
begin	
	return
		exists(select 1 from admin.usuario where email = in_email); 
end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
  
/*
*	N° 7
*	autor: Eduardo Palomino
*	fecha: 10/04/2018
*	descripcion: ver si el usuario existe
*/
CREATE OR REPLACE FUNCTION admin.fn_desktop_usuario_existe(IN in_usuario character varying)
	RETURNS boolean AS
$BODY$
begin	
	return
		exists(select 1 from admin.usuario where usuario = in_usuario); 
end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;


/*
*	N° 8
*	autor: Eduardo Palomino
*	fecha: 11/04/2019
*	descripcion: actualizar usuario
*/

CREATE OR REPLACE FUNCTION admin.fn_desktop_usuario_actualizar(
	IN in_idusuario	integer,
	IN in_idperfil integer,
	IN in_nombrecompleto character varying,
	IN in_email character varying,
	IN in_telefono character varying,
	IN in_usuario character varying,
	IN in_clave character varying,
	IN in_idusuarioupdate integer)
  RETURNS boolean AS
$BODY$
DECLARE p_saltsecret character varying;
BEGIN
	select round(extract(epoch from now())::numeric,0)::character varying into p_saltsecret;

	update admin.usuario
	set idperfil = in_idperfil,
		nombrecompleto = in_nombrecompleto,
		email = in_email,
		telefono = in_telefono,
		usuario = in_usuario,
		clave = md5(in_clave||p_saltsecret),
		saltsecret = p_saltsecret,
		auditoria_actualizacionusuario = in_idusuarioupdate
	where idusuario = in_idusuario;	
	
	return FOUND;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  
/*
*	N° 9
*	autor: Eduardo Palomino
*	fecha: 11/04/2019
*	descripcion: eliminar usuario logicamente
*/
CREATE OR REPLACE FUNCTION admin.fn_desktop_usuario_eliminar(
	IN in_idusuario	integer,
	IN in_idusuarioupdate integer)
  RETURNS boolean AS
$BODY$
BEGIN
	update admin.usuario
	set estadoregistro = 'E',
		auditoria_actualizacionusuario = in_idusuarioupdate
	where idusuario = in_idusuario;	
	
	return FOUND;
END
$BODY$
  LANGUAGE plpgsql volatile
  COST 100;
  
  
  



