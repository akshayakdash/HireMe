(function () {
  'use strict';

  var app = angular.module('admindashboard', ['chart.js']);

  app.config(function (ChartJsProvider) {
    // Configure all charts
    ChartJsProvider.setOptions({
      colors: ['#97BBCD', '#DCDCDC', '#F7464A', '#46BFBD', '#FDB45C', '#949FB1', '#4D5360']
    });
    // Configure all doughnut charts
    ChartJsProvider.setOptions('doughnut', {
      cutoutPercentage: 60
    });
    ChartJsProvider.setOptions('bubble', {
      tooltips: { enabled: false }
    });
  });

 

  app.controller('DoughnutCtrl', ['$scope', '$timeout', function ($scope, $timeout) {
      $scope.labels = ['Nanny', 'Guardian', 'Cook'];
    $scope.data = [0, 0, 0];
   // $scope.series = ['Nanny', 'Guardian','Cook'];
    $timeout(function () {
      $scope.data = [350, 450, 100];
    }, 500);
    $scope.options = {
        legend: { display: true }, responsive: true, title: {
            display: true,
            text: 'Our Members'
        }
    };
  }]);

  

  app.controller('DataTablesCtrl', ['$scope', function ($scope) {
      $scope.series = ['Nanny', 'Guardian'];

    $scope.labels = ['January', 'February', 'March', 'April', 'May', 'June', 'July'];
    $scope.data = [
      [65, 59, 80, 81, 56, 55, 40],
      [28, 48, 40, 19, 86, 27, 90]
    ];
    $scope.colors = [
      { // grey
        backgroundColor: 'rgba(148,159,177,0.2)',
        pointBackgroundColor: 'rgba(148,159,177,1)',
        pointHoverBackgroundColor: 'rgba(148,159,177,1)',
        borderColor: '#97BBCD',
        pointBorderColor: '#fff',
        pointHoverBorderColor: 'rgba(148,159,177,0.8)'
      },
      { // dark grey
        backgroundColor: 'rgba(77,83,96,0.2)',
        pointBackgroundColor: 'rgba(77,83,96,1)',
        pointHoverBackgroundColor: 'rgba(77,83,96,1)',
        borderColor: '#F7464A',
        pointBorderColor: '#fff',
        pointHoverBorderColor: 'rgba(77,83,96,0.8)'
      }
    ];
    $scope.options = {
        legend: { display: true }, responsive: true, title: {
            display: true,
            text: 'Dashboard Members'
        } };
    $scope.randomize = function () {
      $scope.data = $scope.data.map(function (data) {
        return data.map(function (y) {
          y = y + Math.random() * 10 - 5;
          return parseInt(y < 0 ? 0 : y > 100 ? 100 : y);
        });
      });
    };
  }]);



  function getRandomValue (data) {
    var l = data.length, previous = l ? data[l - 1] : 50;
    var y = previous + Math.random() * 10 - 5;
    return y < 0 ? 0 : y > 100 ? 100 : y;
  }
})();
