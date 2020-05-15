'use strict';

angular.module('homeapp')
    .controller('SettingCtrl', function($scope, $state) {
        console.log('SettingCtrl...');

        /*
          $scope.$state = $state;

          console.log($scope.$state);

          $scope.menuItems = [];
          angular.forEach($state.get(), function(item) {
              if (item.data && item.data.visible) {
                  $scope.menuItems.push({ name: item.name, text: item.data.text });
              }
          });
          */
    });