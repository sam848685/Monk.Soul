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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Havior/Detail.cshtml")]
    public partial class _Areas_Backend_Views_Havior_Detail_cshtml : System.Web.Mvc.WebViewPage<V_HaviorVM>
    {
        public _Areas_Backend_Views_Havior_Detail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
  
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

            
            #line 11 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
Write(ViewBag.HaviorInfo.HeadCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("crumbs", () => {

WriteLiteral("\r\n    <label");

WriteLiteral(" class=\"backend-crumbs-separator\"");

WriteLiteral(">/</label>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"系统管理\"");

WriteLiteral(">系统管理</a>\r\n    <label");

WriteLiteral(" class=\"backend-crumbs-separator\"");

WriteLiteral(">/</label>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"模块管理\"");

WriteLiteral(">模块管理</a>\r\n    <label");

WriteLiteral(" class=\"backend-crumbs-separator\"");

WriteLiteral(">/</label>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"行为管理\"");

WriteLiteral(">行为管理</a>\r\n    <label");

WriteLiteral(" class=\"backend-crumbs-separator\"");

WriteLiteral(">/</label>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"查看行为\"");

WriteLiteral(">查看行为</a>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">所属模块</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(Model.ModuleName);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">行为名称</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 34 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">请求方式</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(Model.HttpMethod);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">布局地址</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 46 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Layout, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">行为描述</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 52 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Remark, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">路由格式</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 58 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(Html.Raw(DataToHtmlHelper.StatusHtml(Model.Route)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">链接地址</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 64 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Url, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">区域</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 70 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Area, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">控制器</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 76 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Controller, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">行为</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 82 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Action, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">参数</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 88 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.Parameter, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">默认首页</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 94 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(Html.Raw(DataToHtmlHelper.StatusHtml(Model.Index)));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">页头代码</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-code-wrap monk-full\"");

WriteLiteral(">\r\n        <pre");

WriteLiteral(" class=\"monk-code\"");

WriteLiteral(" data-language=\"HTML\"");

WriteLiteral(">");

            
            #line 100 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
                                               Write(Model.HeadCode);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">页脚代码</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-code-wrap monk-full\"");

WriteLiteral(">\r\n        <pre");

WriteLiteral(" class=\"monk-code\"");

WriteLiteral(" data-language=\"HTML\"");

WriteLiteral(">");

            
            #line 106 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
                                               Write(Model.FootCode);

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">开放状态</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-detail-wrap monk-full\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 112 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(Html.Raw(DataToHtmlHelper.StatusHtml(Model.Enable)));

            
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

            
            #line 118 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
   Write(DataToHtmlHelper.NullHtml(Model.UpdateTime, "无"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");

DefineSection("operate", () => {

WriteLiteral("\r\n    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4393), Tuple.Create("\"", 4460)
            
            #line 123 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
, Tuple.Create(Tuple.Create("", 4400), Tuple.Create<System.Object, System.Int32>(Url.Action("Update", "Havior", new { id = Model.HaviorID })
            
            #line default
            #line hidden
, 4400), false)
);

WriteLiteral(" class=\"monk-input-button turquoise\"");

WriteLiteral(">编辑数据</a>\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"monk-input-button alizarin\"");

WriteLiteral(" onclick=\"deletes();\"");

WriteLiteral(">删除记录</a>\r\n    <input");

WriteLiteral(" type=\"reset\"");

WriteLiteral(" class=\"monk-input-button peterRiver\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4650), Tuple.Create("\"", 4716)
, Tuple.Create(Tuple.Create("", 4660), Tuple.Create("window.location.href", 4660), true)
, Tuple.Create(Tuple.Create(" ", 4680), Tuple.Create("=", 4681), true)
, Tuple.Create(Tuple.Create(" ", 4682), Tuple.Create("\'", 4683), true)
            
            #line 125 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
              , Tuple.Create(Tuple.Create("", 4684), Tuple.Create<System.Object, System.Int32>(Url.Action("Select","Havior")
            
            #line default
            #line hidden
, 4684), false)
, Tuple.Create(Tuple.Create("", 4714), Tuple.Create("\';", 4714), true)
);

WriteLiteral(" value=\"返回列表\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"monk-input-button orange monk-form-previous\"");

WriteLiteral(" value=\"返回前页\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral(">\r\n");

});

WriteLiteral("\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 130 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
Write(ViewBag.HaviorInfo.FootCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        function deletes() {\r\n            backend.confirm(\"您确定要执行此操作吗？\", null," +
" function (index) {\r\n                backend.post(\"");

            
            #line 134 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
                         Write(Url.Action("Delete","Havior",new { }));

            
            #line default
            #line hidden
WriteLiteral("\", { ids: \"");

            
            #line 134 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
                                                                          Write(Model.HaviorID);

            
            #line default
            #line hidden
WriteLiteral("\" }, function (data) {\r\n                    window.location.href = \"");

            
            #line 135 "..\..\Areas\Backend\Views\Havior\Detail.cshtml"
                                       Write(Url.Action("Select", "Havior"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n                });\r\n            });\r\n        }\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
