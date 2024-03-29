#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0bfb077009ca3b59ab7b150447ca4763866008cbc17115589679d5e10e5febd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Index), @"mvc.1.0.view", @"/Views/Articles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articles/Index.cshtml", typeof(AspNetCore.Views_Articles_Index))]
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
#line 2 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0bfb077009ca3b59ab7b150447ca4763866008cbc17115589679d5e10e5febd9", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Articles.ArticlesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
  
    var ItemConfig = API.Areas.Admin.Models.SYSParams.SYSParamsService.GetItemConfigByHome();
    ViewData["Description"] = ItemConfig.SEODescription;
    ViewData["Keywords"] = ItemConfig.SEOKeyword;
    ViewData["Images"] = @Startup.Domain + "/ttudkhcn/images/ogImage3.png?ver=" + DateTime.Now.ToString();
    ViewData["Url"] = @Startup.Domain;
    ViewData["Title"] = "Quản lý tin tức";

#line default
#line hidden
            BeginContext(493, 143, true);
            WriteLiteral("<div class=\"container ContentDiv pt-3\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n\r\n            <div class=\"row ArticleList\">\r\n\r\n");
            EndContext();
#line 19 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                 if (Model.ListItems == null || Model.ListItems.Count() == 0)
                {

#line default
#line hidden
            BeginContext(734, 122, true);
            WriteLiteral("                    <div class=\"col-lg-12\">\r\n                        <p>Chưa có bài đăng</p>\r\n                    </div>\r\n");
            EndContext();
#line 24 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"

                }
                else
                {
                    for (int i = 0; i < Model.ListItems.Count(); i++)
                    {


#line default
#line hidden
            BeginContext(1014, 96, true);
            WriteLiteral("                        <div class=\"col-12\">\r\n                            <div class=\"item\">\r\n\r\n");
            EndContext();
#line 34 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                 if (!string.IsNullOrEmpty(Model.ListItems[i].Images))
                                {

#line default
#line hidden
            BeginContext(1233, 96, true);
            WriteLiteral("                                    <div class=\"left\">\r\n                                        ");
            EndContext();
            BeginContext(1329, 351, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bfb077009ca3b59ab7b150447ca4763866008cbc17115589679d5e10e5febd96426", async() => {
                BeginContext(1473, 50, true);
                WriteLiteral("\r\n                                            <img");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 1523, "\"", 1554, 1);
#line 38 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
WriteAttributeValue("", 1529, Model.ListItems[i].Title, 1529, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1555, 13, true);
                WriteLiteral(" class=\"tall\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1568, "\"", 1632, 3);
                WriteAttributeValue("", 1574, "/Home/ResizeImage?url=", 1574, 22, true);
#line 38 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
WriteAttributeValue("", 1596, Model.ListItems[i].Images, 1596, 26, false);

#line default
#line hidden
                WriteAttributeValue("", 1622, "&width=600", 1622, 10, true);
                EndWriteAttribute();
                BeginContext(1633, 43, true);
                WriteLiteral(">\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                                                           WriteLiteral(Model.ListItems[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 37 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                                                                                                    WriteLiteral(Model.ListItems[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1680, 48, true);
            WriteLiteral("\r\n\r\n                                    </div>\r\n");
            EndContext();
#line 42 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1763, 38, true);
            WriteLiteral("\r\n                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1801, "\"", 1875, 2);
            WriteAttributeValue("", 1809, "right", 1809, 5, true);
#line 44 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
WriteAttributeValue(" ", 1814, string.IsNullOrEmpty(Model.ListItems[i].Images)?"w100":"", 1815, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1876, 98, true);
            WriteLiteral(">\r\n                                    <p class=\"title\">\r\n                                        ");
            EndContext();
            BeginContext(1974, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bfb077009ca3b59ab7b150447ca4763866008cbc17115589679d5e10e5febd911838", async() => {
                BeginContext(2119, 24, false);
#line 46 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                                                                                                                                                   Write(Model.ListItems[i].Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                                                           WriteLiteral(Model.ListItems[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                                                                                                    WriteLiteral(Model.ListItems[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2147, 167, true);
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"date\">\r\n                                        <i class=\"far fa-clock\"></i> ");
            EndContext();
            BeginContext(2315, 57, false);
#line 49 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                                Write(Model.ListItems[i].PublishUp.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 44, true);
            WriteLiteral("\r\n                                    </p>\r\n");
            EndContext();
#line 51 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                     if (!string.IsNullOrEmpty(@Model.ListItems[i].IntroText))
                                    {

#line default
#line hidden
            BeginContext(2551, 55, true);
            WriteLiteral("                                        <p class=\"ovv\">");
            EndContext();
            BeginContext(2607, 39, false);
#line 53 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                                  Write(Html.Raw(@Model.ListItems[i].IntroText));

#line default
#line hidden
            EndContext();
            BeginContext(2646, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 54 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2691, 206, true);
            WriteLiteral("                                </div>\r\n                                <div class=\"clearfix\">\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 61 "D:\code\NGHIA_TRANG\API\Views\Articles\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2939, 98, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"clearfix\"></div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Articles.ArticlesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
