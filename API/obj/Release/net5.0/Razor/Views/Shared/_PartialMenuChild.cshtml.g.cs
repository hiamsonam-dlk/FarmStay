#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9c7ba9efc5f3d17d9af54d80babf7038b1d714f4737fd0ffbc1429c7c8bc2e7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialMenuChild), @"mvc.1.0.view", @"/Views/Shared/_PartialMenuChild.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialMenuChild.cshtml", typeof(AspNetCore.Views_Shared__PartialMenuChild))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9c7ba9efc5f3d17d9af54d80babf7038b1d714f4737fd0ffbc1429c7c8bc2e7b", @"/Views/Shared/_PartialMenuChild.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialMenuChild : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Menus.Menus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 36, true);
            WriteLiteral("\r\n\r\n<li class=\"nav-item dropdown\">\r\n");
            EndContext();
            BeginContext(228, 103, true);
            WriteLiteral("\r\n    <a class=\"nav-link dropdown-toggle\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 331, "\"", 351, 1);
#line 7 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
WriteAttributeValue("", 338, Model.Link, 338, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(352, 13, true);
            WriteLiteral(">\r\n        <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 365, "\"", 386, 1);
#line 8 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
WriteAttributeValue("", 373, Model.Icon, 373, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(387, 7, true);
            WriteLiteral("></i>\r\n");
            EndContext();
#line 9 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
          
            if (Model.Title.Contains("/"))
            {

#line default
#line hidden
            BeginContext(465, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(488, 25, false);
#line 12 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                 Write(Model.Title.Split("/")[0]);

#line default
#line hidden
            EndContext();
            BeginContext(513, 6, true);
            WriteLiteral("<br />");
            EndContext();
            BeginContext(520, 25, false);
#line 12 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                                                 Write(Model.Title.Split("/")[1]);

#line default
#line hidden
            EndContext();
            BeginContext(545, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 13 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
            }
            else
            {
                

#line default
#line hidden
            BeginContext(619, 11, false);
#line 16 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
#line 16 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                            
            }
        

#line default
#line hidden
            BeginContext(658, 44, true);
            WriteLiteral("    </a>\r\n\r\n    <ul class=\"dropdown-menu\">\r\n");
            EndContext();
#line 22 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
         for (int i = 0; i < Model.ListMenus.Count; i++)
        {
            

#line default
#line hidden
#line 24 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
             if (Model.ListMenus[i].ChildCount > 0)
            {
                

#line default
#line hidden
            BeginContext(856, 64, false);
#line 26 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
           Write(await Html.PartialAsync("_PartialMenuChild", Model.ListMenus[i]));

#line default
#line hidden
            EndContext();
#line 26 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                                                                                 
                ;
            }
            else
            {
                if (Model.ListMenus[i].Link != null)
                {

#line default
#line hidden
            BeginContext(1062, 26, true);
            WriteLiteral("                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1088, "\"", 1121, 1);
#line 33 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
WriteAttributeValue("", 1095, Model.ListMenus[i].Link, 1095, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1122, 25, true);
            WriteLiteral(" class=\"dropdown-item\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1147, "\"", 1181, 1);
#line 33 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
WriteAttributeValue("", 1155, Model.ListMenus[i].Icon, 1155, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1182, 5, true);
            WriteLiteral("></i>");
            EndContext();
            BeginContext(1189, 24, false);
#line 33 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                                                                                                                         Write(Model.ListMenus[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 12, true);
            WriteLiteral("</a></li> \r\n");
            EndContext();
#line 34 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                }
                

#line default
#line hidden
#line 38 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                    
                else
                {

#line default
#line hidden
            BeginContext(1545, 60, true);
            WriteLiteral("                    <li><a href=\"#\" class=\"dropdown-item\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1605, "\"", 1639, 1);
#line 41 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
WriteAttributeValue("", 1613, Model.ListMenus[i].Icon, 1613, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1640, 5, true);
            WriteLiteral("></i>");
            EndContext();
            BeginContext(1647, 24, false);
#line 41 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                                                                                                Write(Model.ListMenus[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(1672, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 42 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
                }

            }

#line default
#line hidden
#line 44 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialMenuChild.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1730, 26, true);
            WriteLiteral("    </ul>\r\n</li>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2819, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Menus.Menus> Html { get; private set; }
    }
}
#pragma warning restore 1591