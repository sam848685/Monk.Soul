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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/SysSet/Update.cshtml")]
    public partial class _Areas_Backend_Views_SysSet_Update_cshtml : System.Web.Mvc.WebViewPage<SysSetVM>
    {
        public _Areas_Backend_Views_SysSet_Update_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
  
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

            
            #line 11 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.HeadCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Styles.Render("~/Assets/Backend/WebUploader/Style"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("crumbs", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.Crumbs));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("beginForm", () => {

            
            #line 19 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                      Html.BeginForm("Update", "SysSet", FormMethod.Post, new { @class = "monk-form" });
            
            #line default
            #line hidden
});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Logo\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统标志</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap noborder\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 757), Tuple.Create("\"", 774)
            
            #line 24 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
, Tuple.Create(Tuple.Create("", 763), Tuple.Create<System.Object, System.Int32>(Model.Logo
            
            #line default
            #line hidden
, 763), false)
);

WriteLiteral(" id=\"image-view\"");

WriteLiteral(" alt=\"\"");

WriteLiteral(" class=\"display-block\"");

WriteLiteral(" height=\"50\"");

WriteLiteral(" />\r\n");

WriteLiteral("        ");

            
            #line 25 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.HiddenFor(u => u.Logo));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"clear-both height-8\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap monk-form-image-wrap\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"monk-images-selects\"");

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"monk-form-wrap bgcolor-white\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n            <input");

WriteLiteral(" class=\"monk-form-input normal\"");

WriteLiteral(" value=\"未选择文件\"");

WriteLiteral(" id=\"uploadUrl\"");

WriteLiteral(" readonly=\"readonly\"");

WriteLiteral(" data-src=\"");

            
            #line 33 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                                                                                                        Write(Model.Logo);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" />\r\n            <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha\"");

WriteLiteral(" id=\"removeFile\"");

WriteLiteral("></span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"monk-input-button monk-input-file\"");

WriteLiteral(" id=\"selectFiles\"");

WriteLiteral(">选择图片</div>\r\n        <div");

WriteLiteral(" class=\"monk-file-uploadProgress\"");

WriteLiteral(" id=\"uploadProgress\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"monk-input-button emerland\"");

WriteLiteral(" id=\"startUpload\"");

WriteLiteral(">开始上传</div>\r\n        <div");

WriteLiteral(" class=\"monk-input-button amethyst\"");

WriteLiteral(" id=\"clearUpload\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(">重置删除</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">若成功上传并未应用，应点击 <label");

WriteLiteral(" class=\"tipcolor\"");

WriteLiteral(">重置删除</label> 按钮，服务器会删除对应文件，节省存储空间。</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Name\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统名称</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 47 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Name,
        new
        {
            @class = "monk-form-input normal",
            placeholder = "系统名称",
            datatype = "*1-50",
            errormsg = "系统名称由1-50位英文字母、数字或符号组成",
            nullmsg = "请输入系统名称"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">给你的系统起个牛逼的名字吧</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Version\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统版本</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 65 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Version,
        new
        {
            @class = "monk-form-input middle",
            placeholder = "系统版本",
            datatype = "*1-25",
            errormsg = "系统版本由1-25位英文字母、数字或符号组成",
            nullmsg = "请输入系统版本"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">通常系统版本格式为：v1.0.0</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Keywords\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">关键字</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 83 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextAreaFor(u => u.Keywords,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "关键字",
            datatype = "*1-100",
            ignore = "ignore",
            errormsg = "关键字由1-100位英文字母、数字或符号组成",
            nullmsg = "请输入关键字"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">SEO关键字，用英文逗号隔开，方法搜索引擎收录</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Description\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">系统描述</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 101 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextAreaFor(u => u.Description,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "系统描述",
            datatype = "*1-160",
            ignore = "ignore",
            errormsg = "系统描述由1-160位英文字母、数字或符号组成",
            nullmsg = "请输入系统描述"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">简单一句话，描述一下该系统吧。</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Support\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">技术支持</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 119 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Support,
        new
        {
            @class = "monk-form-input normal",
            disabled = "disabled",
            placeholder = "技术支持",
            ignore = "ignore",
            datatype = "*1-50",
            errormsg = "技术支持由1-50位英文字母、数字或符号组成",
            nullmsg = "请输入技术支持"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">毋庸置疑，只有创造她的人才更懂她~~</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Copyright\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">版权所有</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input textarea-icon\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 137 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextAreaFor(u => u.Copyright,
        new
        {
            @class = "monk-form-textarea normal",
            placeholder = "版权所有",
            datatype = "*1-100",
            ignore = "ignore",
            errormsg = "版权所有由1-100位英文字母、数字或符号组成",
            nullmsg = "请输入版权所有"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input textarea-icon\"" +
"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">格式通常为：Copyright ©  2016 百签软件（中山）有限公司. All rights reserved.</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"Site\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">官方网址</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 155 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.Site,
        new
        {
            @class = "monk-form-input normal",
            placeholder = "官方网址",
            datatype = "url",
            ignore = "ignore",
            errormsg = "请输入正确的网址",
            nullmsg = "请输入官方网址"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">写下你的官方网址，让大家多了解一下你。</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"PageSize\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">默认页容量</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 173 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.PageSize,
        new
        {
            @class = "monk-form-input min",
            placeholder = "默认页容量",
            datatype = "n",
            errormsg = "页容量必须是正整数",
            nullmsg = "请输入默认页容量"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">指定一下默认的数据显示条数吧</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"ImageMaxSize\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">图片最大上传大小（M）</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 191 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.ImageMaxSize,
        new
        {
            @class = "monk-form-input min",
            placeholder = "图片最大上传大小（M）",
            datatype = "n",
            errormsg = "只能输入正整数",
            nullmsg = "请输入图片最大上传大小（M）"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">指定该数值可以显示用户上传图片的大小</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"VideoMaxSize\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">视频最大上传大小（M）</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 209 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.VideoMaxSize,
        new
        {
            @class = "monk-form-input min",
            placeholder = "视频最大上传大小（M）",
            datatype = "n",
            errormsg = "只能输入正整数",
            nullmsg = "请输入视频最大上传大小（M）"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">指定该数值可以显示用户上传视频的大小</div>\r\n</div>\r\n<div");

WriteLiteral(" class=\"monk-form-item\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" for=\"AttachMaxSize\"");

WriteLiteral(" class=\"monk-form-label\"");

WriteLiteral(">附件最大上传大小（M）</label>\r\n    <div");

WriteLiteral(" class=\"monk-form-wrap\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-right icon-monk-input\"");

WriteLiteral("></span>\r\n");

WriteLiteral("        ");

            
            #line 227 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
   Write(Html.TextBoxFor(u => u.AttachMaxSize,
        new
        {
            @class = "monk-form-input min",
            placeholder = "附件最大上传大小（M）",
            datatype = "n",
            errormsg = "只能输入正整数",
            nullmsg = "请输入附件最大上传大小（M）"
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" class=\"monk-iconfont icon-monk-required\"");

WriteLiteral("></span>\r\n        <span");

WriteLiteral(" class=\"monk-iconfont border-left icon-monk-dacha monk-clear-input\"");

WriteLiteral("></span>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"monk-form-tip\"");

WriteLiteral(">指定该数值可以显示用户上传附件的大小</div>\r\n</div>\r\n\r\n\r\n");

DefineSection("operate", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 244 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Html.HiddenFor(u => u.SetID));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 245 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FormButtons));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

DefineSection("endForm", () => {

            
            #line 248 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                    Html.EndForm();
            
            #line default
            #line hidden
});

WriteLiteral("\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 251 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Html.Raw(ViewBag.HaviorInfo.FootCode));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 252 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
Write(Scripts.Render("~/Assets/Backend/WebUploader/Script"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var src= $(\"#uploadUrl\").attr(\"data-src\")" +
";\r\n            // 图片上传\r\n            var uploader = backend.fileUpload({\r\n       " +
"         options: {\r\n                    fileSingleSizeLimit : ");

            
            #line 259 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                                     Write(ViewBag.SysSetInfo.ImageMaxSize);

            
            #line default
            #line hidden
WriteLiteral(" * 1024 * 1024\r\n                },\r\n                data:{\r\n                    a" +
"rea:\"");

            
            #line 262 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                     Write(ViewContext.RouteData.DataTokens["area"]);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n                    controller:\"");

            
            #line 263 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                           Write(ViewContext.RouteData.Values["controller"]);

            
            #line default
            #line hidden
WriteLiteral(@"""
                },
                fileDequeued:function(file){
                    $(""#image-view"").attr(""src"",src);
                    $(""#Logo"").val(src);
                },
                uploadSuccess:function(file,response){
                    $(""#image-view"").attr(""src"",response.data.path);
                    $(""#Logo"").val(response.data.path);
                }
            });

            backend.validform(function (data) {
                window.location.href=""");

            
            #line 276 "..\..\Areas\Backend\Views\SysSet\Update.cshtml"
                                 Write(Url.Action("Detail","SysSet"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n            });\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
