#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "914222be28852b9714d38bab055db879152386247acac32c4c50c5b34c3ecbd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EN_Views_Shared__PartialNotification), @"mvc.1.0.view", @"/Areas/EN/Views/Shared/_PartialNotification.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EN/Views/Shared/_PartialNotification.cshtml", typeof(AspNetCore.Areas_EN_Views_Shared__PartialNotification))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Areas\EN\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Areas\EN\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
#line 1 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
using API.Areas.Admin.Models.Articles;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
using API.Areas.Admin.Models.CategoriesArticles;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"914222be28852b9714d38bab055db879152386247acac32c4c50c5b34c3ecbd1", @"/Areas/EN/Views/Shared/_PartialNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Areas/EN/_ViewImports.cshtml")]
    public class Areas_EN_Views_Shared__PartialNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
  
  
    API.Areas.Admin.Models.Articles.SearchArticles dto = new API.Areas.Admin.Models.Articles.SearchArticles() { CurrentPage = 1, ItemsPerPage = 5 };
    var listNotification = API.Areas.Admin.Models.Articles.ArticlesService.GetListNotification(dto,"EN");

#line default
#line hidden
            BeginContext(358, 205, true);
            WriteLiteral("\r\n<!--Thông báo-->\r\n<div class=\"marquee\" data-direction=\'up\' data-duration=\'10000\' data-startVisible=\"true\" data-gap=\'10\' data-pauseOnHover=\"false\" data-duplicated=\"true\">\r\n    <ul class=\"list-unstyled\">\r\n");
            EndContext();
#line 12 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
         for (int i = 0; i < listNotification.Count(); i++)
        {

#line default
#line hidden
            BeginContext(635, 101, true);
            WriteLiteral("            <li>\r\n                <div class=\"notifi-item\">\r\n                    <div class=\"date\">\r\n");
            EndContext();
#line 17 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
                          
                            var d = @listNotification[i].PublishUp;
                        

#line default
#line hidden
            BeginContext(860, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(885, 5, false);
#line 20 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
                   Write(d.Day);

#line default
#line hidden
            EndContext();
            BeginContext(890, 69, true);
            WriteLiteral(" <br />\r\n                        <span>\r\n                            ");
            EndContext();
            BeginContext(960, 16, false);
#line 22 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
                       Write(d.ToString("MM"));

#line default
#line hidden
            EndContext();
            BeginContext(976, 85, true);
            WriteLiteral("\r\n                        </span>\r\n\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1061, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "914222be28852b9714d38bab055db879152386247acac32c4c50c5b34c3ecbd16879", async() => {
                BeginContext(1243, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1270, 68, false);
#line 27 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
                   Write(API.Models.StringUtilities.Truncate(@listNotification[i].Title, 120));

#line default
#line hidden
                EndContext();
                BeginContext(1338, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
                                                                                     WriteLiteral(listNotification[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 26 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
                                                                                                                               WriteLiteral(listNotification[i].Alias);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 26 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"
AddHtmlAttributeValue("", 1215, listNotification[i].Title, 1215, 26, false);

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
            BeginContext(1366, 97, true);
            WriteLiteral("\r\n                    <div class=\"clearfix\"></div>\r\n                </div>\r\n\r\n            </li>\r\n");
            EndContext();
#line 34 "D:\code\NGHIA_TRANG\API\Areas\EN\Views\Shared\_PartialNotification.cshtml"

        }

#line default
#line hidden
            BeginContext(1476, 29, true);
            WriteLiteral("    </ul>\r\n\r\n</div>\r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
