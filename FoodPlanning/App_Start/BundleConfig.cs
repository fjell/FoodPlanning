using System.Web.Optimization;

namespace FoodPlanning
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Framework CSS

            // Self defined CSS
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/Content/Styles/Style.css"));

            // Framework JS

            //Self defined JS
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/Script.js"));
        }
    }
}