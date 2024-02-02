#pragma checksum "D:\code\NGHIA_TRANG\API\Areas\Admin\Views\Shared\_PartialTinymce.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bc290b77ce4f5967f64ef23101805414bce1fff5e7e17165ed65c732030e28a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__PartialTinymce), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_PartialTinymce.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_PartialTinymce.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__PartialTinymce))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bc290b77ce4f5967f64ef23101805414bce1fff5e7e17165ed65c732030e28a2", @"/Areas/Admin/Views/Shared/_PartialTinymce.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"354159952f87747c1a2715c35c93fa5a5fdedf830348b0cb9841e5003a3ef970", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__PartialTinymce : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormCreateFolder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormRename"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1444, true);
            WriteLiteral(@"<!-- Modal Tinymce -->
<div class=""modal fade"" id=""tinymce_insert"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-scrollable modal-max"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Quản lý file upload</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""tinymce_body"">

                <div class=""row"" id=""tinymce_top"">
                    <div class=""col-xl-6 col-lg-7 col-md-7 col-sm-12"">
                        <span onclick=""ShowUploadFile()"" class=""action""><i class=""fas fa-upload"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Upload""></i> Tải File</span>
                        <span onclick=""ShowFolderPlus()"" cl");
            WriteLiteral(@"ass=""action""><i class=""fas fa-folder-plus""></i> Tạo Folder</span>
                        <span onclick=""TinyResetItems()"" class=""action""><i class=""fas fa-sync""></i> Làm mới</span>

                    </div>

                    <div class=""col-xl-6 col-lg-5 col-md-5 col-sm-12 text-right"">
                        Filters:
                        <input type=""text"" class=""filter-input"" id=""tiny_filter_keyword""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1444, "\"", 1452, 0);
            EndWriteAttribute();
            BeginContext(1453, 1389, true);
            WriteLiteral(@" />
                        <i class=""fas fa-search"" onclick=""TinySearchListItems()""></i>
                    </div>

                </div>
                <div id=""tiny-alert"" style=""display:none;"">
                    <div class=""alert alert-success alert-dismissible fade show"" role=""alert"">
                        <span class=""tiny-alert-msg"">Đang lấy dữ liệu. Xin vui lòng đợi</span>
                        <button type=""button"" class=""close"" onclick=""TinyAlertClose()"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                </div>
                <ul class=""row breadcrumb"" id=""TinyBreadcrumb""></ul>

                <ul id=""tinymce_content""></ul>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""far fa-window-close""></i> Đóng</button>
                <button type=""button"" class=""btn btn-primary btn");
            WriteLiteral(@"-insert-file tiny-insert-file"" style=""display:none;""><i class=""fas fa-check-double""></i> Chèn File</button>
                <button type=""button"" onclick=""ManagerFileSelect()"" class=""btn btn-primary btn-insert-file ouput-insert-file"" style=""display:none;""><i class=""fas fa-check-double""></i> Chèn File</button>
            </div>
            <input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2842, "\"", 2850, 0);
            EndWriteAttribute();
            BeginContext(2851, 57, true);
            WriteLiteral(" id=\"TinySelectPath\" />\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2908, "\"", 2916, 0);
            EndWriteAttribute();
            BeginContext(2917, 61, true);
            WriteLiteral(" id=\"TinySelectNameFile\" />\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2978, "\"", 2986, 0);
            EndWriteAttribute();
            BeginContext(2987, 60, true);
            WriteLiteral(" id=\"TinyCurrentFolder\" />\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3047, "\"", 3055, 0);
            EndWriteAttribute();
            BeginContext(3056, 55, true);
            WriteLiteral(" id=\"TinyOutputId\" />\r\n            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3111, "\"", 3119, 0);
            EndWriteAttribute();
            BeginContext(3120, 752, true);
            WriteLiteral(@" id=""TinyMangerFileType"" /> <!--Loại gì: 1: gọi trong Tinymce, Loại 2: gọi trong fileinput-->
        </div>
    </div>
</div>
<!-- End Modal Tinymce -->
<!-- Modal FolderPlus -->
<div class=""modal fade child-modal-tinymce"" id=""FolderPlus"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered "" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""modal-title"">Bạn hãy nhập tên Folder</div>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(3872, 840, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc290b77ce4f5967f64ef23101805414bce1fff5e7e17165ed65c732030e28a210275", async() => {
                BeginContext(3900, 805, true);
                WriteLiteral(@"
                    <div class=""form-row align-items-center"">
                        <div class=""col-auto"">
                            <label class=""sr-only"" for=""inlineFormInput"">Tên Folder</label>
                            <input style=""width:300px;"" type=""text"" class=""form-control mb-2 "" id=""TinyFolderName"" placeholder=""Ten-Folder"">

                        </div>
                        <div class=""col-auto"">
                            <button onclick=""TinyCreateFolder()"" type=""button"" class=""btn btn-primary mb-2""><i class=""fas fa-folder-plus""></i> Tạo</button>
                        </div>
                        <div class=""invalid-feedback"">
                            Tên folder không hợp lệ.
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4712, 918, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""far fa-window-close""></i> Đóng</button>
            </div>
        </div>
    </div>
</div>
<!--End Modal FolderPlus -->
<!-- Modal UploadFile -->
<div class=""modal fade child-modal-tinymce"" id=""UploadFile"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""modal-title"">Bạn hãy chọn các file cần upload</div>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(5630, 1104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc290b77ce4f5967f64ef23101805414bce1fff5e7e17165ed65c732030e28a213624", async() => {
                BeginContext(5702, 1025, true);
                WriteLiteral(@"
                    <div class=""form-row align-items-center"">
                        <div class=""col-auto"">
                            <div class=""custom-file"" style=""width:300px;"">
                                <input multiple type=""file"" class=""custom-file-input"" id=""TinyUploadFile"" required>
                                <label class=""custom-file-label"" for=""validatedCustomFile"">Choose file...</label>
                                <div class=""invalid-feedback"">Example invalid custom file feedback</div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <button onclick=""TinyUploadFiles()"" type=""button"" class=""btn btn-primary mb-2""><i class=""fas fa-folder-plus""></i> Upload File</button>
                        </div>
                        <div class=""invalid-feedback"">
                            Tên folder không hợp lệ.
                        </div>
                    </div>
               ");
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6734, 1714, true);
            WriteLiteral(@"
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th scope=""col"" width=""60px"">#</th>
                            <th scope=""col"">Tên</th>
                            <th scope=""col"" width=""150px"">Kích Thước</th>
                            <th scope=""col"" width=""100px"">Trạng Thái</th>
                        </tr>
                    </thead>
                    <tbody id=""TinyBodyUploadFile"">
                        <tr>
                            <th scope=""row"">1</th>
                            <td>Mark</td>
                            <td><i class='fas fa-check text-primary'></i> <i class='fas fa-times text-danger'></i></td>
                        </tr>

                    </tbody>
                </table>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""far fa-window-close""></i> Đóng</butt");
            WriteLiteral(@"on>
            </div>
        </div>
    </div>
</div>
<!--End Modal UploadFile -->
<!-- Modal FolderPlus -->
<div class=""modal fade child-modal-tinymce"" id=""TinyShowRename"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-dialog-centered "" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div class=""modal-title"">Bạn hãy nhập tên muốn sửa</div>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(8448, 1316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc290b77ce4f5967f64ef23101805414bce1fff5e7e17165ed65c732030e28a218363", async() => {
                BeginContext(8470, 1104, true);
                WriteLiteral(@"
                    <div class=""form-row align-items-center"">
                        <div class=""col-auto"">
                            <label class=""sr-only"" for=""inlineFormInput"">Tên mới</label>
                            <div class=""input-group"">
                                <input style=""width:300px;"" type=""text"" class=""form-control"" id=""TinyRenameName"" placeholder=""Tên"">
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text"" id=""TinyRenameExtension""></div>
                                </div>
                            </div>

                        </div>
                        <div class=""col-auto"">
                            <button onclick=""TinyRename()"" type=""button"" class=""btn btn-primary mb-2""><i class=""fas fa-folder-plus""></i> Cập nhật</button>
                        </div>
                        <div class=""invalid-feedback"">
                            Lỗi khi đổ tên.
                    ");
                WriteLiteral("    </div>\r\n                    </div>\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 9574, "\"", 9582, 0);
                EndWriteAttribute();
                BeginContext(9583, 62, true);
                WriteLiteral(" id=\"Rename_Path\" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 9645, "\"", 9653, 0);
                EndWriteAttribute();
                BeginContext(9654, 59, true);
                WriteLiteral(" id=\"Rename_N\" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 9713, "\"", 9721, 0);
                EndWriteAttribute();
                BeginContext(9722, 35, true);
                WriteLiteral(" id=\"Rename_I\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9764, 910, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal""><i class=""far fa-window-close""></i> Đóng</button>
            </div>
        </div>
    </div>
</div>
<!--End Modal FolderPlus -->
<!-- Modal Show Image Main-->
<div class=""modal fade"" id=""MainShowImage"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""gridModalLabel"">Ản đại diện</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">×</span></button>
            </div>
            <div class=""modal-body"">
                <img class=""img-fluid"" id=""MainShowImagePath""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 10674, "\"", 10680, 0);
            EndWriteAttribute();
            BeginContext(10681, 61, true);
            WriteLiteral(" />\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
