﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Monk;
    using Monk.Areas.Backend.ViewModels;
    using Monk.Utils;
    using Monk.ViewModels;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Shared/_List.cshtml")]
    public partial class _Areas_Backend_Views_Shared__List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Backend_Views_Shared__List_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"Content-Type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=Edge,chrome=1\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"renderer\"");

WriteLiteral(" content=\"webkit\"");

WriteLiteral(">\r\n    <title>");

            
            #line 8 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" name=\"author\"");

WriteLiteral(" content=\"百签软件有限公司,百小僧\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"generator\"");

WriteLiteral(" content=\"Visual Studio\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteAttribute("content", Tuple.Create(" content=\"", 415), Tuple.Create("\"", 456)
            
            #line 11 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
, Tuple.Create(Tuple.Create("", 425), Tuple.Create<System.Object, System.Int32>(ViewBag.Keywords
            
            #line default
            #line hidden
, 425), false)
, Tuple.Create(Tuple.Create("", 444), Tuple.Create("百签软件有限公司,百小僧", 444), true)
);

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteAttribute("content", Tuple.Create(" content=\"", 490), Tuple.Create("\"", 552)
            
            #line 12 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
, Tuple.Create(Tuple.Create("", 500), Tuple.Create<System.Object, System.Int32>(ViewBag.Description
            
            #line default
            #line hidden
, 500), false)
, Tuple.Create(Tuple.Create("", 522), Tuple.Create("咨询电话：0760-88809987、18676265646", 522), true)
);

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"copyright\"");

WriteLiteral(" content=\"百签软件有限公司,百小僧\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"shortcut icon\"");

WriteAttribute("href", Tuple.Create(" href=\"", 641), Tuple.Create("\"", 682)
, Tuple.Create(Tuple.Create("", 648), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Backend/Assets/favicon.ico")
, 648), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
Write(Scripts.Render("~/Assets/Backend/Pace/Script"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
Write(Styles.Render("~/Assets/Backend/Pace/Style", "~/Assets/Backend/Monk.UI/Style", "~/Assets/Backend/Pagination/Style", "~/Assets/Backend/Style"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 17 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
Write(RenderSection("head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body ");

            
            #line 19 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
 Write(RenderSection("bodyAttr", false));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"backend-crumbs clear-both\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-backend-crumbs\"");

WriteLiteral("></span>\r\n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"管理首页\"");

WriteLiteral(">管理首页</a>\r\n");

WriteLiteral("        ");

            
            #line 23 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
   Write(RenderSection("crumbs", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"backend-buttons\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 26 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
   Write(RenderSection("buttons", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"backend-searchs\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 29 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
   Write(RenderSection("searchs", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"backend-content list-layout\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 32 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"backend-operate\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
   Write(RenderSection("operate", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
Write(Scripts.Render("~/Assets/Backend/Monk.UI/Script", "~/Assets/Backend/JQuery/Script","~/Assets/Backend/Layer/Script", "~/Assets/Backend/Pagination/Script", "~/Assets/Backend/Script"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Areas\Backend\Views\Shared\_List.cshtml"
Write(RenderSection("foot", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
