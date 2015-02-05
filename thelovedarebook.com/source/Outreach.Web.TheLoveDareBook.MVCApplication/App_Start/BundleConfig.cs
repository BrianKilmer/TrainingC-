using System.Web;
using System.Web.Optimization;

namespace Outreach.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/prebody.js").Include(
                        "~/scripts/google-analytics.js",
                        "~/scripts/vwo.js"));

            bundles.Add(new ScriptBundle("~/scripts/postbody.js").Include(
                        "~/scripts/jquery-{version}.js",
                        "~/scripts/bootstrap.js",
                        "~/scripts/site.js"));

            bundles.Add(new StyleBundle("~/content/base.css").Include(
                        "~/content/bootstrap.css",
                        "~/content/site.css"));
        }
    }
}