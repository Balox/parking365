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
    { name: 'base', state: { abstract: true, url: '', templateUrl: 'base?ref=menu', data: { text: "Base", visible: false } } },
    { name: 'configuration', state: { url: '/configuration', parent: 'base', templateUrl: 'configuration?ref=menu', controller: 'ConfigurationCtrl', data: { text: "Configuration", visible: false } } },
    { name: 'main', state: { url: '/main', parent: 'configuration', templateUrl: 'configuration/main?ref=menu', data: { text: "Configuración", visible: true } } },
    { name: 'entry', state: { url: '/entry', parent: 'configuration', templateUrl: 'configuration/entry?ref=menu', data: { text: "Entrada", visible: true } } },
    { name: 'exit', state: { url: '/exit', parent: 'configuration', templateUrl: 'configuration/exit?ref=menu', data: { text: "Salida", visible: true } } },

    //{ name: 'dashboard', state: { url: '/dashboard', parent: 'base', templateUrl: 'dashboard?ref=menu', controller: 'DashboardCtrl', data: { text: "Dashboard", visible: false } } },
    //{ name: 'overview', state: { url: '/overview', parent: 'dashboard', templateUrl: 'dashboard/overview?ref=menu', data: { text: "Overview", visible: true } } },
    //{ name: 'reports', state: { url: '/reports', parent: 'dashboard', templateUrl: 'dashboard/reports?ref=menu', data: { text: "Reports", visible: true } } },
    { name: 'logout', state: { url: '/login', data: { text: "Cerrar Sesión", visible: true } } }
];

angular.module('homeapp', [
    'ui.router',
    'snap',
    'ngAnimate'
])
    .config(function ($stateProvider, $urlRouterProvider, $locationProvider, snapRemoteProvider) {
        snapRemoteProvider.globalOptions.disable = 'right';

        $locationProvider.html5Mode({ enabled: true, requireBase: false });
        $urlRouterProvider.when('/configuration', '/configuration/main');
        $urlRouterProvider.otherwise('/configuration');

        angular.forEach(states, function (state) {
            $stateProvider.state(state.name, state.state);
        });
    });