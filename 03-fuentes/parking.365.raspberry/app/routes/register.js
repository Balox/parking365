'use strict';
var express = require('express');
var app = express();

const logger = require('log4js').getLogger('ws-register');
var usuarioController = require('../controllers/usuarioController');


app.get('/', function(req, res) {
    var year = (new Date).getFullYear();
    res.render('register', { heading: 'Regístrate', isRegister: true, year: year });
});


app.post('/', (req, res) => {
    req.checkBody('username', 'Usuario es requerido').notEmpty();
    req.checkBody('password', 'Contraseña es requerida').notEmpty();
    req.checkBody('password', 'Contraseña requiere de 8 a 30 caracteres').len(6, 30);
    req.checkBody('password2', 'Confirmacion de contraseña es requerida').notEmpty();
    req.checkBody('password2', 'Confirmacion de contraseña requiere de 8 a 30 caracteres').len(6, 30);
    req.checkBody('password', 'Contraseña no coinciden').equals(req.body.password2);
    req.checkBody('token', 'Token de seguridad es requerida').notEmpty();

    var errors = req.validationErrors();

    if (errors) {
        req.flash('error_msg', errors[0].msg);
        res.redirect('/register');
    } else {


        res.redirect('/register');
    }

});

module.exports = app;