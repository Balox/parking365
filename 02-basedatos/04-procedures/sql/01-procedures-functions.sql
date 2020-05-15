
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <27/03/2019>
-- Description:	<obtener usuario>
-- =============================================
CREATE PROCEDURE sp_desktop_obtener_usuario
	@in_usuario varchar(320)
AS
BEGIN
	SET NOCOUNT ON;

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
		FORMAT(u.fechaexpiracion,'yyyy-MM-dd HH:mm:ss'),
		FORMAT(u.fechacambioclave,'yyyy-MM-dd HH:mm:ss'),
		u.idtipopregunta,
		u.respuestapregunta,
		u.modoconexion,
		u.token,
		u.tokengoogle,
		u.estadoregistro
	from usuario u
	inner join perfil p on u.idperfil = p.idperfil
	inner join zonahoraria z on u.idzonahoraria = z.idzonahoraria
	where u.estadoregistro = 'A'
	  and u.usuario = @in_usuario;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <27/03/2019>
-- Description:	<obtener usuarios>
-- =============================================
CREATE PROCEDURE sp_desktop_obtener_usuarios
AS
BEGIN
	SET NOCOUNT ON;

	select 
		(row_number() Over(order by u.idusuario)) item,
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
		FORMAT(u.fechaexpiracion,'yyyy-MM-dd HH:mm:ss'),
		FORMAT(u.fechacambioclave,'yyyy-MM-dd HH:mm:ss'),
		u.estadoregistro
	from usuario u
	inner join perfil p on u.idperfil = p.idperfil
	inner join zonahoraria z on u.idzonahoraria = z.idzonahoraria
	where u.estadoregistro = 'A';
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <27/03/2019>
-- Description:	<obtener usuario>
-- =============================================
CREATE PROCEDURE sp_desktop_obtener_usuario_v2
	@in_usuario varchar(320)
AS
BEGIN
	SET NOCOUNT ON;

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
		from usuario u
		inner join perfil p on u.idperfil = p.idperfil
		where u.estadoregistro = 'A'
		  and u.usuario = @in_usuario;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <27/03/2019>
-- Description:	<listar usuarios>
-- =============================================
CREATE PROCEDURE sp_desktop_usuarios_listar
	@in_usuario varchar(320)
AS
BEGIN
	SET NOCOUNT ON;

		select 
			(row_number() Over(order by u.idusuario)) item,
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
		from usuario u
		inner join perfil p on u.idperfil = p.idperfil
		where u.estadoregistro = 'A'
		  and (u.usuario = @in_usuario or @in_usuario is null);
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <27/03/2019>
-- Description:	<insertar usuario>
-- =============================================
CREATE PROCEDURE sp_desktop_usuario_insertar
	@in_idperfil integer,
	@in_nombrecompleto varchar(300),
	@in_email varchar(320),
	@in_telefono varchar(20),
	@in_usuario varchar(320),
	@in_clave varchar(150),
	@in_idusuario integer
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @saltsecret varchar(100);
	
	set @saltsecret = DATEDIFF(SECOND,'1970-01-01', GETUTCDATE());

	insert into usuario(idperfil,idzonahoraria,nombrecompleto,email,telefono,sexo,usuario,clave,saltsecret,auditoria_creacionusuario,auditoria_actualizacionusuario)
	values(@in_idperfil,146,@in_nombrecompleto,@in_email,@in_telefono,'N',@in_usuario,CONVERT(VARCHAR(150),HashBytes('MD5', @in_clave+@saltsecret),2),@saltsecret,@in_idusuario,@in_idusuario);
	
	RETURN @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <10/04/2018>
-- Description:	<ver si el email existe>
-- =============================================
CREATE FUNCTION fn_desktop_correo_existe
(
	@in_email varchar(320)
)
RETURNS bit
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar bit

	-- Add the T-SQL statements to compute the return value here
	set @ResultVar = case when exists(select 1 from usuario where email = @in_email) then 1 else 0 end;

	-- Return the result of the function
	RETURN @ResultVar

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <10/04/2018>
-- Description:	<ver si el usuario existe>
-- =============================================
CREATE FUNCTION fn_desktop_usuario_existe
(
	@in_usuario varchar(320)
)
RETURNS bit
AS
BEGIN
	-- Declare the return variable here
	DECLARE @ResultVar bit

	-- Add the T-SQL statements to compute the return value here
	set @ResultVar = case when exists(select 1 from usuario where usuario = @in_usuario) then 1 else 0 end;;

	-- Return the result of the function
	RETURN @ResultVar

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<actualizar usuario>
-- =============================================
CREATE PROCEDURE sp_desktop_usuario_actualizar
	@in_idusuario integer,
	@in_idperfil integer,
	@in_nombrecompleto varchar(300),
	@in_email varchar(320),
	@in_telefono varchar(20),
	@in_usuario varchar(320),
	@in_clave varchar(150),
	@in_idusuarioupdate integer
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @saltsecret varchar(100);
	
	set @saltsecret = DATEDIFF(SECOND,'1970-01-01', GETUTCDATE());

	update usuario
	set idperfil = @in_idperfil,
		nombrecompleto = @in_nombrecompleto,
		email = @in_email,
		telefono = @in_telefono,
		usuario = @in_usuario,
		clave = CONVERT(VARCHAR(150),HashBytes('MD5', @in_clave+@saltsecret),2),
		saltsecret = @saltsecret,
		auditoria_actualizacionusuario = @in_idusuarioupdate
	where idusuario = @in_idusuario;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<eliminar usuario logicamente>
-- =============================================
CREATE PROCEDURE sp_desktop_usuario_eliminar
	@in_idusuario integer,
	@in_idusuarioupdate integer
AS
BEGIN
	SET NOCOUNT ON;

	update admin.usuario
	set estadoregistro = 'E',
		auditoria_actualizacionusuario = @in_idusuarioupdate
	where idusuario = @in_idusuario;	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<eliminar usuario logicamente>
-- =============================================
CREATE PROCEDURE sp_desktop_cliente_listar
	@in_documento varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	select
		(row_number() Over(order by c.idcliente)) item,
		c.idcliente,
		c.idtipocliente,
		(case when c.idtipocliente = 1 then 'NATURAL' else 'JURIDICA' end) tipocliente,
		c.idtipodocumento,
		(case when c.idtipodocumento = 1 then 'DNI' else 'RUC' end) tipodocumento,
		c.documento,
		c.nombre,
		c.representante,
		c.telefono,
		c.email,
		c.observacion,
		c.estadoregistro,
		isnull(v.vehiculos,0) 
	from cliente c
	left join (
		select t.idcliente, count(1) as vehiculos 
		from clientevehiculo t
		where t.estadoregistro = 'A' 
		group by t.idcliente
	) v on c.idcliente = v.idcliente
	where c.estadoregistro = 'A'
	  and (c.documento like @in_documento + '%' or @in_documento is null);	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<insertar cliente>
-- =============================================
CREATE PROCEDURE sp_desktop_cliente_insertar
	@in_idtipocliente integer,
	@in_idtipodocumento integer,
	@in_documento varchar(20),
	@in_nombre varchar(120),
	@in_representante varchar(120),
	@in_telefono varchar(20),
	@in_email varchar(320),
	@in_observacion varchar(500),
	@in_idusuario integer
AS
BEGIN
	SET NOCOUNT ON;
	
	insert into cliente(
		idtipocliente,
		idtipodocumento,
		documento,
		nombre,
		representante,
		telefono,
		email,
		observacion,
		auditoria_creacionusuario,
		auditoria_actualizacionusuario)
	values(
		@in_idtipocliente,
		@in_idtipodocumento,
		@in_documento,
		@in_nombre,
		@in_representante,
		@in_telefono,
		@in_email,
		@in_observacion,
		@in_idusuario,
		@in_idusuario);
	
	RETURN @@IDENTITY;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<actualizar cliente>
-- =============================================
CREATE PROCEDURE sp_desktop_cliente_actualizar
	@in_idcliente bigint,
	@in_idtipocliente integer,
	@in_idtipodocumento integer,
	@in_documento varchar(20),
	@in_nombre varchar(120),
	@in_representante varchar(120),
	@in_telefono varchar(20),
	@in_email varchar(320),
	@in_observacion varchar(500),
	@in_idusuario integer
AS
BEGIN
	SET NOCOUNT ON;
	
	update cliente
	set idtipocliente 	= @in_idtipocliente,
		idtipodocumento = @in_idtipodocumento,
		documento 		= @in_documento,
		nombre 			= @in_nombre,
		representante	= @in_representante,
		telefono 		= @in_telefono,
		email 			= @in_email,
		observacion 	= @in_observacion,
		auditoria_actualizacionusuario = @in_idusuario
	where idcliente = @in_idcliente;
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<actualizar cliente>
-- =============================================
CREATE PROCEDURE sp_desktop_cliente_eliminar
	@in_idcliente bigint,
	@in_idusuarioupdate integer
AS
BEGIN
	SET NOCOUNT ON;
	
	update cliente
	set estadoregistro = 'E',
		auditoria_actualizacionusuario = @in_idusuarioupdate
	where idcliente = @in_idcliente;
	
END
GO


-- ============================================================
-- FUNCIONES DE VEHICULO
-- ============================================================ 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<listar vehiculos por placa>
-- =============================================
CREATE PROCEDURE sp_desktop_vehiculo_listar_por_placa
	@in_placa varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	
	select
		(row_number() Over(order by v.idvehiculo)) item,
		v.idvehiculo,
		v.placa,
		t.idtipovehiculo,
		t.nombre as tipovehiculo,
		v.descripcion,
		v.estadoregistro,
		coalesce(cv.idclientevehiculo,0),
		coalesce(cv.idcliente,0),
		c.nombre as propietario
	from vehiculo v
	inner join tipovehiculo t on v.idtipovehiculo = t.idtipovehiculo
	left join clientevehiculo cv on v.idvehiculo = cv.idvehiculo
	left join cliente c on cv.idcliente = c.idcliente and c.estadoregistro = 'A'
	where v.estadoregistro = 'A'
	  and (v.placa like @in_placa + '%' or @in_placa is null);	
	
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<listar vehiculos por nombre cliente>
-- =============================================
CREATE PROCEDURE sp_desktop_vehiculo_listar_por_cliente
	@in_nombre varchar(120)
AS
BEGIN
	SET NOCOUNT ON;
	
	select
		(row_number() Over(order by v.idvehiculo)) item,
		v.idvehiculo,
		v.placa,
		t.idtipovehiculo,
		t.nombre as tipovehiculo,
		v.descripcion,
		v.estadoregistro,
		cv.idclientevehiculo,
		cv.idcliente,
		c.nombre as propietario
	from vehiculo v
	inner join tipovehiculo t on v.idtipovehiculo = t.idtipovehiculo
	inner join clientevehiculo cv on v.idvehiculo = cv.idvehiculo
	inner join cliente c on cv.idcliente = c.idcliente
	where v.estadoregistro = 'A' and c.estadoregistro = 'A'
	  and (c.nombre like @in_nombre + '%' or @in_nombre is null);
		
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<insertar vehiculo>
-- =============================================
CREATE PROCEDURE sp_desktop_vehiculo_insertar
	@in_idtipovehiculo integer,
	@in_placa varchar(10),
	@in_descripcion  varchar(500),
	@in_idcliente bigint
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @idvehiculo bigint;
	
	-- insertar vehiculo
	insert into vehiculo(idtipovehiculo,placa,descripcion) values (@in_idtipovehiculo,@in_placa,@in_descripcion);
	
	set @idvehiculo = @@IDENTITY;

	if (@idvehiculo > 0)
	begin
		if (@in_idcliente > 0)
		begin
			-- insertar clientevehiculo
			insert into clientevehiculo(idcliente,idvehiculo) values (@in_idcliente,@idvehiculo);
		end
	end
	
	RETURN @idvehiculo;
		
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<actualizar vehiculo>
-- =============================================
CREATE PROCEDURE sp_desktop_vehiculo_actualizar
	@in_idvehiculo bigint,
	@in_idtipovehiculo integer,
	@in_placa varchar(10),
	@in_descripcion  varchar(500),
	@in_idclientevehiculo bigint,
	@in_idcliente bigint
AS
BEGIN
	SET NOCOUNT ON;
	
	-- actualizar vehiculo
	update vehiculo
	set idtipovehiculo 	= @in_idtipovehiculo,
		placa 			= @in_placa,
		descripcion 	= @in_descripcion
	where idvehiculo 	= @in_idvehiculo;
	
	if (@in_idclientevehiculo > 0)
	begin
		update clientevehiculo
		set idcliente 	= @in_idcliente,
			idvehiculo 	= @in_idvehiculo
		where idclientevehiculo = @in_idclientevehiculo;
	end
	else
	begin
		if (@in_idcliente > 0)
		begin
			-- insertar nuevo propietario
			insert into clientevehiculo(idcliente,idvehiculo) values (@in_idcliente,@in_idvehiculo);
		end
	end
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Eduardo Palomino>
-- Create date: <11/04/2019>
-- Description:	<eliminar vehiculo>
-- =============================================
CREATE PROCEDURE sp_desktop_vehiculo_eliminar
	@in_idvehiculo bigint,
	@in_idclientevehiculo bigint
AS
BEGIN
	SET NOCOUNT ON;
	
	update vehiculo
	set estadoregistro = 'E'
	where idvehiculo = @in_idvehiculo;
	
	update clientevehiculo
	set estadoregistro = 'E'
	where idclientevehiculo = @in_idclientevehiculo;
	
END
GO














