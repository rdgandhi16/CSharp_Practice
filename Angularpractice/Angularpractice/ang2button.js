
var myapp1 = angular.module("mymodule", []).controller("mycontroller1", function ($scope) {

    var technologies = [
        { name: 'C#', likes: 0, dislikes: 0 },
        { name: 'Java', likes: 0, dislikes: 0 },
        { name: 'Ruby', likes: 0, dislikes: 0 },
        { name: 'Python', likes: 0, dislikes: 0 },
        { name: 'SAP', likes: 0, dislikes: 0 },
    ];

    $scope.technologies= technologies;

    $scope.incrementlikes = function (technology) {
        technology.likes++;
    };
    $scope.dicrementlikes = function (technology) {
        technology.dislikes++;
    }
});