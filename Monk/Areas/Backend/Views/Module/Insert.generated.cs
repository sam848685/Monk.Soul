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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Module/Insert.cshtml")]
    public partial class _Areas_Backend_Views_Module_Insert_cshtml : System.Web.Mvc.WebViewPage<ModuleVM>
    {
        public _Areas_Backend_Views_Module_Insert_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
  
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

            
            #line 11 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.HeadCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("crumbs", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.Crumbs));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("beginForm", () => {

            
            #line 18 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
                      Html.BeginForm("Insert", "Module", FormMethod.Post, new { @class = "monk-form" });
            
            #line default
            #line hidden
});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"ParentID\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">上级栏目</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-select-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"monk-form-input middle\"");

WriteLiteral(" placeholder=\"请输入或选择...\"");

WriteLiteral(" />\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont monk-select-arrow icon-monk-arrowdown border-left\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-select monk-none\"");

WriteLiteral(">\r\n        <select");

WriteLiteral(" class=\"monk-select\"");

WriteLiteral(" name=\"ParentID\"");

WriteLiteral(" datatype=\"*\"");

WriteLiteral(" nullmsg=\"请选择上级栏目\"");

WriteLiteral(" errormsg=\"请选择上级栏目\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请输入或选择...</option>\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
       Write(Html.Raw(ViewData["ModuleList"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </select>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">选择将该模块添加到指定栏目下面</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Name\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">栏目名称</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
   Write(Html.TextBoxFor(u => u.Name,
        new
        {
            @class = "monk-form-input normal",
            placeholder = "栏目名称",
            datatype = "*1-16",
            errormsg = "栏目名称由1-16位英文字母、数字或符号组成",
            nullmsg = "请输入栏目名称"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">通常栏目名称不宜过长，4-6个字最为恰当</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Remark\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">栏目描述</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 58 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
   Write(Html.TextAreaFor(u => u.Remark,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "栏目描述",
            datatype = "*1-100",
            ignore = "ignore",
            errormsg = "栏目描述由1-100位英文字母、数字或符号组成",
            nullmsg = "请输入栏目描述"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">简单一句话，描述一下该栏目吧。</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Sort\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">排序数字</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 76 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
   Write(Html.TextBoxFor(u => u.Sort,
        new
        {
            @class = "monk-form-input min",
            placeholder = "排序数字",
            datatype = "n",
            errormsg = "排序数字必须是正整数",
            nullmsg = "请输入排序数字"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">数字越小，越排前面</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"TagAttr\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">标签属性</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 94 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
   Write(Html.TextAreaFor(u => u.TagAttr,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "标签属性",
            datatype = "*1-100",
            ignore = "ignore",
            errormsg = "标签属性由1-100位英文字母、数字或符号组成",
            nullmsg = "请输入标签属性"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">可以为栏目标签添加HTML属性，如：style=\"color:#000;\" data-name=\"xxx\"</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Iconfont\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">字体图标</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 112 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
   Write(Html.TextBoxFor(u => u.Iconfont,
        new
        {
            @class = "monk-form-input normal",
            placeholder = "字体图标",
            datatype = "*1-50",
            ignore = "ignore",
            errormsg = "字体图标由1-50位英文字母、数字或符号组成",
            nullmsg = "请输入字体图标"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">目前只支持阿里图标，格式为：icon-图标class，默认为文件字体图标</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Enable\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">开放状态</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-switch-list\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 129 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
   Write(Html.CheckBoxFor(u => u.Enable,
       new
       {
           @class = "monk-switch",
           text = "开放"
       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置该栏目是否可见</div>\r\n</div>\r\n\r\n");

DefineSection("operate", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 140 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FormButtons));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("endForm", () => {

            
            #line 143 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
                    Html.EndForm();
            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 146 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FootCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            backend.validform(function (data) {
                backend.confirm(data.info + ""，是否继续新增？"", {}, function (index) {
                    backend.layer().close(index);
                    window.location.reload();
                }, function () {
                    window.location.href = """);

            
            #line 154 "..\..\Areas\Backend\Views\Module\Insert.cshtml"
                                       Write(Url.Action("Detail","Module",new { id=""}));

            
            #line default
            #line hidden
WriteLiteral("/\" + data.data.id;\r\n                });\r\n            });\r\n        });\r\n    </scri" +
"pt>\r\n");

});

        }
    }
}
#pragma warning restore 1591
