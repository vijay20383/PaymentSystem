using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaymentSystem.Models
{
    public class LogFilter : ActionFilterAttribute, IExceptionFilter
    {
        /// <summary>  
        /// This method call before excute Action Method  
        /// </summary>  
        /// <param name="filterContext"></param>  
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string msg = "\n" + DateTime.Now.ToString() + "--" + filterContext.ActionDescriptor.ControllerDescriptor.ControllerName + "----" + filterContext.ActionDescriptor.ActionName + "--" + "OnActionExecuting";
            LogDetails(msg);
        }
        
        /// <summary>  
        /// This method call after excute Result   
        /// </summary>  
        /// <param name="filterContext"></param>  
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string msg = "\n" + DateTime.Now.ToString() + "--" + filterContext.RouteData.Values["controller"] + "----" + filterContext.RouteData.Values["action"] + "--" + ((System.Web.Mvc.JsonResult)filterContext.Result).Data;
            LogDetails(msg);
        }
       
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            string msg = "\n" + DateTime.Now.ToString() + "--" + filterContext.RouteData.Values["controller"] + "----" + filterContext.RouteData.Values["action"] + "--" + filterContext.Exception.InnerException;
            LogDetails(msg);
        }
        private void LogDetails(string logData)
        {
            string filepath = HttpContext.Current.Server.MapPath("~/Log");
            if (!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);
            File.AppendAllText(Path.Combine(filepath,"Log.txt"), logData);
        }
    }
 
}