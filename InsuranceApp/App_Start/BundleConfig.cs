using System.Web;
using System.Web.Optimization;

namespace InsuranceApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/respond.js",
                      "~/Scripts/bootstrap.js",
                      "~/_assets/_libs/jquery.js",
                      "~/_assets/_libs/no-ui-slider/jquery.nouislider.all.min.js",
                      "~/_assets/_libs/smoothscroll.js",
                      "~/_assets/_libs/parallax.js",
                      "~/_assets/_js/functions.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/_assets/_libs/font-awesome/css/font-awesome.css",
                      "~/_assets/_libs/no-ui-slider/jquery.nouislider.css",
                      "~/_assets/_libs/animate.css",
                      "~/_assets/_css/style.css",
                      "~/Content/Site.css"
                      ));
        }
    }
}
