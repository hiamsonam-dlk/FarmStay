#pragma checksum "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0056fca708b5960c057feac73448134bf24ce89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_Shared__PartialLeftCol), @"mvc.1.0.view", @"/Areas/EN/Views/Shared/_PartialLeftCol.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/Shared/_PartialLeftCol.cshtml", typeof(AspNetCore.Areas_EN_Views_Shared__PartialLeftCol))]
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
#line 1 "D:\work\CTY_NUOC\API\Areas\EN\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\EN\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
using API.Areas.Admin.Models.Articles;

#line default
#line hidden
#line 3 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
using API.Areas.Admin.Models.CategoriesArticles;

#line default
#line hidden
#line 4 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
using API.Areas.Admin.Models.Documents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0056fca708b5960c057feac73448134bf24ce89", @"/Areas/EN/Views/Shared/_PartialLeftCol.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_Shared__PartialLeftCol : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialLeftMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(133, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
  
    var listhot = API.Areas.Admin.Models.Articles.ArticlesService.GetListHot(1, 8);
    List<SelectListItem> listLink = API.Areas.Admin.Models.Banners.BannersService.GetListItemsByCat(2,1,"EN");
    var listBannerPo6 = API.Areas.Admin.Models.Banners.BannersService.GetListByCat(6,1,"EN");

#line default
#line hidden
            BeginContext(434, 20, true);
            WriteLiteral("\r\n<!--Left Menu-->\r\n");
            EndContext();
            BeginContext(454, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0056fca708b5960c057feac73448134bf24ce894678", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(489, 69, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"xsClone\">\r\n\r\n    <!--Văn bản chỉ đạo điều hành-->\r\n");
            EndContext();
#line 19 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
      
        SearchDocuments vbdto = new SearchDocuments();
        vbdto.ItemsPerPage = 5;
        var listVB = DocumentsService.GetListPagination(vbdto, "");
    

#line default
#line hidden
            BeginContext(731, 203, true);
            WriteLiteral("    <div class=\"box\">\r\n        <div class=\"header\">\r\n            <a href=\"#\">\r\n                New legislation\r\n            </a>\r\n        </div>\r\n        <div class=\"body vbcd-box\">\r\n            <ul>\r\n\r\n");
            EndContext();
#line 33 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
                 for (int m = 0; m < listVB.Count(); m++)
                {

#line default
#line hidden
            BeginContext(1012, 52, true);
            WriteLiteral("                    <li>\r\n\r\n                        ");
            EndContext();
            BeginContext(1065, 19, false);
#line 37 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
                   Write(listVB[m].Introtext);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 39 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
                         if (!string.IsNullOrEmpty(listVB[m].Link))
                        {

#line default
#line hidden
            BeginContext(1184, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1214, "\"", 1236, 1);
#line 41 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
WriteAttributeValue("", 1221, listVB[m].Link, 1221, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1237, 107, true);
            WriteLiteral(" target=\"_blank\"> <i class=\"fa fa-download\" style=\"margin-right:4px; margin-left:10px;\"></i> Download</a>\r\n");
            EndContext();
#line 42 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
                        }

#line default
#line hidden
            BeginContext(1371, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 45 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
                }

#line default
#line hidden
            BeginContext(1419, 68, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n\r\n    <!--Banner-->\r\n");
            EndContext();
#line 51 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
     foreach (var item in listBannerPo6)
    {

#line default
#line hidden
            BeginContext(1536, 48, true);
            WriteLiteral("        <div class=\"BannerItem\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1601, 1);
#line 54 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
WriteAttributeValue("", 1591, item.Link, 1591, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 1602, "\"", 1623, 1);
#line 54 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
WriteAttributeValue("", 1611, item.Target, 1611, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1624, 23, true);
            WriteLiteral(">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1647, "\"", 1664, 1);
#line 55 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
WriteAttributeValue("", 1653, item.Image, 1653, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1665, "\"", 1682, 1);
#line 55 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
WriteAttributeValue("", 1671, item.Title, 1671, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1683, 39, true);
            WriteLiteral(" />\r\n            </a>\r\n        </div>\r\n");
            EndContext();
#line 58 "D:\work\CTY_NUOC\API\Areas\EN\Views\Shared\_PartialLeftCol.cshtml"
    }

#line default
#line hidden
            BeginContext(1729, 22, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
