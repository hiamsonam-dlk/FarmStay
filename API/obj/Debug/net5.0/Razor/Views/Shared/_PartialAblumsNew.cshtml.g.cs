#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "451962c0e6323c1727981a3f7a8f5f2e36de5412b72116764d87f3e6f0c75218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialAblumsNew), @"mvc.1.0.view", @"/Views/Shared/_PartialAblumsNew.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialAblumsNew.cshtml", typeof(AspNetCore.Views_Shared__PartialAblumsNew))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"451962c0e6323c1727981a3f7a8f5f2e36de5412b72116764d87f3e6f0c75218", @"/Views/Shared/_PartialAblumsNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialAblumsNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblums>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
  
    var listchild = API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsService.GetListByParrent(Model.Id);
    var father = API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsService.GetItem(Model.Id);
    var fatherImage = API.Areas.Admin.Models.Ablums.AblumsService.GetListByParrent(Model.Id);

#line default
#line hidden
            BeginContext(384, 45, true);
            WriteLiteral("\r\n<li>\r\n    <span><i class=\"far fa-file\"></i>");
            EndContext();
            BeginContext(430, 12, false);
#line 10 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                Write(father.Title);

#line default
#line hidden
            EndContext();
            BeginContext(442, 69, true);
            WriteLiteral("</span>\r\n    <ul>\r\n        <li>\r\n            <div class=\"row mb-1\">\r\n");
            EndContext();
#line 14 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                 foreach (var fi in fatherImage)
                {

#line default
#line hidden
            BeginContext(580, 182, true);
            WriteLiteral("                    <div class=\"col-12 col-md-4 col-lg-3 mb-1\">\r\n                        <div class=\"card\" data-aos=\"fade-up\">\r\n                            <a data-fancybox=\"gallery_");
            EndContext();
            BeginContext(763, 9, false);
#line 18 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                                 Write(father.Id);

#line default
#line hidden
            EndContext();
            BeginContext(772, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 773, "\"", 790, 1);
#line 18 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
WriteAttributeValue("", 780, fi.Images, 780, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 15, true);
            WriteLiteral(" data-caption=\"");
            EndContext();
            BeginContext(807, 8, false);
#line 18 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                                                                             Write(fi.Title);

#line default
#line hidden
            EndContext();
            BeginContext(815, 61, true);
            WriteLiteral("\">\r\n                                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 876, "\"", 935, 3);
            WriteAttributeValue("", 882, "/Home/ResizeImage?url=", 882, 22, true);
#line 19 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
WriteAttributeValue("", 904, fi.Images, 904, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 914, "&width=255&height=150", 914, 21, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 936, "\"", 951, 1);
#line 19 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
WriteAttributeValue("", 942, fi.Title, 942, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(952, 97, true);
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 23 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                }

#line default
#line hidden
            BeginContext(1068, 35, true);
            WriteLiteral("            </div>\r\n        </li>\r\n");
            EndContext();
#line 26 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
         foreach (var child in listchild)
        {
            

#line default
#line hidden
#line 28 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
             if (child.ChildCount > 0)
            {
                

#line default
#line hidden
            BeginContext(1229, 51, false);
#line 30 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
           Write(await Html.PartialAsync("_PartialAblumsNew", child));

#line default
#line hidden
            EndContext();
#line 30 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                                                    
                ;
            }
            else
            {
                var listChildImage = API.Areas.Admin.Models.Ablums.AblumsService.GetListByParrent(child.Id);

#line default
#line hidden
            BeginContext(1459, 75, true);
            WriteLiteral("                <li>\r\n                    <span><i class=\"far fa-file\"></i>");
            EndContext();
            BeginContext(1535, 11, false);
#line 37 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                                Write(child.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 117, true);
            WriteLiteral("</span>\r\n                    <ul>\r\n                        <li>\r\n                            <div class=\"row mb-1\">\r\n");
            EndContext();
#line 41 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                 foreach (var childimage in listChildImage)
                                {


#line default
#line hidden
            BeginContext(1777, 230, true);
            WriteLiteral("                                    <div class=\"col-12 col-md-4 col-lg-3 mb-1\">\r\n                                        <div class=\"card\" data-aos=\"fade-up\">\r\n                                            <a data-fancybox=\"gallery_");
            EndContext();
            BeginContext(2008, 8, false);
#line 46 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                                                 Write(child.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2016, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2017, "\"", 2042, 1);
#line 46 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
WriteAttributeValue("", 2024, childimage.Images, 2024, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2043, 15, true);
            WriteLiteral(" data-caption=\"");
            EndContext();
            BeginContext(2059, 16, false);
#line 46 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                                                                                                    Write(childimage.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2075, 77, true);
            WriteLiteral("\">\r\n                                                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2152, "\"", 2219, 3);
            WriteAttributeValue("", 2158, "/Home/ResizeImage?url=", 2158, 22, true);
#line 47 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
WriteAttributeValue("", 2180, childimage.Images, 2180, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 2198, "&width=255&height=150", 2198, 21, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2220, "\"", 2243, 1);
#line 47 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
WriteAttributeValue("", 2226, childimage.Title, 2226, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2244, 145, true);
            WriteLiteral(">\r\n                                            </a>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 51 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
                                }

#line default
#line hidden
            BeginContext(2424, 143, true);
            WriteLiteral("                            </div>\r\n                        \r\n                        </li>\r\n                    </ul>\r\n                </li>\r\n");
            EndContext();
#line 57 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
            }

#line default
#line hidden
#line 57 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblumsNew.cshtml"
             

        }

#line default
#line hidden
            BeginContext(2595, 20, true);
            WriteLiteral("    </ul>\r\n</li>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblums> Html { get; private set; }
    }
}
#pragma warning restore 1591
