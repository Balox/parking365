'use strict';

/**
 * @ngdoc function
 * @name homeapp.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of homeapp
 */
angular.module('homeapp')
    .controller('LoginCtrl', function($scope, $location) {

        $scope.submit = function() {

            $location.path('/dashboard');

            return false;
        }

    });