using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentSystem.Models
{
    public class JsonResponse
    {
        public static object ErrorResponse(string error)
        {
            return new { ErrorMessage = error, SuccessMessage = string.Empty, StatusCode = 205 };
        }
        public static object ErrorResponse(Exception ex)
        {
            return new { ErrorMessage = ex.Message, SuccessMessage = string.Empty, StatusCode = 500 };
        }

        public static object SuccessResponse(string msg)
        {
            return new { ErrorMessage = string.Empty, SuccessMessage = msg, StatusCode = 200 };
        }

        public static object SuccessResponse(object referenceObject, string msg)
        {
            return new { ErrorMessage = string.Empty, SuccessMessage = msg, StatusCode = 200, Object = referenceObject };
        }
    }
}