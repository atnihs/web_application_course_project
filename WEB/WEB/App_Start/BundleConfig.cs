using System.Web;
using System.Web.Optimization;

namespace REALTEST
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            bundles.Add(new StyleBundle("~/Template/css").Include(
                     "~/Template/about.css",
                     "~/Template/bootstrap.css",
                     "~/Template/checkout.css",
                     "~/Template/contact.css",
                     "~/Template/creditly.css",
                     "~/Template/easy-responsive-tabs.css",
                     "~/Template/flexslider.css",
                     "~/Template/font-awesome.css",
                     "~/Template/jquery-ui1.css",
                     "~/Template/shop.css",
                     "~/Template/style.css",
                     "~/Template/style7.css"));


            bundles.Add(new ScriptBundle("~/Template/js").Include(
                        "~/Template/js/bootstrap-3.1.1.min.js",
                        "~/Template/js/classie.js",
                        "~/Template/js/creditly.js",
                        "~/Template/js/demo1.js",
                        "~/Template/js/easing.js",
                        "~/Template/js/easy-responsive-tabs.js",
                        "~/Template/js/imagezoom.js",
                        "~/Template/js/jquery-2.1.4.min.js",
                        "~/Template/js/jquery-ui.js",
                        "~/Template/js/jquery.flexslider.js",
                        "~/Template/js/minicart.js",
                        "~/Template/js/modernizr-2.6.2.min.js",
                        "~/Template/js/move-top.js.js",
                        "~/Template/js/responsiveslides.min.js",
                        "~/Template/js/search.js"));
                       

        }
    }
}
