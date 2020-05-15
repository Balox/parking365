var parametroModel = require('../models/parametroModel');

module.exports.existe = function (done) {
  parametroModel.count({}, function (err, count) {
    if (err) {
      done(err, null);
    } else {
      done(null, (count > 0));
    }

  });
}

module.exports.grabar = function (parametro, done) {
  parametroModel.create({
    nombre: parametro.nombre,
    mac: parametro.mac,
    tipomodulo: parametro.tipomodulo,
    privateaddress: parametro.privateaddress,
    privateport: parametro.privateport,
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

module.exports.obtener = function (done) {
  parametroModel.findOne({}, {
    _id: true,
    nombre: true,
    mac: true,
    tipomodulo: true,
    privateaddress: true,
    privateport: true,
    remoteaddress: true,
    remoteport: true,
    remotesocket: true,
    create: true
  }, function (err, row) {
    if (err) {
      done(err, null);
    } else {
      done(null, row);
    }
  });
}

module.exports.actualizar = function (parametro, done) {
  parametroModel.update({ _id: parametro._id }, {
    $set: {
      mac: parametro.mac,
      ipaddress: parametro.privateaddress,
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
