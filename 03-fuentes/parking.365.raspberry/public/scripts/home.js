'use strict';

/**
 * @ngdoc overview
 * @name homeapp
 * @description
 * # homeapp
 *
 * Main module of the application.
 */

var states = [
    { name: 'base', state: { abstract: true, url: '', templateUrl: 'views/main/base', data: { text: "Base", visible: false } } },
    { name: 'login', state: { url: '/login', parent: 'base', templateUrl: 'views/main/login', controller: 'LoginCtrl', data: { text: "Login", visible: false } } },
    { name: 'dashboard', state: { url: '/dashboard', parent: 'base', templateUrl: 'views/dashboard.html', controller: 'DashboardCtrl', data: { text: "Dashboard", visible: false } } },
    { name: 'overview', state: { url: '/overview', parent: 'dashboard', templateUrl: 'views/dashboard/overview.html', data: { text: "Overview", visible: true } } },
    { name: 'reports', state: { url: '/reports', parent: 'dashboard', templateUrl: 'views/dashboard/reports.html', data: { text: "Reports", visible: true } } },
    { name: 'logout', state: { url: '/login', data: { text: "Logout", visible: true } } }
];

angular.module('homeapp', [
        'ui.router',
        'snap',
        'ngAnimate'
    ])
    .config(function($stateProvider, $urlRouterProvider, $locationProvider) {
        $locationProvider.html5Mode({ enabled: true, requireBase: false }); // configure html5 to get links working on jsfiddle
        //$urlRouterProvider.when('/dashboard', '/dashboard/overview');
        $urlRouterProvider.otherwise('/login');

        //$urlRouterProvider.otherwise('/');
        //$urlRouterProvider.when('/home', { redirectTo: '/' });

        angular.forEach(states, function(state) {
            $stateProvider.state(state.name, state.state);
        });
    });