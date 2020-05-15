var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var usuarioSchema = new Schema({
    idperfil: { type: Number, required: true, index: true },
    usuario: { type: String, required: true, index: true },
    clave: { type: String, required: true },
    saltsecret: { type: String, required: true },
    updated: { type: Date, default: Date.now },
    create: { type: Date, default: Date.now }
});

module.exports = mongoose.model('usuarios', usuarioSchema);