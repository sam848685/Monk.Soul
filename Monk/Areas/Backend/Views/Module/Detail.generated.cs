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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Module/Detail.cshtml")]
    public partial class _Areas_Backend_Views_Module_Detail_cshtml : System.Web.Mvc.WebViewPage<V_ModuleVM>
    {
        public _Areas_Backend_Views_Module_Detail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
  
    ViewBag.Title = ViewBag.HaviorInfo.Name + " - " + ViewBag.SysSetInfo.Name;
    Layout = ViewBag.HaviorInfo.Layout;
    ViewBag.Keywords = ViewBag.SysSetInfo.Keywords;
    ViewBag.Description = ViewBag.SysSetInfo.Description;
    ViewBag.Copyright = ViewBag.SysSetInfo.Copyright;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("head", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 10 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.HeadCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n\r\n");

DefineSection("crumbs", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
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

WriteLiteral(">上级栏目</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.ParentName, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">栏目名称</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">栏目描述</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 34 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Remark, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">排序数字</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(Model.Sort);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">标签属性</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 46 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.TagAttr, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">字体图标</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 52 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(Html.Raw(DataToHtmlHelper.GetIconfont(Model.Iconfont)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">开放状态</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 58 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(Html.Raw(DataToHtmlHelper.StatusHtml(Model.Enable)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">默认数据</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 64 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(Html.Raw(DataToHtmlHelper.StatusHtml(Model.Default)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">创建时间</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 70 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.CreateTime, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">更新时间</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 76 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.UpdateTime, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("operate", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 81 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
Write(Html.HiddenFor(u => u.ModuleID));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 82 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FormButtons));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 86 "..\..\Areas\Backend\Views\Module\Detail.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FootCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
