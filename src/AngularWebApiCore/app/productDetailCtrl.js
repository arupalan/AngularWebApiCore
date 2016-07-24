(function () {
    "use strict";

    function productDetailCtrl($scope, $routeParams) {
        var vm = this;
        vm.product = angular.fromJson($routeParams.product);
        vm.title = "Product Detail: " + vm.product.Name;
    }

    angular
        .module("app")
        .controller("productDetailCtrl",
                    ["$scope", "$routeParams",
                    productDetailCtrl]);
}());