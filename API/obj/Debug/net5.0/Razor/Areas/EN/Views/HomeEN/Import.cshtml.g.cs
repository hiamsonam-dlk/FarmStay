#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ef218fdec277a86c726773cd25ac54de62b6a62e00012fb7b87c4de8ce1ec605"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_HomeEN_Import), @"mvc.1.0.view", @"/Areas/EN/Views/HomeEN/Import.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/HomeEN/Import.cshtml", typeof(AspNetCore.Areas_EN_Views_HomeEN_Import))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Areas\EN\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Areas\EN\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ef218fdec277a86c726773cd25ac54de62b6a62e00012fb7b87c4de8ce1ec605", @"/Areas/EN/Views/HomeEN/Import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_HomeEN_Import : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Articles.ArticlesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AjaxDeleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
  
    ViewData["Title"] = "Import";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(232, 117, true);
            WriteLiteral("<div class=\"container-fluid mt-5 mb-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h2>Import:");
            EndContext();
            BeginContext(350, 21, false);
#line 10 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                  Write(Model.ListItems.Count);

#line default
#line hidden
            EndContext();
            BeginContext(371, 471, true);
            WriteLiteral(@"</h2>
        </div>
        <div class=""col-lg-12"">

            <table class=""table table-bordered table-striped table-hover "">
                <thead>
                    <tr>
                        <th width=""50px"" class=""text-center"">ID</th>
                        <th>Tên bài viết</th>
                        <th width=""150px"">Category</th>
                        <th width=""90px"">Ngày đăng</th>
                        <th width=""150px"">Image</th>
");
            EndContext();
            BeginContext(941, 185, true);
            WriteLiteral("                        <th width=\"80px\">Link</th>\r\n                        <th width=\"80px\">CatId</th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n");
            EndContext();
#line 30 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                     if (Model.ListItems == null || Model.ListItems.Count() == 0)
                    {

#line default
#line hidden
            BeginContext(1232, 253, true);
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"7\" class=\"text-center\">\r\n                                <label *ngIf=\"flagListitems==2\">Không có dữ liệu!</label>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 37 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                    }
                    else
                    {
                        for (int i = 0; i < Model.ListItems.Count(); i++)
                        {

#line default
#line hidden
            BeginContext(1659, 95, true);
            WriteLiteral("                        <tr>\r\n                            <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(1755, 25, false);
#line 43 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                                                            Write(Model.ListItems[i].Params);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 76, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a>");
            EndContext();
            BeginContext(1857, 24, false);
#line 45 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                              Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 73, true);
            WriteLiteral("</a>\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(1955, 27, false);
#line 47 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                           Write(Model.ListItems[i].Category);

#line default
#line hidden
            EndContext();
            BeginContext(1982, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2022, 32, false);
#line 48 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                           Write(Model.ListItems[i].PublishUpShow);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 77, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2131, "\"", 2163, 1);
#line 50 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
WriteAttributeValue("", 2137, Model.ListItems[i].Images, 2137, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2164, 77, true);
            WriteLiteral(" />\r\n                                <br />\r\n                                ");
            EndContext();
            BeginContext(2242, 25, false);
#line 52 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                           Write(Model.ListItems[i].Images);

#line default
#line hidden
            EndContext();
            BeginContext(2267, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
            BeginContext(2423, 52, true);
            WriteLiteral("                            <td class=\"text-center\">");
            EndContext();
            BeginContext(2476, 27, false);
#line 56 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                                               Write(Model.ListItems[i].Metadata);

#line default
#line hidden
            EndContext();
            BeginContext(2503, 59, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">");
            EndContext();
            BeginContext(2563, 24, false);
#line 57 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                                               Write(Model.ListItems[i].CatId);

#line default
#line hidden
            EndContext();
            BeginContext(2587, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 59 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2675, 64, true);
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n            ");
            EndContext();
            BeginContext(2739, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef218fdec277a86c726773cd25ac54de62b6a62e00012fb7b87c4de8ce1ec60510546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 65 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\HomeEN\Import.cshtml"
                      WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2829, 42, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
