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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Havior/Update.cshtml")]
    public partial class _Areas_Backend_Views_Havior_Update_cshtml : System.Web.Mvc.WebViewPage<HaviorVM>
    {
        public _Areas_Backend_Views_Havior_Update_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
  
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

            
            #line 11 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.HeadCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Styles.Render("~/Assets/Backend/Editor.MD/Style"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("crumbs", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.Crumbs));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("beginForm", () => {

            
            #line 19 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                      Html.BeginForm("Update", "Havior", FormMethod.Post, new { @class = "monk-form" });
            
            #line default
            #line hidden
});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"ModuleID\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">所属模块</label>\r\n    <div");

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

WriteLiteral(" name=\"ModuleID\"");

WriteLiteral(" datatype=\"*\"");

WriteLiteral(" nullmsg=\"请选择所属模块\"");

WriteLiteral(" errormsg=\"请选择所属模块\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请输入或选择...</option>\r\n");

WriteLiteral("            ");

            
            #line 32 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
       Write(Html.Raw(ViewData["ModuleList"]));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </select>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">选择将该行为绑定到指定所属模块下面</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Name\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">行为名称</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 41 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Name,
        new
        {
            @class = "monk-form-input normal",
            placeholder = "行为名称",
            datatype = "*1-16",
            errormsg = "行为名称由1-16位英文字母、数字或符号组成",
            nullmsg = "请输入行为名称"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">通常行为名称不宜过长，4-6个字最为恰当</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"HttpMethod\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">请求方式</label>\r\n    <div");

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

WriteLiteral(" name=\"HttpMethod\"");

WriteLiteral(" datatype=\"*\"");

WriteLiteral(" nullmsg=\"请选择请求方式\"");

WriteLiteral(" errormsg=\"请选择请求方式\"");

WriteLiteral(" data-value=\"");

            
            #line 64 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                                                                                                               Write(Model.HttpMethod);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请输入或选择...</option>\r\n            <option");

WriteLiteral(" value=\"GET\"");

WriteLiteral(">GET</option>\r\n            <option");

WriteLiteral(" value=\"POST\"");

WriteLiteral(">POST</option>\r\n            <option");

WriteLiteral(" value=\"PUT\"");

WriteLiteral(">PUT</option>\r\n            <option");

WriteLiteral(" value=\"DELETE\"");

WriteLiteral(">DELETE</option>\r\n        </select>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置该性能请求的方式，通常选择GET、POST请求，其他请求或有兼容问题</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Layout\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">布局地址</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-select-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 78 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Layout,
        new
        {
            @class = "monk-form-input large",
            placeholder = "请选择或输入...",
            datatype = "*",
            ignore = "ignore",
            errormsg = "请选择或输入布局地址",
            nullmsg = "请选择或输入布局地址"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont monk-select-arrow icon-monk-arrowdown border-left\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-select monk-none\"");

WriteLiteral(">\r\n        <select");

WriteLiteral(" class=\"monk-select\"");

WriteLiteral(" data-value=\"");

            
            #line 91 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                                           Write(Model.Layout);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n            <option");

WriteLiteral(" value=\"\"");

WriteLiteral("></option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3956), Tuple.Create("\"", 4007)
, Tuple.Create(Tuple.Create("", 3964), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Backend/Views/Shared/_Layout.cshtml")
, 3964), false)
);

WriteLiteral(">~/Areas/Backend/Views/Shared/_Layout.cshtml</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4082), Tuple.Create("\"", 4131)
, Tuple.Create(Tuple.Create("", 4090), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Backend/Views/Shared/_List.cshtml")
, 4090), false)
);

WriteLiteral(">~/Areas/Backend/Views/Shared/_List.cshtml</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4204), Tuple.Create("\"", 4253)
, Tuple.Create(Tuple.Create("", 4212), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Backend/Views/Shared/_Form.cshtml")
, 4212), false)
);

WriteLiteral(">~/Areas/Backend/Views/Shared/_Form.cshtml</option>\r\n            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4326), Tuple.Create("\"", 4377)
, Tuple.Create(Tuple.Create("", 4334), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Backend/Views/Shared/_Detail.cshtml")
, 4334), false)
);

WriteLiteral(">~/Areas/Backend/Views/Shared/_Detail.cshtml</option>\r\n        </select>\r\n    </d" +
"iv>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置该行为视图应用的Layout布局</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Remark\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">行为描述</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 105 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextAreaFor(u => u.Remark,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "行为描述",
            datatype = "*1-100",
            ignore = "ignore",
            errormsg = "行为描述由1-100位英文字母、数字或符号组成",
            nullmsg = "请输入行为描述"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">简单一句话，描述一下该行为吧。</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Route\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">路由格式</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-switch-list\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 122 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.CheckBoxFor(u => u.Route,
       new
       {
           @class = "monk-switch",
           text = "是"
       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置行为链接地址为路由格式，通常由 Area，Controller，Action，ID组成，参照MVC格式</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Area\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">区域</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 135 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Area,
        new
        {
            @class = "monk-form-input middle",
            placeholder = "区域名称",
            datatype = "s1-25",
            ignore = "ignore",
            errormsg = "区域名称由1-25位英文字母、数字组成",
            nullmsg = "请输入区域名称"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置路由地址中Area名称</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Controller\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">控制器</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 153 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Controller,
        new
        {
            @class = "monk-form-input middle",
            placeholder = "控制器名称",
            datatype = "s1-25",
            ignore = "ignore",
            errormsg = "控制器名称由1-25位英文字母、数字组成",
            nullmsg = "请输入控制器名称"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置路由地址中Controller名称</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Action\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">行为</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 171 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Action,
        new
        {
            @class = "monk-form-input middle",
            placeholder = "行为名称",
            datatype = "s1-25",
            ignore = "ignore",
            errormsg = "行为名称由1-25位英文字母、数字组成",
            nullmsg = "请输入行为名称"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置路由地址中Action名称</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Parameter\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">参数</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 189 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextAreaFor(u => u.Parameter,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "路由参数",
            datatype = "s1-100",
            ignore = "ignore",
            errormsg = "路由参数由1-100位英文字母、数字组成",
            nullmsg = "请输入路由"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置路由地址中id参数</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Url\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">链接地址</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 207 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Url,
        new
        {
            @class = "monk-form-input large",
            placeholder = "链接地址",
            datatype = "*1-200",
            ignore = "ignore",
            errormsg = "区域名称由1-200位英文字母、数字或符号组成",
            nullmsg = "请输入链接地址"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">如果选中<label");

WriteLiteral(" class=\"tipcolor\"");

WriteLiteral(">路由格式</label>选项，则无需填此项，程序会根据下面的Area，Controller，Action，ID自动生成</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Index\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">默认首页</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-switch-list\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 224 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
   Write(Html.CheckBoxFor(u => u.Index,
       new
       {
           @class = "monk-switch",
           text = "是"
       }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">设置行为是否是所属栏目的默认行为</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"HeadCode\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">页头代码</label>\r\n    <div");

WriteLiteral(" class=\"monk-editor-code\"");

WriteLiteral(" id=\"head-code\"");

WriteLiteral("><textarea");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">");

            
            #line 235 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                                                                            Write(Model.HeadCode);

            
            #line default
            #line hidden
WriteLiteral("</textarea></div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">在这里可以添加页头代码，<label");

WriteLiteral(" class=\"tipcolor\"");

WriteLiteral(">按F11可以全屏，ESC可以退出</label></div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"FootCode\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">页脚代码</label>\r\n    <div");

WriteLiteral(" class=\"monk-editor-code\"");

WriteLiteral(" id=\"foot-code\"");

WriteLiteral("><textarea");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">");

            
            #line 240 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                                                                            Write(Model.FootCode);

            
            #line default
            #line hidden
WriteLiteral("</textarea></div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">在这里可以添加页脚代码，<label");

WriteLiteral(" class=\"tipcolor\"");

WriteLiteral(">按F11可以全屏，ESC可以退出</label></div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Enable\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">开放状态</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-switch-list\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 246 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
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

WriteLiteral(">设置该行为是否开放</div>\r\n</div>\r\n\r\n");

DefineSection("operate", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 257 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Html.HiddenFor(u => u.HaviorID));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 258 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FormButtons));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("endForm", () => {

            
            #line 261 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                    Html.EndForm();
            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 264 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FootCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 265 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
Write(Scripts.Render("~/Assets/Backend/Editor.MD/Script"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            var headcode = backend.codeEditor(""head-code"", ""HeadCode"");
            var footcode = backend.codeEditor(""foot-code"", ""FootCode"");
            backend.validform(function (data) {
                window.location.href = """);

            
            #line 271 "..\..\Areas\Backend\Views\Havior\Update.cshtml"
                                   Write(Url.Action("Detail","Havior",new { id=Model.HaviorID}));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n            });\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
