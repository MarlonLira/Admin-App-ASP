using System.Web;
using System.Web.Optimization;

namespace Admin
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/Js").Include(
                      "~/Content/bower_components/jquery/dist/jquery.min.js",
                      "~/Content/bower_components/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                      "~/Content/bower_components/fastclick/lib/fastclick.js",
                      "~/Content/bower_components/select2/dist/js/select2.full.min.js",
                      "~/Content/dist/js/adminlte.min.js",
                      "~/Content/plugins/input-mask/jquery.inputmask.js",
                      "~/Content/plugins/input-mask/jquery.inputmask.date.extensions.js",
                      "~/Content/plugins/input-mask/jquery.inputmask.extensions.js",
                      "~/Content/dist/js/demo.js"
                      ));

            bundles.Add(new StyleBundle("~/Css").Include(
                      "~/Content/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Content/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/dist/css/skins/_all-skins.min.css"
                      ));
        }
    }
}
