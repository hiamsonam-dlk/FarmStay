#pragma checksum "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d666e25ad574973e7911a57472b4b3f2ab1817d81b593e518079d94e2d39006e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialQuestionTemplate), @"mvc.1.0.view", @"/Views/Shared/_PartialQuestionTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialQuestionTemplate.cshtml", typeof(AspNetCore.Views_Shared__PartialQuestionTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d666e25ad574973e7911a57472b4b3f2ab1817d81b593e518079d94e2d39006e", @"/Views/Shared/_PartialQuestionTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de782fee9593460bafed273ea97f173af49f59f3f83dccfacb27283faf97b742", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialQuestionTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
  
    var listBannerPo13 = API.Areas.Admin.Models.Banners.BannersService.GetListByCat(13);

#line default
#line hidden
            BeginContext(97, 179, true);
            WriteLiteral("\r\n<!-- Button trigger modal -->\r\n<button type=\"button\" data-bs-toggle=\"offcanvas\" data-bs-target=\"#QuestionTemPlate\" id=\"BtnOpenQuestionTemPlate\" aria-controls=\"offcanvasRight\">\r\n");
            EndContext();
            BeginContext(406, 1830, true);
            WriteLiteral(@"    <img src=""/ttudkhcn/images/icon.png""/>
</button>

<!-- Modal -->
<div class=""offcanvas offcanvas-end"" id=""QuestionTemPlate"" aria-labelledby=""QuestionTemPlateLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-scrollable m-0"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""row"">
                    <div class=""col-2 pr-0 my-auto"">
                        <img src=""./ttudkhcn/images/Customer-Support-Icon.jpg"" class=""avatar_supporter"" alt=""..."">
                    </div>
                    <div class=""col-10"">
                        <h1 class=""m-0"">Dakwaco</h1>
                        <p class=""m-0"">Đang trực tuyến <i class=""fa fa-circle"" aria-hidden=""true"" style=""color:#56F000""></i></p>
                        <p class=""m-0"">Hệ thống giải đáp thắc mắc</p>
                    </div>
                </div>
            </div>
            <div class=""modal-body"">
                <div class=""container-fluid p-0"" id=""c");
            WriteLiteral(@"onversation"">

                    <div class=""col-8 p-0"">
                        <h6 class=""message btn-secondary"">Xin chào mừng quý vị đến với hệ thống tư vấn dịch vụ của Dakwaco.</h6>
                    </div>

                    <div class=""col-8 p-0"">
                        <h6 class=""message btn-secondary"">Vui lòng nhấn vào những dịch vụ mà quý vị quan tâm để được tư vấn. Xin cảm ơn!</h6>
                    </div>

                    <div class=""position-relative"">
                        <hr />
                        <p class=""position-absolute top-0 start-50 translate-middle bg-white px-2"">Danh sách dịch vụ</p>
                    </div>
                    

                    <div class=""card-body-message-from-admin"">
                        <div class=""row"">
");
            EndContext();
#line 46 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
                             for (int m = 0; m < listBannerPo13.Count(); m++)
                            {

#line default
#line hidden
            BeginContext(2346, 157, true);
            WriteLiteral("                                <div class=\"col-8 col-md-6\">\r\n                                    <button type=\"button\" class=\"btn btn-secondary m-1 message\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2503, "\"", 2579, 6);
            WriteAttributeValue("", 2513, "GetListQuestion(", 2513, 16, true);
#line 49 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
WriteAttributeValue("", 2529, listBannerPo13[m].Id, 2529, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 2550, ",", 2550, 1, true);
            WriteAttributeValue(" ", 2551, "\'", 2552, 2, true);
#line 49 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
WriteAttributeValue("", 2553, listBannerPo13[m].Title, 2553, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 2577, "\')", 2577, 2, true);
            EndWriteAttribute();
            BeginContext(2580, 47, true);
            WriteLiteral(">\r\n                                        <h6>");
            EndContext();
            BeginContext(2628, 23, false);
#line 50 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
                                       Write(listBannerPo13[m].Title);

#line default
#line hidden
            EndContext();
            BeginContext(2651, 100, true);
            WriteLiteral("</h6>\r\n                                    </button><br />\r\n                                </div>\r\n");
            EndContext();
#line 53 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
                            }

#line default
#line hidden
            BeginContext(2782, 2608, true);
            WriteLiteral(@"                        </div>
                    </div>
                    
                    <hr />
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""col-12 mx-auto"">
                    <p class=""lead"">Hãy để lại câu hỏi nếu quý vị còn thắc mắc.</p>
                </div>
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""offcanvas"">Đóng</button>
                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#surveypopup"" data-bs-dismiss=""offcanvas"">Đặt câu hỏi.</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""surveypopup"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog mr-0 modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Đặt câu hỏi</h5>
     ");
            WriteLiteral(@"           <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""form-group"">
                        <div class=""col-12"">
                            <label for=""hotencauhoi"">Họ và tên</label>
                            <input type=""text"" class=""form-control"" id=""hotencauhoi"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-12"">
                            <label for=""sodtcauhoi"">Số điện thoại</label>
                            <input type=""text"" class=""form-control"" id=""sodtcauhoi"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-12"">
                            <label for");
            WriteLiteral(@"=""cauhoi"">Câu hỏi</label>
                            <input type=""text"" class=""form-control"" id=""cauhoi"">
                        </div>
                    </div>
                </div>
                <div id=""txtErr"" class=""mt-3""> </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Đóng</button>
                <button type=""button"" class=""btn btn-primary"" id=""guiCauHoi"">Gửi đi</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(5390, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d666e25ad574973e7911a57472b4b3f2ab1817d81b593e518079d94e2d39006e10707", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5403, "~/ttudkhcn/js/question_template.js?ver=", 5403, 39, true);
#line 111 "D:\code\NGHIA_TRANG\API\Views\Shared\_PartialQuestionTemplate.cshtml"
AddHtmlAttributeValue("", 5442, DateTime.Now.ToString(), 5442, 26, false);

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
            BeginContext(5479, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591