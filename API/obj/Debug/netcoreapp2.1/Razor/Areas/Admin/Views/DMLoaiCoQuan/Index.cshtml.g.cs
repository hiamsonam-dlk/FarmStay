#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6490838bb497d639c5086291339e3b629f72c3dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DMLoaiCoQuan_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DMLoaiCoQuan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/DMLoaiCoQuan/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_DMLoaiCoQuan_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6490838bb497d639c5086291339e3b629f72c3dd", @"/Areas/Admin/Views/DMLoaiCoQuan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DMLoaiCoQuan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.DMLoaiCoQuan.DMLoaiCoQuanModel>
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
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Quản lý Loại Cơ Quan";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(237, 173, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n\r\n        <h4><i class=\"fas fa-table\"></i> Danh mục Loại Cơ Quan</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(410, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6490838bb497d639c5086291339e3b629f72c3dd5864", async() => {
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
            BeginContext(449, 559, true);
            WriteLiteral(@"

        <div class=""row"">
            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">STT</th>
                            <th>Tên</th>                          
                            <th width=""80px"">Trạng Thái</th>
                            <th>Mô tả</th>
                            <th width=""130px"" class=""btn-contain"">
                                ");
            EndContext();
            BeginContext(1008, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6490838bb497d639c5086291339e3b629f72c3dd7693", async() => {
                BeginContext(1090, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
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
            BeginContext(1102, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 33 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1345, 369, true);
            WriteLiteral(@"                            <tr>
                                <td colspan=""5"" class=""text-center"">
                                    <div *ngIf=""flagListitems==1"" class=""lds-dual-ring""></div>
                                    <label *ngIf=""flagListitems==2"">Không có dữ liệu!</label>
                                </td>
                            </tr>
");
            EndContext();
#line 41 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(1908, 111, true);
            WriteLiteral("                                <tr>\r\n                                    <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(2021, 5, false);
#line 47 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                                                     Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2027, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2075, 24, false);
#line 48 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                   Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2099, 107, true);
            WriteLiteral("</td>\r\n                                    \r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 51 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                         if (@Model.ListItems[i].Status)
                                        {

#line default
#line hidden
            BeginContext(2323, 49, true);
            WriteLiteral("                                            <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2372, "\"", 2445, 5);
            WriteAttributeValue("", 2382, "UpdateStatus(\'", 2382, 14, true);
#line 53 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
WriteAttributeValue("", 2396, ControllerName, 2396, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2411, "\',\'", 2411, 3, true);
#line 53 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
WriteAttributeValue("", 2414, Model.ListItems[i].Ids, 2414, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2437, "\',false)", 2437, 8, true);
            EndWriteAttribute();
            BeginContext(2446, 57, true);
            WriteLiteral(" class=\"fas fa-check-circle\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 54 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2635, 49, true);
            WriteLiteral("                                            <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2684, "\"", 2756, 5);
            WriteAttributeValue("", 2694, "UpdateStatus(\'", 2694, 14, true);
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
WriteAttributeValue("", 2708, ControllerName, 2708, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2723, "\',\'", 2723, 3, true);
#line 57 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
WriteAttributeValue("", 2726, Model.ListItems[i].Ids, 2726, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2749, "\',true)", 2749, 7, true);
            EndWriteAttribute();
            BeginContext(2757, 58, true);
            WriteLiteral(" class=\"far fa-times-circle\" aria-hidden=\"false\"></span>\r\n");
            EndContext();
#line 58 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2858, 83, true);
            WriteLiteral("                                    </td>\r\n                                    <td>");
            EndContext();
            BeginContext(2942, 30, false);
#line 60 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                   Write(Model.ListItems[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(2972, 195, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <ul class=\"list-inline action\">\r\n                                            <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3167, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6490838bb497d639c5086291339e3b629f72c3dd15398", async() => {
                BeginContext(3264, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
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
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
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
            BeginContext(3297, 145, true);
            WriteLiteral("</li>\r\n                                            <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(3443, 24, false);
#line 64 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                                                                                                                     Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(3467, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(3480, 22, false);
#line 64 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                                                                                                                                                                          Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(3502, 172, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                                        </ul>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 68 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(3732, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(3808, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6490838bb497d639c5086291339e3b629f72c3dd20157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 74 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
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
            BeginContext(3898, 75, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(3974, 63, false);
#line 77 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DMLoaiCoQuan\Index.cshtml"
           Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4037, 60, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.DMLoaiCoQuan.DMLoaiCoQuanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
