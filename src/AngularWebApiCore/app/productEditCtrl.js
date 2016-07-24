(function () {
    "use strict";

    function productEditCtrl($scope, $routeParams,$http) {
        var vm = this;
        vm.product = angular.fromJson($routeParams.product);

        if (vm.key) {
            vm.title = "Edit: " + vm.product.Name;
        }
        else {
            vm.title = "New Product";
        }

        vm.open = function ($event) {
            $event.preventDefault();
            $event.stopPropagation();

            vm.opened = !vm.opened;
        };

        vm.submit = function () {
            $http.post("api/product",
                       JSON.stringify(vm.product),
                        {
                            headers: {
                                'Content-Type': 'application/json'
                            }
                        }
                       )
                    .then(function success(response) {
                        vm.product = angular.fromJson(response.data);
                        toastr.success("Save Successful");
                }, function error(response) {
                    toastr.error("Save Failed");
                });
        };
    }

    angular
        .module("app")
        .controller("productEditCtrl",
                ["$scope", "$routeParams","$http",
                    productEditCtrl]);
}());