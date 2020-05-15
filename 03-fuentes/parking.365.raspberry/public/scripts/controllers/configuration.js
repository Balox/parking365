'use strict';

/**
 * @ngdoc function
 * @name yapp.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of yapp
 */
angular.module('homeapp')
  .controller('ConfigurationCtrl', function ($scope, $state) {
    $scope.$state = $state;

    $scope.menuItems = [];
    angular.forEach($state.get(), function (item) {
      if (item.data && item.data.visible) {
        $scope.menuItems.push({ name: item.name, text: item.data.text });
      }
    });


    $scope.parametro = {
      name: 'Raspberry pi b3+',
      mac: '305A3A81300E',
      ip: '172.16.3.52'
    };

    $scope.dateNow = new Date();
    $scope.tipo = '1';

    $scope.save = function () {
      console.log('GUARDAR TIPO...');
    }

  });