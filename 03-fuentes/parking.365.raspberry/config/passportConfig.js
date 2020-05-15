const passport = require('passport');
const localStrategy = require('passport-local').Strategy;

var usuarioController = require('../app/controllers/usuarioController');

passport.use(
    new localStrategy({
            usernameField: 'username',
            passwordField: 'password'
        },
        (username, password, done) => {
            usuarioController.obtenerusuario(username, function(error, usuario) {
                if (error)
                    return done(error);
                else if (!usuario)
                    return done(null, false, { success: 0, message: 'Usuario no esta registrado.' });
                else {
                    usuarioController.compararclave(password, usuario.saltsecret, usuario.clave, function(isMatch) {
                        if (!isMatch)
                            return done(null, false, { success: 2, message: 'Contraseña invalida.' });
                        else
                            return done(null, usuario, { success: 1, message: 'Exito' });
                    });
                }
            });
        })
);