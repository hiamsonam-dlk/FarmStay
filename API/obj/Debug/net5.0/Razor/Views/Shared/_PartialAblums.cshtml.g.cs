#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4a509a9bbfc04507b2ada091cdf086dc60a7dfa83a0ec60e027d25a78b732f2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialAblums), @"mvc.1.0.view", @"/Views/Shared/_PartialAblums.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialAblums.cshtml", typeof(AspNetCore.Views_Shared__PartialAblums))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
using API.Areas.Admin.Models.CategoriesAblums;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
using API.Areas.Admin.Models.Ablums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4a509a9bbfc04507b2ada091cdf086dc60a7dfa83a0ec60e027d25a78b732f2a", @"/Views/Shared/_PartialAblums.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialAblums : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Albums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Tin ảnh"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
  
    List<Ablums> ListAblums = AblumsService.GetListFeatured();

#line default
#line hidden
            BeginContext(159, 71, true);
            WriteLiteral("\r\n\r\n<!--Video-->\r\n<div class=\"box\">\r\n    <div class=\"header\">\r\n        ");
            EndContext();
            BeginContext(230, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a509a9bbfc04507b2ada091cdf086dc60a7dfa83a0ec60e027d25a78b732f2a4785", async() => {
                BeginContext(293, 34, true);
                WriteLiteral("\r\n          THƯ VIỆN ẢNH\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(331, 195, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"body white\">\r\n        <div id=\"AlbumBox\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <!-- The slideshow -->\r\n            <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 19 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
                 for (int j = 0; j < ListAblums.Count(); j++)
                {

#line default
#line hidden
            BeginContext(608, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 632, "\"", 673, 2);
            WriteAttributeValue("", 640, "carousel-item", 640, 13, true);
#line 21 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
WriteAttributeValue(" ", 653, j==0?"active":"", 654, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(674, 128, true);
            WriteLiteral(">\r\n                        <div class=\"khungAnh\">\r\n                            <a class=\"khungAnhCrop\" data-fancybox=\"gallery_1\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 802, "\"", 830, 1);
#line 23 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
WriteAttributeValue("", 809, ListAblums[j].Images, 809, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(831, 15, true);
            WriteLiteral(" data-caption=\"");
            EndContext();
            BeginContext(847, 19, false);
#line 23 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
                                                                                                                    Write(ListAblums[j].Title);

#line default
#line hidden
            EndContext();
            BeginContext(866, 40, true);
            WriteLiteral("\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 906, "\"", 933, 1);
#line 24 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"
WriteAttributeValue("", 912, ListAblums[j].Images, 912, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(934, 99, true);
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n\r\n                    </div>\r\n");
            EndContext();
#line 29 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialAblums.cshtml"

                }

#line default
#line hidden
            BeginContext(1054, 451, true);
            WriteLiteral(@"
            </div>
            <!-- Left and right controls -->
            <a class=""carousel-control-prev control"" href=""#AlbumBox"" data-slide=""prev"">
                <i class=""far fa-arrow-alt-circle-left""></i>
            </a>
            <a class=""carousel-control-next control"" href=""#AlbumBox"" data-slide=""next"">
                <i class=""far fa-arrow-alt-circle-right""></i>
            </a>

        </div>

    </div>
</div>

");
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
