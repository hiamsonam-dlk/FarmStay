#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "937cd1f6ebb77c19591050f29a987e8fedafb57cd6cdf333717eabc179c29ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialSEO), @"mvc.1.0.view", @"/Views/Shared/_PartialSEO.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialSEO.cshtml", typeof(AspNetCore.Views_Shared__PartialSEO))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"937cd1f6ebb77c19591050f29a987e8fedafb57cd6cdf333717eabc179c29ab5", @"/Views/Shared/_PartialSEO.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialSEO : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 24, true);
            WriteLiteral("<meta name=\"description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 24, "\"", 58, 1);
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml"
WriteAttributeValue("", 34, ViewData["Description"], 34, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(59, 26, true);
            WriteLiteral(" />\r\n<meta name=\"keywords\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 85, "\"", 116, 1);
#line 2 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml"
WriteAttributeValue("", 95, ViewData["Keywords"], 95, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(117, 98, true);
            WriteLiteral(" />\r\n<meta http-equiv=\"content-type\" content=\"text/html;charset=UTF-8\" />\r\n<meta property=\"og:url\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 215, "\"", 241, 1);
#line 4 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml"
WriteAttributeValue("", 225, ViewData["Url"], 225, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(242, 77, true);
            WriteLiteral(" />\r\n<meta property=\"og:type\" content=\"article\" />\r\n<meta property=\"og:title\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 319, "\"", 347, 1);
#line 6 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml"
WriteAttributeValue("", 329, ViewData["Title"], 329, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(348, 36, true);
            WriteLiteral(" />\r\n<meta property=\"og:description\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 384, "\"", 418, 1);
#line 7 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml"
WriteAttributeValue("", 394, ViewData["Description"], 394, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 77, true);
            WriteLiteral(" />\r\n<meta property=\"og:locale\" content=\"vi-vn\" />\r\n<meta property=\"og:image\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 496, "\"", 525, 1);
#line 9 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSEO.cshtml"
WriteAttributeValue("", 506, ViewData["Images"], 506, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(526, 69, true);
            WriteLiteral(" />\r\n<meta property=\"og:image:alt\" content=\"Taxi điện Đắk Lắk\" />\r\n\r\n");
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