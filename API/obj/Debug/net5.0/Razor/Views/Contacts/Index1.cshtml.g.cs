#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Contacts\Index1.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6fb3720cc842c8c0eca917f21941a5b34434ca227dafab60e6d7f009f191eb8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index1), @"mvc.1.0.view", @"/Views/Contacts/Index1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/Index1.cshtml", typeof(AspNetCore.Views_Contacts_Index1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6fb3720cc842c8c0eca917f21941a5b34434ca227dafab60e6d7f009f191eb8e", @"/Views/Contacts/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\code\NGHIA_TRANG\API\Views\Contacts\Index1.cshtml"
  
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();

#line default
#line hidden
            BeginContext(102, 494, true);
            WriteLiteral(@"
<div class=""hero-wrap"">
    <div class=""container full-height"">
        <div class=""row no-gutters slider-text justify-content-center align-items-center"">
            <div class=""col-12 d-flex justify-content-center"" data-aos=""fade-up"">
                <div class=""text navigation nlist"">
                    <h2 class=""text-center text-white"">Đài tưởng niệm các liệt sỹ Giao bưu, thông tin liên lạc Tây Nguyên</h2>
                <br />
                    <h4 class=""text-center""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 596, "\"", 627, 2);
            WriteAttributeValue("", 603, "mailto:", 603, 7, true);
#line 12 "D:\code\NGHIA_TRANG\API\Views\Contacts\Index1.cshtml"
WriteAttributeValue("", 610, ItemConfig.Email, 610, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(628, 57, true);
            WriteLiteral(" class=\"text-white\">Mọi tư liệu xin gửi về ban biên tập: ");
            EndContext();
            BeginContext(686, 16, false);
#line 12 "D:\code\NGHIA_TRANG\API\Views\Contacts\Index1.cshtml"
                                                                                                                                  Write(ItemConfig.Email);

#line default
#line hidden
            EndContext();
            BeginContext(702, 89, true);
            WriteLiteral("</a></h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
