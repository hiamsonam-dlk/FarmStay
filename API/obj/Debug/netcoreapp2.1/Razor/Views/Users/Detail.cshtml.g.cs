#pragma checksum "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f94665532954e5173370b33d83fa79a748f2f7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Detail), @"mvc.1.0.view", @"/Views/Users/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Detail.cshtml", typeof(AspNetCore.Views_Users_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f94665532954e5173370b33d83fa79a748f2f7b", @"/Views/Users/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.USUsers.USUsersModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile-bg.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/employees-male.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:128px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
  
    ViewData["Title"] = "Đội Ngũ - "+@Model.Item.FullName;
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(208, 157, true);
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <ul class=\"list-inline navigation nlist\">\r\n            <li>\r\n                <a href=\"/\">Trang chủ</a>\r\n                ");
            EndContext();
            BeginContext(365, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f94665532954e5173370b33d83fa79a748f2f7b6479", async() => {
                BeginContext(410, 41, true);
                WriteLiteral("<i class=\"fa fa-angle-right\"></i> Đội ngũ");
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
            BeginContext(455, 52, true);
            WriteLiteral("\r\n                <i class=\"fa fa-angle-right\"></i> ");
            EndContext();
            BeginContext(508, 19, false);
#line 11 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                                             Write(Model.Item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(527, 215, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"row\" id=\"user-detail\">\r\n            <div class=\"col-lg-4\">\r\n                <div class=\"card\">\r\n                    ");
            EndContext();
            BeginContext(742, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f94665532954e5173370b33d83fa79a748f2f7b8723", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(808, 104, true);
            WriteLiteral("\r\n                    <div class=\"card-body text-center\">\r\n                        <div class=\"pro-img\">");
            EndContext();
            BeginContext(912, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f94665532954e5173370b33d83fa79a748f2f7b10169", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
AddHtmlAttributeValue("", 977, Model.Item.FullName, 977, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1022, 38, true);
            WriteLiteral("</div>\r\n\r\n                        <h2>");
            EndContext();
            BeginContext(1061, 19, false);
#line 24 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 35, true);
            WriteLiteral("</h2>\r\n                        <h4>");
            EndContext();
            BeginContext(1116, 16, false);
#line 25 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 34, true);
            WriteLiteral("</h4>\r\n                        <p>");
            EndContext();
            BeginContext(1167, 20, false);
#line 26 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                      Write(Model.Item.TenChucVu);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 283, true);
            WriteLiteral(@"</p>
                    </div>
                </div>


            </div>

            <div class=""col-lg-8"">
                <table class=""table table-bordered"">
                    <tr>
                        <th width=""200px"">Họ Tên</th>
                        <td>");
            EndContext();
            BeginContext(1471, 19, false);
#line 37 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1490, 144, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"200px\">Chức Vụ</th>\r\n                        <td>");
            EndContext();
            BeginContext(1635, 20, false);
#line 41 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.TenChucVu);

#line default
#line hidden
            EndContext();
            BeginContext(1655, 151, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"200px\">Phòng Khoa/Ban</th>\r\n                        <td>");
            EndContext();
            BeginContext(1807, 20, false);
#line 45 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.TenCoQuan);

#line default
#line hidden
            EndContext();
            BeginContext(1827, 142, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"200px\">Email</th>\r\n                        <td>");
            EndContext();
            BeginContext(1970, 16, false);
#line 49 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1986, 147, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"200px\">Chuyên môn</th>\r\n                        <td>");
            EndContext();
            BeginContext(2134, 21, false);
#line 53 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Model.Item.Specialize);

#line default
#line hidden
            EndContext();
            BeginContext(2155, 144, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th width=\"200px\">Tiểu sử</th>\r\n                        <td>");
            EndContext();
            BeginContext(2300, 32, false);
#line 57 "D:\work\CTY_NUOC\API\Views\Users\Detail.cshtml"
                       Write(Html.Raw(Model.Item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 108, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.USUsers.USUsersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591