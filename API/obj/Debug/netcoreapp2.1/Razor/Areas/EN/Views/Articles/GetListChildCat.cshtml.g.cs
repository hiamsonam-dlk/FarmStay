#pragma checksum "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f2444ac31efa8bee792abe2e99e5b580fc8d6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_Articles_GetListChildCat), @"mvc.1.0.view", @"/Areas/EN/Views/Articles/GetListChildCat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/Articles/GetListChildCat.cshtml", typeof(AspNetCore.Areas_EN_Views_Articles_GetListChildCat))]
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
#line 1 "D:\work\CTY_NUOC\API\Areas\EN\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\EN\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f2444ac31efa8bee792abe2e99e5b580fc8d6b", @"/Areas/EN/Views/Articles/GetListChildCat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_Articles_GetListChildCat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Articles.ArticlesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetListChildCat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "13", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "dai-hoc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Đại học"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CMS/Content/TuyenSinh/dai-hoc.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "14", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-alias", "lien-thong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Liên thông"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
  
    Layout = "~/Views/Shared/_Layout_0.cshtml";
    ViewData["Title"] = Model.Categories.Title;
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    List<API.Areas.Admin.Models.Articles.Articles> ListArticles_DH = API.Areas.Admin.Models.Articles.ArticlesService.GetListNew(13,5,1);
    List<API.Areas.Admin.Models.Articles.Articles> ListArticles_LT = API.Areas.Admin.Models.Articles.ArticlesService.GetListNew(14,5,1);
    List<API.Areas.Admin.Models.Articles.Articles> ListArticles_15 = API.Areas.Admin.Models.Articles.ArticlesService.GetListNew(15,5,1);
    List<API.Areas.Admin.Models.Articles.Articles> ListArticles_16 = API.Areas.Admin.Models.Articles.ArticlesService.GetListNew(16,5,1);

#line default
#line hidden
            BeginContext(802, 187, true);
            WriteLiteral("<section id=\"block-view-1\" style=\"margin-top: 0px;\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"title_main_large\">\r\n                <h2 class=\"h2\">");
            EndContext();
            BeginContext(989, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b8593", async() => {
                BeginContext(1107, 7, true);
                WriteLiteral("Đại học");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_3.Value;
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
            BeginContext(1118, 36, true);
            WriteLiteral("</h2>\r\n            </div>\r\n       \r\n");
            EndContext();
#line 20 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
                 if (ListArticles_DH != null && ListArticles_DH.Count() > 0) {
                    for (int i = 0; i < 3; i++) { 


#line default
#line hidden
            BeginContext(1288, 70, true);
            WriteLiteral("                        <div class=\"col-12 col-sm-4 col-md-4 col-lg-4\"");
            EndContext();
            BeginWriteAttribute("itemscope", " itemscope=\"", 1358, "\"", 1370, 0);
            EndWriteAttribute();
            BeginContext(1371, 186, true);
            WriteLiteral(" itemtype=\"https://schema.org/Article\">\r\n                            <div class=\"card\">\r\n                                <a href=\"#\" itemprop=\"url\">\r\n                                    ");
            EndContext();
            BeginContext(1557, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b11859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1642, 748, true);
            WriteLiteral(@"
                                </a>
                                <div class=""card-body"">
                                    <a href=""#"" itemprop=""url"">
                                        <h3 class=""title"" itemprop=""name""> thông báo tuyển sinh thạc sĩ ngành luật học - trường đh luật hà nội năm 2019 </h3>
                                    </a>
                                    <p>
                                        Trên cơ sở nội dung trong thông báo tuyển sinh của khoa luật. Kính đề nghị quý trường ra thông báo chi tiết phát hành rộng rãi đến đối tượng người học
                                    </p>
                                </div>
                            </div>

                        </div>
");
            EndContext();
#line 39 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2432, 210, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n<section id=\"block-view-1-2\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"title_main_large\">\r\n                <h2 class=\"h2\">");
            EndContext();
            BeginContext(2642, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b14534", async() => {
                BeginContext(2766, 10, true);
                WriteLiteral("Liên thông");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_10.Value;
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
            BeginContext(2780, 29, true);
            WriteLiteral("</h2>\r\n            </div>\r\n\r\n");
            EndContext();
#line 55 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
             if (ListArticles_DH != null && ListArticles_DH.Count() > 0)
            {
                for (int i = 0; i < 3; i++)
                {


#line default
#line hidden
            BeginContext(2964, 62, true);
            WriteLiteral("                <div class=\"col-12 col-sm-4 col-md-4 col-lg-4\"");
            EndContext();
            BeginWriteAttribute("itemscope", " itemscope=\"", 3026, "\"", 3038, 0);
            EndWriteAttribute();
            BeginContext(3039, 163, true);
            WriteLiteral(" itemtype=\"https://schema.org/Article\">\r\n                    <div class=\"card\" >\r\n                        <a href=\"#\" itemprop=\"url\">\r\n                            ");
            EndContext();
            BeginContext(3202, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b17791", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3287, 682, true);
            WriteLiteral(@"
                        </a>
                        <div class=""card-body"">
                            <a href=""#"" itemprop=""url"">
                                <h3 class=""title"" itemprop=""name""> thông báo tuyển sinh thạc sĩ ngành luật học - trường đh luật hà nội năm 2019 </h3>
                            </a>
                            <p>
                                Trên cơ sở nội dung trong thông báo tuyển sinh của khoa luật. Kính đề nghị quý trường ra thông báo chi tiết phát hành rộng rãi đến đối tượng người học
                            </p>
                        </div>
                    </div>
                  


                </div>
");
            EndContext();
#line 78 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(4003, 206, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"block-view-1\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"title_main_large\">\r\n                <h2 class=\"h2\">");
            EndContext();
            BeginContext(4209, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b20386", async() => {
                BeginContext(4333, 11, true);
                WriteLiteral("SAU ĐẠI HỌC");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_10.Value;
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
            BeginContext(4348, 29, true);
            WriteLiteral("</h2>\r\n            </div>\r\n\r\n");
            EndContext();
#line 93 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
             if (ListArticles_DH != null && ListArticles_DH.Count() > 0)
            {
                for (int i = 0; i < 3; i++)
                {


#line default
#line hidden
            BeginContext(4532, 66, true);
            WriteLiteral("                    <div class=\"col-12 col-sm-4 col-md-4 col-lg-4\"");
            EndContext();
            BeginWriteAttribute("itemscope", " itemscope=\"", 4598, "\"", 4610, 0);
            EndWriteAttribute();
            BeginContext(4611, 174, true);
            WriteLiteral(" itemtype=\"https://schema.org/Article\">\r\n                        <div class=\"card\">\r\n                            <a href=\"#\" itemprop=\"url\">\r\n                                ");
            EndContext();
            BeginContext(4785, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b23659", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4870, 708, true);
            WriteLiteral(@"
                            </a>
                            <div class=""card-body"">
                                <a href=""#"" itemprop=""url"">
                                    <h3 class=""title"" itemprop=""name""> thông báo tuyển sinh thạc sĩ ngành luật học - trường đh luật hà nội năm 2019 </h3>
                                </a>
                                <p>
                                    Trên cơ sở nội dung trong thông báo tuyển sinh của khoa luật. Kính đề nghị quý trường ra thông báo chi tiết phát hành rộng rãi đến đối tượng người học
                                </p>
                            </div>
                        </div>



                    </div>
");
            EndContext();
#line 116 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(5612, 208, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section id=\"block-view-1-2\">\r\n    <div class=\"container\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"title_main_large\">\r\n                <h2 class=\"h2\">");
            EndContext();
            BeginContext(5820, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b26283", async() => {
                BeginContext(5944, 33, true);
                WriteLiteral("CÁC CHƯƠNG TRÌNH LIÊN KẾT ĐÀO TẠO");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = (string)__tagHelperAttribute_10.Value;
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
            BeginContext(5981, 29, true);
            WriteLiteral("</h2>\r\n            </div>\r\n\r\n");
            EndContext();
#line 131 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
             if (ListArticles_DH != null && ListArticles_DH.Count() > 0)
            {
                for (int i = 0; i < 3; i++)
                {


#line default
#line hidden
            BeginContext(6165, 66, true);
            WriteLiteral("                    <div class=\"col-12 col-sm-4 col-md-4 col-lg-4\"");
            EndContext();
            BeginWriteAttribute("itemscope", " itemscope=\"", 6231, "\"", 6243, 0);
            EndWriteAttribute();
            BeginContext(6244, 174, true);
            WriteLiteral(" itemtype=\"https://schema.org/Article\">\r\n                        <div class=\"card\">\r\n                            <a href=\"#\" itemprop=\"url\">\r\n                                ");
            EndContext();
            BeginContext(6418, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "64f2444ac31efa8bee792abe2e99e5b580fc8d6b29579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6503, 708, true);
            WriteLiteral(@"
                            </a>
                            <div class=""card-body"">
                                <a href=""#"" itemprop=""url"">
                                    <h3 class=""title"" itemprop=""name""> thông báo tuyển sinh thạc sĩ ngành luật học - trường đh luật hà nội năm 2019 </h3>
                                </a>
                                <p>
                                    Trên cơ sở nội dung trong thông báo tuyển sinh của khoa luật. Kính đề nghị quý trường ra thông báo chi tiết phát hành rộng rãi đến đối tượng người học
                                </p>
                            </div>
                        </div>



                    </div>
");
            EndContext();
#line 154 "D:\work\CTY_NUOC\API\Areas\EN\Views\Articles\GetListChildCat.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(7245, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Articles.ArticlesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591