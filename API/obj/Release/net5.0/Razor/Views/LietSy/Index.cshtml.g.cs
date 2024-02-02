#pragma checksum "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c906ab55094b881d6589e35988e3c26835effe5d49cbb8a069e05012ad44fb87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LietSy_Index), @"mvc.1.0.view", @"/Views/LietSy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LietSy/Index.cshtml", typeof(AspNetCore.Views_LietSy_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c906ab55094b881d6589e35988e3c26835effe5d49cbb8a069e05012ad44fb87", @"/Views/LietSy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_LietSy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.DMTinhThanh.DMTinhThanhModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
  
    ViewData["Title"] = "DANH SÁCH LIỆT SỸ NGÀNH GIAO BƯU, THÔNG TIN LIÊN LẠC TÂY NGUYÊN";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();
    ViewData["Description"] = ItemConfig.SEODescription;
    ViewData["Keywords"] = ItemConfig.SEOKeyword;
    ViewData["Images"] = @Startup.Domain + "/ttudkhcn/images/ogImage3.png?ver=" + DateTime.Now.ToString();
    ViewData["Url"] = @Startup.Domain;

#line default
#line hidden
            BeginContext(600, 560, true);
            WriteLiteral(@"
<div class=""danh-sach-liet-sy hero-wrap"" style=""height:75vh; background-position: bottom;"">
    <div class=""container"">
        <div class=""row no-gutters slider-text justify-content-center align-items-center"" style=""height: 75vh"">
            <div class=""col-12 d-flex justify-content-center"" data-aos=""fade-up"">
        <div class=""text navigation nlist"">
                    <h2 class=""text-center text-white"">DANH SÁCH LIỆT SỸ NGÀNH GIAO BƯU, THÔNG TIN LIÊN LẠC TÂY NGUYÊN</h2>
        </div>
        </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(1771, 248, true);
            WriteLiteral("\r\n<div class=\"danh-sach-liet-sy-bg\">\r\n    <div class=\"container\">\r\n        <div class=\"row no-gutters align-items-center\" data-aos=\"fade-up\">\r\n            <ul class=\"nav nav-pills my-3 d-flex justify-content-center\" id=\"pills-tab\" role=\"tablist\">\r\n");
            EndContext();
#line 49 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                 for (int i = 0; i < Model.ListItems.Count(); i++)
                {
                    

#line default
#line hidden
#line 51 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                     if (Model.ListItems != null && Model.ListItems.Count() > 0)
                    {

#line default
#line hidden
            BeginContext(2211, 102, true);
            WriteLiteral("                        <li class=\"nav-item\" role=\"presentation\">\r\n                            <button");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2313, "\"", 2349, 2);
            WriteAttributeValue("", 2321, "nav-link", 2321, 8, true);
#line 54 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue(" ", 2329, i==0?"active":"", 2330, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2350, "\"", 2367, 3);
            WriteAttributeValue("", 2355, "pills-", 2355, 6, true);
#line 54 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue("", 2361, i, 2361, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 2363, "-tab", 2363, 4, true);
            EndWriteAttribute();
            BeginContext(2368, 46, true);
            WriteLiteral(" data-bs-toggle=\"pill\" data-bs-target=\"#pills-");
            EndContext();
            BeginContext(2415, 1, false);
#line 54 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2416, 26, true);
            WriteLiteral("\" type=\"button\" role=\"tab\"");
            EndContext();
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 2442, "\"", 2466, 2);
            WriteAttributeValue("", 2458, "pills-", 2458, 6, true);
#line 54 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue("", 2464, i, 2464, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("aria-selected", " aria-selected=\"", 2467, "\"", 2500, 1);
#line 54 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue("", 2483, i==0?"true":"", 2483, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2501, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2503, 22, false);
#line 54 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                                                                                                                                                                                           Write(Model.ListItems[i].Ten);

#line default
#line hidden
            EndContext();
            BeginContext(2525, 42, true);
            WriteLiteral("</button>\r\n                        </li>\r\n");
            EndContext();
#line 56 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                    }

#line default
#line hidden
#line 56 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2609, 146, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n\r\n\r\n        <div class=\"row\">\r\n            <div class=\"tab-content\" id=\"pills-tabContent\" data-aos=\"fade-up\">\r\n");
            EndContext();
#line 64 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                 for (int i = 0; i < Model.ListItems.Count(); i++)
                {
                    

#line default
#line hidden
#line 66 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                     if (Model.ListItems[i].ListLietSy.Count() > 1)
                    {


#line default
#line hidden
            BeginContext(2936, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2964, "\"", 3010, 3);
            WriteAttributeValue("", 2972, "tab-pane", 2972, 8, true);
            WriteAttributeValue(" ", 2980, "fade", 2981, 5, true);
#line 69 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue(" ", 2985, i==0?"show active":"", 2986, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3011, "\"", 3024, 2);
            WriteAttributeValue("", 3016, "pills-", 3016, 6, true);
#line 69 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue("", 3022, i, 3022, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3025, 16, true);
            WriteLiteral(" role=\"tabpanel\"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3041, "\"", 3071, 3);
            WriteAttributeValue("", 3059, "pills-", 3059, 6, true);
#line 69 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
WriteAttributeValue("", 3065, i, 3065, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3067, "-tab", 3067, 4, true);
            EndWriteAttribute();
            BeginContext(3072, 744, true);
            WriteLiteral(@" tabindex=""0"">
                            <table class=""table table-bordered border-primary table-hover"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">STT</th>
                                        <th scope=""col"">Tên liệt sỹ</th>
                                        <th scope=""col"">Năm sinh</th>
                                        <th scope=""col"">Quê quán</th>
                                        <th scope=""col"">Chức vụ</th>
                                        <th scope=""col"">Năm hy sinh</th>
                                    </tr>
                                </thead>
                                <tbody>
");
            EndContext();
#line 82 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                     if (Model.ListItems[i].ListLietSy.Count() > 1)
                                    {

                                        

#line default
#line hidden
#line 85 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                         for (int j = 0; j < Model.ListItems[i].ListLietSy.Count(); j++)
                                        {

#line default
#line hidden
            BeginContext(4091, 122, true);
            WriteLiteral("                                            <tr>\r\n                                                <td class=\"text-center\">");
            EndContext();
            BeginContext(4215, 5, false);
#line 88 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                                    Write(j + 1);

#line default
#line hidden
            EndContext();
            BeginContext(4221, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4282, 37, false);
#line 89 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                Write(Model.ListItems[i].ListLietSy[j].Name);

#line default
#line hidden
            EndContext();
            BeginContext(4320, 79, true);
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
            EndContext();
            BeginContext(4401, 40, false);
#line 90 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                                    Write(Model.ListItems[i].ListLietSy[j].NamSinh);

#line default
#line hidden
            EndContext();
            BeginContext(4442, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4503, 40, false);
#line 91 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                Write(Model.ListItems[i].ListLietSy[j].QueQuan);

#line default
#line hidden
            EndContext();
            BeginContext(4544, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4605, 39, false);
#line 92 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                Write(Model.ListItems[i].ListLietSy[j].ChucVu);

#line default
#line hidden
            EndContext();
            BeginContext(4645, 79, true);
            WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
            EndContext();
            BeginContext(4726, 39, false);
#line 93 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                                                    Write(Model.ListItems[i].ListLietSy[j].NamMat);

#line default
#line hidden
            EndContext();
            BeginContext(4766, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 95 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                        }

#line default
#line hidden
#line 95 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(4906, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 100 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                    }

#line default
#line hidden
#line 100 "D:\code\NGHIA_TRANG\API\Views\LietSy\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(5060, 64, true);
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.DMTinhThanh.DMTinhThanhModel> Html { get; private set; }
    }
}
#pragma warning restore 1591