#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b228b222c28182d9bb58717e3789986236cedf5fe4b1560c4d9fbd869bea7a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_List), @"mvc.1.0.view", @"/Views/Questions/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/List.cshtml", typeof(AspNetCore.Views_Questions_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b228b222c28182d9bb58717e3789986236cedf5fe4b1560c4d9fbd869bea7a5a", @"/Views/Questions/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Questions.QuestionsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left:30px; padding-right:30px; margin-bottom:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
  
    ViewData["Title"] = "Hỏi đáp";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(190, 333, true);
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
            BeginContext(523, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b228b222c28182d9bb58717e3789986236cedf5fe4b1560c4d9fbd869bea7a5a6544", async() => {
                BeginContext(571, 7, true);
                WriteLiteral("Hỏi đáp");
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
            BeginContext(582, 265, true);
            WriteLiteral(@"

                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>



<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-8 col-md-6 mt-4 mb-3"" style=""border-bottom:1px solid #ddd;"">
            ");
            EndContext();
            BeginContext(847, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b228b222c28182d9bb58717e3789986236cedf5fe4b1560c4d9fbd869bea7a5a8417", async() => {
                BeginContext(993, 52, true);
                WriteLiteral("<i class=\"fas fa-plus-circle mr-1\"></i> Gửi câu hỏi ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1049, 119, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-4 col-md-6 mt-4 mb-3\" style=\"border-bottom:1px solid #ddd;\">\r\n            ");
            EndContext();
            BeginContext(1168, 775, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b228b222c28182d9bb58717e3789986236cedf5fe4b1560c4d9fbd869bea7a5a10361", async() => {
                BeginContext(1248, 235, true);
                WriteLiteral("\r\n                <div class=\"search-form\">\r\n                    <ul class=\"list-inline\">\r\n                        <li class=\"list-inline-item\" style=\"width:calc(100% - 30px) !important\">\r\n                            <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1483, "\"", 1516, 1);
#line 38 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
WriteAttributeValue("", 1491, Model.SearchData.Keyword, 1491, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1517, 419, true);
                WriteLiteral(@" placeholder=""Tìm kiếm"" class=""txtSearch"" id=""content-search-all"" name=""keyword"" style=""width:100% !important"" />
                        </li>
                        <li class=""list-inline-item"">
                            <a onclick=""SubmitSearch()"" class=""search""><i class=""fa fa-search"" aria-hidden=""true""></i></a>
                        </li>
                    </ul>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1943, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 47 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
         for (int i = 0; i < Model.ListItems.Count(); i++)
        {

#line default
#line hidden
            BeginContext(2032, 111, true);
            WriteLiteral("            <div class=\"col-md-12\">\r\n                <div class=\"hoidap-item\">\r\n                    <p><strong>");
            EndContext();
            BeginContext(2144, 24, false);
#line 51 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
                          Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2168, 77, true);
            WriteLiteral("</strong></p>\r\n                    <p class=\"date\">\r\n                        ");
            EndContext();
            BeginContext(2246, 34, false);
#line 53 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
                   Write(Model.ListItems[i].CreatedDateShow);

#line default
#line hidden
            EndContext();
            BeginContext(2280, 4, true);
            WriteLiteral("  - ");
            EndContext();
            BeginContext(2285, 27, false);
#line 53 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
                                                          Write(Model.ListItems[i].Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2312, 94, true);
            WriteLiteral("\r\n                    </p>\r\n                    <p class=\"question\">\r\n                        ");
            EndContext();
            BeginContext(2407, 28, false);
#line 56 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
                   Write(Model.ListItems[i].Introtext);

#line default
#line hidden
            EndContext();
            BeginContext(2435, 121, true);
            WriteLiteral("\r\n                    </p>\r\n                    <button class=\"btn btn-success\" data-toggle=\"collapse\" data-target=\"#demo");
            EndContext();
            BeginContext(2558, 1, false);
#line 58 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
                                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2560, 50, true);
            WriteLiteral("\">Xem chi tiết </button>\r\n                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2610, "\"", 2623, 2);
            WriteAttributeValue("", 2615, "demo", 2615, 4, true);
#line 59 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
WriteAttributeValue("", 2619, i, 2619, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2624, 312, true);
            WriteLiteral(@" class=""collapse"" style=""padding:20px 0; color:#555"">
                        <div>
                            <p class=""badge badge-warning"" style=""font-size:95%;padding:7px 10px"">Trả lời có tính chất tham khảo:</p>
                        </div>
                        <div>
                            ");
            EndContext();
            BeginContext(2937, 41, false);
#line 64 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
                       Write(Html.Raw(@Model.ListItems[i].Description));

#line default
#line hidden
            EndContext();
            BeginContext(2978, 108, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 70 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
        }

#line default
#line hidden
            BeginContext(3097, 91, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 mb-3\">\r\n            ");
            EndContext();
            BeginContext(3189, 63, false);
#line 77 "D:\code\NGHIA_TRANG\API\Views\Questions\List.cshtml"
       Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(3252, 52, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Questions.QuestionsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
