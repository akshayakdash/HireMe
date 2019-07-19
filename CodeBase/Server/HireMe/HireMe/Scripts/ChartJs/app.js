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



    app.controller('kpiCtrl', ['$scope', '$timeout', '$http', function ($scope, $timeout, $http) {
        $scope.doughnut_labels = ['Nanny', 'Guardian', 'Cook'];
        $scope.doughnut_data = [0, 0, 0];
        $scope.loading = false;
        $scope.isLoading = function () {
            return $http.pendingRequests.length !== 0;
        };
        // $scope.series = ['Nanny', 'Guardian','Cook'];
        $timeout(function () {
            //$scope.data = [350, 450, 100];

            $http.get("/api/jobtekapi/GetJobRequestDoughnotData?year=" + $('#cboYear').find(":selected").text(), {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);
                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.doughnut_labels = jQuery.map(response.data, function (n, i) {
                            return (n.JobName + " - " + n.TotalRequests );
                        });
                        $scope.doughnut_data = jQuery.map(response.data, function (n, i) {
                            return (n.TotalRequests);
                        });
                    }
                });
        }, 500);

        $scope.doughnut_options = {
            legend: { display: true, position: 'left' }, responsive: true,
            maintainAspectRatio: false, title: {
                display: true,
                text: 'Our Members'
            }
        };


        // Line Chart
        $scope.line_chart_series = ['Nanny', 'Guardian', 'Cook'];

        $scope.line_chart_labels = [];
        $scope.line_chart_data = [
            [0, 0],
            [0, 0],
            [0, 0]
        ];

        $timeout(function () {
            //$scope.data = [350, 450, 100];

            $http.get("/api/jobtekapi/GetJobRequestCounts?year=" + $('#cboYear').find(":selected").text(), {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);


                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.line_chart_series = $.map(response.data, function (item) { return item.JobName }).unique();

                        $scope.line_chart_labels = $.map(response.data,
                            function(groupedItem) {
                                return $.map(groupedItem.Items,
                                    function(item) {
                                        return item.Month;
                                    });
                            }).unique();

                        var requestCounts = [];

                        angular.forEach(response.data, function (item) {
                            var count = 0;

                            // iterate the months
                            var monthsCount = [];
                            angular.forEach($scope.line_chart_labels, function (month) {
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
                        $scope.line_chart_data = requestCounts;
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

        $scope.line_chart_colors = [
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
        $scope.line_chart_options = {
            legend: { display: true }, responsive: true,
            maintainAspectRatio: false, title: {
                display: true,
                text: 'Dashboard Members'
            }
        };
        
        $scope.randomize = function () {
            $scope.line_chart_data = $scope.line_chart_data.map(function (data) {
                return data.map(function (y) {
                    y = y + Math.random() * 10 - 5;
                    return parseInt(y < 0 ? 0 : y > 100 ? 100 : y);
                });
            });
        };

        $scope.jobType = 1;

        $scope.getJobRequests = function () {
            $scope.loading = true;
            $http.get("/api/jobtekapi/GetJobRequestDoughnotData?year=" + $('#cboYear').find(":selected").text(), {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);
                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.doughnut_labels = jQuery.map(response.data, function (n, i) {
                            return (n.JobName + " - " + n.TotalRequests);
                        });
                        $scope.doughnut_data = jQuery.map(response.data, function (n, i) {
                            return (n.TotalRequests);
                        });
                    }
                    if (!$scope.isLoading()) {
                        $scope.loading = false;
                    }
                });

            $http.get("/api/jobtekapi/GetJobRequestCounts", {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);
                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.line_chart_series = $.map(response.data, function (item) { return item.JobName }).unique();

                        $scope.line_chart_labels = $.map(response.data,
                            function(groupedItem) {
                                return $.map(groupedItem.Items,
                                    function(item) {
                                        return item.Month;
                                    });
                            }).unique();

                        var requestCounts = [];

                        angular.forEach(response.data, function (item) {
                            var count = 0;

                            // iterate the months
                            var monthsCount = [];
                            angular.forEach($scope.line_chart_labels, function (month) {
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
                        $scope.line_chart_data = requestCounts;
                    }

                    if (!$scope.isLoading()) {
                        $scope.loading = false;
                    }
                });
        }

        $scope.getJobOffers = function () {

            $scope.loading = true;

            $http.get("/api/jobtekapi/GetJobOfferDoughnotData=Year" + $('#cboYear').find(":selected").text(), {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);
                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.doughnut_labels = jQuery.map(response.data, function (n, i) {
                            return (n.JobName + " - " + n.TotalRequests);
                        });
                        $scope.doughnut_data = jQuery.map(response.data, function (n, i) {
                            return (n.TotalRequests);
                        });
                    }
                    if (!$scope.isLoading()) {
                        $scope.loading = false;
                    }
                });

            $http.get("/api/jobtekapi/GetJobOfferCounts?year=" + $('#cboYear').find(":selected").text(), {
                //params: $scope.searchParam
            })
                .then(function (response) {
                    console.log(response.data);
                    //$scope.members = response.data;
                    if (response && response.data) {
                        $scope.line_chart_series = $.map(response.data, function (item) { return item.JobName }).unique();

                        $scope.line_chart_labels = $.map(response.data,
                            function(groupedItem) {
                                return $.map(groupedItem.Items,
                                    function(item) {
                                        return item.Month;
                                    });
                            }).unique();

                        var requestCounts = [];

                        angular.forEach(response.data, function (item) {
                            var count = 0;

                            // iterate the months
                            var monthsCount = [];
                            angular.forEach($scope.line_chart_labels, function (month) {
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
                        $scope.line_chart_data = requestCounts;

                        if (!$scope.isLoading()) {
                            $scope.loading = false;
                        }
                    }
                });
        }

        $scope.populateReportData = function() {
            if ($scope.jobType === 1) {
                //alert("Hello" + $('#cboYear').find(":selected").text());
                $scope.getJobRequests();
            } else {
                //alert("Hi" + $('#cboYear').find(":selected").text());
                $scope.getJobOffers();
            }
        }
    }]);



    //app.controller('DataTablesCtrl', ['$scope', '$timeout', '$http', function ($scope, $timeout, $http) {
    //    $scope.series = ['Nanny', 'Guardian', 'Cook'];

    //    $scope.labels = [];
    //    $scope.data = [
    //        [65, 59],
    //        [28, 48],
    //        [38, 78]
    //    ];

    //    $timeout(function () {
    //        //$scope.data = [350, 450, 100];

    //        $http.get("/api/jobtekapi/GetJobRequestCounts", {
    //            //params: $scope.searchParam
    //        })
    //            .then(function (response) {
    //                console.log(response.data);


    //                //$scope.members = response.data;
    //                if (response && response.data) {
    //                    $scope.series = $.map(response.data, function (item) { return item.JobName }).unique();

    //                    $scope.labels = $.map(response.data, function (groupedItem) {
    //                        return $.map(groupedItem.Items, function (item) {
    //                            return item.Month
    //                        })
    //                    }).unique()

    //                    var requestCounts = [];

    //                    angular.forEach(response.data, function (item) {
    //                        var count = 0;

    //                        // iterate the months
    //                        var monthsCount = [];
    //                        angular.forEach($scope.labels, function (month) {
    //                            //requestCounts.push([]);
    //                            var filteredItemsForMonth = $.grep(item.Items, function (obj) { return obj.Month == month })
    //                            if (filteredItemsForMonth && filteredItemsForMonth.length > 0) {
    //                                var totalCount = $.map(filteredItemsForMonth, function (filt) { return filt.TotalRequests })
    //                                    .reduce(function (total, num) { return total + num; })
    //                                monthsCount.push(totalCount);
    //                                console.log("Month: " + month + ", Count: " + totalCount);
    //                            } else {
    //                                console.log("Month: " + month + ", Count: " + 0);
    //                                monthsCount.push(0);
    //                            }
                                
    //                        });
    //                        requestCounts.push(monthsCount);
    //                    });

    //                    console.log(requestCounts);
    //                    $scope.data = requestCounts;
    //                    //console.log(months);
    //                    //$scope.labels = jQuery.map(response.data, function (n, i) {
    //                    //    return (n.Month);
    //                    //}).unique();
    //                    //$scope.data = jQuery.map(response.data, function (n, i) {
    //                    //    return (n.TotalRequests);
    //                    //});
    //                }
    //            });
    //    }, 500);

    //    $scope.colors = [
    //        { // grey
    //            backgroundColor: 'rgba(148,159,177,0.2)',
    //            pointBackgroundColor: 'rgba(148,159,177,1)',
    //            pointHoverBackgroundColor: 'rgba(148,159,177,1)',
    //            borderColor: '#97BBCD',
    //            pointBorderColor: '#fff',
    //            pointHoverBorderColor: 'rgba(148,159,177,0.8)'
    //        },
    //        { // dark grey
    //            backgroundColor: 'rgba(77,83,96,0.2)',
    //            pointBackgroundColor: 'rgba(77,83,96,1)',
    //            pointHoverBackgroundColor: 'rgba(77,83,96,1)',
    //            borderColor: '#F7464A',
    //            pointBorderColor: '#fff',
    //            pointHoverBorderColor: 'rgba(77,83,96,0.8)'
    //        }
    //    ];
    //    $scope.options = {
    //        legend: { display: true }, responsive: true,
    //        maintainAspectRatio: false, title: {
    //            display: true,
    //            text: 'Dashboard Members'
    //        }
    //    };

    //    //$timeout(function () {
    //    //    //$scope.data = [350, 450, 100];

    //    //    $http.get("/api/jobtekapi/GetJobRequestCounts", {
    //    //        //params: $scope.searchParam
    //    //    })
    //    //        .then(function (response) {
    //    //            console.log(response.data);
    //    //            //$scope.members = response.data;
    //    //            if (response && response.data) {
    //    //                //$scope.labels = jQuery.map(response.data, function (n, i) {
    //    //                //    return (n.JobName);
    //    //                //});
    //    //                //$scope.data = jQuery.map(response.data, function (n, i) {
    //    //                //    return (n.TotalRequests);
    //    //                //});
    //    //            }
    //    //        });
    //    //}, 500);
    //    $scope.randomize = function () {
    //        $scope.data = $scope.data.map(function (data) {
    //            return data.map(function (y) {
    //                y = y + Math.random() * 10 - 5;
    //                return parseInt(y < 0 ? 0 : y > 100 ? 100 : y);
    //            });
    //        });
    //    };
    //}]);
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