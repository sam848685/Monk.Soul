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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/SysSet/Detail.cshtml")]
    public partial class _Areas_Backend_Views_SysSet_Detail_cshtml : System.Web.Mvc.WebViewPage<SysSetVM>
    {
        public _Areas_Backend_Views_SysSet_Detail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
  
    ViewBag.Title = ViewBag.HaviorInfo.Name + " - " + ViewBag.SysSetInfo.Name;
    Layout = ViewBag.HaviorInfo.Layout;
    ViewBag.Keywords = ViewBag.SysSetInfo.Keywords;
    ViewBag.Description = ViewBag.SysSetInfo.Description;
    ViewBag.Copyright = ViewBag.SysSetInfo.Copyright;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("head", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.HeadCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("crumbs", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.Crumbs));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统标志</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 608), Tuple.Create("\"", 625)
            
            #line 21 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 614), Tuple.Create<System.Object, System.Int32>(Model.Logo
            
            #line default
            #line hidden
, 614), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" class=\"display-block\"");

WriteLiteral(" height=\"50\"");

WriteLiteral(" />\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统名称</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 27 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统版本</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n        <text>v</text>");

            
            #line 33 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
                 Write(Model.Version);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">关键字</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 39 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.Keywords);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统描述</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 45 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">技术支持</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"http://www.baisoft.org\"");

WriteLiteral(" style=\"text-decoration:none;\"");

WriteLiteral(" target=\"_blank\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1729), Tuple.Create("\"", 1751)
            
            #line 51 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
              , Tuple.Create(Tuple.Create("", 1737), Tuple.Create<System.Object, System.Int32>(Model.Support
            
            #line default
            #line hidden
, 1737), false)
);

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
                                                                                                         Write(Model.Support);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">版权所有</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 57 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.Copyright);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">官方网址</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2153), Tuple.Create("\"", 2171)
            
            #line 63 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 2160), Tuple.Create<System.Object, System.Int32>(Model.Site
            
            #line default
            #line hidden
, 2160), false)
);

WriteLiteral(" style=\"text-decoration:none;\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"官方网址\"");

WriteLiteral(">");

            
            #line 63 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
                                                                                    Write(Model.Site);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">默认页容量</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 69 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.PageSize);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">图片最大上传大小（M）</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 75 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.ImageMaxSize);

            
            #line default
            #line hidden
WriteLiteral("<text>M</text>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">视频最大上传大小（M）</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 81 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.VideoMaxSize);

            
            #line default
            #line hidden
WriteLiteral("<text>M</text>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">附件最大上传大小（M）</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 87 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(Model.AttachMaxSize);

            
            #line default
            #line hidden
WriteLiteral("<text>M</text>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">更新时间</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 93 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.UpdateTime));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("operate", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 98 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
Write(Html.HiddenFor(u => u.SetID));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 99 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FormButtons));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 103 "..\..\Areas\Backend\Views\SysSet\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FootCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
