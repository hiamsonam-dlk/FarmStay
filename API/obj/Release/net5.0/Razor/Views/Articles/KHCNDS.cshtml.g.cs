#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a97fb924759e97225a5543c9afad34d7a89c9e34867bcd21d65e712c4c6c1e83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_KHCNDS), @"mvc.1.0.view", @"/Views/Articles/KHCNDS.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Articles/KHCNDS.cshtml", typeof(AspNetCore.Views_Articles_KHCNDS))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
using API.Areas.Admin.Models.CategoriesArticles;

#line default
#line hidden
#line 3 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
using API.Areas.Admin.Models.Articles;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a97fb924759e97225a5543c9afad34d7a89c9e34867bcd21d65e712c4c6c1e83", @"/Views/Articles/KHCNDS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_KHCNDS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Articles.ArticlesModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/noimage.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
  
    ViewData["Title"] = API.Models.StringUtilities.RemoveHtmlTags(Model.Categories.Title);
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    var listChild = CategoriesArticlesService.GetListChild(Model.Categories.Id, 100);

#line default
#line hidden
            BeginContext(419, 409, true);
            WriteLiteral(@"<style>
    .modal{
    z-index:9999;
    }
    .modal iframe{
        width:100%;
    }
</style>
<div class=""navigation"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  nlist"">
                    <li>
                        <a href=""/"">Trang chủ</a> <i class=""fa fa-angle-right""></i>
                        ");
            EndContext();
            BeginContext(830, 22, false);
#line 24 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                    Write(Model.Categories.Title);

#line default
#line hidden
            EndContext();
            BeginContext(853, 160, true);
            WriteLiteral("\r\n\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 35 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
         for (int j = 0; j < listChild.Count(); j++)
        {


#line default
#line hidden
            BeginContext(1080, 145, true);
            WriteLiteral("            <div class=\"col-lg-12\">\r\n                <fieldset class=\"scheduler-border\">\r\n                    <legend class=\"scheduler-border\">  ");
            EndContext();
            BeginContext(1226, 18, false);
#line 40 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                                  Write(listChild[j].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 11, true);
            WriteLiteral("</legend>\r\n");
            EndContext();
#line 41 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                      
                        var listVideo = ArticlesService.GetListByCatSimple(@listChild[j].Id, 52);
                        var total1 = listVideo.Count;
                        if (total1 > 4)
                        { total1 = 4; }
                    

#line default
#line hidden
            BeginContext(1538, 63, true);
            WriteLiteral("\r\n                    <div class=\"row itemProduct VideoList\">\r\n");
            EndContext();
#line 49 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                         for (int i = 0; i < total1; i++)
                        {

#line default
#line hidden
            BeginContext(1687, 149, true);
            WriteLiteral("                            <div class=\"col-lg-3 col-md-3 col-sm-6 col-12\">\r\n                                <div class=\"item\" style=\"cursor:pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1836, "\"", 1873, 3);
            WriteAttributeValue("", 1846, "OpenPopup(", 1846, 10, true);
#line 52 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 1856, listVideo[i].Id, 1856, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1872, ")", 1872, 1, true);
            EndWriteAttribute();
            BeginContext(1874, 133, true);
            WriteLiteral(">\r\n                                    <div class=\"khungAnh\">\r\n                                        <a class=\"khungAnhCrop img\">\r\n");
            EndContext();
#line 55 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                             if (listVideo[i].Images == null || @listVideo[i].Images == "" || listVideo[i].Images.ToLower() == "/cms/content/tintuc/")
                                            {

#line default
#line hidden
            BeginContext(2222, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(2270, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a97fb924759e97225a5543c9afad34d7a89c9e34867bcd21d65e712c4c6c1e838480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 57 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
AddHtmlAttributeValue("", 2307, listVideo[i].Title, 2307, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2341, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(2487, 52, true);
            WriteLiteral("                                                <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 2539, "\"", 2564, 1);
#line 61 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 2545, listVideo[i].Title, 2545, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2565, 13, true);
            WriteLiteral(" class=\"tall\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2578, "\"", 2636, 3);
            WriteAttributeValue("", 2584, "/Home/ResizeImage?url=", 2584, 22, true);
#line 61 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 2606, listVideo[i].Images, 2606, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 2626, "&width=600", 2626, 10, true);
            EndWriteAttribute();
            BeginContext(2637, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 62 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2687, 235, true);
            WriteLiteral("                                        </a>\r\n                                    </div>\r\n\r\n                                    <p class=\"name\">\r\n                                        <a>\r\n                                            ");
            EndContext();
            BeginContext(2923, 60, false);
#line 68 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                       Write(API.Models.StringUtilities.Truncate(@listVideo[i].Title, 70));

#line default
#line hidden
            EndContext();
            BeginContext(2983, 166, true);
            WriteLiteral("\r\n                                        </a>\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 73 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"

                        }

#line default
#line hidden
            BeginContext(3178, 28, true);
            WriteLiteral("                    </div>\r\n");
            EndContext();
#line 76 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                     if (listVideo.Count > 4)
                    {

#line default
#line hidden
            BeginContext(3276, 827, true);
            WriteLiteral(@"                        <div class=""row itemProduct VideoList"">
                            <div class=""col-12"">
                                <p class=""text-center"">
                                    <a class=""btn btn-secondary"" style=""padding-left:30px; padding-right:30px"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                                        <i class=""fas fa-angle-down mr-1""></i> XEM THÊM
                                    </a>
                                </p>
                            </div>
                            <div class=""col-12"">
                                <hr />
                                <div class=""collapse"" id=""collapseExample"">
                                    <div class=""row"">
");
            EndContext();
#line 90 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                         for (int i = 4; i < listVideo.Count(); i++)
                                        {

#line default
#line hidden
            BeginContext(4232, 343, true);
            WriteLiteral(@"                                            <div class=""col-lg-3 col-md-3 col-sm-6 col-12"">
                                                <div class=""item"">
                                                    <div class=""khungAnh"">
                                                        <a class=""khungAnhCrop img"" style=""cursor:pointer""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4575, "\"", 4612, 3);
            WriteAttributeValue("", 4585, "OpenPopup(", 4585, 10, true);
#line 95 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 4595, listVideo[i].Id, 4595, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 4611, ")", 4611, 1, true);
            EndWriteAttribute();
            BeginContext(4613, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 96 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                                             if (listVideo[i].Images == null || @listVideo[i].Images == "" || listVideo[i].Images.ToLower() == "/cms/content/tintuc/")
                                                            {

#line default
#line hidden
            BeginContext(4863, 64, true);
            WriteLiteral("                                                                ");
            EndContext();
            BeginContext(4927, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a97fb924759e97225a5543c9afad34d7a89c9e34867bcd21d65e712c4c6c1e8315615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 98 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
AddHtmlAttributeValue("", 4964, listVideo[i].Title, 4964, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4998, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
            BeginContext(5192, 68, true);
            WriteLiteral("                                                                <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 5260, "\"", 5285, 1);
#line 102 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 5266, listVideo[i].Title, 5266, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5286, 13, true);
            WriteLiteral(" class=\"tall\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5299, "\"", 5357, 3);
            WriteAttributeValue("", 5305, "/Home/ResizeImage?url=", 5305, 22, true);
#line 102 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 5327, listVideo[i].Images, 5327, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 5347, "&width=600", 5347, 10, true);
            EndWriteAttribute();
            BeginContext(5358, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 103 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(5424, 275, true);
            WriteLiteral(@"                                                        </a>
                                                    </div>

                                                    <p class=""name"">
                                                        <a style=""cursor:pointer""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5699, "\"", 5736, 3);
            WriteAttributeValue("", 5709, "OpenPopup(", 5709, 10, true);
#line 108 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
WriteAttributeValue("", 5719, listVideo[i].Id, 5719, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5735, ")", 5735, 1, true);
            EndWriteAttribute();
            BeginContext(5737, 63, true);
            WriteLiteral(">\r\n                                                            ");
            EndContext();
            BeginContext(5801, 60, false);
#line 109 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                                       Write(API.Models.StringUtilities.Truncate(@listVideo[i].Title, 70));

#line default
#line hidden
            EndContext();
            BeginContext(5861, 230, true);
            WriteLiteral("\r\n                                                        </a>\r\n                                                    </p>\r\n                                                </div>\r\n                                            </div>\r\n");
            EndContext();
#line 114 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6134, 154, true);
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n");
            EndContext();
#line 120 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
                    }

#line default
#line hidden
            BeginContext(6311, 51, true);
            WriteLiteral("\r\n                </fieldset>\r\n            </div>\r\n");
            EndContext();
#line 124 "D:\code\NGHIA_TRANG\API\Views\Articles\KHCNDS.cshtml"
        }

#line default
#line hidden
            BeginContext(6373, 948, true);
            WriteLiteral(@"
    </div>


</div>


<!-- Modal -->
<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-body"">
                <h4 id=""aTitle""></h4>
                <div id=""aContent"">
                    
                </div>
            </div>
        </div>

    </div>
</div>



<script>
  
    function OpenPopup(id) {
        $(""#myModal"").modal();
        return $.ajax({
            type: ""GET"",
            url: ""/Articles/GetDetailJS?id="" + id,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (data) {

                $(""#aTitle"").html(data.Title);
                $(""#aContent"").html(data.FullText);

            },
            error: function () {

            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Articles.ArticlesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591