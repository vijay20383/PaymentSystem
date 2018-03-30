using PaymentSystem.Class;
using PaymentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentSystem.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            return View();
        }
        [LogFilter]
        [HttpPost]
        public ActionResult MakePayment(PaymentDetailModel model)
        {
            var path = Server.MapPath("~/App_Data/SavedData");            
            if (ModelState.IsValid)
            {
                PaymentBusiness payClass = new PaymentBusiness();                
                return Json(payClass.SavePaymentData(path, model));
            }
            else
            {
                string messages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                return Json(JsonResponse.ErrorResponse(messages));
            }
               
        }
    }
}