#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f7ac95b9348caf062d9502723212b77b8a4227d5a3f820cf22d1e702e8c2f428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_AlbumsEN_Index), @"mvc.1.0.view", @"/Areas/EN/Views/AlbumsEN/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/AlbumsEN/Index.cshtml", typeof(AspNetCore.Areas_EN_Views_AlbumsEN_Index))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Areas\EN\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Areas\EN\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f7ac95b9348caf062d9502723212b77b8a4227d5a3f820cf22d1e702e8c2f428", @"/Areas/EN/Views/AlbumsEN/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_AlbumsEN_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
  
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();
    ViewData["Description"] = ItemConfig.SEODescription;
    ViewData["Keywords"] = ItemConfig.SEOKeyword;
    ViewData["Images"] = @Startup.Domain + "/ttudkhcn/images/ogImage3.png?ver=" + DateTime.Now.ToString();
    ViewData["Url"] = @Startup.Domain;

#line default
#line hidden
            BeginContext(429, 1164, true);
            WriteLiteral(@"
<div class=""hero-wrap"" style=""height:50vh; background-position: bottom;"">
    <div class=""container"">
        <div class=""row no-gutters slider-text justify-content-center align-items-center"" style=""height: 50vh"">
            <div class=""col-12 d-flex align-items-end justify-content-center"" data-aos=""fade-up"">


                <div class=""text navigation nlist"">
                    <h2 class=""text-center text-white"">Image gallery</h2>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""navigation nlist"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline "">
                    <li>
                        <a href=""/EN"">Home</a> <i class=""fa fa-angle-right""></i>
                        Image gallery
                        <i class=""fa fa-angle-right""></i>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>


<div cla");
            WriteLiteral("ss=\"container ContentDiv\">\r\n    <div class=\"row my-5\">\r\n\r\n        <div class=\"container-image-gallery\">\r\n            <section id=\"photos\">\r\n");
            EndContext();
#line 46 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
                 for (int i = 0; i < Model.ListItems.Count(); i++)
                {
                    

#line default
#line hidden
#line 48 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
                     if (Model.ListItems[i].ListItemsAlbums != null && Model.ListItems[i].ListItemsAlbums.Count() > 0)
                    {

#line default
#line hidden
            BeginContext(1823, 99, true);
            WriteLiteral("                        <div class=\"card-image\" data-aos=\"fade-up\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1922, "\"", 1997, 5);
            WriteAttributeValue("", 1929, "/EN/albums/", 1929, 11, true);
#line 51 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
WriteAttributeValue("", 1940, Model.ListItems[i].Alias, 1940, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 1967, "-", 1967, 1, true);
#line 51 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
WriteAttributeValue("", 1968, Model.ListItems[i].Id, 1968, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 1992, ".html", 1992, 5, true);
            EndWriteAttribute();
            BeginContext(1998, 75, true);
            WriteLiteral(">\r\n                                <img loading=\"lazy\" class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2073, "\"", 2105, 1);
#line 52 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
WriteAttributeValue("", 2079, Model.ListItems[i].Images, 2079, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2106, "\"", 2135, 1);
#line 52 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
WriteAttributeValue("", 2112, Model.ListItems[i].Ten, 2112, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2136, 181, true);
            WriteLiteral(">\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title text-center\">\r\n                                        <strong>");
            EndContext();
            BeginContext(2318, 22, false);
#line 55 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
                                           Write(Model.ListItems[i].Ten);

#line default
#line hidden
            EndContext();
            BeginContext(2340, 135, true);
            WriteLiteral("</strong>\r\n                                        <br />\r\n                                        <span class=\"badge badge-secondary\">");
            EndContext();
            BeginContext(2476, 42, false);
#line 57 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
                                                                       Write(Model.ListItems[i].ListItemsAlbums.Count());

#line default
#line hidden
            EndContext();
            BeginContext(2518, 167, true);
            WriteLiteral(" image(s)</span>\r\n                                    </h5>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
            EndContext();
#line 62 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
                    }

#line default
#line hidden
#line 62 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\AlbumsEN\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2727, 42, true);
            WriteLiteral("            </section>\r\n        </div>\r\n\r\n");
            EndContext();
            BeginContext(4354, 26, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4397, 8, true);
                WriteLiteral("\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(4408, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
