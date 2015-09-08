using System;
using System.Web;
using System.Web.Optimization;

namespace JobHunter
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);


            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));


            bundles.Add(
                new ScriptBundle("~/Scripts/vendor")
                    .Include("~/Scripts/vendor/angular.js")
                    .Include("~/Scripts/vendor/bootstrap.js")
                     .Include("~/Scripts/vendor/themeApp.min.js")

                );

            ///////////////STYLES/////////////////////


            bundles.Add(
                new StyleBundle("~/Content/css")
                    .Include("~/Content/site.css")
                    .Include("~/Content/bootstrap.css")
                    .Include("~/Content/AdminLTE.min.css")
                    .Include("~/Content/skin-blue.min.css")

               );

            bundles.Add(
                new StyleBundle("~/Content/Theme/css")
                    .Include("~/Content/Theme/AdminLTE.min.css")
                    .Include("~/Content/Theme/Skins/skin-blue.min.css")
                   

               );

        }

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}