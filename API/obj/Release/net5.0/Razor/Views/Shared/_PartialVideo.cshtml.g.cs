#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a863f9f348ff50295eb55bc8dc74363c4b737903a840247012edfcc055e7874a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialVideo), @"mvc.1.0.view", @"/Views/Shared/_PartialVideo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialVideo.cshtml", typeof(AspNetCore.Views_Shared__PartialVideo))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
using API.Areas.Admin.Models.Videos;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a863f9f348ff50295eb55bc8dc74363c4b737903a840247012edfcc055e7874a", @"/Views/Shared/_PartialVideo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialVideo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Videos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Video"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
  

    var listVideo = VideosService.GetListFeatured();

#line default
#line hidden
            BeginContext(102, 71, true);
            WriteLiteral("\r\n\r\n<!--Video-->\r\n<div class=\"box\">\r\n    <div class=\"header\">\r\n        ");
            EndContext();
            BeginContext(173, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a863f9f348ff50295eb55bc8dc74363c4b737903a840247012edfcc055e7874a4616", async() => {
                BeginContext(233, 29, true);
                WriteLiteral("\r\n            Video\r\n        ");
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
            BeginContext(266, 195, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"body white\">\r\n        <div id=\"VideoBox\" class=\"carousel slide\" data-ride=\"carousel\">\r\n            <!-- The slideshow -->\r\n            <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 19 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
                 for (int i = 0; i < listVideo.Count(); i++)
                {

#line default
#line hidden
            BeginContext(542, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 566, "\"", 607, 2);
            WriteAttributeValue("", 574, "carousel-item", 574, 13, true);
#line 21 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
WriteAttributeValue(" ", 587, i==0?"active":"", 588, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(608, 59, true);
            WriteLiteral(">\r\n                        <div class=\"VideoItem videolink\"");
            EndContext();
            BeginWriteAttribute("val", " val=\"", 667, "\"", 691, 1);
#line 22 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
WriteAttributeValue("", 673, listVideo[i].Link, 673, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(692, 110, true);
            WriteLiteral(">\r\n                            <div class=\"khungAnh\">\r\n                                <a class=\"khungAnhCrop\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 802, "\"", 829, 1);
#line 24 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
WriteAttributeValue("", 810, listVideo[i].Title, 810, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 43, true);
            WriteLiteral(">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 873, "\"", 930, 3);
            WriteAttributeValue("", 879, "/Home/ResizeImage?url=", 879, 22, true);
#line 25 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
WriteAttributeValue("", 901, listVideo[i].Image, 901, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 920, "&width=500", 920, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 931, "\"", 956, 1);
#line 25 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
WriteAttributeValue("", 937, listVideo[i].Title, 937, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(957, 160, true);
            WriteLiteral(">\r\n                                </a>\r\n                            </div>\r\n\r\n                            <p class=\"title\">\r\n                                <a");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1117, "\"", 1144, 1);
#line 30 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
WriteAttributeValue("", 1125, listVideo[i].Title, 1125, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1145, 39, true);
            WriteLiteral(">\r\n                                    ");
            EndContext();
            BeginContext(1185, 61, false);
#line 31 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"
                               Write(API.Models.StringUtilities.Truncate(@listVideo[i].Title, 100));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 136, true);
            WriteLiteral("\r\n                                </a>\r\n                            </p>\r\n                        </div>\r\n\r\n                    </div>\r\n");
            EndContext();
#line 37 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialVideo.cshtml"

                }

#line default
#line hidden
            BeginContext(1403, 805, true);
            WriteLiteral(@"
            </div>
            <!-- Left and right controls -->
            <a class=""carousel-control-prev control"" href=""#VideoBox"" data-slide=""prev"">
                <i class=""far fa-arrow-alt-circle-left""></i>
            </a>
            <a class=""carousel-control-next control"" href=""#VideoBox"" data-slide=""next"">
                <i class=""far fa-arrow-alt-circle-right""></i>
            </a>

        </div>

    </div>
</div>



<!-- Modal -->
<div class=""modal fade"" id=""myModal"" role=""dialog"" style=""z-index:9999"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div class=""VideoWrapper modal-video"">

                </div>
            </div>
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
