const jwt = require('jsonwebtoken');

module.exports.generateJwtToken = (idusuario, usuario) => {
    return jwt.sign({ idusuario: idusuario, usuario: usuario }, global.RSA_PRIVATE_KEY, {
        algorithm: 'RS256',
        expiresIn: process.env.JWT_EXP
    });
}

module.exports.verifyJwtToken = (req, res, next) => {
    var token;
    if ('authorization' in req.headers)
        token = req.headers['authorization'].split(' ')[1];

    if (!token)
        res.redirect('/login');
    //return res.status(403).send({ success: false, message: 'No hay token proporcionado.' });
    else {
        jwt.verify(token, global.RSA_PUBLIC_KEY, { algorithm: 'RS256', expiresIn: process.env.JWT_EXP }, (err, decoded) => {
            if (err)
                return res.status(500).send({ success: false, error: 'Falló la autenticación de token.' });
            else {
                req.usuario = decoded.usuario;
                next();
            }
        })
    }
}

module.exports.generateJwtToken_v2 = (_usuario) => {
    return jwt.sign({ usuario: _usuario }, global.RSA_PRIVATE_KEY, {
        algorithm: 'RS256',
        expiresIn: process.env.JWT_EXP
    });
}