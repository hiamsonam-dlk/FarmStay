#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f948e0b3b1fe44d39ed0f43f9d675fbe9072d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__PartialMsgInfoAdmin), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_PartialMsgInfoAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_PartialMsgInfoAdmin.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__PartialMsgInfoAdmin))]
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
#line 1 "D:\work\CTY_NUOC\API\Areas\Admin\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f948e0b3b1fe44d39ed0f43f9d675fbe9072d1", @"/Areas/Admin/Views/Shared/_PartialMsgInfoAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__PartialMsgInfoAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml"
 if (TempData["MessageSuccess"] != null)
{

#line default
#line hidden
            BeginContext(45, 88, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(134, 26, false);
#line 4 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml"
   Write(TempData["MessageSuccess"]);

#line default
#line hidden
            EndContext();
            BeginContext(160, 172, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
            EndContext();
#line 9 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml"
}

#line default
#line hidden
            BeginContext(335, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml"
 if (TempData["MessageError"] != null)
{

#line default
#line hidden
            BeginContext(380, 87, true);
            WriteLiteral("    <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(468, 24, false);
#line 14 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml"
   Write(TempData["MessageError"]);

#line default
#line hidden
            EndContext();
            BeginContext(492, 175, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>   \r\n");
            EndContext();
#line 19 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Shared\_PartialMsgInfoAdmin.cshtml"
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
