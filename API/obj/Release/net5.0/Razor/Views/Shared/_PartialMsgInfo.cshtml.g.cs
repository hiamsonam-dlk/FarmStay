#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5c26d140912fa53bbd5586c285253c9d36f37b84e37023e6f1a2246011b8a3ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialMsgInfo), @"mvc.1.0.view", @"/Views/Shared/_PartialMsgInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialMsgInfo.cshtml", typeof(AspNetCore.Views_Shared__PartialMsgInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5c26d140912fa53bbd5586c285253c9d36f37b84e37023e6f1a2246011b8a3ce", @"/Views/Shared/_PartialMsgInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialMsgInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml"
 if (TempData["MessageSuccess"] != null)
{

#line default
#line hidden
            BeginContext(45, 88, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(134, 26, false);
#line 4 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml"
   Write(TempData["MessageSuccess"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 172, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
            EndContext();
#line 9 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml"
}

#line default
#line hidden
            BeginContext(335, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml"
 if (TempData["MessageError"] != null)
{

#line default
#line hidden
            BeginContext(380, 51, true);
            WriteLiteral("    <div class=\"alert alert-danger mb-3\">\r\n        ");
            EndContext();
            BeginContext(432, 24, false);
#line 14 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml"
   Write(TempData["MessageError"]);

#line default
#line hidden
            EndContext();
            BeginContext(456, 172, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
            EndContext();
#line 19 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMsgInfo.cshtml"
}

#line default
#line hidden
            BeginContext(631, 2, true);
            WriteLiteral("\r\n");
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