#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\ImportDBOld\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6db63bc599a14785b3f9c654afa863841cc32f99ce78bdadaffe29e2fb2b5bbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ImportDBOld_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ImportDBOld/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ImportDBOld/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_ImportDBOld_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6db63bc599a14785b3f9c654afa863841cc32f99ce78bdadaffe29e2fb2b5bbc", @"/Areas/Admin/Views/ImportDBOld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"354159952f87747c1a2715c35c93fa5a5fdedf830348b0cb9841e5003a3ef970", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ImportDBOld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.ImportDBOld.ImportDBOldModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\ImportDBOld\Index.cshtml"
  
    Layout = "_layoutAdmin";
    ViewData["Title"] = "Index";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
#line 7 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\ImportDBOld\Index.cshtml"
 if (Model.ListItems != null)
{

#line default
#line hidden
            BeginContext(254, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(263, 23, false);
#line 9 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\ImportDBOld\Index.cshtml"
   Write(Model.ListItems.Count());

#line default
#line hidden
            EndContext();
            BeginContext(286, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 10 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\ImportDBOld\Index.cshtml"
}
else {

#line default
#line hidden
            BeginContext(304, 20, true);
            WriteLiteral("<h2>Khong cos</h2>\r\n");
            EndContext();
#line 13 "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\ImportDBOld\Index.cshtml"
}

#line default
#line hidden
            BeginContext(327, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.ImportDBOld.ImportDBOldModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
