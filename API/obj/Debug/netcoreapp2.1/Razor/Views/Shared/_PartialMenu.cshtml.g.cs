#pragma checksum "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c834f485184018c43899f55b0fd54d2f78e166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialMenu), @"mvc.1.0.view", @"/Views/Shared/_PartialMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialMenu.cshtml", typeof(AspNetCore.Views_Shared__PartialMenu))]
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
#line 1 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
using API.Areas.Admin.Models.Menus;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
using API.Controllers;

#line default
#line hidden
#line 3 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 4 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c834f485184018c43899f55b0fd54d2f78e166", @"/Views/Shared/_PartialMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetByCat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
  
    int IdCoQuan = 1;
    if (Context.Session.GetString("IdCoQuan") != null && Context.Session.GetString("IdCoQuan") != "") {
        IdCoQuan = int.Parse(Context.Session.GetString("IdCoQuan"));
    }
    var ListMenu = MenusService.GetListByParrent(0,IdCoQuan,0);
    string css_class = "";
    int CartCount = 0;

#line default
#line hidden
            BeginContext(451, 62, true);
            WriteLiteral("\r\n<div class=\"stellarnav\">\r\n\r\n    <ul class=\"nav\">\r\n        \r\n");
            EndContext();
#line 19 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
         for (int i = 0; i < ListMenu.Count(); i++)
        {

            if (i == 0)
            {
                css_class = "first";
            }
            else if (i == (ListMenu.Count() - 1))
            {
                css_class = "last";
            }
            else {
                css_class = "";
            }
            if (ListMenu[i].ChildCount > 0)
            {
                

#line default
#line hidden
            BeginContext(935, 57, false);
#line 35 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
           Write(await Html.PartialAsync("_PartialMenuChild", ListMenu[i]));

#line default
#line hidden
            EndContext();
#line 35 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                          ;
            }
            else
            {
                if (ListMenu[i].Link != null)
                {

#line default
#line hidden
            BeginContext(1109, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1132, "\"", 1178, 1);
#line 41 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1140, ListMenu[i].Position==2?"xsshow":"", 1140, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1179, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1182, "\"", 1200, 1);
#line 41 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1190, css_class, 1190, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1201, "\"", 1227, 1);
#line 41 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1208, ListMenu[i].Link, 1208, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1228, 4, true);
            WriteLiteral("> <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1232, "\"", 1259, 1);
#line 41 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1240, ListMenu[i].Icon, 1240, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1260, 5, true);
            WriteLiteral("></i>");
            EndContext();
            BeginContext(1267, 17, false);
#line 41 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                                        Write(ListMenu[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 12, true);
            WriteLiteral(" </a></li>\r\n");
            EndContext();
#line 42 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                }
                else if (ListMenu[i].ArticleId != 0)
                {

#line default
#line hidden
            BeginContext(1389, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1412, "\"", 1458, 1);
#line 45 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1420, ListMenu[i].Position==2?"xsshow":"", 1420, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1459, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1460, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0c834f485184018c43899f55b0fd54d2f78e1668874", async() => {
                BeginContext(1604, 3, true);
                WriteLiteral(" <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1607, "\"", 1634, 1);
#line 45 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1615, ListMenu[i].Icon, 1615, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1635, 5, true);
                WriteLiteral("></i>");
                EndContext();
                BeginContext(1642, 17, false);
#line 45 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                                                                                                                                       Write(ListMenu[i].Title);

#line default
#line hidden
                EndContext();
                BeginContext(1660, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 45 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
AddHtmlAttributeValue("", 1470, css_class, 1470, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                             WriteLiteral(ListMenu[i].ArticleId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 45 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                                                                       WriteLiteral(ListMenu[i].Alias);

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
            BeginContext(1665, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 46 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                }
                else if (ListMenu[i].CatId != 0)
                {

#line default
#line hidden
            BeginContext(1760, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1783, "\"", 1829, 1);
#line 49 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1791, ListMenu[i].Position==2?"xsshow":"", 1791, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1830, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1831, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0c834f485184018c43899f55b0fd54d2f78e16614359", async() => {
                BeginContext(1973, 3, true);
                WriteLiteral(" <i");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1976, "\"", 2003, 1);
#line 49 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 1984, ListMenu[i].Icon, 1984, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2004, 5, true);
                WriteLiteral("></i>");
                EndContext();
                BeginContext(2011, 17, false);
#line 49 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                                                                                                                                     Write(ListMenu[i].Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 49 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
AddHtmlAttributeValue("", 1841, css_class, 1841, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                               WriteLiteral(ListMenu[i].CatId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 49 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                                                                     WriteLiteral(ListMenu[i].Alias);

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
            BeginContext(2033, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 50 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2100, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2123, "\"", 2169, 1);
#line 53 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 2131, ListMenu[i].Position==2?"xsshow":"", 2131, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2170, 3, true);
            WriteLiteral("><a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2173, "\"", 2191, 1);
#line 53 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 2181, css_class, 2181, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2192, 13, true);
            WriteLiteral(" href=\"#\"> <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2205, "\"", 2232, 1);
#line 53 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
WriteAttributeValue("", 2213, ListMenu[i].Icon, 2213, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2233, 5, true);
            WriteLiteral("></i>");
            EndContext();
            BeginContext(2240, 17, false);
#line 53 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                                                                                                                                      Write(ListMenu[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2258, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 54 "D:\work\CTY_NUOC\API\Views\Shared\_PartialMenu.cshtml"
                }
            }
        }

#line default
#line hidden
            BeginContext(2314, 412, true);
            WriteLiteral(@"    </ul>
</div><!-- .stellarnav -->

<script>

    window.onscroll = function () { myFunction() };

    var navbar = document.getElementById(""MainMenu"");
    var sticky = navbar.offsetTop;

    function myFunction() {
        if (window.pageYOffset >= sticky) {
            navbar.classList.add(""sticky"")
        } else {
            navbar.classList.remove(""sticky"");
        }
    }
</script>");
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
