#pragma checksum "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d4207510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocumentForms_Detail), @"mvc.1.0.view", @"/Views/DocumentForms/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocumentForms/Detail.cshtml", typeof(AspNetCore.Views_DocumentForms_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d4207510", @"/Views/DocumentForms/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_DocumentForms_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.DocumentForms.DocumentFormsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DocumentForms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Keyword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
  

    ViewData["Title"] = Model.Item.Title;
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    var rootsite=@Startup.Domain.ToString();

#line default
#line hidden
            BeginContext(251, 314, true);
            WriteLiteral(@"




<div class=""navigation nlist"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  "">
                    <li>
                        <a href=""/"">Trang chủ</a> <i class=""fa fa-angle-right""></i>
                        ");
            EndContext();
            BeginContext(565, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d42075106334", async() => {
                BeginContext(618, 20, true);
                WriteLiteral("Tạp chí Chư Yang Sin");
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
            BeginContext(642, 407, true);
            WriteLiteral(@" <i class=""fa fa-angle-right""></i>

                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""container ContentDiv"">
    <div class=""row"">

        <div class=""col-lg-9 col-md-12"">
            <div class=""PageDetail"">
                <div class=""ContentArticle"">
                    <div class=""detailBTTP"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1049, "\"", 1073, 1);
#line 36 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
WriteAttributeValue("", 1055, Model.Item.Images, 1055, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1074, 47, true);
            WriteLiteral(" />\r\n                        <h1 class=\"Title\">");
            EndContext();
            BeginContext(1123, 16, false);
#line 37 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                                      Write(Model.Item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 142, true);
            WriteLiteral("</h1>\r\n                        <p class=\"text-muted icon\">\r\n                            <span class=\"date\"><i class=\"far fa-clock mr-1\"></i>  ");
            EndContext();
            BeginContext(1283, 25, false);
#line 39 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                                                                             Write(Model.Item.IssuedDateShow);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 151, true);
            WriteLiteral("</span>\r\n                        </p>\r\n                        <div class=\"clearfix\">\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n");
            EndContext();
#line 46 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                     if (!string.IsNullOrEmpty(Model.Item.Introtext))
                    {

#line default
#line hidden
            BeginContext(1553, 27, true);
            WriteLiteral("                        <p>");
            EndContext();
            BeginContext(1581, 20, false);
#line 48 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                      Write(Model.Item.Introtext);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 49 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1630, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                     if (!string.IsNullOrEmpty(Model.Item.EmbedLink) && Model.Item.EmbedLink.Contains("iframe "))
                    {

#line default
#line hidden
            BeginContext(1770, 77, true);
            WriteLiteral("                        <div class=\"bttpEmbed\">\r\n                            ");
            EndContext();
            BeginContext(1848, 30, false);
#line 54 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                       Write(Html.Raw(Model.Item.EmbedLink));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 56 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 59 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                         if (Model.Item.Link != null)
                        {


                            string ex = API.Models.ManagerFiles.ManagerFilesService.GetExtension(Model.Item.Link);

                            if (ex == ".pdf")
                            {


#line default
#line hidden
            BeginContext(2268, 101, true);
            WriteLiteral("                                <div>\r\n                                    <iframe id=\"pdf-js-viewer\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2369, "\"", 2418, 2);
            WriteAttributeValue("", 2375, "/viewer.html?file=TapChi/", 2375, 25, true);
#line 69 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
WriteAttributeValue("", 2400, Model.Item.Link, 2400, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2419, 114, true);
            WriteLiteral(" title=\"webviewer\" frameborder=\"0\" width=\"100%\" height=\"800px\"></iframe>\r\n                                </div>\r\n");
            EndContext();
#line 71 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                                                                                                                        

                            }



                        }

#line default
#line hidden
#line 77 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(2744, 176, true);
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-3 col-md-12\">\r\n            <div class=\"greyDiv searchDiv mb-3\">\r\n                ");
            EndContext();
            BeginContext(2920, 905, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d420751013641", async() => {
                BeginContext(2991, 173, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <div class=\"form-group\">\r\n                                ");
                EndContext();
                BeginContext(3164, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d420751014234", async() => {
                    BeginContext(3200, 7, true);
                    WriteLiteral("Từ khóa");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 92 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchData.Keyword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3215, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3249, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d420751016022", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 93 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchData.Keyword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3333, 485, true);
                WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""col-12"">
                            <div class=""form-group"">
                                <div>
                                    <input type=""submit"" class=""btn btn-primary"" name=""Search"" value=""Tìm kiếm"" />
                                </div>

                            </div>

                        </div>
                    </div>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 88 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                          WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3825, 132, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div>\r\n                <ul class=\"listYear\">\r\n                    <li>\r\n                        ");
            EndContext();
            BeginContext(3957, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d420751020872", async() => {
                BeginContext(4010, 47, true);
                WriteLiteral("<i class=\"fas fa-book mr-1\"></i>Tất cả bản tin ");
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
            BeginContext(4061, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 116 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                     for (int i = DateTime.Now.Year; i >= 2010; i--)
                    {

#line default
#line hidden
            BeginContext(4183, 50, true);
            WriteLiteral("                    <li>\r\n                        ");
            EndContext();
            BeginContext(4233, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "716f2cdb188a70dc91ad2c8970691a45eb5c60cbf745b66c7e9ad022d420751022898", async() => {
                BeginContext(4306, 38, true);
                WriteLiteral(" <i class=\"fas fa-book mr-1\"></i> Năm ");
                EndContext();
                BeginContext(4345, 1, false);
#line 119 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                                                                                                                                  Write(i);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-year", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 119 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"
                                                                                 WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-year", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4350, 29, true);
            WriteLiteral("\r\n                    </li>\r\n");
            EndContext();
#line 121 "D:\code\NGHIA_TRANG\API\Views\DocumentForms\Detail.cshtml"

                    }

#line default
#line hidden
            BeginContext(4404, 81, true);
            WriteLiteral("                </ul>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.DocumentForms.DocumentFormsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591