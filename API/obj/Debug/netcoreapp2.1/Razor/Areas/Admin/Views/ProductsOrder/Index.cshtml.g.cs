#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76828e035e8b88b8d092eef8b04ba6d49d7155e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductsOrder_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductsOrder/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductsOrder/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductsOrder_Index))]
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
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
using API.Areas.Admin.Models.ProductsOrder;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76828e035e8b88b8d092eef8b04ba6d49d7155e9", @"/Areas/Admin/Views/ProductsOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductsOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.ProductsOrder.ProductsOrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialMsgInfoAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Keyword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Tìm kiếm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Status", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MySearchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AjaxDeleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Quản lý đơn hàng";

    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    var ListItemsStatus = ProductsOrderService.GetListItemsStatus();

#line default
#line hidden
            BeginContext(352, 166, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h4><i class=\"fas fa-table\"></i> Quản lý đơn hàng</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(518, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76828e035e8b88b8d092eef8b04ba6d49d7155e98590", async() => {
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
            BeginContext(557, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(567, 1040, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76828e035e8b88b8d092eef8b04ba6d49d7155e99855", async() => {
                BeginContext(656, 143, true);
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(799, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "76828e035e8b88b8d092eef8b04ba6d49d7155e910391", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchData.Keyword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(896, 114, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-3\">\r\n                    ");
                EndContext();
                BeginContext(1010, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76828e035e8b88b8d092eef8b04ba6d49d7155e912496", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 25 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchData.Status);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 25 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ListItemsStatus;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1118, 482, true);
                WriteLiteral(@"
                </div>
                <div class=""col-lg-4"">
                    <div class=""form-row align-items-center"">

                        <div class=""col-auto"">
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary"">Tìm Kiếm</button>
                            </div>
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
#line 17 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                  WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1607, 669, true);
            WriteLiteral(@"
        <div class=""row"">

            <div class=""col-lg-12"">

                <table class=""table table-bordered table-striped table-hover "">
                    <thead>
                        <tr>
                            <th width=""50px"" class=""text-center"">#</th>
                            <th>Tên</th>
                            <th>Điện thoại</th>
                            <th>Địa chỉ</th>
                            <th width=""150px"" class=""text-center"">Ngày đặt hàng</th>
                            <th width=""100px"">Trạng Thái</th>
                            <th width=""130px"" class=""btn-contain"">
                                ");
            EndContext();
            BeginContext(2276, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76828e035e8b88b8d092eef8b04ba6d49d7155e918163", async() => {
                BeginContext(2358, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 55 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                                       WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2370, 129, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
            EndContext();
#line 61 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                         if (Model.ListItems == null || Model.ListItems.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(2613, 248, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"7\" class=\"text-center\">\r\n                                    <label>Không có dữ liệu!</label>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 68 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                        }
                        else
                        {
                            for (int i = 0; i < Model.ListItems.Count(); i++)
                            {

#line default
#line hidden
            BeginContext(3055, 103, true);
            WriteLiteral("                            <tr>\r\n                                <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(3160, 5, false);
#line 74 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                                                                 Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(3166, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3210, 23, false);
#line 75 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                               Write(Model.ListItems[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(3233, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3277, 24, false);
#line 76 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                               Write(Model.ListItems[i].Phone);

#line default
#line hidden
            EndContext();
            BeginContext(3301, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3345, 26, false);
#line 77 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                               Write(Model.ListItems[i].Address);

#line default
#line hidden
            EndContext();
            BeginContext(3371, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3453, 89, false);
#line 79 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                               Write(DateTime.Parse(Model.ListItems[i].CreatedDate.ToString()).ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(3542, 140, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"text-center\">\r\n                                    <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3682, "\"", 3837, 3);
            WriteAttributeValue("", 3690, "badge", 3690, 5, true);
            WriteAttributeValue(" ", 3695, "badge-", 3696, 7, true);
#line 82 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
WriteAttributeValue("", 3702, @Model.ListItems[i].Status==3?"secondary":(@Model.ListItems[i].Status==2?"primary":(@Model.ListItems[i].Status==1?"warning":"info")), 3702, 135, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3838, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(3841, 62, false);
#line 82 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                                                                                                                                                                                                  Write(ProductsOrderService.GetTextStatus(@Model.ListItems[i].Status));

#line default
#line hidden
            EndContext();
            BeginContext(3903, 294, true);
            WriteLiteral(@"</span>
                                   
                                </td>
                               
                                <td>
                                    <ul class=""list-inline action"">
                                        <li class=""list-inline-item"">");
            EndContext();
            BeginContext(4197, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76828e035e8b88b8d092eef8b04ba6d49d7155e925172", async() => {
                BeginContext(4294, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 88 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                                                                            WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
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
            BeginContext(4327, 141, true);
            WriteLiteral("</li>\r\n                                        <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(4469, 23, false);
#line 89 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                                                                                                                                 Write(Model.ListItems[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(4492, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(4505, 22, false);
#line 89 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                                                                                                                                                                     Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(4527, 160, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 93 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4745, 76, true);
            WriteLiteral("\r\n                    </tbody>\r\n\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(4821, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76828e035e8b88b8d092eef8b04ba6d49d7155e929902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 99 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
                          WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4911, 75, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-12\">\r\n                ");
            EndContext();
            BeginContext(4987, 63, false);
#line 102 "D:\work\CTY_NUOC\API\Areas\Admin\Views\ProductsOrder\Index.cshtml"
           Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(5050, 162, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    function MySearchForm() {\r\n        jQuery(\"#MySearchForm\").submit();\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.ProductsOrder.ProductsOrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
