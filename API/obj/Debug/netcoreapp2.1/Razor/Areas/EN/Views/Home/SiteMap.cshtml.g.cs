#pragma checksum "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91b325d6521d736a642e32d165cffbf4f7227bcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_Home_SiteMap), @"mvc.1.0.view", @"/Areas/EN/Views/Home/SiteMap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/Home/SiteMap.cshtml", typeof(AspNetCore.Areas_EN_Views_Home_SiteMap))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\work\CTY_NUOC\API\Areas\EN\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\EN\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91b325d6521d736a642e32d165cffbf4f7227bcc", @"/Areas/EN/Views/Home/SiteMap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_Home_SiteMap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
  
    ViewData["Title"] = "SiteMap";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<API.Areas.Admin.Models.Menus.Menus> ListItems = API.Areas.Admin.Models.Menus.MenusService.GetList();

#line default
#line hidden
            BeginContext(203, 562, true);
            WriteLiteral(@"
<div class=""navigation"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  nlist"">
                    <li>
                        <a href=""/"">Trang chủ</a>
                        <i class=""fa fa-angle-right""></i>
                        Sơ đồ website

                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>


<div class=""container"">
    <div class=""row PageDetail PageDetail"">
        <div class=""col-md-12"">

");
            EndContext();
#line 30 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
             if (ListItems != null && ListItems.Count() > 0)
            {

#line default
#line hidden
            BeginContext(842, 50, true);
            WriteLiteral("            <ul class=\"sitemap\">\r\n              \r\n");
            EndContext();
#line 34 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
                         for (int i = 0; i < ListItems.Count(); i++)
                        {

#line default
#line hidden
            BeginContext(989, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1048, 1);
#line 36 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
WriteAttributeValue("", 1030, ListItems[i].Link, 1030, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1049, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1051, 18, false);
#line 36 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
                                                        Write(ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 37 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
                        }

#line default
#line hidden
            BeginContext(1107, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 39 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\SiteMap.cshtml"
            }

#line default
#line hidden
            BeginContext(1141, 49, true);
            WriteLiteral("\r\n        </div>\r\n\r\n     \r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
