#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f746a0ed07b75183e40027f9d6da40474d8dbc50a489ea9f5aa2e921d113dc7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_newfooter), @"mvc.1.0.view", @"/Views/Shared/newfooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/newfooter.cshtml", typeof(AspNetCore.Views_Shared_newfooter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f746a0ed07b75183e40027f9d6da40474d8dbc50a489ea9f5aa2e921d113dc7d", @"/Views/Shared/newfooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_newfooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
  
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();


#line default
#line hidden
            BeginContext(104, 415, true);
            WriteLiteral(@"<!-- Remove the container if you want to extend the Footer to full width. -->
<div class=""container-fluid p-0"">

    <footer class=""ftco-footer ftco-bg-dark ftco-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-5 col-md-12"">
                    <div class=""ftco-footer-widget "" data-aos=""fade-up"">
                        <h2 class=""ftco-heading-2"">");
            EndContext();
            BeginContext(520, 22, false);
#line 13 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                              Write(ItemConfig.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(542, 34, true);
            WriteLiteral("</h2>\r\n                        <p>");
            EndContext();
            BeginContext(577, 28, false);
#line 14 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                      Write(Html.Raw(@ItemConfig.Footer));

#line default
#line hidden
            EndContext();
            BeginContext(605, 453, true);
            WriteLiteral(@"</p>
                    </div>
                    <hr class=""my-3 d-md-none"" />
                </div>

                <div class=""col-lg-3 col-md-5"">
                    <div class=""ftco-footer-widget "" data-aos=""fade-up"">
                        <h2 class=""ftco-heading-2"">Hỗ trợ</h2>
                        <ul class=""list-unstyled"">
                            <li><a href=""/admin"" class=""d-block"">Đăng nhập hệ thống quản trị</a></li>
");
            EndContext();
            BeginContext(1383, 508, true);
            WriteLiteral(@"                        </ul>
                    </div>
                    <hr class=""my-3 d-md-none"" />
                </div>

                <div class=""col-lg-4 col-md-7"">
                    <div class=""ftco-footer-widget "" data-aos=""fade-up"">
                        <h2 class=""ftco-heading-2"">Địa chỉ</h2>
                        <div class=""block-23 mb-3"">
                            <ul>
                                <li><span class=""icon icon-map-marker""></span><span class=""text"">");
            EndContext();
            BeginContext(1892, 18, false);
#line 37 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                                                                            Write(ItemConfig.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1910, 14, true);
            WriteLiteral("</span></li>\r\n");
            EndContext();
#line 38 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                 if (!string.IsNullOrEmpty(ItemConfig.Phone))
                                {

#line default
#line hidden
            BeginContext(2038, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2080, "\"", 2108, 2);
            WriteAttributeValue("", 2087, "tel:", 2087, 4, true);
#line 40 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
WriteAttributeValue("", 2091, ItemConfig.Phone, 2091, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2109, 57, true);
            WriteLiteral("><span class=\"icon icon-phone\"></span><span class=\"text\">");
            EndContext();
            BeginContext(2167, 16, false);
#line 40 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                                                                                                           Write(ItemConfig.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2183, 18, true);
            WriteLiteral("</span></a></li>\r\n");
            EndContext();
#line 41 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                }

#line default
#line hidden
#line 42 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                 if (!string.IsNullOrEmpty(ItemConfig.Email))
                                {

#line default
#line hidden
            BeginContext(2350, 42, true);
            WriteLiteral("                                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2392, "\"", 2423, 2);
            WriteAttributeValue("", 2399, "mailto:", 2399, 7, true);
#line 44 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
WriteAttributeValue("", 2406, ItemConfig.Email, 2406, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2424, 60, true);
            WriteLiteral("><span class=\"icon icon-envelope\"></span><span class=\"text\">");
            EndContext();
            BeginContext(2485, 16, false);
#line 44 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                                                                                                                 Write(ItemConfig.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2501, 18, true);
            WriteLiteral("</span></a></li>\r\n");
            EndContext();
#line 45 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
                                }

#line default
#line hidden
            BeginContext(2554, 669, true);
            WriteLiteral(@"                            </ul>
                            
                        </div>
                    </div>                    
                </div>
            </div>

            

            <div class=""row"">
                <div class=""col-md-12 text-center"">
                    <hr class=""my-3"" />
                    <section class=""pt-0"">
                        <div class=""row d-flex justify-content-center"">
                            <div class=""col-md-4 justify-content-center text-white social-icon"">
                                <ul class=""ftco-footer-social list-unstyled m-0"">
                                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3223, "\"", 3231, 0);
            EndWriteAttribute();
            BeginContext(3232, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3235, "\"", 3261, 1);
#line 62 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
WriteAttributeValue("", 3242, ItemConfig.Twitter, 3242, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3262, 85, true);
            WriteLiteral("><span class=\"icon-twitter\"></span></a></li>\r\n                                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3347, "\"", 3355, 0);
            EndWriteAttribute();
            BeginContext(3356, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3359, "\"", 3386, 1);
#line 63 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
WriteAttributeValue("", 3366, ItemConfig.Facebook, 3366, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3387, 86, true);
            WriteLiteral("><span class=\"icon-facebook\"></span></a></li>\r\n                                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3473, "\"", 3481, 0);
            EndWriteAttribute();
            BeginContext(3482, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3485, "\"", 3511, 1);
#line 64 "D:\code\NGHIA_TRANG\API\Views\Shared\newfooter.cshtml"
WriteAttributeValue("", 3492, ItemConfig.Youtube, 3492, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3512, 230, true);
            WriteLiteral("><span class=\"icon-youtube\"></span></a></li>\r\n                                </ul>\r\n                            </div>\r\n                            <div class=\"col-md-4 text-md-right p-3 vnpt\">\r\n                                <p");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3742, "\"", 3750, 0);
            EndWriteAttribute();
            BeginContext(3751, 393, true);
            WriteLiteral(@">
                                    Thực hiện bởi <a href=""http://daklak.vnpt.vn/"" target=""_blank"">VNPT Đắk Lắk</a> <img src=""/images/vnpt-logo.png"">
                                </p>
                            </div>
                            <!-- Grid column -->
                        </div>
                    </section>
                    <!-- Section: Copyright -->

");
            EndContext();
            BeginContext(4712, 147, true);
            WriteLiteral("                    <!-- Section: Copyright -->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </footer>\r\n\r\n    <!-- Footer -->\r\n");
            EndContext();
            BeginContext(10131, 55, true);
            WriteLiteral("    <!-- Footer -->\r\n</div>\r\n<!-- End of .container -->");
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
