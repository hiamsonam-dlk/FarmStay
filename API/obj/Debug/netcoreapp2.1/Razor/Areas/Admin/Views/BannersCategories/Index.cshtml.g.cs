#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e08335e4ed27adaa8796f57b4b7aa3a07656af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BannersCategories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BannersCategories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BannersCategories/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_BannersCategories_Index))]
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
#line 1 "D:\work\CTY_NUOC\API\Areas\Admin\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e08335e4ed27adaa8796f57b4b7aa3a07656af0", @"/Areas/Admin/Views/BannersCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BannersCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.BannersCategories.BannersCategoriesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialMsgInfoAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AjaxDeleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Loại Banner/Liên Kết";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(247, 172, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n\r\n        <h4><i class=\"fas fa-table\"></i> Loại Banner/Liên Kết</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(419, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e08335e4ed27adaa8796f57b4b7aa3a07656af05913", async() => {
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
            BeginContext(458, 566, true);
            WriteLiteral(@"
        <div class=""row"">

            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">STT</th>
                            <th>Tên Loại</th>                            
                            <th width=""80px"">Trạng Thái</th>
                            <th>Mô tả</th>
                            <th width=""130px"" class=""btn-contain"">
                                ");
            EndContext();
            BeginContext(1024, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e08335e4ed27adaa8796f57b4b7aa3a07656af07749", async() => {
                BeginContext(1106, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                       WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(1118, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 33 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1361, 369, true);
            WriteLiteral(@"                            <tr>
                                <td colspan=""5"" class=""text-center"">
                                    <div *ngIf=""flagListitems==1"" class=""lds-dual-ring""></div>
                                    <label *ngIf=""flagListitems==2"">Không có dữ liệu!</label>
                                </td>
                            </tr>
");
            EndContext();
#line 41 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(1924, 111, true);
            WriteLiteral("                                <tr>\r\n                                    <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(2036, 21, false);
#line 47 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                                                    Write(Model.ListItems[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(2057, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2105, 24, false);
#line 48 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                   Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2129, 106, true);
            WriteLiteral("</td>\r\n                                   \r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 51 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                         if (@Model.ListItems[i].Status==true)
                                        {

#line default
#line hidden
            BeginContext(2358, 49, true);
            WriteLiteral("                                            <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2407, "\"", 2480, 5);
            WriteAttributeValue("", 2417, "UpdateStatus(\'", 2417, 14, true);
#line 53 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
WriteAttributeValue("", 2431, ControllerName, 2431, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2446, "\',\'", 2446, 3, true);
#line 53 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
WriteAttributeValue("", 2449, Model.ListItems[i].Ids, 2449, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2472, "\',false)", 2472, 8, true);
            EndWriteAttribute();
            BeginContext(2481, 57, true);
            WriteLiteral(" class=\"fas fa-check-circle\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 54 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2670, 49, true);
            WriteLiteral("                                            <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2719, "\"", 2791, 5);
            WriteAttributeValue("", 2729, "UpdateStatus(\'", 2729, 14, true);
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
WriteAttributeValue("", 2743, ControllerName, 2743, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2758, "\',\'", 2758, 3, true);
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
WriteAttributeValue("", 2761, Model.ListItems[i].Ids, 2761, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2784, "\',true)", 2784, 7, true);
            EndWriteAttribute();
            BeginContext(2792, 58, true);
            WriteLiteral(" class=\"far fa-times-circle\" aria-hidden=\"false\"></span>\r\n");
            EndContext();
#line 58 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2893, 83, true);
            WriteLiteral("                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(2977, 30, false);
#line 60 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                   Write(Model.ListItems[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(3007, 195, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <ul class=\"list-inline action\">\r\n                                            <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3202, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e08335e4ed27adaa8796f57b4b7aa3a07656af015540", async() => {
                BeginContext(3299, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                                                                WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                                                                                                                     WriteLiteral(Model.ListItems[i].Ids);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3332, 145, true);
            WriteLiteral("</li>\r\n                                            <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(3478, 24, false);
#line 64 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                                                                                                                     Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(3502, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(3515, 22, false);
#line 64 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                                                                                                                                                                          Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(3537, 172, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                                        </ul>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 68 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(3767, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(3843, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e08335e4ed27adaa8796f57b4b7aa3a07656af020324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 74 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
                          WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3933, 75, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(4009, 63, false);
#line 77 "D:\work\CTY_NUOC\API\Areas\Admin\Views\BannersCategories\Index.cshtml"
           Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4072, 62, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.BannersCategories.BannersCategoriesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
