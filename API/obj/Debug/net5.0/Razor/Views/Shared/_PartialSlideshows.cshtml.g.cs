#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2ee561c4224acf7568c110d59aa710afec96d26320f8270908b64fc5eec13d2f"
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
#line 1 "D:\code\NGHIA_TRANG\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
using API.Areas.Admin.Models.Booking;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 3 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
using reCAPTCHA.AspNetCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2ee561c4224acf7568c110d59aa710afec96d26320f8270908b64fc5eec13d2f", @"/Views/Shared/_PartialSlideshows.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialSlideshows : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
  
    string[] title;
    var img = API.Areas.Admin.Models.Banners.BannersService.GetListByCat(16);
    BookingModel booking = new BookingModel();
    booking.Item = new Booking();

#line default
#line hidden
            BeginContext(387, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
 if (img != null && img.Count() > 0)
{

#line default
#line hidden
            BeginContext(430, 283, true);
            WriteLiteral(@"        <div class=""container-fluid"">
            <div class=""row mb-3"">
                <div class=""col-12 px-0"">

                <div id=""carouselExampleControls"" class=""carousel slide carousel-fade"" data-bs-ride=""carousel"">
                    <div class=""carousel-inner"">
");
            EndContext();
#line 21 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                         for (int i = 0; i < img.Count(); i++)
                        {

#line default
#line hidden
            BeginContext(804, 32, true);
            WriteLiteral("                            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 836, "\"", 883, 2);
            WriteAttributeValue("", 844, "carousel-item", 844, 13, true);
#line 23 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
WriteAttributeValue(" ", 857, i==0?"active":"active", 858, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(884, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(992, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                                 if (img[i].Title != null)
                                {

#line default
#line hidden
            BeginContext(1089, 54, true);
            WriteLiteral("                                <div class=\"hero-wrap\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1143, "\"", 1190, 4);
            WriteAttributeValue("", 1151, "background-image:", 1151, 17, true);
            WriteAttributeValue(" ", 1168, "url(\'", 1169, 6, true);
#line 28 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
WriteAttributeValue("", 1174, img[i].Image, 1174, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1187, "\');", 1187, 3, true);
            EndWriteAttribute();
            BeginContext(1191, 536, true);
            WriteLiteral(@" >
                                    <div class=""overlay""></div>
                                    <div class=""container"">
                                        <div class=""row no-gutters slider-text justify-content-start align-items-center"">
                                            <div class=""col-lg-3 col-md-6 ftco-animate d-md-flex d-none align-items-end"">
                                                <div class=""text"">
                                                        <h1 class=""mb-1 ftco-animate""><span>");
            EndContext();
            BeginContext(1728, 12, false);
#line 34 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                                                                                       Write(img[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1740, 339, true);
            WriteLiteral(@"</span></h1>
                                                </div>
                                            </div>
                                            <div class=""col-lg-5 col""></div>
                                                <div class=""col-lg-4 col-md-6 mt-0 d-flex justify-md-content-end justify-content-center"">
");
            EndContext();
            BeginContext(4839, 188, true);
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                    </div>\r\n");
            EndContext();
#line 69 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                                } else
                                {

#line default
#line hidden
            BeginContext(5102, 58, true);
            WriteLiteral("                                    <div class=\"hero-wrap\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5160, "\"", 5207, 4);
            WriteAttributeValue("", 5168, "background-image:", 5168, 17, true);
            WriteAttributeValue(" ", 5185, "url(\'", 5186, 6, true);
#line 71 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
WriteAttributeValue("", 5191, img[i].Image, 5191, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5204, "\');", 5204, 3, true);
            EndWriteAttribute();
            BeginContext(5208, 542, true);
            WriteLiteral(@">
                                        <div class=""overlay""></div>
                                        <div class=""container"">
                                            <div class=""row no-gutters slider-text justify-content-start align-items-center"">
                                                <div class=""col-lg-4 col-md-6 ftco-animate d-md-flex d-none align-items-end"">
                                                    <div class=""text"">
                                                        <h1 class=""mb-1""><span>");
            EndContext();
            BeginContext(5751, 12, false);
#line 77 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                                                                          Write(img[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(5763, 351, true);
            WriteLiteral(@"</span></h1>
                                                    </div>
                                                </div>
                                                <div class=""col-lg-2 col""></div>
                                                <div class=""col-lg-6 col-md-6 mt-0 d-flex justify-md-content-end justify-content-center"">
");
            EndContext();
            BeginContext(8922, 200, true);
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 112 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                                }

#line default
#line hidden
            BeginContext(9157, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 114 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
                        }

#line default
#line hidden
            BeginContext(9220, 112, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 120 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialSlideshows.cshtml"
}

#line default
#line hidden
            BeginContext(9335, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RecaptchaSettings> RecaptchaSettings { get; private set; }
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
