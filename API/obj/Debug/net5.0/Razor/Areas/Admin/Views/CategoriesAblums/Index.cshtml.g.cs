#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "877b3c1f780d97fbdf41121ab22acf3d550c446b4c463d935ae8ba899b351b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoriesAblums_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoriesAblums/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CategoriesAblums/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_CategoriesAblums_Index))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"877b3c1f780d97fbdf41121ab22acf3d550c446b4c463d935ae8ba899b351b00", @"/Areas/Admin/Views/CategoriesAblums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"354159952f87747c1a2715c35c93fa5a5fdedf830348b0cb9841e5003a3ef970", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CategoriesAblums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsModel>
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
#line 2 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Quản lý Ablum Ảnh";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(242, 172, true);
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n\r\n        <h4><i class=\"fas fa-table\"></i> Danh mục Ablum Ảnh</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(414, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "877b3c1f780d97fbdf41121ab22acf3d550c446b4c463d935ae8ba899b351b005990", async() => {
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
            BeginContext(453, 639, true);
            WriteLiteral(@"

        <div class=""row"">
            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">STT</th>
                            <th>Tên Album</th>
                            <th width=""80px"">Hình</th>
                            <th width=""100px"">Trạng Thái</th>
                            <th width=""80px"">Nổi bật</th>                            
                            <th width=""130px"" class=""btn-contain"">
                                ");
            EndContext();
            BeginContext(1092, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877b3c1f780d97fbdf41121ab22acf3d550c446b4c463d935ae8ba899b351b007927", async() => {
                BeginContext(1174, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 29 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
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
            BeginContext(1186, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 35 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1429, 369, true);
            WriteLiteral(@"                            <tr>
                                <td colspan=""6"" class=""text-center"">
                                    <div *ngIf=""flagListitems==1"" class=""lds-dual-ring""></div>
                                    <label *ngIf=""flagListitems==2"">Không có dữ liệu!</label>
                                </td>
                            </tr>
");
            EndContext();
#line 43 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(1992, 87, true);
            WriteLiteral("                    <tr>\r\n                        <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(2081, 5, false);
#line 49 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                                                         Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2087, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2153, 24, false);
#line 51 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                       Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2177, 60, true);
            WriteLiteral(" <br />\r\n                            (<span> Alias </span>: ");
            EndContext();
            BeginContext(2238, 24, false);
#line 52 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                                              Write(Model.ListItems[i].Alias);

#line default
#line hidden
            EndContext();
            BeginContext(2262, 66, true);
            WriteLiteral(")\r\n                        </td>\r\n                        <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2328, "\"", 2360, 1);
#line 54 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 2334, Model.ListItems[i].Images, 2334, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2361, 39, true);
            WriteLiteral(" class=\"img-fluid\" style=\"height:50px;\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 2400, "\"", 2431, 1);
#line 54 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 2406, Model.ListItems[i].Title, 2406, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2432, 62, true);
            WriteLiteral(" /></td>\r\n\r\n                        <td class=\"text-center\">\r\n");
            EndContext();
#line 57 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                             if (@Model.ListItems[i].Status)
                            {

#line default
#line hidden
            BeginContext(2587, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2621, "\"", 2694, 5);
            WriteAttributeValue("", 2631, "UpdateStatus(\'", 2631, 14, true);
#line 59 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 2645, ControllerName, 2645, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2660, "\',\'", 2660, 3, true);
#line 59 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 2663, Model.ListItems[i].Ids, 2663, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2686, "\',false)", 2686, 8, true);
            EndWriteAttribute();
            BeginContext(2695, 67, true);
            WriteLiteral(" class=\"fas fa-check-circle text-primary\" aria-hidden=\"true\"></a>\r\n");
            EndContext();
#line 60 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2858, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2892, "\"", 2964, 5);
            WriteAttributeValue("", 2902, "UpdateStatus(\'", 2902, 14, true);
#line 63 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 2916, ControllerName, 2916, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2931, "\',\'", 2931, 3, true);
#line 63 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 2934, Model.ListItems[i].Ids, 2934, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2957, "\',true)", 2957, 7, true);
            EndWriteAttribute();
            BeginContext(2965, 67, true);
            WriteLiteral(" class=\"far fa-times-circle text-danger\" aria-hidden=\"false\"></a>\r\n");
            EndContext();
#line 64 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3063, 81, true);
            WriteLiteral("                        </td>\r\n                        <td class=\"text-center\">\r\n");
            EndContext();
#line 67 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                             if (@Model.ListItems[i].Featured)
                            {

#line default
#line hidden
            BeginContext(3239, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3273, "\"", 3348, 5);
            WriteAttributeValue("", 3283, "UpdateFeatured(\'", 3283, 16, true);
#line 69 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 3299, ControllerName, 3299, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3314, "\',\'", 3314, 3, true);
#line 69 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 3317, Model.ListItems[i].Ids, 3317, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3340, "\',false)", 3340, 8, true);
            EndWriteAttribute();
            BeginContext(3349, 67, true);
            WriteLiteral(" class=\"fas fa-check-circle text-primary\" aria-hidden=\"true\"></a>\r\n");
            EndContext();
#line 70 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3512, 34, true);
            WriteLiteral("                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3546, "\"", 3620, 5);
            WriteAttributeValue("", 3556, "UpdateFeatured(\'", 3556, 16, true);
#line 73 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 3572, ControllerName, 3572, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3587, "\',\'", 3587, 3, true);
#line 73 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
WriteAttributeValue("", 3590, Model.ListItems[i].Ids, 3590, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3613, "\',true)", 3613, 7, true);
            EndWriteAttribute();
            BeginContext(3621, 67, true);
            WriteLiteral(" class=\"far fa-times-circle text-danger\" aria-hidden=\"false\"></a>\r\n");
            EndContext();
#line 74 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3719, 207, true);
            WriteLiteral("                        </td>                        \r\n                        <td>\r\n                            <ul class=\"list-inline action\">\r\n                                <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3926, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877b3c1f780d97fbdf41121ab22acf3d550c446b4c463d935ae8ba899b351b0019273", async() => {
                BeginContext(4023, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 78 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
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
#line 78 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
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
            BeginContext(4056, 133, true);
            WriteLiteral("</li>\r\n                                <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(4190, 24, false);
#line 79 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                                                                                                                         Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(4214, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(4227, 22, false);
#line 79 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                                                                                                                                                              Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(4249, 136, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                            </ul>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 83 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4443, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(4519, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "877b3c1f780d97fbdf41121ab22acf3d550c446b4c463d935ae8ba899b351b0023995", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 89 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
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
            BeginContext(4609, 75, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(4685, 63, false);
#line 92 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\CategoriesAblums\Index.cshtml"
           Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4748, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.CategoriesAblums.CategoriesAblumsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
