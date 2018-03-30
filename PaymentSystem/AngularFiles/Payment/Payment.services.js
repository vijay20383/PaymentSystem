app.service("PaymentSvc", function ($http) {
    var baseurl = "/Payment";
    
    this.Payment = function (paymentObj) {
        return $http({
            method: "post",
            url: baseurl + "/MakePayment",
            data: paymentObj
        });
    }
   
});