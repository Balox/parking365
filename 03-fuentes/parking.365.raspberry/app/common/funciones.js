const dateformat = require('dateformat');

/**
 * Normalize a port into a number, string, or false.
 */
module.exports.normalizePort = function (val) {
    var port = parseInt(val, 10);

    if (isNaN(port)) {
        // named pipe
        return val;
    }

    if (port >= 0) {
        // port number
        return port;
    }

    return false;
}

module.exports.obtenerHora = function () {
    return dateformat(new Date(), "yyyy-mm-dd HH:MM:ss.l");
}

module.exports.genRand = function () {
    codigoreset = Math.floor(Math.random() * 89999 + 10000);

    return codigoreset.toString();
}