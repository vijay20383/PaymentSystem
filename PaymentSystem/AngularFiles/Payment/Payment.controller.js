app.controller('PaymentCtrl', ['$scope', 'PaymentSvc', 'aaNotify', 'common', '$route', '$location', '$log', function ($scope, PaymentSvc, aaNotify, common, $route, $location, $log) {

    $scope.PageTitle = "Signup";
   
    $scope.PaymentObj = { UserId: 1, BSB: null, AccountNo: null, AccountName: null, Reference: null, Amount: null };
    $scope.usernameexists = false;
    $scope.init = function () {
       
    }
    
    $scope.Payment = function ()
    {
        common.startspin('paymentspinner');
            $log.info("Make Payment");
            PaymentSvc.Payment($scope.PaymentObj).then(function (data) {
                if (common.ShowMessage(data, "Payment Success")) {
                    $log.info("Payment Success");
                    $route.reload();
                    
                }
                common.stopspin('paymentspinner');
            })
             .catch(function (error) {
                 common.ShowMessage(error, "Unable to complete payment");
                 common.stopspin('paymentspinner');
                 $log.error("Payment Error");
             });
        
       

    }  
    $scope.Reset = function ()
    {        
        $route.reload();
    }
    $scope.init();

}
]);
