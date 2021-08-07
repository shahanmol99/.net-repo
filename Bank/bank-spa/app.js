angular.module('studentSpa')
    .config(['$routeProvider', function ($routeProvider) {

        $routeProvider.when("/", {
            tempalteUrl: 'index.html'
        })
        
            .when("/register", {
                templateUrl: 'views/register.html',
                controller: 'registerController'
            })

            .when("/login", {
                templateUrl: 'views/login.html',
                controller: 'loginController'
            })

            .when("/passbook", {
                templateUrl: 'views/passbook.html',
                controller: 'passbookController'
            })

            .when("/transaction", {
                templateUrl: 'views/transaction.html',
                controller: 'transactionController'
            })
    }])
