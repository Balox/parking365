function Usuario() {
  this._id = '0';
  this.idperfil = 0;
  this.usuario = '';
  this.clave = 0;
  this.saltsecret = '';
  this.fechacreacion = null;
}

module.exports = Usuario;