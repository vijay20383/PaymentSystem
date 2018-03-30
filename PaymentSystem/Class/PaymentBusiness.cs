using PaymentSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PaymentSystem.Class
{
    public class PaymentBusiness
    {
        public PaymentBusiness() { }

        public object SavePaymentData(string filepath,PaymentDetailModel model)
        {
            string filename = "payment.txt";
            //string filepath= HttpRequest
            string data = string.Empty;
            data = "Date : " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            data += ", UserId : " + model.UserId;
            data += ", BSB : " + model.BSB;
            data += ", AccountNo : " + model.AccountNo;
            data += ", AccountName : " + model.AccountName;
            data += ", Reference : " + model.Reference;
            data += ", Amount : " + model.Amount;
            try
            {
                if (!Directory.Exists(filepath))
                    Directory.CreateDirectory(filepath);
                FileSystem.WriteDataToFile(Path.Combine(filepath,filename), data);
                return JsonResponse.SuccessResponse("Payment completed successfully.");
            }
            catch(Exception ex)
            {
                return JsonResponse.ErrorResponse(ex);
            }
            
        }
    }
}