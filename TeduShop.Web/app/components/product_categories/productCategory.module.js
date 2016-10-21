/// <reference path="/Assets/admin/libs/angular/angular.js" />  
/// <reference path="productCategoryListView.html" />
 

//keo goi y anguarjs
(function () {
    angular.module('tedushop.product_categories', ['tedushop.common']).config(config);
    //inject 2 doi tuong 
    config.$inject = ['$stateProvider', '$urlRouterProvider'];



    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            templateUrl: "/app/components/product_categories/productCategoryListView.html",
            controller: "productCategoryListController"
        });
    } 

})();//khai bao 1 ham nac danh