/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function () {
    angular.module('qlhd.dmhuongdans', ['qlhd.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('dmhuongdans', {
            url: "/dmhuongdans",
            templateUrl: "/app/components/dmhuongdan/dmhuongdanListView.html",
            controller: "dmhuongdanListController"
        }).state('dmhuongdan_add', {
            url: "/dmhuongdan_add",
            templateUrl: "/app/components/dmhuongdan/dmhuongdanAddView.html",
            controller: "dmhuongdanAddController"
        });
    }
})();