/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function (app) {
    app.service('apiService', apiService);//ten service la apiservice,ten ham cung la apiService
    apiService.$inject = ['$http'];

    function apiService($http) {
        return {
            get: get
        }

        function get(url, params, success, failure) {
            $http.get(url, params).then(function(resuilt) {
                    success(resuilt);
                }, function(error) {
                    failure(error);
                }
            );

        }
    }
})(angular.module('tedushop.common'));//namspace thuoc tedushop.common