#pragma checksum "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da59dd3df330e996496f1df5564bcef54ba8b8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoriesDocumentsLaw_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoriesDocumentsLaw/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CategoriesDocumentsLaw/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_CategoriesDocumentsLaw_Index))]
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
#line 1 "D:\work\CTY_NUOC\API\Areas\Admin\Views\_ViewImports.cshtml"
using API;

#line default
#line hidden
#line 2 "D:\work\CTY_NUOC\API\Areas\Admin\Views\_ViewImports.cshtml"
using API.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da59dd3df330e996496f1df5564bcef54ba8b8f", @"/Areas/Admin/Views/CategoriesDocumentsLaw/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ad969ebe7f58ef9915d12dd5c55b51cfe0576", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CategoriesDocumentsLaw_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Areas.Admin.Models.CategoriesDocumentsLaw.CategoriesDocumentsLawModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialMsgInfoAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Keyword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Tìm kiếm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("MySearchForm()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Level", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MySearchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AjaxDeleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
  
   Layout = "_layoutAdmin";
    ViewData["Title"] = "Index";
    string ControllerName = this.ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(243, 193, true);
            WriteLiteral("\r\n    <div class=\"card\">\r\n        <div class=\"card-header\">\r\n\r\n            <h4><i class=\"fas fa-table\"></i> Danh mục tài liệu</h4>\r\n        </div>\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(436, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8da59dd3df330e996496f1df5564bcef54ba8b8f8931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(475, 18, true);
            WriteLiteral("\r\n\r\n\r\n            ");
            EndContext();
            BeginContext(493, 1337, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da59dd3df330e996496f1df5564bcef54ba8b8f10208", async() => {
                BeginContext(582, 159, true);
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(741, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8da59dd3df330e996496f1df5564bcef54ba8b8f10761", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchData.Keyword);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(838, 319, true);
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-lg-8"">
                        <div class=""form-row align-items-center"">
                            <div class=""col-auto"">
                                <div class=""form-group"">
                                    ");
                EndContext();
                BeginContext(1157, 176, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da59dd3df330e996496f1df5564bcef54ba8b8f13079", async() => {
                    BeginContext(1284, 40, true);
                    WriteLiteral("\r\n\r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 29 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchData.Level);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 29 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListItemLevel;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1333, 490, true);
                WriteLiteral(@"
                                </div>
                            </div>
                   
                            <div class=""col-auto"">
                                <div class=""form-group"">
                                    <button type=""submit"" class=""btn btn-primary"">Tìm Kiếm</button>
                                </div>
                            </div>

                        </div>
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
            BeginWriteTagHelperAttribute();
#line 18 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                      WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1830, 918, true);
            WriteLiteral(@"
            <div class=""row"">
                <div class=""col-lg-12"">

                    <table class=""table table-bordered table-striped table-hover "">
                        <thead>
                            <tr>
                                <th width=""50px"" class=""text-center"">Id</th>
                                <th width=""50px"" class=""text-center"">TT</th>
                                <th>Tên danh mục</th>
                                <th>Alias</th>
                                <th width=""100px"" class=""text-info text-center"" data-toggle=""tooltip"" data-placement=""top"" title=""Active"">Active</th>
                                <th width=""100px"" class=""text-info"" data-toggle=""tooltip"" data-placement=""top"" title=""Hiển thị danh mục ra ngoài trang chủ"">Trang chủ</th>
                                <th width=""130px"" class=""btn-contain"">
                                    ");
            EndContext();
            BeginContext(2748, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da59dd3df330e996496f1df5564bcef54ba8b8f19307", async() => {
                BeginContext(2830, 8, true);
                WriteLiteral("THÊM MỚI");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 61 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                           WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2842, 145, true);
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n\r\n                        <tbody>\r\n");
            EndContext();
#line 67 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                             if (Model.ListItems == null || Model.ListItems.Count() == 0)
                            {

#line default
#line hidden
            BeginContext(3109, 393, true);
            WriteLiteral(@"                                <tr>
                                    <td colspan=""7"" class=""text-center"">
                                        <div *ngIf=""flagListitems==1"" class=""lds-dual-ring""></div>
                                        <label *ngIf=""flagListitems==2"">Không có dữ liệu!</label>
                                    </td>
                                </tr>
");
            EndContext();
#line 75 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                            }
                            else
                            {
                                for (int i = 0; i < Model.ListItems.Count(); i++)
                                {

#line default
#line hidden
            BeginContext(3716, 119, true);
            WriteLiteral("                                    <tr>\r\n                                        <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(3836, 21, false);
#line 81 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                        Write(Model.ListItems[i].Id);

#line default
#line hidden
            EndContext();
            BeginContext(3857, 84, true);
            WriteLiteral("</td>\r\n                                        <td width=\"50px\" class=\"text-center\">");
            EndContext();
            BeginContext(3942, 27, false);
#line 82 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                        Write(Model.ListItems[i].Ordering);

#line default
#line hidden
            EndContext();
            BeginContext(3969, 102, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4071, "\"", 4171, 1);
#line 84 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
WriteAttributeValue("", 4079, Model.ListItems[i].Level==1?"text-primary":(Model.ListItems[i].Level==2?"text-danger":""), 4079, 92, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4172, 51, true);
            WriteLiteral(">\r\n                                                ");
            EndContext();
            BeginContext(4224, 24, false);
#line 85 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                           Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(4248, 192, true);
            WriteLiteral("\r\n                                            </span>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4441, 24, false);
#line 89 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                       Write(Model.ListItems[i].Alias);

#line default
#line hidden
            EndContext();
            BeginContext(4465, 115, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"text-center\">\r\n");
            EndContext();
#line 92 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                             if (@Model.ListItems[i].Status)
                                            {

#line default
#line hidden
            BeginContext(4705, 123, true);
            WriteLiteral("                                                <span class=\"fas fa-check-circle text-primary\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 95 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(4972, 122, true);
            WriteLiteral("                                                <span class=\"fas fa-check-circle text-danger\" aria-hidden=\"true\"></span>\r\n");
            EndContext();
#line 99 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5141, 113, true);
            WriteLiteral("                                        </td>\r\n                                        <td class=\"text-center\">\r\n");
            EndContext();
#line 102 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                             if (@Model.ListItems[i].FeaturedHome)
                                            {

#line default
#line hidden
            BeginContext(5385, 154, true);
            WriteLiteral("                                                <span class=\"fas fa-check-circle text-success\" aria-hidden=\"true\"></span> <span class=\"text-muted small\">(");
            EndContext();
            BeginContext(5540, 27, false);
#line 104 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                                                                                                     Write(Model.ListItems[i].Ordering);

#line default
#line hidden
            EndContext();
            BeginContext(5567, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 105 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                            }
                                            else
                                            {


                                            }

#line default
#line hidden
            BeginContext(5772, 249, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n\r\n                                            <ul class=\"list-inline action\">\r\n                                                <li class=\"list-inline-item\">");
            EndContext();
            BeginContext(6021, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da59dd3df330e996496f1df5564bcef54ba8b8f28477", async() => {
                BeginContext(6118, 29, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>Sửa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#line 115 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                                    WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 115 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                                                                                         WriteLiteral(Model.ListItems[i].Ids);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6151, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 116 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                 if (@Model.ListItems[i].NoDelete != true)
                                                {

#line default
#line hidden
            BeginContext(6301, 146, true);
            WriteLiteral("                                                    <li class=\"list-inline-item\"><a data-toggle=\"modal\" data-target=\"#DeleteModal\" data-whatever=\"");
            EndContext();
            BeginContext(6448, 24, false);
#line 118 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                                                                                             Write(Model.ListItems[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(6472, 12, true);
            WriteLiteral("\" data-ids=\"");
            EndContext();
            BeginContext(6485, 22, false);
#line 118 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                                                                                                                                                  Write(Model.ListItems[i].Ids);

#line default
#line hidden
            EndContext();
            BeginContext(6507, 43, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i>Xóa</a></li>\r\n");
            EndContext();
#line 119 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(6601, 145, true);
            WriteLiteral("\r\n\r\n                                            </ul>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 125 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(6812, 88, true);
            WriteLiteral("\r\n                        </tbody>\r\n\r\n                    </table>\r\n                    ");
            EndContext();
            BeginContext(6900, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da59dd3df330e996496f1df5564bcef54ba8b8f33996", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 131 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
                              WriteLiteral(ControllerName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6990, 87, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-12\">\r\n                    ");
            EndContext();
            BeginContext(7078, 63, false);
#line 134 "D:\work\CTY_NUOC\API\Areas\Admin\Views\CategoriesDocumentsLaw\Index.cshtml"
               Write(await Html.PartialAsync("_PartialPagination", Model.Pagination));

#line default
#line hidden
            EndContext();
            BeginContext(7141, 74, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Areas.Admin.Models.CategoriesDocumentsLaw.CategoriesDocumentsLawModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
