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



    app.controller('DoughnutCtrl', ['$scope', '$timeout', '$http', function ($scope, $timeout, $http) {
        $scope.labels = ['Nanny', 'Guardian', 'Cook'];
        $scope.data = [0, 0, 0];
        // $scope.series = ['Nanny', 'Guardian','Cook'];
        $timeout(function () {
            //$scope.data = [350, 450, 100];

            $http.get("/api/jobtekapi/GetJobCounts", {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);
                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.labels = jQuery.map(response.data, function (n, i) {
                            return (n.JobName);
                        });
                        $scope.data = jQuery.map(response.data, function (n, i) {
                            return (n.TotalRequests);
                        });
                    }
                });
        }, 500);

        $scope.options = {
            legend: { display: true }, responsive: true, title: {
                display: true,
                text: 'Our Members'
            }
        };
    }]);



    app.controller('DataTablesCtrl', ['$scope', '$timeout', '$http', function ($scope, $timeout, $http) {
        $scope.series = ['Nanny', 'Guardian', 'Cook'];

        $scope.labels = [];
        $scope.data = [
            [65, 59],
            [28, 48],
            [38, 78]
        ];

        $timeout(function () {
            //$scope.data = [350, 450, 100];

            $http.get("/api/jobtekapi/GetJobRequestCounts", {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);


                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.series = $.map(response.data, function (item) { return item.JobName }).unique();

                        $scope.labels = $.map(response.data, function (groupedItem) {
                            return $.map(groupedItem.Items, function (item) {
                                return item.Month
                            })
                        }).unique()

                        var requestCounts = [];

                        angular.forEach(response.data, function (item) {
                            var count = 0;

                            // iterate the months
                            var monthsCount = [];
                            angular.forEach($scope.labels, function (month) {
                                //requestCounts.push([]);
                                var filteredItemsForMonth = $.grep(item.Items, function (obj) { return obj.Month == month })
                                if (filteredItemsForMonth && filteredItemsForMonth.length > 0) {
                                    var totalCount = $.map(filteredItemsForMonth, function (filt) { return filt.TotalRequests })
                                        .reduce(function (total, num) { return total + num; })
                                    monthsCount.push(totalCount);
                                    console.log("Month: " + month + ", Count: " + totalCount);
                                } else {
                                    console.log("Month: " + month + ", Count: " + 0);
                                    monthsCount.push(0);
                                }
                                
                            });
                            requestCounts.push(monthsCount);
                        });

                        console.log(requestCounts);
                        $scope.data = requestCounts;
                        //console.log(months);
                        //$scope.labels = jQuery.map(response.data, function (n, i) {
                        //    return (n.Month);
                        //}).unique();
                        //$scope.data = jQuery.map(response.data, function (n, i) {
                        //    return (n.TotalRequests);
                        //});
                    }
                });
        }, 500);

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
            }
        };

        //$timeout(function () {
        //    //$scope.data = [350, 450, 100];

        //    $http.get("/api/jobtekapi/GetJobRequestCounts", {
        //        //params: $scope.searchParam
        //    })
        //        .then(function (response) {
        //            console.log(response.data);
        //            //$scope.members = response.data;
        //            if (response && response.data) {
        //                //$scope.labels = jQuery.map(response.data, function (n, i) {
        //                //    return (n.JobName);
        //                //});
        //                //$scope.data = jQuery.map(response.data, function (n, i) {
        //                //    return (n.TotalRequests);
        //                //});
        //            }
        //        });
        //}, 500);
        $scope.randomize = function () {
            $scope.data = $scope.data.map(function (data) {
                return data.map(function (y) {
                    y = y + Math.random() * 10 - 5;
                    return parseInt(y < 0 ? 0 : y > 100 ? 100 : y);
                });
            });
        };
    }]);



    function getRandomValue(data) {
        var l = data.length, previous = l ? data[l - 1] : 50;
        var y = previous + Math.random() * 10 - 5;
        return y < 0 ? 0 : y > 100 ? 100 : y;
    }
})();
Array.prototype.unique = function () {
    var arr = [];
    for (var i = 0; i < this.length; i++) {
        if (!arr.includes(this[i])) {
            arr.push(this[i]);
        }
    }
    return arr;
}