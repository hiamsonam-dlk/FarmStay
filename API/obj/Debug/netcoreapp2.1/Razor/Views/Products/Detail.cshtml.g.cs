#pragma checksum "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0f332f0e4e23013bbf2dce77c2c33ac09a4a3e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Detail), @"mvc.1.0.view", @"/Views/Products/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Detail.cshtml", typeof(AspNetCore.Views_Products_Detail))]
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
#line 2 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0f332f0e4e23013bbf2dce77c2c33ac09a4a3e0", @"/Views/Products/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Products.ProductsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/noimage.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("khungAnhCrop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = (Model.Item.Title);
    ViewData["Description"] = (Model.Item.Metadesc);
    ViewData["Keywords"] = (Model.Item.Metakey);
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();


#line default
#line hidden
            BeginContext(335, 247, true);
            WriteLiteral("\r\n<div class=\"navigation\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <ul class=\"list-inline  nlist\">\r\n                    <li>\r\n                        <a href=\"/\">Trang chủ</a>\r\n");
            EndContext();
#line 18 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                         if (!Model.Item.StaticPage)
                        {

#line default
#line hidden
            BeginContext(663, 91, true);
            WriteLiteral("                            <i class=\"fa fa-angle-right\"></i>\r\n                            ");
            EndContext();
            BeginContext(754, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f332f0e4e23013bbf2dce77c2c33ac09a4a3e06429", async() => {
                BeginContext(882, 22, false);
#line 21 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                                                                                                      Write(Model.Categories.Title);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                              WriteLiteral(Model.Categories.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 21 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                                                                     WriteLiteral(Model.Categories.Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(909, 65, true);
            WriteLiteral("\r\n                            <i class=\"fa fa-angle-right\"></i>\r\n");
            EndContext();
            BeginContext(1003, 16, false);
#line 23 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                       Write(Model.Item.Title);

#line default
#line hidden
            EndContext();
#line 23 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1105, 63, true);
            WriteLiteral("                            <i class=\"fa fa-angle-right\"></i>\r\n");
            EndContext();
            BeginContext(1197, 16, false);
#line 28 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                       Write(Model.Item.Title);

#line default
#line hidden
            EndContext();
#line 28 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                             
                        }

#line default
#line hidden
            BeginContext(1242, 440, true);
            WriteLiteral(@"                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>


<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""row ProductDetail"">
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <ul id=""ProductGallery"" class=""gallery list-unstyled cS-hidden"">
                        <li data-thumb=""/Home/ResizeImage?url=");
            EndContext();
            BeginContext(1683, 17, false);
#line 44 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                         Write(Model.Item.Images);

#line default
#line hidden
            EndContext();
            BeginContext(1700, 56, true);
            WriteLiteral("&width=100&height=67\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1756, "\"", 1823, 3);
            WriteAttributeValue("", 1762, "/Home/ResizeImage?url=", 1762, 22, true);
#line 45 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
WriteAttributeValue("", 1784, Model.Item.Images, 1784, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 1802, "&width=600&height=400", 1802, 21, true);
            EndWriteAttribute();
            BeginContext(1824, 36, true);
            WriteLiteral(" />\r\n                        </li>\r\n");
            EndContext();
#line 47 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                         if (Model.Item.ListFile != null && Model.Item.ListFile.Count > 0)
                        {
                            

#line default
#line hidden
#line 49 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                             for (int j = 0; j < Model.Item.ListFile.Count(); j++)
                            {

#line default
#line hidden
            BeginContext(2094, 70, true);
            WriteLiteral("                                <li data-thumb=\"/Home/ResizeImage?url=");
            EndContext();
            BeginContext(2165, 31, false);
#line 51 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                 Write(Model.Item.ListFile[j].FilePath);

#line default
#line hidden
            EndContext();
            BeginContext(2196, 64, true);
            WriteLiteral("&width=100&height=67\">\r\n                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2260, "\"", 2341, 3);
            WriteAttributeValue("", 2266, "/Home/ResizeImage?url=", 2266, 22, true);
#line 52 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
WriteAttributeValue("", 2288, Model.Item.ListFile[j].FilePath, 2288, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 2320, "&width=600&height=400", 2320, 21, true);
            EndWriteAttribute();
            BeginContext(2342, 44, true);
            WriteLiteral(" />\r\n                                </li>\r\n");
            EndContext();
#line 54 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                            }

#line default
#line hidden
#line 54 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(2444, 269, true);
            WriteLiteral(@"

                    </ul>
                </div>

                <div class=""col-lg-7 col-md-6 col-sm-12"">
                    <div class=""row"">
                        <div class=""col-md-12 article-body"">
                            <h1 class=""ProductName"">");
            EndContext();
            BeginContext(2715, 16, false);
#line 64 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                Write(Model.Item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2732, 54, true);
            WriteLiteral("</h1>\r\n                            <p class=\"price\">\r\n");
            EndContext();
#line 66 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                 if (Model.Item.Price != null)
                                {

#line default
#line hidden
            BeginContext(2885, 48, true);
            WriteLiteral("                                    <span> Giá: ");
            EndContext();
            BeginContext(2934, 45, false);
#line 68 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                           Write(string.Format("{0:#,##0}", @Model.Item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2979, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 69 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3096, 63, true);
            WriteLiteral("                                    <span>Giá: liên hệ</span>\r\n");
            EndContext();
#line 73 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                }

#line default
#line hidden
            BeginContext(3194, 111, true);
            WriteLiteral("                            </p>\r\n                            <p class=\"ovv\">\r\n                                ");
            EndContext();
            BeginContext(3306, 20, false);
#line 76 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                           Write(Model.Item.IntroText);

#line default
#line hidden
            EndContext();
            BeginContext(3326, 290, true);
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""col-md-12"">
                            <ul class=""list-inline"">
                                <li class=""list-inline-item"">
                                    <input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3616, "\"", 3638, 1);
#line 82 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
WriteAttributeValue("", 3624, Model.Item.Id, 3624, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3639, 322, true);
            WriteLiteral(@" id=""txtProductId"" />
                                    <input type=""number"" value=""1"" class=""form-control"" min=""1"" id=""txtQuantity"" />
                                </li>
                                <li class=""list-inline-item"">
                                    <input type=""button"" class=""btn btn-warning""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3961, "\"", 4012, 1);
#line 86 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
WriteAttributeValue("", 3969, Model.Item.CatId==1?"Đăng ký":"Đặt hàng", 3969, 43, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4013, 339, true);
            WriteLiteral(@" id=""btnAddcart"" />
                                </li>
                            </ul>
                            <div id=""txtErr"" class=""mt-3""> </div>
                        </div>
                    </div>
                </div>


                <div class=""col-12"">
                    <h4 class=""headTitle"">Chi tiết ");
            EndContext();
            BeginContext(4354, 46, false);
#line 96 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                               Write(Model.Item.CatId == 1 ? "dịch vụ" : "sản phẩm");

#line default
#line hidden
            EndContext();
            BeginContext(4401, 75, true);
            WriteLiteral("</h4>\r\n                    <div class=\"FullText\">\r\n                        ");
            EndContext();
            BeginContext(4477, 29, false);
#line 98 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                   Write(Html.Raw(Model.Item.FullText));

#line default
#line hidden
            EndContext();
            BeginContext(4506, 58, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n\r\n");
            EndContext();
            BeginContext(4599, 82, true);
            WriteLiteral("\r\n                <div class=\"col-12\">\r\n                    <h4 class=\"headTitle\">");
            EndContext();
            BeginContext(4683, 56, false);
#line 106 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                      Write(Model.Item.CatId == 1 ? "Dịch vụ khác" : "Sản phẩm khác");

#line default
#line hidden
            EndContext();
            BeginContext(4740, 70, true);
            WriteLiteral(" </h4>\r\n                </div>\r\n                <div class=\"col-12\">\r\n");
            EndContext();
#line 109 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                       var ListProduct = Model.ListItems;

#line default
#line hidden
            BeginContext(4870, 147, true);
            WriteLiteral("                    <div class=\"cat-item\">\r\n                        <div class=\"body\">\r\n                            <div class=\"row itemProduct\">\r\n");
            EndContext();
#line 113 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                 for (int i = 0; i < ListProduct.Count(); i++)
                                {

#line default
#line hidden
            BeginContext(5132, 269, true);
            WriteLiteral(@"                                    <div class=""col-lg-3 col-md-3 col-sm-6 col-12"">
                                        <div class=""item hotitem"">
                                            <div class=""khungAnh"">
                                                ");
            EndContext();
            BeginContext(5401, 984, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f332f0e4e23013bbf2dce77c2c33ac09a4a3e021253", async() => {
                BeginContext(5575, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 119 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                     if (ListProduct[i].Images == null || @ListProduct[i].Images == "" || ListProduct[i].Images.ToLower() == "/cms/content/tintuc/")
                                                    {

#line default
#line hidden
                BeginContext(5814, 56, true);
                WriteLiteral("                                                        ");
                EndContext();
                BeginContext(5870, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0f332f0e4e23013bbf2dce77c2c33ac09a4a3e022134", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 121 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 5907, ListProduct[i].Title, 5907, 21, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5943, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 122 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
                BeginContext(6113, 60, true);
                WriteLiteral("                                                        <img");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 6173, "\"", 6200, 1);
#line 125 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
WriteAttributeValue("", 6179, ListProduct[i].Title, 6179, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6201, 13, true);
                WriteLiteral(" class=\"tall\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6214, "\"", 6274, 3);
                WriteAttributeValue("", 6220, "/Home/ResizeImage?url=", 6220, 22, true);
#line 125 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
WriteAttributeValue("", 6242, ListProduct[i].Images, 6242, 22, false);

#line default
#line hidden
                WriteAttributeValue("", 6264, "&width=600", 6264, 10, true);
                EndWriteAttribute();
                BeginContext(6275, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 126 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(6333, 48, true);
                WriteLiteral("                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 118 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                                                                        WriteLiteral(ListProduct[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 118 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                                                                                                             WriteLiteral(ListProduct[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 118 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 5552, ListProduct[i].Title, 5552, 21, false);

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
            BeginContext(6385, 166, true);
            WriteLiteral("\r\n                                            </div>\r\n\r\n                                            <p class=\"name\">\r\n                                                ");
            EndContext();
            BeginContext(6551, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f332f0e4e23013bbf2dce77c2c33ac09a4a3e029238", async() => {
                BeginContext(6704, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(6759, 62, false);
#line 132 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                               Write(API.Models.StringUtilities.Truncate(@ListProduct[i].Title, 70));

#line default
#line hidden
                EndContext();
                BeginContext(6821, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 131 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                                                   WriteLiteral(ListProduct[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 131 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                                                                                                                        WriteLiteral(ListProduct[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 131 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 6681, ListProduct[i].Title, 6681, 21, false);

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
            BeginContext(6875, 148, true);
            WriteLiteral("\r\n                                            </p>\r\n\r\n                                        </div>\r\n\r\n                                    </div>\r\n");
            EndContext();
#line 139 "D:\work\CTY_NUOC\API\Views\Products\Detail.cshtml"
                                }

#line default
#line hidden
            BeginContext(7058, 1940, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>


<script>
    $(document).ready(function () {
        $("".viewFile"").click(function () {
            var url = $(this).attr(""val"");
            $(""#myFrame"").attr(""src"", url);
            $(""#myFrame"").show();


        })

        $('#ProductGallery').lightSlider({
            gallery: true,
            item: 1,
            thumbItem: 9,
            slideMargin: 0,
            speed: 500,
            auto: true,
            loop: true,
            onSliderLoad: function () {
                $('#ProductGallery').removeClass('cS-hidden');
            }
        });

        $(""#btnAddcart"").click(function () {

            var ProductId = $(""#txtProductId"").val();
            var Quantity = $(""#txtQuantity"").val();

            if (Quantity == null || Quantity <= 0) {
                $(""#txtErr"").html(""");
            WriteLiteral(@"<div class='alert alert-danger'>Vui lòng chọn số lượng !</div>"");
            }
            else {
                return $.ajax({
                    type: ""POST"",
                    url: ""/ProductsOrder/AddCart?ProductId="" + ProductId + ""&Quantity="" + Quantity,
                    contentType: ""application/json; charset=utf-8"",
                    dataType: ""json"",
                    success: function (data) {
                        $(""#txtErr"").html(""<div class='alert alert-success'>Thêm vào giỏ hàng thành công ! <a class='text-success' href='/ProductsOrder/'><i class='fas fa-shopping-cart mr-1 ml-2'></i>Xem giỏ hàng</a></div>"");
                    },
                    error: function () {
                        $(""#txtErr"").html(""<div class='alert alert-danger'>Đã có lỗi xảy ra !</div>"");
                    }
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Products.ProductsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
