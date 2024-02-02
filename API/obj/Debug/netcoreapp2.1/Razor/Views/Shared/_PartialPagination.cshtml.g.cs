#pragma checksum "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94faae5f6ec55fd791bac040eb6a8248352acd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialPagination), @"mvc.1.0.view", @"/Views/Shared/_PartialPagination.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialPagination.cshtml", typeof(AspNetCore.Views_Shared__PartialPagination))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94faae5f6ec55fd791bac040eb6a8248352acd5", @"/Views/Shared/_PartialPagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596ee91360b297ff619c22751a25970a765dc05e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialPagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.Partial.PartialPagination>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
  
    var controllerName = this.ViewContext.RouteData.Values["controller"].ToString();
    var actionName = this.ViewContext.RouteData.Values["action"].ToString();
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
        Url = "?" + "CurrentPage";
    }
    else
    {
        Url = "?" + Url + "&CurrentPage";
    }

    //string Url = "/Admin/" + @controllerName + "/Index"; //+ Model.QueryString + "&CurrentPage";
    decimal Start = 1;
    decimal Links = 10; //Number of frequency links to show at one time ;

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

            if(Last<Links)
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
            BeginContext(2397, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 108 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
 if (Last <= 1)
{

}
else
{



#line default
#line hidden
            BeginContext(2439, 81, true);
            WriteLiteral("    <nav aria-label=\"Page navigation example\">\r\n        <ul class=\"pagination\">\r\n");
            EndContext();
#line 118 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage == 1)
            {

#line default
#line hidden
            BeginContext(2577, 67, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2644, "\"", 2657, 2);
#line 120 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 2651, Url, 2651, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2655, "=1", 2655, 2, true);
            EndWriteAttribute();
            BeginContext(2658, 15, true);
            WriteLiteral(">Đầu</a></li>\r\n");
            EndContext();
#line 121 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2721, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2779, "\"", 2792, 2);
#line 124 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 2786, Url, 2786, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2790, "=1", 2790, 2, true);
            EndWriteAttribute();
            BeginContext(2793, 15, true);
            WriteLiteral(">Đầu</a></li>\r\n");
            EndContext();
#line 125 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(2823, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 127 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage > 1 && Last > 1)
            {

#line default
#line hidden
            BeginContext(2893, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2951, "\"", 2964, 2);
#line 129 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 2958, Url, 2958, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 2962, "=1", 2962, 2, true);
            EndWriteAttribute();
            BeginContext(2965, 51, true);
            WriteLiteral("><span aria-hidden=\"true\">&laquo;</span></a></li>\r\n");
            EndContext();
#line 130 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3064, 67, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3131, "\"", 3144, 2);
#line 133 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 3138, Url, 3138, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 3142, "=1", 3142, 2, true);
            EndWriteAttribute();
            BeginContext(3145, 51, true);
            WriteLiteral("><span aria-hidden=\"true\">&laquo;</span></a></li>\r\n");
            EndContext();
#line 134 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
#line 135 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
             for (decimal i = Start; i <= End; i++)
            {
                if (i == Model.CurrentPage)
                {

#line default
#line hidden
            BeginContext(3343, 125, true);
            WriteLiteral("                    <li class=\"page-item active\" aria-current=\"page\">\r\n                        <a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(3469, 1, false);
#line 140 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3470, 72, true);
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                    </li>\r\n");
            EndContext();
#line 142 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3602, 62, true);
            WriteLiteral("                    <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3664, "\"", 3678, 3);
#line 145 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 3671, Url, 3671, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 3675, "=", 3675, 1, true);
#line 145 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 3676, i, 3676, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3679, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3681, 1, false);
#line 145 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
                                                                         Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3682, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 146 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
                }

            }

#line default
#line hidden
#line 149 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage < Last && Last > 1)
            {

#line default
#line hidden
            BeginContext(3800, 118, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\" href=\"#\"><span aria-hidden=\"true\">&raquo;</span></a></li>\r\n");
            EndContext();
#line 152 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3966, 127, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\" href=\"#\"><span aria-hidden=\"true\">&raquo;</span></a></li>\r\n");
            EndContext();
#line 156 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(4108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 158 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
             if (Model.CurrentPage == Last)
            {


#line default
#line hidden
            BeginContext(4172, 92, true);
            WriteLiteral("                <li class=\"page-item disabled\"><a class=\"page-link\" href=\"#\">Cuối</a></li>\r\n");
            EndContext();
#line 162 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4312, 58, true);
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4370, "\"", 4387, 3);
#line 165 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 4377, Url, 4377, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 4381, "=", 4381, 1, true);
#line 165 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
WriteAttributeValue("", 4382, Last, 4382, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4388, 16, true);
            WriteLiteral(">Cuối</a></li>\r\n");
            EndContext();
#line 166 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
            }

#line default
#line hidden
            BeginContext(4419, 29, true);
            WriteLiteral("\r\n        </ul>\r\n    </nav>\r\n");
            EndContext();
#line 170 "D:\work\CTY_NUOC\API\Views\Shared\_PartialPagination.cshtml"
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
