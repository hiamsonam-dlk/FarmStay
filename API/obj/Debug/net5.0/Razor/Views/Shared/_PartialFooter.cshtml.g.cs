#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialFooter.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e7c5f6a50639d8facfb7f562c080078e1453afb8450907768dc7ef3e2a1832b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialFooter), @"mvc.1.0.view", @"/Views/Shared/_PartialFooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialFooter.cshtml", typeof(AspNetCore.Views_Shared__PartialFooter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e7c5f6a50639d8facfb7f562c080078e1453afb8450907768dc7ef3e2a1832b0", @"/Views/Shared/_PartialFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialFooter.cshtml"
  
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();


#line default
#line hidden
            BeginContext(104, 251, true);
            WriteLiteral("<div class=\"Footer_wr\">\r\n    <footer>\r\n        <!--copyright -->\r\n        <div class=\"copyright\">\r\n\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-8 col-sm-12\">\r\n                        ");
            EndContext();
            BeginContext(356, 28, false);
#line 13 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialFooter.cshtml"
                   Write(Html.Raw(@ItemConfig.Footer));

#line default
#line hidden
            EndContext();
            BeginContext(384, 544, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col-md-4 col-sm-12 text-md-right mt-sm-4 mt-md-0 vnpt"">

                        <p>
                            Thực hiện bởi  <a href=""http://daklak.vnpt.vn/"" target=""_blank"">VNPT Đắk Lắk</a>
                        </p>
                        <p>
                            <img src=""/images/vnpt-logo.png"" style=""margin-top:5px"">
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
</div>");
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
