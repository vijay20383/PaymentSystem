app.config(function ($routeProvider) {
    
    $routeProvider	
        .when('/', {
            templateUrl: '/AngularFiles/Payment/Payment.html',
            controller: 'PaymentCtrl'
        });
});