using System.Web;
using System.Web.Optimization;

namespace HireMe
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));



            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/plugins/jquery/jquery-2.2.4.min.js",
                        "~/assets/bootstrap/js/popper.min.js",
                        "~/assets/bootstrap/js/bootstrap.min.js",
                        "~/assets/plugins/viewport/jquery.viewport.min.js",
                        "~/assets/plugins/menu/hoverintent.min.js",
                        "~/assets/plugins/menu/superfish.min.js",
                        "~/assets/plugins/fancybox/jquery.fancybox.min.js",
                        "~/assets/plugins/revolutionslider/js/jquery.themepunch.tools.min.js",
                        "~/assets/plugins/revolutionslider/js/jquery.themepunch.revolution.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.actions.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.carousel.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.kenburn.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.layeranimation.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.migration.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.navigation.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.parallax.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.slideanims.min.js",
                        "~/assets/plugins/revolutionslider/js/extensions/revolution.extension.video.min.js",
                        "~/assets/plugins/owl-carousel/owl.carousel.min.js",
                        "~/assets/plugins/parallax/jquery.stellar.min.js",
                        "~/assets/plugins/animations/wow.min.js",
                        "~/assets/js/custom.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/bootstrap/css/bootstrap.min.css",
                      "~/assets/fonts/fontawesome/css/font-awesome.min.css",
                      "~/assets/fonts/bizhub-icons/css/bizhub-icons.min.css",
                      "~/assets/plugins/fancybox/jquery.fancybox.min.css",
                      "~/assets/plugins/revolutionslider/css/settings.css",
                      "~/assets/plugins/revolutionslider/css/layers.css",
                      "~/assets/plugins/revolutionslider/css/navigation.css",
                      "~/assets/plugins/owl-carousel/owl.carousel.min.css",
                      "~/assets/plugins/counters/odometer-theme-default.min.css",
                      "~/assets/plugins/ytplayer/css/jquery.mb.ytplayer.min.css",
                      "~/assets/plugins/beatpicker/beatpicker.min.css",
                      "~/assets/plugins/animations/animate.min.css",
                      "~/assets/css/custom.css",
                      "~/assets/css/pages-style.css"));
        }
    }
}
