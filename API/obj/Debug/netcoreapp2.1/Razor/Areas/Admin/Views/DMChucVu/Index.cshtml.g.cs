#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ee8e30ba8d1268a50e98de7f710eb4471274fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DMChucVu_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DMChucVu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/DMChucVu/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_DMChucVu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ee8e30ba8d1268a50e98de7f710eb4471274fb", @"/Areas/Admin/Views/DMChucVu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DMChucVu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.DMChucVu.DMChucVuModel>
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
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Index";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(214, 176, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        \r\n        <h4><i class=\"fas fa-table\"></i> Danh mục chức vụ</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(390, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c2ee8e30ba8d1268a50e98de7f710eb4471274fb5812", async() => {
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
            BeginContext(429, 1039, true);
            WriteLiteral(@"
        
        <div class=""row"">            
            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">STT</th>
                            <th class=""text-info"" data-toggle=""tooltip"" data-placement=""top"" title=""Tên chức vụ"">Tên chức vụ </th>
                            <th width=""100px"" class=""text-info"" data-toggle=""tooltip"" data-placement=""top"" title=""Trạng thái để biết chức vụ này có phải là lãnh đạo hay không."">Lãnh Đạo </th>
                            <th width=""150px"" class=""text-center text-info"" data-toggle=""tooltip"" data-placement=""top"" title=""Trạng thái Hiện/Ẩn"">Trạng Thái </th>
                            <th class=""text-info"" data-toggle=""tooltip"" data-placement=""top"" title=""Thông tin mô tả về chức vụ"">Mô tả </th>
                            <th width=""130px"" class=""btn-contain"">
                 ");
            WriteLiteral("               ");
            EndContext();
            BeginContext(1468, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ee8e30ba8d1268a50e98de7f710eb4471274fb8187", async() => {
                BeginContext(1551, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 28 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
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
            BeginContext(1563, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 34 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1806, 369, true);
            WriteLiteral(@"                            <tr>
                                <td colspan=""5"" class=""text-center"">
                                    <div *ngIf=""flagListitems==1"" class=""lds-dual-ring""></div>
                                    <label *ngIf=""flagListitems==2"">Không có dữ liệu!</label>
                                </td>
                            </tr>
");
            EndContext();
#line 42 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(2369, 111, true);
            WriteLiteral("                                <tr>\r\n                                    <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(2482, 5, false);
#line 48 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                                                     Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2488, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2536, 24, false);
#line 49 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                   Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2560, 69, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 51 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                         if (@Model.ListItems[i].Leader)
                                        {

#line default
#line hidden
            BeginContext(2746, 104, true);
            WriteLiteral("                                            <span class=\"fa fa-check green\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 54 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2893, 105, true);
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                         if (@Model.ListItems[i].Status)
                                        {

#line default
#line hidden
            BeginContext(3115, 49, true);
            WriteLiteral("                                            <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3164, "\"", 3237, 5);
            WriteAttributeValue("", 3174, "UpdateStatus(\'", 3174, 14, true);
#line 59 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
WriteAttributeValue("", 3188, ControllerName, 3188, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3203, "\',\'", 3203, 3, true);
#line 59 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
WriteAttributeValue("", 3206, Model.ListItems[i].Ids, 3206, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3229, "\',false)", 3229, 8, true);
            EndWriteAttribute();
            BeginContext(3238, 71, true);
            WriteLiteral("  class=\"fas fa-check-circle text-primary\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 60 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3441, 49, true);
            WriteLiteral("                                            <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3490, "\"", 3562, 5);
            WriteAttributeValue("", 3500, "UpdateStatus(\'", 3500, 14, true);
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
WriteAttributeValue("", 3514, ControllerName, 3514, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3529, "\',\'", 3529, 3, true);
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
WriteAttributeValue("", 3532, Model.ListItems[i].Ids, 3532, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3555, "\',true)", 3555, 7, true);
            EndWriteAttribute();
            BeginContext(3563, 70, true);
            WriteLiteral(" class=\"far fa-times-circle text-danger\" aria-hidden=\"false\"></span>\r\n");
            EndContext();
#line 64 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3676, 83, true);
            WriteLiteral("                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(3760, 30, false);
#line 66 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                   Write(Model.ListItems[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(3790, 195, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <ul class=\"list-inline action\">\r\n                                            <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3985, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ee8e30ba8d1268a50e98de7f710eb4471274fb16618", async() => {
                BeginContext(4082, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 69 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
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
#line 69 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
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
            BeginContext(4115, 145, true);
            WriteLiteral("</li>\r\n                                            <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(4261, 24, false);
#line 70 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                                                                                                                     Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(4285, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(4298, 22, false);
#line 70 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                                                                                                                                                                          Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(4320, 172, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                                        </ul>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 74 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4550, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(4626, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2ee8e30ba8d1268a50e98de7f710eb4471274fb21357", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 80 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
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
            BeginContext(4716, 99, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">                    \r\n                    ");
            EndContext();
            BeginContext(4816, 62, false);
#line 83 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMChucVu\Index.cshtml"
               Write(await Html.PartialAsync("_PartialPagination",Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4878, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.DMChucVu.DMChucVuModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
