using System.Web;
using System.Web.Optimization;

namespace BabySitter.MvcUI.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery.js"));


            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            //Slider Javascript Files
            bundles.Add(new ScriptBundle("~/bundles/templatejs").Include(
                "~/Scripts/wow.min.js",
                "~/Scripts/owl.carousel.min.js",
                "~/Scripts/OwlCarousel2Thumbs.min.js",
                "~/Scripts/jRate.min.js",
                "~/Scripts/jquery.magnific-popup.js",
                "~/Scripts/jquery.mixitup.js",
                "~/Scripts/datepicker.js",
                "~/Scripts/select2.min.js",
                "~/Scripts/countUp.js",
                "~/Scripts/slider/jquery.themepunch.tools.min.js",
                "~/Scripts/slider/jquery.themepunch.revolution.min.js",
                "~/Scripts/slider/revolution.extension.layeranimation.min.js",
                "~/Scripts/slider/revolution.extension.navigation.min.js",
                "~/Scripts/slider/revolution.extension.slideanims.min.js",
                "~/Scripts/slider/revolution.extension.video.min.js",
                "~/Scripts/main.js"));

            #endregion

            #region CSS
            bundles.Add(new StyleBundle("~/bundles/commoncss").Include(
                      //"~/Content/css/bootstrap.css",
                      //"~/Content/css/site.css",
                      "~/Content/css/main.css"));
            #endregion

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/css/bootstrap.css",
            //          "~/Content/css/site.css",
            //          "~/Content/css/main.css"));
        }
    }
}