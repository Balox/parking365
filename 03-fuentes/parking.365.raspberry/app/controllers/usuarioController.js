const crypto = require('crypto');

var usuarioModel = require('../models/usuarioModel');

module.exports.obtenerusuario = function (username, done) {
    usuarioModel.findOne({
        usuario: username
    }, {
        _id: true,
        idperfil: true,
        usuario: true,
        clave: true,
        saltsecret: true,
        updated: true,
        create: true
    },
        function (err, row) {
            if (err) {
                done(err, null);
            } else {
                done(err, row);
            }
        });
}

module.exports.compararclave = function (password, salt, hash, done) {
    var data = crypto.createHash('md5').update(password + salt).digest("hex");

    if (data == hash)
        done(true);
    else
        done(false);
}

module.exports.grabar = function (usuario, done) {
    usuarioModel.create({
        idperfil: usuario.idperfil,
        usuario: usuario.usuario,
        clave: usuario.clave,
        saltsecret: usuario.saltsecret,
        updated: new Date(),
        create: new Date()
    },
        function (err, rowCreate) {
            if (err) {
                done(err, null);
            } else {
                done(null, rowCreate);
            }
        }
    );
}

module.exports.actualizar = function (usuario, done) {
    usuarioModel.update({ _id: usuario._id }, {
        $set: {
            saltsecret: usuario.saltsecret,
            clave: usuario.clave,
            updated: new Date()
        }
    },
        function (err) {
            if (err) {
                done(err);
            } else {
                done(null);
            }
        }
    )
}