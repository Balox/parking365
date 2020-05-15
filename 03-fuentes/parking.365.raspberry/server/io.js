var app = require('express')();
var http = require('http').Server(app);
var io = require('socket.io')(http);

var arrays = [];
io.on('connection', (socket) => {

    // console.log('user connected ->',  socket.id);

    socket.on('disconnect', function() {
        // console.log('user disconnected');
        //  arrays = [];
    });

    socket.on('add-message', (message) => {
        // console.log(message);
        io.emit('message', { type: 'new-message', text: message });
    });

    socket.on('url-ubicacion', (ubicacion) => {
        //console.log(ubicacion);
        io.emit('ubicacion', ubicacion);
    });

    socket.on('add-evento', (evento) => {
        //console.log(evento);
        io.emit('evento', evento);
    });

    socket.on('add-alerta-data', (data) => {
        // console.log(data);
        io.emit('alerta-data', data);
    });

    socket.on('registrar-mac', (mac) => {
        mac.forEach(element => {
                arrays.push(element.c_mac);
            })
            // console.log(arrays);
    });

    arrays.forEach(eventos => {
        socket.on(eventos, (evento) => {
            // console.log(evento);
            io.emit(eventos, evento);
        });

    })

});

module.exports = io;