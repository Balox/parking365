'use strict';
var express = require('express');
var app = express();

const logger = require('log4js').getLogger('ws-login');
const jwtHelper = require('../../config/jwtHelper');
const ms = require('ms');
var usuarioController = require('../controllers/usuarioController');


// Login
app.get('/', function(req, res) {
    var year = (new Date).getFullYear();
    res.render('login', { heading: 'Iniciar sesión', isRegister: false, year: year });
});


app.post('/', (req, res) => {

    console.log('HOLA MUNDO....');
    res.redirect('/login');

    //req.checkBody('username', 'Usuario es requerido').notEmpty();
    //req.checkBody('password', 'Contraseña es requerida').notEmpty();
    //req.checkBody('password', 'Contraseña requiere de 8 a 30 caracteres').len(6, 30);

    //var errors = req.validationErrors();
    //var errors = req.validationErrors();
    /*
    if (errors) {
        console.log(errors);

        req.flash('error_msg', errors[0].msg);
        res.redirect('/login');
    } else {
        res.redirect('/login');
        
        passport.authenticate('local', {
            successRedirect: '/users/access',
            failureRedirect: '/users/login',
            failureFlash: true
        })(req, res, next);
    }
    */

    var username = req.body.username;
    var password = req.body.password;

    var idusuario;





    /*
    usuarioController.obtenerusuario(username, function(err, usuario) {
        if (err) {
            if (process.env.SHOW_LOG) logger.error('[obtenerusuario] Error: %s.', err);

            return res.status(500).json({
                success: false,
                message: 'Error al buscar el usuario',
                errors: err
            });
        }

        if (!usuario) {
            if (process.env.SHOW_LOG) logger.warn('WS[/api/login][username:%s] - Credenciales incorrectas.', username);

            return res.status(500).json({
                success: false,
                message: 'Credenciales incorrectas.',
                errors: { message: 'Credenciales incorrectas.' }
            });
        }

        if (usuario.estadoregistro === 'E') {
            if (process.env.SHOW_LOG) logger.warn('WS[/api/login][username:%s] - El usuario no tiene acceso al sistema fue eliminado.', username);

            return res.status(500).json({
                success: false,
                message: 'El usuario fue eliminado.',
                errors: { message: 'El usuario no tiene acceso al sistema fue eliminado.' }
            });
        }

        idusuario = usuario.idusuario;
        usuarioController.compararclave(password, usuario.saltsecret, usuario.clave, function(isMatch) {
            if (!isMatch) {
                if (process.env.SHOW_LOG) logger.warn('WS[/api/login][username:%s] - Credenciales incorrectas(compararclave).', username);

                return res.status(400).json({
                    success: false,
                    message: 'Credenciales incorrectas.',
                    errors: { message: 'Credenciales incorrectas.' }
                });
                // } else if (usuario.estadosession == '1'){
                //     // return done(null, false, { success: 3, message: 'La cuenta de usuario ya inicio sessión.' });
                //     return res.status(200).json({ success: true, message: 'La cuenta de usuario ya inicio sessión, por favor comuníquese con el Administrador del Sistema.' });
            } else if (usuario.cuentaexpirada == 1) {
                // return done(null, false, { success: 4, message: 'Cuenta de usuario ha expirado, por favor comuníquese con el Administrador del Sistema.' });
                return res.status(200).json({ success: true, message: 'Cuenta de usuario ha expirado, por favor comuníquese con el Administrador del Sistema.' });
            } else if (usuario.claveexpirada == 1) {
                // return done(null, false, { success: 5, message: 'Su contraseña ha expirado, por favor registre una nueva.' });
                return res.status(200).json({ success: true, message: 'Su contraseña ha expirado, por favor registre una nueva.' });
            } else {
                usuario.clave = '';
                var usuarioEncript = {
                    idusuario: usuario.idusuario,
                    idzonahoraria: usuario.idzonahoraria,
                    idperfil: usuario.idperfil,
                    nombrecompleto: usuario.nombrecompleto,
                    email: usuario.email
                };
                usuario.idperfil = '';
                usuario.idmonitoreo = '';

                var token = jwtHelper.generateJwtToken_v2(usuarioEncript);

                usuarioController.getmenuAccesoUsuario(idusuario, function(err2, returnMenu) {
                    if (err2) {
                        if (process.env.SHOW_LOG) logger.error('[getmenuAccesoUsuario] Error: %s.', err2);

                        return res.status(500).json({
                            success: false,
                            message: 'Error al buscar al consultar los accesos.',
                            errors: err2
                        });
                    }

                    if (returnMenu.length === 0) {
                        if (process.env.SHOW_LOG) logger.warn('WS[/api/login][username:%s] - No tiene accesos asignados al usuario.', username);

                        return res.status(500).json({
                            success: false,
                            message: 'Error al buscar los accesos.',
                            errors: { message: 'No tiene accesos asignados al usuario.' }
                        });
                    }

                    usuario.respuestapregunta = '';

                    return res.status(200).json({
                        success: true,
                        message: 'Credenciales correctas.',
                        usuario: usuario,
                        idtoken: token,
                        expiresIn: process.env.JWT_EXP,
                        menu: returnMenu
                    });
                });

            }
        });
    });
    */
});

module.exports = app;