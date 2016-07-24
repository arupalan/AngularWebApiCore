(function (angular) {
    angular.module('app')
           .directive('productList', [function () {
               return {
                   restrict: 'E',
                   replace: true,
                   scope: {
                       products: '=',
                       minstock: '=',
                       category: '=',
                       subcategory: '='
                   },
                   templateUrl: 'partials/product-list',
                   link: function (scope) {
                       //scope.ChangeCategory = function(configid) {

                       //    console.log('link ChangeCategory', scope.model, configid);
                       //}

                   }
               };
           }]);
})(angular);
