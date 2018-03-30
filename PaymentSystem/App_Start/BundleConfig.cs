using System.Web;
using System.Web.Optimization;

namespace PaymentSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Css/bootstrap-theme.min.css",
                      "~/Css/validation.css"));

            bundles.Add(new ScriptBundle("~/bundles/Payment").Include(
                     "~/AngularFiles/Payment/Payment.controller.js",
                      "~/AngularFiles/Payment/Payment.route.js",
                      "~/AngularFiles/Payment/Payment.services.js",
                      "~/AngularFiles/common.js"
                      ));

        }
    }
}
