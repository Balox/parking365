'use strict';

const logger = require('log4js').getLogger('app');
const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');
const flash = require('connect-flash');
const session = require('express-session');
const expressValidator = require('express-validator');
//const passport = require('passport');
const fu = require('./app/common/funciones');

// declare routes
const index = require('./app/routes/index');
const login = require('./app/routes/login');
const register = require('./app/routes/register');
// ....

var app = express();
var http = require('http');
var io = require('./server/io');

var server = http.createServer(app);

io.attach(server);


// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'pug');

// middleware
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

// Set Static Folder
app.use(express.static(path.join(__dirname, 'public')));

// Express Session
app.use(session({
    secret: 'secret',
    saveUninitialized: true,
    resave: true
}));

// Express Validator
app.use(expressValidator({
    errorFormatter: function(param, msg, value) {
        var namespace = param.split('.'),
            root = namespace.shift(),
            formParam = root;

        while (namespace.length) {
            formParam += '[' + namespace.shift() + ']';
        }
        return {
            param: formParam,
            msg: msg,
            value: value
        };
    }
}));

app.use(flash());

// Global Vars
app.use(function(req, res, next) {
    res.locals.success_msg = req.flash('success_msg');
    res.locals.error_msg = req.flash('error_msg');
    res.locals.warning_msg = req.flash('warning_msg');
    res.locals.error = req.flash('error');
    res.locals.user = req.user || null;

    next();
});


// init routes
app.use('/', index);
//app.use('/login', login);
//app.use('/register', register);

// ....
/*
//TO GET AND RENDER PARTIAL VIEWS  
//SEE THIS PART SO
app.get('/partials/:name', function(req, res) {
    console.log(req.params.name);
    res.render('partials/' + req.params.name);
});

//THE CATCH ALL ROUTE
app.get('*', function(req, res) {
    res.render('index', { title: title });
})
*/







// catch 404 and forward to error handler
app.use(function(req, res, next) {
    var err = new Error('Not Found');
    err.status = 404;
    next(err);
});


// error handler
app.use(function(err, req, res, next) {
    // set locals, only providing error in development
    res.locals.message = err.message;
    res.locals.error = req.app.get('env') === 'development' ? err : {};

    // render the error page
    res.status(err.status || 500);
    res.render('error');
});




// Get port from environment and store in Express.
const port = fu.normalizePort(process.env.PORT);

// start server
server.listen(port, process.env.HOSTNAME, () => {
    logger.info('Raspberry-pi Admin | iniciado: http://%s:%s', process.env.HOSTNAME, port);
    if (process.env.SHOW_LOG) console.info('[%s] Raspberry-pi Admin | iniciado: http://%s:%s', fu.obtenerHora(), process.env.HOSTNAME, port);
});
server.on('error', onError);
server.on('listening', onListening);


/**
 * Event listener for HTTP server "error" event.
 */

function onError(error) {
    if (error.syscall !== 'listen') {
        throw error;
    }

    var bind = typeof port === 'string' ?
        'Pipe ' + port :
        'Port ' + port;

    // handle specific listen errors with friendly messages
    switch (error.code) {
        case 'EACCES':
            console.error(bind + ' requires elevated privileges');
            process.exit(1);
            break;
        case 'EADDRINUSE':
            console.error(bind + ' is already in use');
            process.exit(1);
            break;
        default:
            throw error;
    }
}

/**
 * Event listener for HTTP server "listening" event.
 */

function onListening() {
    var addr = server.address();
    var bind = typeof addr === 'string' ?
        'pipe ' + addr :
        'port ' + addr.port;
    logger.info('Listening on ' + bind);
}

module.exports = app;