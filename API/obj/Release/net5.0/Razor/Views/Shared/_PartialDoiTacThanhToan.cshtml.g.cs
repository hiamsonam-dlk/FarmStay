#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5cf3dddff169489f1c4feea2b31f3524b832058ddf552d5985b936089b955191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialDoiTacThanhToan), @"mvc.1.0.view", @"/Views/Shared/_PartialDoiTacThanhToan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialDoiTacThanhToan.cshtml", typeof(AspNetCore.Views_Shared__PartialDoiTacThanhToan))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5cf3dddff169489f1c4feea2b31f3524b832058ddf552d5985b936089b955191", @"/Views/Shared/_PartialDoiTacThanhToan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialDoiTacThanhToan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
  
    var listBannerPo7 = API.Areas.Admin.Models.Banners.BannersService.GetListByCat(7);
    var data = API.Areas.Admin.Models.BannersCategories.BannersCategoriesService.GetItem(7);
    var ten = data.Title;

#line default
#line hidden
            BeginContext(216, 238, true);
            WriteLiteral("\r\n<div class=\"col-12\">\r\n\r\n    <div class=\"category-list\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"cat-item lyo1\">\r\n                    <div class=\"header\">\r\n                        <h4>");
            EndContext();
            BeginContext(455, 3, false);
#line 14 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
                       Write(ten);

#line default
#line hidden
            EndContext();
            BeginContext(458, 272, true);
            WriteLiteral(@"</h4>
                    </div>
                    <div class=""body"">

                        <div class=""row justify-content-center"">
                            <div class=""col-12"">
                                <ul id=""Features-Slide-DTTT"" class=""gallery"">
");
            EndContext();
#line 21 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
                                     foreach (var item in listBannerPo7)
                                    {

#line default
#line hidden
            BeginContext(843, 105, true);
            WriteLiteral("                                        <li class=\"px-5\">\r\n                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 948, "\"", 965, 1);
#line 24 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
WriteAttributeValue("", 955, item.Link, 955, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(966, 55, true);
            WriteLiteral(">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1021, "\"", 1038, 1);
#line 25 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
WriteAttributeValue("", 1027, item.Image, 1027, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1039, "\"", 1056, 1);
#line 25 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
WriteAttributeValue("", 1045, item.Title, 1045, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1057, 100, true);
            WriteLiteral(">\r\n                                            </a>\r\n                                        </li>\r\n");
            EndContext();
#line 28 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialDoiTacThanhToan.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1196, 113, true);
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2303, 990, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>

</div>


<script>
    $('#Features-Slide-DTTT').lightSlider({
        gallery: true,
        item: 3,
        slideMargin: 0,
        speed: 800,
        pause: 4000,
        auto: true,
        pager: false,
        controls: true,
        loop: true,
        responsive: [
            {
                breakpoint: 1170,
                settings: {
                    item: 3,
                    slideMove: 1,
                    slideMargin: 6,
                }
            },
            {
                breakpoint: 980,
                settings: {
                    item: 2,
                    slideMove: 1
                }
            },
            {
                breakpoint: 460,
                settings: {
                    item: 1,
                    slideMove: 1
                }
            }
        ]
    });
</script>");
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
