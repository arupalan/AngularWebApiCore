(function (angular) {
    angular.module('app')
           .directive('dynamicInput', ['$http', function ($http) {
            return {
                restrict: 'E',
                replace: true,
                scope: {
                    model: '=',
                    config: '=?'
                },
                templateUrl: 'partials/dynamic-input',
                link: function (scope) {

                    $http.get("api/category").then(function (response) {
                        scope.$parent.input.category.config.options = angular.fromJson(response.data);

                    }, function (response) {
                        console.error("error in api/category", response);
                    });

                    scope.OnChangeInput = function (configid) {

                        console.log('dynamicInput link OnChangeInput', scope.model, configid);

                        if (configid === "category")
                        {
                            //clear out products on the isolated scope 
                            scope.$parent.products = [];
                            //clear out subcategories
                            scope.$parent.input.subcategory.config.options = [];

                            //fetch the subcategories for the selected category
                            var selectedcategoryid = scope.model.Id;
                            $http.get("api/Category/GetSubCategories/" + selectedcategoryid)
                                .then(function success (response) {
                                    var subcategories = angular.fromJson(response.data);
                                    scope.$parent.input.subcategory.config.options = angular.fromJson(response.data);
                                    console.log("category " + selectedcategoryid, subcategories);
                            }, function error (response) {
                                console.error("error in api/Category/GetSubCategories/" + selectedcategoryid, response);
                            });
                        }
                        else if (configid === "subcategory") 
                        {
                            //clear out products on the isolated scope 
                            scope.$parent.products = [];

                            //fetch the products for the selected subcategory
                            //Note that '=' to products in the parent isolated scope will do the rest
                            if (scope.model) {
                                var selectedsubcategoryid = scope.model.Id;
                                $http.get("api/Product/GetProductListBySubCategory/" + selectedsubcategoryid)
                                    .then(function success(response) {
                                        var products = angular.fromJson(response.data);
                                        scope.$parent.products = angular.fromJson(response.data);
                                        console.log(products);
                                    }, function error(response) {
                                        console.error("error in api/Product/GetProductListBySubCategory/" + selectedsubcategoryid, response);
                                    });
                            }
                        }
                        else if (configid === "minstock") {
                            console.log("minstock {}");
                        }
                        else {
                            console.error("invalid configid passed to OnChangeInput");
                        }
                    }

                    scope.config = scope.config || {
                        label: 'Text',
                        id: 'fs9h32nm45nh4msdf0983dlj93',
                        type: 'text'
                    };
                }
               };
           }]);

})(angular);
