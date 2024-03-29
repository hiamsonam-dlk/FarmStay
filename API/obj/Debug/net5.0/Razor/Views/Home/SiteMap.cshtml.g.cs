#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c9adfdeb5c5a5667851699fc24903b820b68f705c002f828394dfce858d95413"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SiteMap), @"mvc.1.0.view", @"/Views/Home/SiteMap.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SiteMap.cshtml", typeof(AspNetCore.Views_Home_SiteMap))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#line 1 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
using API.Areas.Admin.Models.Menus;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c9adfdeb5c5a5667851699fc24903b820b68f705c002f828394dfce858d95413", @"/Views/Home/SiteMap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SiteMap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
  
    ViewData["Title"] = "SiteMap";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();
    ViewData["Description"] = ItemConfig.SEODescription;
    ViewData["Keywords"] = ItemConfig.SEOKeyword;
    ViewData["Images"] = @Startup.Domain + "/ttudkhcn/images/ogImage3.png?ver=" + DateTime.Now.ToString();
    ViewData["Url"] = @Startup.Domain;


#line default
#line hidden
            BeginContext(482, 1005, true);
            WriteLiteral(@"
<div class=""navigation nlist"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  "">
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

        <div class=""col-12"">

            <div class=""tree "">
                <ul>
                    <li>
                        <span>
                            <a style=""color:#000; text-decoration:none;"" data-toggle=""collapse"" href=""#Web"" aria-expanded=""true"" aria-controls=""Web"">
                                <i class=""collapsed""><i class=""fas fa-folder""></i></i>
                                <i class=""expanded""><i class=""far fa-folder-open""></i></i> ");
            EndContext();
            BeginContext(1488, 22, false);
#line 42 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                                                                      Write(ItemConfig.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 133, true);
            WriteLiteral("\r\n                            </a>\r\n                        </span>\r\n\r\n                        <div id=\"Web\" class=\"collapse show\">\r\n");
            EndContext();
#line 47 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                              
                                var listMenu = MenusService.GetListByParrent(0, 1, 1, "VI");
                                var listLeft = MenusService.GetListByParrent(0, 1, 2, "VI");
                                listMenu.AddRange(listLeft);
                            

#line default
#line hidden
            BeginContext(1956, 36, true);
            WriteLiteral("\r\n                            <ul>\r\n");
            EndContext();
#line 54 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                 foreach (var item in listMenu)
                                {


                                    

#line default
#line hidden
#line 58 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                     if (item.ChildCount > 0)
                                    {

#line default
#line hidden
            BeginContext(2198, 218, true);
            WriteLiteral("                                        <li>\r\n                                            <span>\r\n                                                <a style=\"color:#333; text-decoration:none;\" data-toggle=\"collapse show\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2416, "\"", 2438, 2);
            WriteAttributeValue("", 2423, "#page", 2423, 5, true);
#line 62 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
WriteAttributeValue("", 2428, item.Id, 2428, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2439, 266, true);
            WriteLiteral(@" aria-expanded=""false"" aria-controls=""page1"">
                                                    <i class=""collapsed""><i class=""fas fa-folder""></i></i>
                                                    <i class=""expanded""><i class=""far fa-folder-open""></i></i> ");
            EndContext();
            BeginContext(2706, 10, false);
#line 64 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                                                                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2716, 109, true);
            WriteLiteral("\r\n                                                </a>\r\n                                            </span>\r\n");
            EndContext();
#line 67 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                              
                                                var listchild = MenusService.GetListByParrent(item.Id, 1, 0, "VI");
                                            

#line default
#line hidden
            BeginContext(3037, 102, true);
            WriteLiteral("                                            <ul>\r\n                                                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3139, "\"", 3158, 2);
            WriteAttributeValue("", 3144, "page", 3144, 4, true);
#line 71 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
WriteAttributeValue("", 3148, item.Id, 3148, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3159, 25, true);
            WriteLiteral(" class=\"collapse show\">\r\n");
            EndContext();
#line 72 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                                     foreach (var child in listchild)
                                                    {

#line default
#line hidden
            BeginContext(3326, 95, true);
            WriteLiteral("                                                        <li><span><i class=\"far fa-file\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3421, "\"", 3439, 1);
#line 74 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
WriteAttributeValue("", 3428, child.Link, 3428, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3440, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(3443, 11, false);
#line 74 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                                                                                               Write(child.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3454, 18, true);
            WriteLiteral("</a></span></li>\r\n");
            EndContext();
#line 75 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(3527, 154, true);
            WriteLiteral("                                                </div>\r\n                                            </ul>\r\n                                        </li>\r\n");
            EndContext();
#line 79 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3801, 79, true);
            WriteLiteral("                                        <li><span><i class=\"far fa-file\"></i><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3880, "\"", 3897, 1);
#line 82 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
WriteAttributeValue("", 3887, item.Link, 3887, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3898, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(3901, 10, false);
#line 82 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                                                                              Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3911, 18, true);
            WriteLiteral("</a></span></li>\r\n");
            EndContext();
#line 83 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                    }

#line default
#line hidden
#line 83 "D:\code\NGHIA_TRANG\API\Views\Home\SiteMap.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(4003, 187, true);
            WriteLiteral("\r\n\r\n\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
