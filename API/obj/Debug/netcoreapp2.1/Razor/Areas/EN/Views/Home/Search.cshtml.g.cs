#pragma checksum "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11b8c102101f097685e412fe1a10d255601312e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_Home_Search), @"mvc.1.0.view", @"/Areas/EN/Views/Home/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/Home/Search.cshtml", typeof(AspNetCore.Areas_EN_Views_Home_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11b8c102101f097685e412fe1a10d255601312e6", @"/Areas/EN/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Search.SearchAllModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialLeftCol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/noimage.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialRightCol", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(186, 564, true);
            WriteLiteral(@"


<div class=""navigation nlist"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline"">
                    <li>
                        <a href=""/EN/"">Home</a> <i class=""fa fa-angle-right""></i>
                       Search

                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>


<div class=""container ContentDiv"">

    <div class=""row"">
        <div class=""col-12"">
            <div class=""col1"">
                ");
            EndContext();
            BeginContext(750, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11b8c102101f097685e412fe1a10d255601312e66713", async() => {
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
            BeginContext(784, 206, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col2\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 mb-3\">\r\n                        <h5>Results for: <strong class=\"text-primary\">");
            EndContext();
            BeginContext(991, 24, false);
#line 37 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                                 Write(Model.SearchData.Keyword);

#line default
#line hidden
            EndContext();
            BeginContext(1015, 120, true);
            WriteLiteral("</strong> </h5>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"row ArticleList\">\r\n\r\n");
            EndContext();
#line 43 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                     if (Model.ListItems == null || Model.ListItems.Count() == 0)
                    {

#line default
#line hidden
            BeginContext(1241, 123, true);
            WriteLiteral("                        <div class=\"col-lg-12\">\r\n                            <p>Empty</p>\r\n                        </div>\r\n");
            EndContext();
#line 48 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"

                    }
                    else
                    {
                        for (int i = 0; i < Model.ListItems.Count(); i++)
                        {


#line default
#line hidden
            BeginContext(1542, 198, true);
            WriteLiteral("                            <div class=\"col-12\">\r\n                                <div class=\"item\">\r\n                                    <div class=\"left\">\r\n                                        ");
            EndContext();
            BeginContext(1740, 928, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b8c102101f097685e412fe1a10d255601312e69719", async() => {
                BeginContext(1917, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 60 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                             if (Model.ListItems[i].Images == null || @Model.ListItems[i].Images == "" || Model.ListItems[i].Images.ToLower() == "/cms/content/tintuc/")
                                            {

#line default
#line hidden
                BeginContext(2154, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(2202, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11b8c102101f097685e412fe1a10d255601312e610595", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 62 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 2239, Model.ListItems[i].Title, 2239, 25, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2266, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 63 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
                BeginContext(2412, 52, true);
                WriteLiteral("                                                <img");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 2464, "\"", 2495, 1);
#line 66 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
WriteAttributeValue("", 2470, Model.ListItems[i].Title, 2470, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2496, 13, true);
                WriteLiteral(" class=\"tall\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2509, "\"", 2573, 3);
                WriteAttributeValue("", 2515, "/Home/ResizeImage?url=", 2515, 22, true);
#line 66 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
WriteAttributeValue("", 2537, Model.ListItems[i].Images, 2537, 26, false);

#line default
#line hidden
                WriteAttributeValue("", 2563, "&width=600", 2563, 10, true);
                EndWriteAttribute();
                BeginContext(2574, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 67 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                            }

#line default
#line hidden
                BeginContext(2624, 40, true);
                WriteLiteral("                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                                                                       WriteLiteral(Model.ListItems[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 58 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                                                                                                                WriteLiteral(Model.ListItems[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 58 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 1890, Model.ListItems[i].Title, 1890, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2668, 206, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"right\">\r\n                                        <p class=\"title\">\r\n                                            ");
            EndContext();
            BeginContext(2874, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b8c102101f097685e412fe1a10d255601312e617632", async() => {
                BeginContext(3019, 24, false);
#line 72 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                                                                                                                                                       Write(Model.ListItems[i].Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                                                               WriteLiteral(Model.ListItems[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 72 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                                                                                                        WriteLiteral(Model.ListItems[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3047, 48, true);
            WriteLiteral("\r\n                                        </p>\r\n");
            EndContext();
#line 74 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                         if (!string.IsNullOrEmpty(@Model.ListItems[i].IntroText))
                                        {

#line default
#line hidden
            BeginContext(3238, 59, true);
            WriteLiteral("                                            <p class=\"ovv\">");
            EndContext();
            BeginContext(3298, 71, false);
#line 76 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                                      Write(API.Models.StringUtilities.Truncate(@Model.ListItems[i].IntroText, 200));

#line default
#line hidden
            EndContext();
            BeginContext(3369, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 77 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3418, 226, true);
            WriteLiteral("                                    </div>\r\n                                    <div class=\"clearfix\">\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 84 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3694, 137, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12 mb-3\">\r\n                        ");
            EndContext();
            BeginContext(3832, 63, false);
#line 91 "D:\work\CTY_NUOC\API\Areas\EN\Views\Home\Search.cshtml"
                   Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(3895, 124, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col3\">\r\n                ");
            EndContext();
            BeginContext(4019, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11b8c102101f097685e412fe1a10d255601312e623577", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4054, 104, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"clearfix\"></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Search.SearchAllModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
