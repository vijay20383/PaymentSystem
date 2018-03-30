app.service('common', ['aaNotify', 'usSpinnerService', function (aaNotify, usSpinnerService) {


    this.ShowMessage = function (response, message) {
        
            if (response.data.StatusCode == 200) {
                if (response.data.SuccessMessage != "")
                    aaNotify.success(response.data.SuccessMessage);
                else if (message != "")
                    aaNotify.success(message);
                return true;
            }
            else {
                if (response.data.ErrorMessage != "")
                    aaNotify.error("Error: " + response.data.ErrorMessage);
                else
                    aaNotify.error("Error: " + message);
                return false;
            }
       

    }
    this.ShowError = function (message) {
        aaNotify.error(message);
    }
    this.ShowSuccess = function (message) {
        aaNotify.success(message);
    }
    this.startspin = function (spinnerkey) {
        usSpinnerService.spin(spinnerkey);
    }
    this.stopspin = function (spinnerkey) {
        usSpinnerService.stop(spinnerkey);
    }
}
]);