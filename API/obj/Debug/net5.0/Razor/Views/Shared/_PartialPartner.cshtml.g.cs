#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "edf99d3e43b79680701d51a96de6d3e0b9e483ebdc9ed9acbbfad67e7134d923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialPartner), @"mvc.1.0.view", @"/Views/Shared/_PartialPartner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialPartner.cshtml", typeof(AspNetCore.Views_Shared__PartialPartner))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"edf99d3e43b79680701d51a96de6d3e0b9e483ebdc9ed9acbbfad67e7134d923", @"/Views/Shared/_PartialPartner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialPartner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
   
    List<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblums> ListItems = API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsService.GetListFeatured();

#line default
#line hidden
            BeginContext(171, 378, true);
            WriteLiteral(@"<!--section id=""block-nopadding"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""icon-lien-ket-dao-tao"" ></div>
            </div>
        </div>
    </div>
</!--section-->

<section id=""block-partner"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
");
            EndContext();
#line 18 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
                 if (ListItems != null && ListItems.Count() > 0) { 

#line default
#line hidden
            BeginContext(618, 68, true);
            WriteLiteral("                <div class=\"owl-carousel owl-theme block-partner\">\r\n");
            EndContext();
#line 20 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
                     for (int i = 0; i < ListItems.Count(); i++)
                    {

#line default
#line hidden
            BeginContext(775, 74, true);
            WriteLiteral("                        <div class=\"item\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 849, "\"", 908, 3);
            WriteAttributeValue("", 856, "/Albums.html#prettyPhoto[gallery_", 856, 33, true);
#line 23 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
WriteAttributeValue("", 889, ListItems[i].Id, 889, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 905, "]/0", 905, 3, true);
            EndWriteAttribute();
            BeginContext(909, 62, true);
            WriteLiteral(">\r\n                                <img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 971, "\"", 997, 1);
#line 24 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
WriteAttributeValue("", 977, ListItems[i].Images, 977, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 998, "\"", 1025, 1);
#line 24 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
WriteAttributeValue("", 1006, ListItems[i].Title, 1006, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1026, 71, true);
            WriteLiteral(" />\r\n                            </a>\r\n                        </div>\r\n");
            EndContext();
#line 27 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
                    }

#line default
#line hidden
            BeginContext(1120, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 29 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialPartner.cshtml"
                }

#line default
#line hidden
            BeginContext(1163, 62, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
