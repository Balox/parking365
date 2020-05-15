var express = require('express');
var router = express.Router();
const jwtHelper = require('../../config/jwtHelper');

/* GET home page. */
router.get('/', function (req, res, next) {
    res.render('index', { title: title });
});

router.get('/base', function (req, res, next) {
    if (req.query.ref) {
        //console.log('base...');
        res.render('base');
    } else {
        res.redirect('/');
    }
});

router.get('/configuration', function (req, res, next) {
    if (req.query.ref) {
        res.render('dashboard');
    } else {
        res.redirect('/');
    }
});

router.get('/configuration/:name', function (req, res, next) {
    if (req.query.ref) {
        res.render('configuration/' + req.params.name, { title: title });
    } else {
        res.redirect('/');
    }
});













router.get('/dashboard', function (req, res, next) {
    if (req.query.ref) {
        console.log('dashboard...');
        res.render('dashboard', { title: title });
    } else {
        res.redirect('/');
    }
});

router.get('/dashboard/:name', function (req, res, next) {
    if (req.query.ref) {
        console.log('dashboard: ', req.params.name);
        res.render('dashboard/' + req.params.name, { title: title });
    } else {
        res.redirect('/');
    }
});


module.exports = router;