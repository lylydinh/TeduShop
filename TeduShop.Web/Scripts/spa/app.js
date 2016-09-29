/// <reference path="../plugins/angular/angular.js" />
var myapp = angular.module('myModule', []);//2 tham so la ten modul va danh sach cac dependencie ten phai giong voi ng-app
// day la acach khoi tao 1 module
myapp.controller("myController", myController);
// khai bao nhu 
//myapp.controller("myController", function($scope) {
//    $scope.message = "this is may page";
//}); la giong nhau

//tiem doi tuong scope
myController.$inject = ['$scope'];
//khai bao 1 cntroller
function myController($scope) {
    $scope.message = "this is may page";
}
