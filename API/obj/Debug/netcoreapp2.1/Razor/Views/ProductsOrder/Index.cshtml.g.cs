#pragma checksum "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af6b728622dbc7ffb611e44a56d65065532cf666"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductsOrder_Index), @"mvc.1.0.view", @"/Views/ProductsOrder/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductsOrder/Index.cshtml", typeof(AspNetCore.Views_ProductsOrder_Index))]
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
#line 1 "D:\work\CTY_NUOC\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af6b728622dbc7ffb611e44a56d65065532cf666", @"/Views/ProductsOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductsOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.ProductsOrderDetail.ProductsOrderDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contacs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductsOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Tiến hành đặt hàng"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    var chk = int.Parse(TempData["CART"].ToString());

#line default
#line hidden
            BeginContext(266, 330, true);
            WriteLiteral(@"
<div class=""navigation"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  nlist"">
                    <li>
                        <a href=""/"">Trang chủ</a>
                        <i class=""fa fa-angle-right""></i>
                        ");
            EndContext();
            BeginContext(596, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6b728622dbc7ffb611e44a56d65065532cf6667442", async() => {
                BeginContext(643, 8, true);
                WriteLiteral("Giỏ hàng");
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
            BeginContext(655, 141, true);
            WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
#line 29 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
     if (chk == 1)
    {

#line default
#line hidden
            BeginContext(823, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(831, 5559, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6b728622dbc7ffb611e44a56d65065532cf6669417", async() => {
                BeginContext(913, 988, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-12"">
                    <table class=""table table-bordered ProductsOrderTbl"">
                        <thead>
                            <tr>
                                <th style=""width:50px"">

                                </th>
                                <th>
                                    Tên sản phẩm
                                </th>
                                <th width=""150px"" class=""text-center"">
                                    Giá
                                </th>
                                <th width=""100px"" class=""text-center"">
                                    Số lượng
                                </th>
                                <th class=""text-center"">
                                    Tổng
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 55 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                               var i = 0;

#line default
#line hidden
#line 56 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                             foreach (var item in Model.ListItems)
                            {

#line default
#line hidden
                BeginContext(2044, 181, true);
                WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <input type=\"hidden\" class=\"txtProductId\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2225, "\"", 2256, 3);
                WriteAttributeValue("", 2232, "listUpdate[", 2232, 11, true);
#line 60 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
WriteAttributeValue("", 2243, i, 2243, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2245, "].ProductId", 2245, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2257, "\"", 2280, 1);
#line 60 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
WriteAttributeValue("", 2265, item.ProductId, 2265, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2281, 250, true);
                WriteLiteral(" />\r\n                                        <a href=\"#\" class=\"text-danger removeItem\"> <i class=\"fas fa-trash\"></i></a>\r\n                                    </td>\r\n                                    <td>\r\n\r\n                                        ");
                EndContext();
                BeginContext(2531, 272, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6b728622dbc7ffb611e44a56d65065532cf66612530", async() => {
                    BeginContext(2701, 46, true);
                    WriteLiteral("\r\n                                            ");
                    EndContext();
                    BeginContext(2748, 9, false);
#line 66 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(2757, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 65 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 65 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                                                                                                             WriteLiteral(API.Models.StringUtilities.ToNameRewrite(item.Name));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 65 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
AddHtmlAttributeValue("", 2689, item.Name, 2689, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2803, 147, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
                EndContext();
                BeginContext(2951, 38, false);
#line 70 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                   Write(string.Format("{0:#,##0}", item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(2989, 212, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <input type=\"number\" class=\"form-control text-center txtQuantity\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 3201, "\"", 3231, 3);
                WriteAttributeValue("", 3208, "listUpdate[", 3208, 11, true);
#line 73 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
WriteAttributeValue("", 3219, i, 3219, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 3221, "].Quantity", 3221, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3232, "\"", 3254, 1);
#line 73 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
WriteAttributeValue("", 3240, item.Quantity, 3240, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3255, 152, true);
                WriteLiteral(" />\r\n\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
                EndContext();
                BeginContext(3408, 54, false);
#line 77 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                   Write(string.Format("{0:#,##0}", item.Price * item.Quantity));

#line default
#line hidden
                EndContext();
                BeginContext(3462, 84, true);
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 80 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                i = i + 1;
                            }

#line default
#line hidden
                BeginContext(3621, 123, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                    <div id=\"txtErr\" class=\"mt-1 mb-1\">\r\n");
                EndContext();
#line 86 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                         if (TempData["MessageSuccess"] != null)
                        {

#line default
#line hidden
                BeginContext(3837, 136, true);
                WriteLiteral("                            <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                                ");
                EndContext();
                BeginContext(3974, 26, false);
#line 89 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                           Write(TempData["MessageSuccess"]);

#line default
#line hidden
                EndContext();
                BeginContext(4000, 268, true);
                WriteLiteral(@"
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
");
                EndContext();
#line 94 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(4295, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 96 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                         if (TempData["MessageError"] != null)
                        {

#line default
#line hidden
                BeginContext(4388, 135, true);
                WriteLiteral("                            <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n                                ");
                EndContext();
                BeginContext(4524, 24, false);
#line 99 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                           Write(TempData["MessageError"]);

#line default
#line hidden
                EndContext();
                BeginContext(4548, 268, true);
                WriteLiteral(@"
                                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
");
                EndContext();
#line 104 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(4843, 163, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row mt-2 mb-3\">\r\n                <div class=\"col-md-12 col-lg-6\">\r\n");
                EndContext();
#line 110 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                     if (Model.ListItems.Count != null && Model.ListItems.Count > 0)
                    {

#line default
#line hidden
                BeginContext(5115, 379, true);
                WriteLiteral(@"                        <ul class=""list-inline"">
                            <li class=""list-inline-item"">
                                <a href=""#"" id=""btnUpdatecart"" class=""btn btn-warning""> <i class=""fas fa-save mr-1""></i> Cập nhật giỏ hàng</a>
                            </li>
                            <li class=""list-inline-item"">
                                ");
                EndContext();
                BeginContext(5494, 232, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af6b728622dbc7ffb611e44a56d65065532cf66623020", async() => {
                    BeginContext(5601, 121, true);
                    WriteLiteral("\r\n                                    <i class=\"fas fa-shopping-bag mr-1\"></i> Đặt hàng\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5726, 68, true);
                WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n");
                EndContext();
#line 122 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(5817, 74, true);
                WriteLiteral("                </div>\r\n                <div class=\"col-md-12 col-lg-6\">\r\n");
                EndContext();
#line 125 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                      
                        decimal total = 0;
                        

#line default
#line hidden
#line 127 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                         foreach (var item in Model.ListItems)
                        {
                            total = total + (decimal)(item.Quantity * item.Price);
                        }

#line default
#line hidden
                BeginContext(6161, 90, true);
                WriteLiteral("                        <h5 class=\"text-right\"><strong>Tổng đơn hàng: <span id=\"SumTotal\">");
                EndContext();
                BeginContext(6252, 33, false);
#line 131 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
                                                                                     Write(string.Format("{0:#,##0}", total));

#line default
#line hidden
                EndContext();
                BeginContext(6285, 23, true);
                WriteLiteral("</span></strong></h5>\r\n");
                EndContext();
                BeginContext(6331, 52, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
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
            BeginContext(6390, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 136 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(6416, 341, true);
            WriteLiteral(@"        <div class=""jumbotron"">
            <h3 class=""display-5"">Giỏ hàng rỗng!</h3>
            <p>Vui lòng chọn thêm sản phẩm.</p>
            <hr class=""my-4"">
          
            <p class=""lead"">
                <a class=""btn btn-primary btn-lg"" href=""/"" role=""button"">Quay lại trang chủ</a>
            </p>
        </div>
");
            EndContext();
#line 148 "D:\work\CTY_NUOC\API\Views\ProductsOrder\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(6764, 1622, true);
            WriteLiteral(@"</div>





<script>
    $(document).ready(function () {


        $("".removeItem"").click(function () {
            var ProductId = $(this).parent().find("".txtProductId"").val();
            var row = $(this).parent().parent();
              return $.ajax({
                            type: ""POST"",
                            url: ""/ProductsOrder/RemoveItemCart?ProductId="" + ProductId,
                            contentType: ""application/json; charset=utf-8"",
                            dataType: ""json"",
                            success: function (data) {                                
                                window.location.reload();
                            },
                            error: function () {
                                window.location.reload();
                            }
                        });
        })


        $(""#btnUpdatecart"").click(function () {
            var check =1;
            $('.ProductsOrderTbl tbody tr').each(functio");
            WriteLiteral(@"n (index, value) {
                var ProductId = $(this).find("".txtProductId"").val();
                var Quantity = $(this).find("".txtQuantity"").val();
                if (Quantity == null || Quantity <= 0) {
                        check=0                      
                    }
                    
            });
            if (check == 0) {
                $(""#txtErr"").html(""<div class='alert alert-danger'>Số lượng phải lớn hơn 0.</div>"");
              
            } else {
                $(""#myForm"").submit();
            }
        })

    })
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.ProductsOrderDetail.ProductsOrderDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
