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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Default/Signin.cshtml")]
    public partial class _Areas_Backend_Views_Default_Signin_cshtml : System.Web.Mvc.WebViewPage<SigninModelVM>
    {
        public _Areas_Backend_Views_Default_Signin_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
  
    ViewBag.Title = ViewBag.HaviorInfo.Name;
    Layout = ViewBag.HaviorInfo.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("head", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
Write(ViewBag.HaviorInfo.HeadCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"signin-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"signin-logo\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" href=\"http://www.baisoft.org\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"\"");

WriteLiteral(" title=\"百签软件有限公司\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 333), Tuple.Create("\"", 385)
, Tuple.Create(Tuple.Create("", 339), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Backend/Assets/Images/baisoft-logo.png")
, 339), false)
);

WriteLiteral(" class=\"display-block\"");

WriteLiteral(" alt=\"百签软件有限公司\"");

WriteLiteral(" title=\"百签软件有限公司\"");

WriteLiteral(" />\r\n        </a>\r\n    </div>\r\n");

            
            #line 15 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
     using (Html.BeginForm("Signin", "Default", FormMethod.Post, new { @class = "monk-form" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(" for=\"Account\"");

WriteLiteral(">会员账号</label>\r\n            <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-backend-account\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
           Write(Html.TextBoxFor(u => u.Account,
               new
               {
                   @class = "monk-form-input",
                   placeholder = "会员账号",
                   datatype = "s3-16",
                   errormsg = "账号由3-16位英文字母，数字或中文组成",
                   nullmsg = "请输入会员账号"
               }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">账号由3-16位英文字母，数字或中文组成</div>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(" for=\"Password\"");

WriteLiteral(">会员密码</label>\r\n            <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-backend-lock\"");

WriteLiteral("></span>\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
           Write(Html.PasswordFor(u => u.Password,
               new
               {
                   @class = "monk-form-input",
                   placeholder = "会员密码",
                   datatype = "*6-20",
                   errormsg = "密码由6-20位英文字母、数字或符号组成",
                   nullmsg = "请输入会员密码"
               }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">密码由6-20位英文字母、数字或符号组成</div>\r\n        </div>\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"monk-input-button turquoise monk-form-submit float-left\"");

WriteLiteral(" value=\"验证登入\"");

WriteLiteral(">\r\n");

WriteLiteral("        <input");

WriteLiteral(" type=\"reset\"");

WriteLiteral(" class=\"monk-input-button amethyst monk-form-reset float-right\"");

WriteLiteral(" value=\"重置表单\"");

WriteLiteral(">\r\n");

            
            #line 55 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 59 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
Write(ViewBag.HaviorInfo.FootCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 60 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
Write(Scripts.Render("~/Assets/Backend/Validform/Script"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        if (self != top) { top.location = self.location; }\r\n        $(function" +
" () {\r\n            $(\"#Account\").focus();\r\n            backend.validform(functio" +
"n (data) {\r\n                window.location.href = \"");

            
            #line 66 "..\..\Areas\Backend\Views\Default\Signin.cshtml"
                                   Write(Url.Action("Index","Default"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n            });\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591