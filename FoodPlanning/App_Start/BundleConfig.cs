using System.Web.Optimization;

namespace FoodPlanning
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Framework CSS
            bundles.Add(new StyleBundle("~/bundles/frameworkCss").Include(
                        "~/Content/Styles/Framework/Bootstrap/bootstrap.css"));

            // Self defined CSS
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/Content/Styles/Style.css"));

            // Framework JS
            bundles.Add(new ScriptBundle("~/bundles/frameworkJs").Include(
                        "~/Scripts/Framework/Bootstrap/bootstrap.js"));

            //Self defined JS
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/Script.js"));
        }
    }
}