﻿using System.Web.Optimization;

namespace Monk
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Backend Bundles

            // backend
            bundles.Add(new StyleBundle("~/Assets/Backend/Style").Include(
                "~/Areas/Backend/Assets/Styles/backend.min.css"
            ));
            bundles.Add(new ScriptBundle("~/Assets/Backend/Script").Include(
                "~/Areas/Backend/Assets/Scripts/backend.js"
            ));
            // Monk.UI
            bundles.Add(new StyleBundle("~/Assets/Backend/Monk.UI/Style").Include(
                "~/Areas/Backend/Assets/Vendors/monk.ui-v0.3.5/monk.ui.min.css"
            ));
            bundles.Add(new ScriptBundle("~/Assets/Backend/Monk.UI/Script").Include(
                "~/Areas/Backend/Assets/Vendors/monk.ui-v0.3.5/monk.ui.min.js"
            ));
            // Hover
            bundles.Add(new StyleBundle("~/Assets/Backend/Hover/Style").Include(
                "~/Areas/Backend/Assets/Vendors/hover-v2.0.2/hover-min.css"
            ));
            // JQuery
            bundles.Add(new ScriptBundle("~/Assets/Backend/JQuery/Script").Include(
               "~/Areas/Backend/Assets/Vendors/jquery-v3.1.1/jquery-3.1.1.min.js"
           ));
            // Layer
            bundles.Add(new ScriptBundle("~/Assets/Backend/Layer/Script").Include(
               "~/Areas/Backend/Assets/Vendors/layer-v2.4/layer.js"
           ));
            // Linq
            bundles.Add(new ScriptBundle("~/Assets/Backend/Linq/Script").Include(
               "~/Areas/Backend/Assets/Vendors/linq-v3.0.4/linq.min.js"
           ));
            // Validform
            bundles.Add(new ScriptBundle("~/Assets/Backend/Validform/Script").Include(
               "~/Areas/Backend/Assets/Vendors/validform-v5.3.2/validform-v5.3.2.min.js"
           ));
            // Store
            bundles.Add(new ScriptBundle("~/Assets/Backend/Store/Script").Include(
               "~/Areas/Backend/Assets/Vendors/store-v1.3.20/store_json2.min.js"
           ));
            // Waypoints
            bundles.Add(new ScriptBundle("~/Assets/Backend/Waypoints/Script").Include(
               "~/Areas/Backend/Assets/Vendors/waypoints-v4.0.1/noframework.waypoints.min.js"
           ));
            // Pace
            bundles.Add(new StyleBundle("~/Assets/Backend/Pace/Style").Include(
                "~/Areas/Backend/Assets/Vendors/pace-v1.0.2/pace-theme-minimal.min.css"
            ));
            bundles.Add(new ScriptBundle("~/Assets/Backend/Pace/Script").Include(
                "~/Areas/Backend/Assets/Vendors/pace-v1.0.2/pace.min.js"
            ));
            // Pagination
            bundles.Add(new StyleBundle("~/Assets/Backend/Pagination/Style").Include(
                "~/Areas/Backend/Assets/Vendors/pagination-v2.0.7/pagination.css"
            ));
            bundles.Add(new ScriptBundle("~/Assets/Backend/Pagination/Script").Include(
                "~/Areas/Backend/Assets/Vendors/pagination-v2.0.7/pagination.min.js"
            ));
            // Nicescroll
            bundles.Add(new ScriptBundle("~/Assets/Backend/Nicescroll/Script").Include(
               "~/Areas/Backend/Assets/Vendors/nicescroll-v3.6.8/nicescroll.min.js"
            ));
            // WebUploader
            bundles.Add(new StyleBundle("~/Assets/Backend/WebUploader/Style").Include(
              "~/Areas/Backend/Assets/Vendors/webuploader-v0.1.6/dist/webuploader.min.css"
            ));
            bundles.Add(new ScriptBundle("~/Assets/Backend/WebUploader/Script").Include(
                "~/Areas/Backend/Assets/Vendors/webuploader-v0.1.6/dist/webuploader.min.js"
            ));
        }
    }
}