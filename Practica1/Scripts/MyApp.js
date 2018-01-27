var myApp = angular.module("MyApp", []);

myApp.controller("MyController", ["$scope", "$http", function ($scope, $http) {


    $scope.GetPersonas = function () {
        $http({
            method: "get",
            url: "/Home/GetPersonas"
        }).then(function (response) {
            $scope.Personas = response.data;
        }, function (error) {
            alert("Error Occur" + error.message);
        })
    };  


//    getPersonas();
//    function getPersonas() {
//        PersonasService.getPersonas()
//            .success(function (data) {
//                $scope.Personas = data;
//                console.log($scope.Personas)
//            })
//            .error(function (error) {
//                $scope.status = 'No se pudo cargar los datos ' + error.message;
//                alert($scope.status);
//            });
//    }
//}]);


//myApp.factory('PersonasService', ["$http", function ($http) {

//    var PersonasService = {};

//    PersonasService.getPersonas = function () {
//        return $http.get("/Home/GetPersonas");
//    }

//    return PersonasService;
}]);