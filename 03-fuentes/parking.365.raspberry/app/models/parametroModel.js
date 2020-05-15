var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var parametroSchema = new Schema({
  nombre: { type: String, required: true },
  mac: { type: String, required: true },
  idtype: { type: Number, default: 1 }, // 1: ENTRADA - 2: SALIDA
  privateaddress: String,
  privateport: Number,
  remoteaddress: String,
  remoteport: Number,
  remotesocket: String,
  updated: { type: Date, default: Date.now },
  create: { type: Date, default: Date.now }
});

module.exports = mongoose.model('parametros', parametroSchema);