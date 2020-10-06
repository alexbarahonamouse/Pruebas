using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SchoolCF.App_Start
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite 
        // https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // ...

            // JQUERY UNOBTRUSIVE PARA @Ajax.BeginForm() 
            bundles.Add(new ScriptBundle("~/bundles/jqueryajax").Include(
                        "~/Scripts/jquery.unobtrusive*"));

            // ...
        }
    }
}