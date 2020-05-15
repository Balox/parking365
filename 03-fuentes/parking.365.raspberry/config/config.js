'use strict';

// fetch logger
var log4js = require('log4js');
var logger = log4js.configure(require('./log4js.json')).getLogger('configuration');
const fu = require('../app/common/funciones');

// fetch env. config
var properties = require('./properties.js');

// add env. config values to process.env
process.env.HOSTNAME = properties.production.HOSTNAME;
process.env.PORT = properties.production.PORT;
process.env.MONGODB_URI = properties.production.MONGODB_URI;
process.env.JWT_SECRET = properties.production.JWT_SECRET;
process.env.JWT_EXP = properties.production.JWT_EXP;
process.env.JWT_PATH_PRIVATE = properties.production.JWT_PATH_PRIVATE;
process.env.JWT_PATH_PUBLIC = properties.production.JWT_PATH_PUBLIC;
process.env.ENV_DEV = properties.production.ENV_DEV;
process.env.SHOW_LOG = properties.production.SHOW_LOG;

// Inicialize monogodb
var mongoose = require('mongoose');
mongoose.connect(process.env.MONGODB_URI, { useMongoClient: true });

// load key security
const path = require('path')
const fs = require('fs');
const security = require('../security/path');

global.RSA_PRIVATE_KEY = fs.readFileSync(path.join(security.path, process.env.JWT_PATH_PRIVATE));
global.RSA_PUBLIC_KEY = fs.readFileSync(path.join(security.path, process.env.JWT_PATH_PUBLIC));

// variable apra mostrar log-
process.env.SHOW_LOG = true;


logger.info('Variables de configuracion cargadas.');
if (process.env.SHOW_LOG) console.info('[%s] Variables de configuracion cargadas.', fu.obtenerHora());


// comentado para pruebas
//console.log(process.env.NODE_ENV);
//console.log(process.env.HOSTNAME);
//console.log(process.env.PORT);
//console.log(process.env.MONGODB_URI);
//console.log(process.env.JWT_SECRET);
//console.log(process.env.JWT_EXP);
//console.log(process.env.JWT_PATH_PRIVATE);
//console.log(process.env.JWT_PATH_PUBLIC);
//console.log(process.env.ENV_DEV);
//console.log(process.env.SHOW_LOG);
//console.log(global.macaddress);
