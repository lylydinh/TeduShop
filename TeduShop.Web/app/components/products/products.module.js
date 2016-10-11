﻿/// <reference path="/Assets/admin/libs/angular/angular.js" />  

//keo goi y anguarjs
(function () {
    angular.module('tedushop.products', ['tedushop.common']).config(config);
    //inject 2 doi tuong 
    config.$inject = ['$stateProvider', '$urlRouterProvider'];



    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('products_add', {
            url: "/products_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        })

        ;
    } 

})();//khai bao 1 ham nac danh