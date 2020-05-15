function Parametro() {
  this._id = '0';
  this.nombre = '';
  this.mac = '';
  this.tipomodulo = 0;
  this.privateaddress = '0.0.0.0';
  this.privateport = 0;
  this.remoteaddress = '0.0.0.0';
  this.remoteport = 0;
  this.remotesocket = '';
  this.create = null;
}

module.exports = Parametro;
