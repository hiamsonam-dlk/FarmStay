#pragma checksum "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ac65f3de3a449b592da5da57f9f45ffba01df6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Index), @"mvc.1.0.view", @"/Views/Videos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Videos/Index.cshtml", typeof(AspNetCore.Views_Videos_Index))]
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
#line 1 "D:\work\CTY_NUOC\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ac65f3de3a449b592da5da57f9f45ffba01df6", @"/Views/Videos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Videos.VideosModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Videos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
  
    ViewData["Title"] = "Thư viện Video";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(189, 335, true);
            WriteLiteral(@"

<div class=""navigation nlist"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  "">
                    <li>
                        <a href=""/"">Trang chủ</a>
                        <i class=""fa fa-angle-right""></i>

                        ");
            EndContext();
            BeginContext(524, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ac65f3de3a449b592da5da57f9f45ffba01df64357", async() => {
                BeginContext(570, 6, true);
                WriteLiteral("Videos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(580, 221, true);
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"PageDetail\" style=\"padding-top:30px\">\r\n\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 30 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
             for (int i = 0; i < Model.ListItems.Count(); i++)
            {


#line default
#line hidden
            BeginContext(882, 108, true);
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-12\">\r\n                    <div class=\"VideoItem videolink\"");
            EndContext();
            BeginWriteAttribute("val", " val=\"", 990, "\"", 1020, 1);
#line 34 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
WriteAttributeValue("", 996, Model.ListItems[i].Link, 996, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1021, 102, true);
            WriteLiteral(">\r\n                        <div class=\"khungAnh\">\r\n                            <a class=\"khungAnhCrop\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1123, "\"", 1156, 1);
#line 36 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
WriteAttributeValue("", 1131, Model.ListItems[i].Title, 1131, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1157, 39, true);
            WriteLiteral(">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1196, "\"", 1259, 3);
            WriteAttributeValue("", 1202, "/Home/ResizeImage?url=", 1202, 22, true);
#line 37 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
WriteAttributeValue("", 1224, Model.ListItems[i].Image, 1224, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 1249, "&width=500", 1249, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1260, "\"", 1291, 1);
#line 37 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
WriteAttributeValue("", 1266, Model.ListItems[i].Title, 1266, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1292, 144, true);
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n\r\n                        <p class=\"title\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1436, "\"", 1469, 1);
#line 42 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
WriteAttributeValue("", 1444, Model.ListItems[i].Title, 1444, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1470, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(1506, 66, false);
#line 43 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"
                           Write(API.Models.StringUtilities.Truncate(Model.ListItems[i].Title, 100));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 118, true);
            WriteLiteral("\r\n                            </a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 48 "D:\work\CTY_NUOC\API\Views\Videos\Index.cshtml"



            }

#line default
#line hidden
            BeginContext(1711, 394, true);
            WriteLiteral(@"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Videos.VideosModel> Html { get; private set; }
    }
}
#pragma warning restore 1591