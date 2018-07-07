var app = angular.module('Myapp', []);
app.factory("Busmang", function ($http) {
    Tiksobj = {};

    Tiksobj.getAll = function () {
        var Opes;

        Opes = $http({ method: 'Get', url: '/Operator/GetInfo/' }).
            then(function (response) {
                return response.data;
            });

        return Opes;
    }

    Tiksobj.Search = function () {
        var bus;

        bus = $http({ method: 'Get', url: '/Operator/BusInfo/' }).
            then(function (response) {
                return response.data;
            });

        return bus;
    }


    Tiksobj.createPassenger = function (pass) {
        var PASS;

        PASS = $http({ method: 'Post', url: '/Operator/Passenger', data: pass }).then(function (response) {
            return response.data;
        });

        return PASS;
    };

    Tiksobj.createPayment = function (pay) {
        var PAY;

        PAY = $http({ method: 'Post', url: '/Operator/Payment', data: pay }).then(function (response) {
            return response.data;
        });

        return PAY;
    };


    return Tiksobj;

});

app.controller('operatorController', function ($scope, Busmang) {

    //here is the code
    $scope.selectedSeat = function (data1, data2, data3, data4, data5, data6, data7, data8, data9, data11, data12, data13,
        data14, data15, data16, data17, data18, data19, data21, data22, data23, data24, data25, data26, data27, data28, data29, data31, data32, data33
        , data34, data35, data36, data37, data38, data39) {

        var data = data1, data2, data3, data4, data5, data6, data7, data8, data9, data11, data12, data13,
            data14, data15, data16, data17, data18, data19, data21, data22, data23, data24, data25, data26, data27, data28, data29, data31, data32, data33
            , data34, data35, data36, data37, data38, data39;

        $scope.Tiks = data;

    }
    //end

    $scope.passoP = function (Opes) {
        Busmang.getAll().then(function (result) {
            $scope.Opes = result;
        });
    }


    $scope.busdetails = function (bus) {
        
            Busmang.getAll().then(function (result) {
                $scope.businfo = result;
           });       
    }

    $scope.createPassenger = function (PASS) {
        Busmang, createPassenger(PASS).then(function (result) {
            Busmang.getAll().then(function (result) {
                $scope.PASSs = result;
            });
        });
    }

    $scope.createPayment = function (PAY) {
        Busmang, createPassenger(PAY).then(function (result) {
            Busmang.getAll().then(function (result) {
                $scope.PAYs = result;
            });
        });
    }
  
});






   



