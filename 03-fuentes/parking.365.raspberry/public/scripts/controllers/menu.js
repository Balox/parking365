'use strict';

/**
 * @ngdoc function
 * @name homeapp.controller:menuCtrl
 * @description
 * # menuCtrl
 * Controller of homeapp
 */
angular.module('homeapp')
    .controller('menuCtrl', function($scope, $state) {
        $scope.$state = $state;

        $scope.menuItems = [];
        angular.forEach($state.get(), function(item) {
            if (item.data && item.data.visible) {
                $scope.menuItems.push({ name: item.name, text: item.data.text });
            }
        });
    });