#pragma checksum "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "305da20182bdf03261df371e13bf2fc7ded4b4167c0650780c933abacfe3d8d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DuThaoVanBan_Index), @"mvc.1.0.view", @"/Views/DuThaoVanBan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DuThaoVanBan/Index.cshtml", typeof(AspNetCore.Views_DuThaoVanBan_Index))]
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
#line 2 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
using API.Areas.Admin.Models.DuThaoVanBan;

#line default
#line hidden
#line 4 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"305da20182bdf03261df371e13bf2fc7ded4b4167c0650780c933abacfe3d8d9", @"/Views/DuThaoVanBan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_DuThaoVanBan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.DuThaoVanBan.DuThaoVanBanModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DuThaoVanBan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialMsgInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DuThaoVanBanGopY", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
  

    ViewData["Title"] = "Văn bản dự thảo";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(294, 337, true);
            WriteLiteral(@"


<div class=""navigation nlist"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""list-inline  "">
                    <li>
                        <a href=""/"">Trang chủ</a>
                        <i class=""fa fa-angle-right""></i>

                        ");
            EndContext();
            BeginContext(631, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305da20182bdf03261df371e13bf2fc7ded4b4167c0650780c933abacfe3d8d96534", async() => {
                BeginContext(682, 22, true);
                WriteLiteral("Văn bản chờ lấy ý kiến");
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
            BeginContext(708, 721, true);
            WriteLiteral(@"
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>

<div class=""container"">
    <div class=""PageDetail"" style=""padding-top:30px"">


        <div class=""alert alert-primary draft_justify"">
            Hiện nay, Liên đoàn Lao động tỉnh Đắk Lắk đang xây dựng một số Dự thảo Văn bản quy phạm pháp luật. Liên đoàn Lao động tỉnh Đắk Lắk xin giới thiệu toàn văn nội dung các Dự thảo Văn bản quy phạm pháp luật dưới đây để lấy ý kiến đóng góp rộng rãi của các cơ quan, tổ chức, doanh nghiệp và đông đảo người dân trong và ngoài nước.<br>
            Mời bạn đọc nhấn vào các Dự thảo Văn bản quy phạm pháp luật dưới đây để tham gia góp ý.
        </div>

        ");
            EndContext();
            BeginContext(1429, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "305da20182bdf03261df371e13bf2fc7ded4b4167c0650780c933abacfe3d8d98879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1463, 469, true);
            WriteLiteral(@"

        <table class=""table table-bordered myTable"" style=""margin-top: 15px;"">
            <thead>
                <tr>
                    <th width=""50px"">STT</th>
                    <th>Tiêu đề văn bản</th>
                    <th>Hạn góp ý</th>
                    <th width=""150px"" class=""text-center"">Góp ý</th>
                    <th width=""100px"" class=""text-center"">Chi tiết</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 52 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                 if (Model.ListItems == null || Model.ListItems.Count() == 0)
                {

#line default
#line hidden
            BeginContext(2030, 140, true);
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"text-center\">Không có văn bản nào</td>\r\n                    </tr>\r\n");
            EndContext();
#line 57 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                }
                else
                {
                    for (int i = 0; i < Model.ListItems.Count(); i++)
                    {


#line default
#line hidden
            BeginContext(2326, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2390, 5, false);
#line 64 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2396, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2470, 24, false);
#line 66 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                           Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2494, 61, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(2556, 53, false);
#line 68 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                       Write(Model.ListItems[i].ExpiresDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 57, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n");
            EndContext();
#line 70 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                             if (Model.ListItems[i].ExpiresDate > DateTime.Now)
                            {

#line default
#line hidden
            BeginContext(2778, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2810, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305da20182bdf03261df371e13bf2fc7ded4b4167c0650780c933abacfe3d8d913062", async() => {
                BeginContext(2979, 45, true);
                WriteLiteral(" <i class=\"fas fa-comment\"></i>Tham gia góp Ý");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 72 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                                       WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                                                                                                    WriteLiteral(Model.ListItems[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 72 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                                                                                                                                           WriteLiteral(Model.ListItems[i].Ids);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Ids"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Ids", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Ids"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3028, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3126, 104, true);
            WriteLiteral("                                <h5><span class=\"badge badge-secondary\">  Đã hết hạn góp ý</span></h5>\r\n");
            EndContext();
#line 77 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                             
                            }

#line default
#line hidden
            BeginContext(3292, 85, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n");
            EndContext();
            BeginContext(3508, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3538, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305da20182bdf03261df371e13bf2fc7ded4b4167c0650780c933abacfe3d8d917870", async() => {
                BeginContext(3718, 69, true);
                WriteLiteral("\r\n                             Chi tiết\r\n                            ");
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
#line 85 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                                                                                   WriteLiteral(Model.ListItems[i].Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 85 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                                                                                                                            WriteLiteral(StringUtilities.ToNameRewrite(@Model.ListItems[i].Title));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-alias", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["alias"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3791, 62, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 91 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(3887, 124, true);
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(4012, 63, false);
#line 100 "D:\code\NGHIA_TRANG\API\Views\DuThaoVanBan\Index.cshtml"
       Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(4075, 44, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.DuThaoVanBan.DuThaoVanBanModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
