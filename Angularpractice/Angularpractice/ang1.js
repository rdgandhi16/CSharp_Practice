
var myapp = angular.module("mymodule", []).controller("mycontroller", function ($scope) {

    var employees = [
        { firstname: 'Rinkal', lastname: 'Gandhi', gender: 'Male' },
        { firstname: 'Rohit', lastname: 'Modi', gender: 'Male' },
        { firstname: 'Roma', lastname: 'Gandhi', gender: 'Female' }
    ];
    $scope.employees = employees;

    var technologies = [
        { name: 'c#', like: 0, dislike: 0 },
        { name: 'Asp.Net', like: 0, dislike: 0 },
        { name: 'Ado.Net', like: 0, dislike: 0 },
        { name: 'MVC', like: 0, dislike: 0 },
        { name: 'AngularJs', like: 0, dislike: 0 }
    ];
    $scope.technologies = technologies;
    $scope.incrementlikes = function (technology) {
        technology.like++;
    };

    $scope.discrementlikes = function (technology) {
        technology.dislike++;
    };
});