'use strict';

(function (angular) {
    angular.module('app', ['ngRoute']).config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider.when('/', {
            templateUrl: 'partials/start-test'
        }).when('/product', {
            templateUrl: 'partials/product',
            controller: 'productCtrl'
        })
        //productDetail
        .when("/productDetail/:product", {
            templateUrl: "partials/productDetailView",
            controller: "productDetailCtrl",
            controllerAs: "vm"
        })
        //productEdit
        .when("/productEdit/:product", {
            templateUrl: "partials/productEditView",
            controller: "productEditCtrl",
            controllerAs: "vm"
        }).otherwise({
            redirectTo: '/'
        });

        // use the hashbang mode
        $locationProvider.html5Mode(false);
    }]);
})(angular);

//(function (angular) {
//    "use strict";
//    var app = angular.module("app",
//                            ["ui.router"]);

//    app.config(["$stateProvider", "$urlRouterProvider",
//            function ($stateProvider, $urlRouterProvider) {

//                $urlRouterProvider.otherwise("/");
//                console.log("inside app config",$stateProvider,$urlRouterProvider);
//                $stateProvider
//                    //home
//                    .state("home", {
//                        url: "/",
//                        templateUrl: "partials/start-test.cshtml"
//                    })
//                    //products
//                    .state("product", {
//                        url: "/product",
//                        templateUrl: "partials/product.cshtml",
//                        controller: "productCtrl"
//                    })
//                    //productEdit
//                    .state("productEdit", {
//                        url: "/product/edit/:productId",
//                        templateUrl: "partials/productEditView",
//                        controller: "ProductEditCtrl as vm"
//                    })
//                    //productDetail
//                    .state("productDetail", {
//                        url: "/product/:productId",
//                        templateUrl: "partials/productDetailView",
//                        controller: "ProductDetailCtrl as vm"
//                    });
//            }]);

//})(angular);

