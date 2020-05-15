--=================================================================
-- GRANT CRUD USER parkingadmin
--=================================================================

GRANT SELECT, INSERT, UPDATE, DELETE ON admin.acceso TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.perfil TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.perfilacceso TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.ubigeo TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.ubigeotipo TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.usuario TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.usuarioacceso TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.usuariosession TO parkingadmin;
GRANT SELECT, INSERT, UPDATE, DELETE ON admin.zonahoraria TO parkingadmin;

--=================================================================
-- ALTER SEQUENCE  USER parkingadmin
--=================================================================
GRANT USAGE, SELECT ON SEQUENCE admin.seq_acceso_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_perfil_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_perfilacceso_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_ubigeo_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_ubigeotipo_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_usuario_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_usuarioacceso_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_usuariosession_pk TO parkingadmin;
GRANT USAGE, SELECT ON SEQUENCE admin.seq_zonahoraria_pk TO parkingadmin;