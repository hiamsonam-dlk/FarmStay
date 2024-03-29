#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4205a9487efaf03035b37fc2dbea05814af8f21b9e0e1a13eb006d0cc7202d89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__PartialPagination), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_PartialPagination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_PartialPagination.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__PartialPagination))]
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
#line 1 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4205a9487efaf03035b37fc2dbea05814af8f21b9e0e1a13eb006d0cc7202d89", @"/Areas/Admin/Views/Shared/_PartialPagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"354159952f87747c1a2715c35c93fa5a5fdedf830348b0cb9841e5003a3ef970", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__PartialPagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Partial.PartialPagination>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
  
    var controllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    string Url = "";
    if (Model.CurrentPage <= 0)
    {
        Model.CurrentPage = 1;
    }

    if (Model.QueryString == null || Model.QueryString == "")
    {
        Url = "";
    }
    else
    {
        string OldUrl = Model.QueryString.Substring(1);


        List<string> ListUrl = OldUrl.Split("&").ToList();
        if (ListUrl != null && ListUrl.Count() > 0)
        {
            for (int i = 0; i < ListUrl.Count(); i++)
            {
                if (ListUrl[i].StartsWith("CurrentPage") == false)
                {
                    if (Url == "")
                    {
                        Url = ListUrl[i];
                    }
                    else
                    {
                        Url = Url + "&" + ListUrl[i];
                    }

                }
            }

        }
    }

    if (Url == "")
    {
        Url = "/Admin/" + @controllerName + "/Index?" + "CurrentPage";
    }
    else
    {
        Url = "/Admin/" + @controllerName + "/Index?" + Url + "&CurrentPage";
    }

    //string Url = "/Admin/" + @controllerName + "/Index"; //+ Model.QueryString + "&CurrentPage";
    decimal Start = 1;
    decimal Links = 12; //Number of frequency links to show at one time ;

    decimal Last = Math.Ceiling(Model.TotalItems / Model.ItemsPerPage);
    decimal End = 1;
    if (Last <= 0)
    {
        Last = 1;
    }
    if ((Model.CurrentPage + Math.Floor(Links / 2)) < Last)
    {
        if ((Model.CurrentPage > Math.Floor(Links / 2)))
        {
            End = Model.CurrentPage + Math.Floor(Links / 2);
        }
        else
        {
            End = Links;

            if (Last < Links)
            {
                End = Last;
            }
        }
    }
    else
    {

        End = Last;
    }

    if ((Model.CurrentPage - Math.Floor(Links / 2)) > 1)
    {
        if ((Model.CurrentPage > Math.Floor(Links / 2)))
        {
            Start = Model.CurrentPage - Math.Floor(Links / 2);
            if ((End - Start) < Links)
            {
                Start = End - Links + 1;
            }

        }

    }

    if (Start < 1)
    {
        Start = 1;
    }

#line default
#line hidden
            BeginContext(2386, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 102 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
 if (Last <= 1)
{

}
else
{

#line default
#line hidden
            BeginContext(2422, 81, true);
            WriteLiteral("    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n");
            EndContext();
#line 110 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage == 1)
            {

#line default
#line hidden
            BeginContext(2560, 67, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2627, "\"", 2640, 2);
#line 112 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 2634, Url, 2634, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2638, "=1", 2638, 2, true);
            EndWriteAttribute();
            BeginContext(2641, 15, true);
            WriteLiteral(">Đầu</a></li>\r\n");
            EndContext();
#line 113 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2704, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2762, "\"", 2775, 2);
#line 116 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 2769, Url, 2769, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2773, "=1", 2773, 2, true);
            EndWriteAttribute();
            BeginContext(2776, 15, true);
            WriteLiteral(">Đầu</a></li>\r\n");
            EndContext();
#line 117 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(2806, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 119 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage > 1 && Last > 1)
            {

#line default
#line hidden
            BeginContext(2876, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2934, "\"", 2947, 2);
#line 121 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 2941, Url, 2941, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2945, "=1", 2945, 2, true);
            EndWriteAttribute();
            BeginContext(2948, 51, true);
            WriteLiteral("><span aria-hidden=\"true\">&laquo;</span></a></li>\r\n");
            EndContext();
#line 122 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3047, 67, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3114, "\"", 3127, 2);
#line 125 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 3121, Url, 3121, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 3125, "=1", 3125, 2, true);
            EndWriteAttribute();
            BeginContext(3128, 51, true);
            WriteLiteral("><span aria-hidden=\"true\">&laquo;</span></a></li>\r\n");
            EndContext();
#line 126 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(3194, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 129 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
             for (decimal i = Start; i <= End; i++)
            {
                if (i == Model.CurrentPage)
                {

#line default
#line hidden
            BeginContext(3330, 125, true);
            WriteLiteral("                    <li class=\"page-item active\" aria-current=\"page\">\r\n                        <a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(3456, 1, false);
#line 134 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3457, 72, true);
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                    </li>\r\n");
            EndContext();
#line 136 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3589, 62, true);
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3651, "\"", 3665, 3);
#line 139 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 3658, Url, 3658, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 3662, "=", 3662, 1, true);
#line 139 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 3663, i, 3663, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3666, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3668, 1, false);
#line 139 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3669, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 140 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
                }

            }

#line default
#line hidden
#line 143 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage < Last && Last > 1)
            {

#line default
#line hidden
            BeginContext(3787, 118, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\" href=\"#\"><span aria-hidden=\"true\">&raquo;</span></a></li>\r\n");
            EndContext();
#line 146 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3953, 127, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\" href=\"#\"><span aria-hidden=\"true\">&raquo;</span></a></li>\r\n");
            EndContext();
#line 150 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(4095, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 152 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage == Last)
            {


#line default
#line hidden
            BeginContext(4159, 92, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\" href=\"#\">Cuối</a></li>\r\n");
            EndContext();
#line 156 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4299, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4357, "\"", 4374, 3);
#line 159 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 4364, Url, 4364, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 4368, "=", 4368, 1, true);
#line 159 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 4369, Last, 4369, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4375, 16, true);
            WriteLiteral(">Cuối</a></li>\r\n");
            EndContext();
#line 160 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(4406, 29, true);
            WriteLiteral("\r\n        </ul>\r\n    </nav>\r\n");
            EndContext();
#line 164 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialPagination.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.Partial.PartialPagination> Html { get; private set; }
    }
}
#pragma warning restore 1591
