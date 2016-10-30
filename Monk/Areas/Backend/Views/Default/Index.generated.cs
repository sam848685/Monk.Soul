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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Backend/Views/Default/Index.cshtml")]
    public partial class _Areas_Backend_Views_Default_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Backend_Views_Default_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Backend\Views\Default\Index.cshtml"
  
    ViewBag.Title = ViewBag.HaviorInfo.Name + " - " + ViewBag.SysSetInfo.Name;
    Layout = ViewBag.HaviorInfo.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("head", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 6 "..\..\Areas\Backend\Views\Default\Index.cshtml"
Write(ViewBag.HaviorInfo.HeadCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

DefineSection("bodyAttr", () => {

WriteLiteral(" class=\"index-body\"");

});

WriteLiteral("<div");

WriteLiteral(" id=\"backend-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"backend-top\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" id=\"switch-module\"");

WriteLiteral(" title=\"更多模块\"");

WriteLiteral(" class=\"backend-top-menu border-right monk-iconfont icon-backend-module\"");

WriteLiteral("></a>\r\n        <a");

WriteLiteral(" title=\"返回前页\"");

WriteLiteral(" class=\"backend-top-menu border-right monk-iconfont icon-backend-back\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("></a>\r\n        <a");

WriteLiteral(" title=\"刷新页面\"");

WriteLiteral(" class=\"backend-top-menu border-right monk-iconfont icon-backend-refresh\"");

WriteLiteral(" onclick=\"document.getElementById(\'backend-iframe\').contentWindow.location.reload" +
"(true);\"");

WriteLiteral("></a>\r\n        <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"查看网站\"");

WriteLiteral(" class=\"backend-top-menu border-right monk-iconfont icon-backend-website\"");

WriteLiteral("></a>\r\n        <a");

WriteLiteral(" title=\"会员信息\"");

WriteLiteral(" class=\"backend-top-menu border-left monk-iconfont icon-backend-account float-rig" +
"ht\"");

WriteLiteral("></a>\r\n        <a");

WriteLiteral(" title=\"退出管理\"");

WriteLiteral(" class=\"backend-top-menu border-left monk-iconfont icon-backend-tuichu float-righ" +
"t\"");

WriteLiteral(" id=\"signout\"");

WriteLiteral("></a>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"backend-left\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"backend-logo\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1174), Tuple.Create("\"", 1205)
            
            #line 20 "..\..\Areas\Backend\Views\Default\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1181), Tuple.Create<System.Object, System.Int32>(ViewBag.SysSetInfo.Site
            
            #line default
            #line hidden
, 1181), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1231), Tuple.Create("\"", 1263)
            
            #line 20 "..\..\Areas\Backend\Views\Default\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1239), Tuple.Create<System.Object, System.Int32>(ViewBag.SysSetInfo.Name
            
            #line default
            #line hidden
, 1239), false)
);

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1287), Tuple.Create("\"", 1317)
            
            #line 21 "..\..\Areas\Backend\Views\Default\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1293), Tuple.Create<System.Object, System.Int32>(ViewBag.SysSetInfo.Logo
            
            #line default
            #line hidden
, 1293), false)
);

WriteLiteral(" class=\"display-block\"");

WriteLiteral(" alt=\"系统标志\"");

WriteLiteral(" title=\"系统标志\"");

WriteLiteral(" onerror=\"this.src = \'/Areas/Backend/Assets/Images/baisoft-logo.png\'\"");

WriteLiteral(" />\r\n            </a>\r\n        </div>\r\n        <div");

WriteLiteral(" id=\"backend-left-menu\"");

WriteLiteral(">\r\n\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"backend-right\"");

WriteLiteral(">\r\n        <iframe");

WriteLiteral(" frameborder=\"0\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1601), Tuple.Create("\"", 1639)
            
            #line 29 "..\..\Areas\Backend\Views\Default\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Url.Action("Console","Default")
            
            #line default
            #line hidden
, 1607), false)
);

WriteLiteral(" id=\"backend-iframe\"");

WriteLiteral(" name=\"backend-iframe\"");

WriteLiteral("></iframe>\r\n    </div>\r\n</div>\r\n<div");

WriteLiteral(" id=\"backend-module\"");

WriteLiteral(">\r\n\r\n</div>\r\n\r\n");

DefineSection("foot", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 37 "..\..\Areas\Backend\Views\Default\Index.cshtml"
Write(ViewBag.HaviorInfo.FootCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Areas\Backend\Views\Default\Index.cshtml"
Write(Scripts.Render("~/Assets/Backend/Store/Script", "~/Assets/Backend/Linq/Script", "~/Assets/Backend/Nicescroll/Script"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/html\"");

WriteLiteral(" id=\"moduleTpl\"");

WriteLiteral(@">
        <% for(var i=0; i< list.length;i++) { %>
        <div class=""backend-module-item"" data-moduleid=""<%=list[i].ModuleID %>"">
            <a title=""<%=list[i].Remark %>"" <%=(list[i].Url?"" href='""+list[i].Url+""' "":"""") %>>
                <span class=""monk-iconfont <%=list[i].Iconfont %>""></span>
                <label><%=list[i].Name %></label>
            </a>
        </div>
        <% } %>
    </script>
    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        // 禁止iframe中打开\r\n        if (self != top) { top.location = self.locatio" +
"n; }\r\n\r\n        // 判断栏目下面是否有子栏目\r\n        function hasChildren(data, moduleId) {\r" +
"\n            var queryResult = Enumerable.from(data).where(function (x) { return" +
" x.ParentID == moduleId; }).toArray();\r\n            return queryResult.length > " +
"0;\r\n        }\r\n\r\n        // 定义渲染模块栏目方法\r\n        function renderAction(data, pare" +
"ntId) {\r\n            var actionTree = \"\";\r\n\r\n            function core(parentId," +
" level) {\r\n                var queryResult = Enumerable.from(data).where(functio" +
"n (x) { return x.ParentID == parentId; }).orderBy(function (x) { return x.Sort; " +
"}).toArray();\r\n                if (queryResult.length > 0) {\r\n                  " +
"  level++;\r\n                    var spaceHtml = \"\";\r\n                    for (va" +
"r i = 0; i < level - 1; i++) {\r\n                        spaceHtml += \'<span clas" +
"s=\"space\"></span>\';\r\n                    }\r\n\r\n                    actionTree += " +
"\'<ul>\';\r\n                    queryResult.forEach(function (x) {\r\n               " +
"         var hasChild = hasChildren(data, x.ModuleID);\r\n                        " +
"actionTree += \'<li>\';\r\n                        actionTree += \'<div data-url=\"\' +" +
" x.Url + \'\" target=\"backend-iframe\" class=\"backend-menu-action\" data-actionid=\"\'" +
" + x.ModuleID + \'\" title=\"\' + x.Remark + \'\">\';\r\n                        actionTr" +
"ee += spaceHtml + \'<span class=\"monk-iconfont \' + (hasChild ? \' icon-backend-fol" +
"der-close \' : \' icon-backend-file \') + \'  action-icon\"></span><label>\' + x.Name " +
"+ \'</label>\';\r\n                        if (hasChild) {\r\n                        " +
"    actionTree += \'<span class=\"monk-iconfont icon-arrow icon-monk-arrowdown flo" +
"at-right\"></span>\';\r\n                        }\r\n                        actionTr" +
"ee += \'</div>\';\r\n                        core(x.ModuleID, level);\r\n             " +
"           actionTree += \'</li>\';\r\n                    });\r\n                    " +
"actionTree += \'</ul>\';\r\n                }\r\n                level = 0;\r\n         " +
"   }\r\n            core(parentId, 0);\r\n            return actionTree;\r\n        }\r" +
"\n\r\n\r\n        // 模块渲染对象\r\n        var moduleRender = monk.tppl(document.getElement" +
"ById(\"moduleTpl\").innerHTML);\r\n        // 模块客户端缓存Key\r\n        var moduleIdKey = " +
"\"");

            
            #line 97 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                      Write(ViewBag.MemberInfo.Account);

            
            #line default
            #line hidden
WriteLiteral("\" + \"_moduleId\";\r\n        // 功能客户端缓存的key\r\n        var actionidKey = \"");

            
            #line 99 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                      Write(ViewBag.MemberInfo.Account);

            
            #line default
            #line hidden
WriteLiteral("\" + \"_actionId\";\r\n        // 定义渲染模块应用方法\r\n        function renderModule(data) {\r\n " +
"           var queryResult = Enumerable.from(data).where(function (x) { return x" +
".ParentID == \"11111111-1111-1111-1111-111111111111\"; }).orderBy(function (x) { r" +
"eturn x.Sort; }).toArray();\r\n            $(\"#backend-module\").html(moduleRender(" +
"{ list: queryResult }));\r\n\r\n            // 生成功能菜单\r\n            var actionHtml = " +
"\"\";\r\n            queryResult.forEach(function (x) {\r\n                actionHtml " +
"+= \'<div \' + (x.TagAttr ? x.TagAttr : \"  \") + \' class=\"backend-menu-item display" +
"-none\" data-moduleid=\"\' + x.ModuleID + \'\">\';\r\n                actionHtml += \'<h2" +
" class=\"backend-menu-title\">\' + x.Name + \'</h2>\';\r\n                actionHtml +=" +
" \'<div class=\"backe-menu-list\">\';\r\n                // 内层递归循环\r\n                ac" +
"tionHtml += renderAction(data, x.ModuleID);\r\n                actionHtml += \'</di" +
"v>\';\r\n                actionHtml += \'</div>\';\r\n            });\r\n            $(\"#" +
"backend-left-menu\").html(actionHtml);\r\n\r\n            // 美化滚动条\r\n            var n" +
"icescrolls = backend.nicescroll($(\"#backend-module,.backe-menu-list\"));\r\n       " +
"     if (store.get(actionidKey)) {\r\n                $(\".backend-menu-action[data" +
"-actionid=\'\" + store.get(actionidKey) + \"\']\").trigger(\"click\", \"auto\");\r\n       " +
"     }\r\n            // 读取缓存，恢复上一次状态\r\n            if (store.get(moduleIdKey)) {\r\n" +
"                $(\".backend-module-item[data-moduleid=\'\" + store.get(moduleIdKey" +
") + \"\']\").click();\r\n            }\r\n            else {\r\n                $(\".backe" +
"nd-module-item\").eq(0).trigger(\"click\");\r\n            }\r\n        }\r\n\r\n        $(" +
"function () {\r\n            backend.successTip(\"您好，");

            
            #line 133 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                              Write(ViewBag.MemberInfo.Account);

            
            #line default
            #line hidden
WriteLiteral("\");\r\n\r\n            backend.get(\"");

            
            #line 135 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                    Write(Url.Action("Modules","Default"));

            
            #line default
            #line hidden
WriteLiteral(@""", {}, function (data) {
                renderModule(data.data);
            });

            // 点击模块处理
            $(""#backend-module"").on(""click"", "".backend-module-item"", function () {
                var lastModuleid = store.get(moduleIdKey);
                if (lastModuleid) {
                    $("".backend-menu-item[data-moduleid='"" + lastModuleid + ""']"").addClass(""display-none"");
                    $("".backend-module-item[data-moduleid='"" + lastModuleid + ""']"").children(""a"").removeClass(""selected"");
                }
                var that = $(this);
                var moduleid = that.attr(""data-moduleid"");
                $("".backend-menu-item[data-moduleid='"" + moduleid + ""']"").removeClass(""display-none"");
                that.children(""a"").addClass(""selected"");
                store.set(moduleIdKey, moduleid);
            });

            // ################模块显示隐藏切换
            var $container = $(""#backend-container"");
            var $module = $(""#backend-module"");
            var moduleWidth = $module.outerWidth(true);
            var speed = 300;
            var moduleStatusKey = """);

            
            #line 158 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                              Write(ViewBag.MemberInfo.Account);

            
            #line default
            #line hidden
WriteLiteral("\" + \"_moduleStatus\";\r\n            if (store.get(moduleStatusKey) == \"open\") {\r\n  " +
"              $container.animate({\r\n                    left: moduleWidth + \"px\"" +
"\r\n                }, speed);\r\n                $module.animate({\r\n               " +
"     left: 0\r\n                }, speed);\r\n            }\r\n            $(\"#switch-" +
"module\").on({\r\n                click: function () {\r\n                    if (!$m" +
"odule.is(\":animated\") && !$container.is(\":animated\")) {\r\n                       " +
" if (store.get(moduleStatusKey) == \"open\") {\r\n                            $conta" +
"iner.animate({\r\n                                left: 0\r\n                       " +
"     }, speed);\r\n                            $module.animate({\r\n                " +
"                left: -moduleWidth + \"px\"\r\n                            }, speed)" +
";\r\n                            store.set(moduleStatusKey, \"close\");\r\n           " +
"             }\r\n                        else {\r\n                            $con" +
"tainer.animate({\r\n                                left: moduleWidth + \"px\"\r\n    " +
"                        }, speed);\r\n                            $module.animate(" +
"{\r\n                                left: 0\r\n                            }, speed" +
");\r\n                            store.set(moduleStatusKey, \"open\");\r\n           " +
"             }\r\n                    }\r\n                }\r\n            });\r\n     " +
"       // 模块显示隐藏切换################\r\n\r\n\r\n            // 功能菜单处理\r\n\r\n            $(\"" +
"#backend-left\").on(\"click\", \".backend-menu-action\", function (e, data) {\r\n      " +
"          var lastActionid = store.get(actionidKey);\r\n                if (lastAc" +
"tionid) {\r\n                    $(\".backend-menu-action[data-actionid=\'\" + lastAc" +
"tionid + \"\']\").removeClass(\"selected\");\r\n                }\r\n                var " +
"that = $(this);\r\n                var ul = that.siblings(\"ul\");\r\n                " +
"var url = that.attr(\"data-url\");\r\n                var actionid = that.attr(\"data" +
"-actionid\");\r\n                var childrenKey = store.get(actionid + \"_actionidC" +
"hildrenKey\");\r\n                var target = that.attr(\"target\");\r\n              " +
"  that.addClass(\"selected\");\r\n                if (url && url != \"#\" && url != \"n" +
"ull\" && url != \"NULL\") {\r\n                    if (target == \"backend-iframe\") {\r" +
"\n                        document.getElementById(\'backend-iframe\').contentWindow" +
".location.href = url;\r\n                    }\r\n                    else {\r\n      " +
"                  window.location.href = url;\r\n                    }\r\n          " +
"      }\r\n                if (data == \"auto\") {\r\n                    that.parents" +
"(\"ul\").each(function () {\r\n                        var _menuItem = $(this).sibli" +
"ngs(\".backend-menu-action\");\r\n                        _menuItem.children(\".icon-" +
"arrow\").removeClass(\"icon-monk-arrowdown\").addClass(\"icon-monk-arrowup\");\r\n     " +
"                   _menuItem.children(\".action-icon\").removeClass(\"icon-backend-" +
"folder-close\").addClass(\"icon-backend-folder-open\");\r\n                        $(" +
"this).show();\r\n                    });\r\n                }\r\n                if (u" +
"l.length > 0) {\r\n                    if (data != \"auto\") {\r\n                    " +
"    if (ul.is(\":visible\")) {\r\n                            that.children(\".icon-a" +
"rrow\").removeClass(\"icon-monk-arrowup\").addClass(\"icon-monk-arrowdown\");\r\n      " +
"                      that.children(\".action-icon\").removeClass(\"icon-backend-fo" +
"lder-open\").addClass(\"icon-backend-folder-close\");\r\n                            " +
"ul.hide();\r\n                            store.set(actionid + \"_actionidChildrenK" +
"ey\", \"close\");\r\n                        }\r\n                        else {\r\n     " +
"                       that.children(\".icon-arrow\").removeClass(\"icon-monk-arrow" +
"down\").addClass(\"icon-monk-arrowup\");\r\n                            that.children" +
"(\".action-icon\").removeClass(\"icon-backend-folder-close\").addClass(\"icon-backend" +
"-folder-open\");\r\n                            ul.show();\r\n                       " +
"     store.set(actionid + \"_actionidChildrenKey\", \"open\");\r\n                    " +
"    }\r\n                    }\r\n                    else {\r\n                      " +
"  if (childrenKey == \"open\") {\r\n                            that.parent(\"ul\").sh" +
"ow();\r\n                            that.children(\".icon-arrow\").removeClass(\"ico" +
"n-monk-arrowdown\").addClass(\"icon-monk-arrowup\");\r\n                            t" +
"hat.children(\".action-icon\").removeClass(\"icon-backend-folder-close\").addClass(\"" +
"icon-backend-folder-open\");\r\n                            ul.show();\r\n           " +
"             }\r\n                        else {\r\n                            that" +
".children(\".icon-arrow\").removeClass(\"icon-monk-arrowup\").addClass(\"icon-monk-ar" +
"rowdown\");\r\n                            that.children(\".action-icon\").removeClas" +
"s(\"icon-backend-folder-open\").addClass(\"icon-backend-folder-close\");\r\n          " +
"                  ul.hide();\r\n                        }\r\n                    }\r\n" +
"                }\r\n                store.set(actionidKey, actionid);\r\n          " +
"  });\r\n\r\n\r\n            // 退出系统\r\n            $(\"#signout\").on({\r\n                " +
"click: function () {\r\n                    backend.loadTip(\"系统正在注销，请稍后...\")\r\n    " +
"                $.post(\"");

            
            #line 261 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                       Write(Url.Action("Signout", "Default"));

            
            #line default
            #line hidden
WriteLiteral(@""", {}, function (data) {
                        backend.ajaxResultHandle(data, function (data) {
                            if (data.status == ""n"") {
                                backend.errorTip(data.info);
                            }
                            else if (data.status == ""y"") {
                                backend.successTip(data.info, { time: 1000 }, function () {
                                    window.location.href = '");

            
            #line 268 "..\..\Areas\Backend\Views\Default\Index.cshtml"
                                                       Write(Url.Action("Signin", "Default"));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n                                });\r\n                            }\r\n         " +
"               });\r\n                    });\r\n                }\r\n            });\r" +
"\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
