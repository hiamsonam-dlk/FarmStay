#pragma checksum "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c806ed948fdc6e3269e5039d7a98b97c65b294b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialSlideshows), @"mvc.1.0.view", @"/Views/Shared/_PartialSlideshows.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialSlideshows.cshtml", typeof(AspNetCore.Views_Shared__PartialSlideshows))]
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
#line 1 "D:\work\CTY_NUOC\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#line 1 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c806ed948fdc6e3269e5039d7a98b97c65b294b", @"/Views/Shared/_PartialSlideshows.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialSlideshows : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
  
    var ListItems = API.Areas.Admin.Models.Banners.BannersService.GetListByCat(1);

#line default
#line hidden
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
 if (ListItems != null && ListItems.Count() > 0)
{
    

#line default
#line hidden
            BeginContext(186, 95, true);
            WriteLiteral("    <div id=\"slide\">\r\n        <ul id=\"image-gallery\" class=\"gallery list-unstyled cS-hidden\">\r\n");
            EndContext();
#line 11 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
             for (int i = 0; i < ListItems.Count(); i++)
            {

#line default
#line hidden
            BeginContext(354, 44, true);
            WriteLiteral("                <li>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 398, "\"", 423, 1);
#line 14 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
WriteAttributeValue("", 405, ListItems[i].Link, 405, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(424, 31, true);
            WriteLiteral(">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 455, "\"", 480, 1);
#line 15 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
WriteAttributeValue("", 461, ListItems[i].Image, 461, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", "  alt=\"", 481, "\"", 507, 1);
#line 15 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
WriteAttributeValue("", 488, ListItems[i].Title, 488, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(508, 52, true);
            WriteLiteral(">\r\n                    </a>\r\n                </li>\r\n");
            EndContext();
#line 18 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
            }

#line default
#line hidden
            BeginContext(575, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 21 "D:\work\CTY_NUOC\API\Views\Shared\_PartialSlideshows.cshtml"
}

#line default
#line hidden
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
