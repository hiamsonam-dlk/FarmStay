#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4538d9eac4dbabdc16ba50c7f4ec54c7134ac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contacts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contacts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Contacts/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Contacts_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4538d9eac4dbabdc16ba50c7f4ec54c7134ac4", @"/Areas/Admin/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Contacts.ContactsModel>
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
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
  
    Layout = "_layoutAdmin";
 ViewData["Title"] = "Quản lý thông tin liên hệ";
 string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(228, 174, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h4><i class=\"fas fa-table\"></i>Quản lý thông tin liên hệ</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(402, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed4538d9eac4dbabdc16ba50c7f4ec54c7134ac45822", async() => {
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
            BeginContext(441, 633, true);
            WriteLiteral(@"
        <div class=""row"">

     
            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">STT</th>
                            <th>Họ tên</th>
                            <th>Điện thoại</th>
                            <th>Tiêu đề</th>
                            <td>Ngày</td>
                            <th width=""80px"">Đã xem</th>
                            <th width=""130px"" class=""btn-contain"">
                                ");
            EndContext();
            BeginContext(1074, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4538d9eac4dbabdc16ba50c7f4ec54c7134ac47726", async() => {
                BeginContext(1196, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 29 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Type", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                                                                                              WriteLiteral(Model.SearchData.Type);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1208, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 35 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1451, 250, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"7\" class=\"text-center\">\r\n\r\n                                    <label>Không có dữ liệu!</label>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 43 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(1895, 103, true);
            WriteLiteral("                            <tr>\r\n                                <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(2000, 5, false);
#line 49 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                                                                 Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2006, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2050, 27, false);
#line 50 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Model.ListItems[i].Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2077, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2121, 24, false);
#line 51 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Model.ListItems[i].Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2145, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2189, 24, false);
#line 52 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2213, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2257, 34, false);
#line 53 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                               Write(Model.ListItems[i].CreatedDateShow);

#line default
#line hidden
            EndContext();
            BeginContext(2291, 65, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-center\">\r\n");
            EndContext();
#line 55 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                                     if (@Model.ListItems[i].Status)
                                    {

#line default
#line hidden
            BeginContext(2465, 68, true);
            WriteLiteral("                                        <span style=\"cursor:pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2533, "\"", 2606, 5);
            WriteAttributeValue("", 2543, "UpdateStatus(\'", 2543, 14, true);
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 2557, ControllerName, 2557, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2572, "\',\'", 2572, 3, true);
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 2575, Model.ListItems[i].Ids, 2575, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2598, "\',false)", 2598, 8, true);
            EndWriteAttribute();
            BeginContext(2607, 70, true);
            WriteLiteral(" class=\"fas fa-check-circle text-primary\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 58 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2797, 68, true);
            WriteLiteral("                                        <span style=\"cursor:pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2865, "\"", 2937, 5);
            WriteAttributeValue("", 2875, "UpdateStatus(\'", 2875, 14, true);
#line 61 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 2889, ControllerName, 2889, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2904, "\',\'", 2904, 3, true);
#line 61 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
WriteAttributeValue("", 2907, Model.ListItems[i].Ids, 2907, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2930, "\',true)", 2930, 7, true);
            EndWriteAttribute();
            BeginContext(2938, 70, true);
            WriteLiteral(" class=\"far fa-times-circle text-danger\" aria-hidden=\"false\"></span>\r\n");
            EndContext();
#line 62 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3047, 215, true);
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <ul class=\"list-inline action\">\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3262, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4538d9eac4dbabdc16ba50c7f4ec54c7134ac417012", async() => {
                BeginContext(3359, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 66 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
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
#line 66 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
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
            BeginContext(3392, 153, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"\" data-ids=\"");
            EndContext();
            BeginContext(3546, 22, false);
#line 67 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                                                                                                                                             Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(3568, 160, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 71 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(3786, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(3862, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4538d9eac4dbabdc16ba50c7f4ec54c7134ac421255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 77 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
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
            BeginContext(3952, 75, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(4028, 63, false);
#line 80 "D:\work\CTY_NUOC\API\Areas\Admin\Views\Contacts\Index.cshtml"
           Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4091, 83, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Contacts.ContactsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591