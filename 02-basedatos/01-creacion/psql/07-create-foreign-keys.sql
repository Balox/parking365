-- ==================================================
-- FOREIGN KEY
-- ==================================================

ALTER TABLE admin.perfilacceso ADD CONSTRAINT fk_acceso_perfilacceso FOREIGN KEY ( idacceso ) REFERENCES admin.acceso ( idacceso ) ;

ALTER TABLE admin.usuarioacceso ADD CONSTRAINT fk_acceso_usuarioacceso FOREIGN KEY ( idacceso ) REFERENCES admin.acceso ( idacceso ) ;

ALTER TABLE admin.perfilacceso ADD CONSTRAINT fk_perfil_perfilacceso FOREIGN KEY ( idperfil ) REFERENCES admin.perfil ( idperfil ) ;

ALTER TABLE admin.usuario ADD CONSTRAINT fk_perfil_usuario FOREIGN KEY ( idperfil ) REFERENCES admin.perfil ( idperfil ) ;

ALTER TABLE admin.ubigeo ADD CONSTRAINT fk_ubigeotipo_ubigeo FOREIGN KEY ( idubigeotipo ) REFERENCES admin.ubigeotipo ( idubigeotipo ) ;

ALTER TABLE admin.usuarioacceso ADD CONSTRAINT fk_usuario_usuarioacceso FOREIGN KEY ( idusuario ) REFERENCES admin.usuario ( idusuario ) ;

ALTER TABLE admin.usuariosession ADD CONSTRAINT fk_usuario_usuariosession FOREIGN KEY ( idusuario ) REFERENCES admin.usuario ( idusuario ) ;

ALTER TABLE admin.usuario ADD CONSTRAINT fk_zonahoraria_usuario FOREIGN KEY ( idzonahoraria ) REFERENCES admin.zonahoraria ( idzonahoraria ) ;
