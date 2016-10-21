/// <reference path="/Assets/admin/libs/angular/angular.js" /> 

//keo goi y anguarjs
(function () {
    angular.module('tedushop', [
                    'tedushop.products',
                    'tedushop.product_categories',
                    'tedushop.common'
    ]).config(config);
    //inject 2 doi tuong 
    config.$inject = ['$stateProvider', '$urlRouterProvider'];



    function config($stateProvider,$urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/HomeView.html",
            controller:"homeController"
        });//ten state la home
        $urlRouterProvider.otherwise('/admin')
    }
    //ten cua module chinh la tedushop,dependenci la null chua co j 

})();//khai bao 1 ham nac danh