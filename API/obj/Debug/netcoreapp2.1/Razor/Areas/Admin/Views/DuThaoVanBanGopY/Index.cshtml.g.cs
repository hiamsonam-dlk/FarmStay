#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d0d29495b208c879678c53aa27d4374467861d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DuThaoVanBanGopY_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DuThaoVanBanGopY/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/DuThaoVanBanGopY/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_DuThaoVanBanGopY_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d0d29495b208c879678c53aa27d4374467861d", @"/Areas/Admin/Views/DuThaoVanBanGopY/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DuThaoVanBanGopY_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.DuThaoVanBanGopY.DuThaoVanBanGopYModel>
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
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Quản lý Góp ý văn bản dự thảo";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(254, 104, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        \r\n        <h4><i class=\"fas fa-table\"></i> ");
            EndContext();
            BeginContext(359, 17, false);
#line 11 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                                    Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(376, 58, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n\r\n        ");
            EndContext();
            BeginContext(434, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15d0d29495b208c879678c53aa27d4374467861d6249", async() => {
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
            BeginContext(473, 257, true);
            WriteLiteral(@"
        

        <div class=""row"">            
            <div class=""col-12"">
               
                <div class=""alert alert-primary draft_justify"">
                    <p><strong>Danh sách góp ý:</strong> </p>
                    <p>  ");
            EndContext();
            BeginContext(731, 14, false);
#line 23 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                    Write(Model.vb.Title);

#line default
#line hidden
            EndContext();
            BeginContext(745, 721, true);
            WriteLiteral(@"</p>
                  
                </div>
            </div>
            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">STT</th>

                            <th width=""250px"">Họ tên </th>
                            <th width=""150px"">Điện thoại </th>
                            <th>Tiêu đề</th>
                            <th width=""250px"">Ngày gửi </th>
                            <th width=""100px"">Trạng thái</th>
                            <th width=""250px"" class=""btn-contain"">
                                ");
            EndContext();
            BeginContext(1466, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d0d29495b208c879678c53aa27d4374467861d8836", async() => {
                BeginContext(1596, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 40 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-IdDuThao", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                                                                                                  WriteLiteral(Model.SearchData.IdDuThao);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdDuThao"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-IdDuThao", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["IdDuThao"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1608, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 46 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1851, 284, true);
            WriteLiteral(@"                            <tr>
                                <td colspan=""7"" class=""text-center"">                                    
                                    <label>Không có dữ liệu!</label>
                                </td>
                            </tr>
");
            EndContext();
#line 53 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(2329, 103, true);
            WriteLiteral("                            <tr>\r\n                                <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(2434, 5, false);
#line 59 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                                                                 Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2440, 45, true);
            WriteLiteral("</td>\r\n\r\n                                <td>");
            EndContext();
            BeginContext(2486, 27, false);
#line 61 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                               Write(Model.ListItems[i].Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(2513, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2557, 24, false);
#line 62 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                               Write(Model.ListItems[i].Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2581, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2625, 24, false);
#line 63 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                               Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2693, 62, false);
#line 64 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                               Write(Model.ListItems[i].CreatedDate.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(2755, 67, true);
            WriteLiteral("</td>\r\n\r\n                                <td class=\"text-center\">\r\n");
            EndContext();
#line 67 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
             if (@Model.ListItems[i].Status)
            {

#line default
#line hidden
            BeginContext(2883, 21, true);
            WriteLiteral("                <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2904, "\"", 2977, 5);
            WriteAttributeValue("", 2914, "UpdateStatus(\'", 2914, 14, true);
#line 69 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
WriteAttributeValue("", 2928, ControllerName, 2928, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2943, "\',\'", 2943, 3, true);
#line 69 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
WriteAttributeValue("", 2946, Model.ListItems[i].Ids, 2946, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 2969, "\',false)", 2969, 8, true);
            EndWriteAttribute();
            BeginContext(2978, 71, true);
            WriteLiteral("  class=\"fas fa-check-circle text-primary\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 70 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3097, 21, true);
            WriteLiteral("                <span");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3118, "\"", 3190, 5);
            WriteAttributeValue("", 3128, "UpdateStatus(\'", 3128, 14, true);
#line 73 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
WriteAttributeValue("", 3142, ControllerName, 3142, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3157, "\',\'", 3157, 3, true);
#line 73 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
WriteAttributeValue("", 3160, Model.ListItems[i].Ids, 3160, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3183, "\',true)", 3183, 7, true);
            EndWriteAttribute();
            BeginContext(3191, 70, true);
            WriteLiteral(" class=\"far fa-times-circle text-danger\" aria-hidden=\"false\"></span>\r\n");
            EndContext();
#line 74 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3276, 191, true);
            WriteLiteral("        </td>\r\n                                <td>\r\n                                    <ul class=\"list-inline action\">\r\n                                        <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(3467, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d0d29495b208c879678c53aa27d4374467861d18068", async() => {
                BeginContext(3565, 39, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i> Xem chi tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 78 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                                                                                                                                 WriteLiteral(Model.ListItems[i].Ids);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3608, 143, true);
            WriteLiteral("</li>\r\n\r\n                                        <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(3752, 24, false);
#line 80 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                                                                                                                                 Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(3776, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(3789, 22, false);
#line 80 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                                                                                                                                                                      Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(3811, 160, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 84 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4029, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(4105, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d0d29495b208c879678c53aa27d4374467861d22829", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 90 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
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
            BeginContext(4195, 99, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">                    \r\n                    ");
            EndContext();
            BeginContext(4295, 62, false);
#line 93 "D:\work\CTY_NUOC\API\Areas\Admin\Views\DuThaoVanBanGopY\Index.cshtml"
               Write(await Html.PartialAsync("_PartialPagination",Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4357, 60, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.DuThaoVanBanGopY.DuThaoVanBanGopYModel> Html { get; private set; }
    }
}
#pragma warning restore 1591