#pragma checksum "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a5aff6e112bf4a68f810bb3ec132fdfd3da71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProfileOfConsultant), @"mvc.1.0.view", @"/Views/Admin/ProfileOfConsultant.cshtml")]
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
#nullable restore
#line 1 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.ConsultantViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.StudentViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a5aff6e112bf4a68f810bb3ec132fdfd3da71f", @"/Views/Admin/ProfileOfConsultant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ae6053615c6228361e0c4a0af90505855f00e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProfileOfConsultant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultantProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "subasWallet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToWallet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
  
    ViewData["Title"] = "ProfileOfConsultant";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-content\">\r\n\r\n    <div class=\"container-fluid\">\r\n");
            WriteLiteral(@"
        <!-- اینجا ساخته شود -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""d-flex align-items-center justify-content-between"">
                                    <div>
                                        <h6 class=""card-title mb-3"">نام و نام خانوادگی</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">");
#nullable restore
#line 34 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                                              Write(ViewBag.NameF);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                            <p class=""small text-muted mb-0 line-height-20"">
                                            </p>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""avatar avatar-lg"">
                                            <div class=""avatar-title bg-success-bright text-success rounded-circle"">
                                                <i class=""fa fa-users""></i>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""d-flex");
            WriteLiteral(@" align-items-center justify-content-between"">
                                    <div>
                                        <h6 class=""card-title mb-3"">تعداد دانش آموز </h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">");
#nullable restore
#line 57 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                                              Write(ViewBag.CountStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                            <p class=""small text-muted mb-0 line-height-20"">
                                            </p>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""avatar avatar-lg"">
                                            <div class=""avatar-title bg-warning-bright text-warning rounded-circle"">
                                                <i class=""fa fa-check""></i>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""d-flex");
            WriteLiteral(@" align-items-center justify-content-between"">
                                    <div>
                                        <h6 class=""card-title mb-3"">اعتبار مشاور</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold""> ");
#nullable restore
#line 80 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                                               Write(Model.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان</h2>
                                            <p class=""small text-muted mb-0 line-height-20"">
                                            </p>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""avatar avatar-lg"">
                                            <div class=""avatar-title bg-info-bright text-info rounded-circle"">
                                                <i class=""fa fa-money""></i>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
");
            WriteLiteral(@"            <div class=""col-12"">
                <div class=""accordion custom-accordion"">

                    <div class=""accordion-row bg-white"">
                        <a href=""#"" class=""accordion-header"">
                            <span>تراکنش های مالی</span>
                            <i class=""accordion-status-icon close fa fa-chevron-up""></i>
                            <i class=""accordion-status-icon open fa fa-chevron-down""></i>
                        </a>
                        <div class=""accordion-body"">
                            <div class=""row"">
                                <div class=""table-responsive"">
                                    <table class=""table table-hover bg-white text-center"">
                                        <thead class=""thead-dark"">
                                            <tr>

                                                <th scope=""col""> کد پیگیری </th>
                                                <th scope=""col"">مبلغ</th>
      ");
            WriteLiteral(@"                                          <th scope=""col""> میزان کمیسیون</th>
                                                <th scope=""col""> مبلغ باقی مانده</th>

                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 148 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                             foreach (var item in Model.HistoryPeys)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td> ");
#nullable restore
#line 151 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                    Write(item.RefId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                                    <td>");
#nullable restore
#line 152 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                   Write(item.Peyamount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 153 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                   Write(item.comision);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 154 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                    Write(item.Peyamount-item.comision);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                                </tr>\r\n");
#nullable restore
#line 158 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""accordion-row bg-white"">
                        <a href=""#"" class=""accordion-header"">
                            <span>کم کردن از اعتبار کیف پول مشاور</span>
                            <i class=""accordion-status-icon close fa fa-chevron-up""></i>
                            <i class=""accordion-status-icon open fa fa-chevron-down""></i>
                        </a>
                        <div class=""accordion-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a5aff6e112bf4a68f810bb3ec132fdfd3da71f16349", async() => {
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83a5aff6e112bf4a68f810bb3ec132fdfd3da71f16644", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 175 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreditforSub);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                    <button type=\"submit\" class=\"btn btn-danger\" style=\"margin:10px\">کم کردن</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 174 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                                                    WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""accordion-row bg-white"">
                        <a href=""#"" class=""accordion-header"">
                            <span>اضافه کردن به اعتبار کیف پول مشاور</span>
                            <i class=""accordion-status-icon close fa fa-chevron-up""></i>
                            <i class=""accordion-status-icon open fa fa-chevron-down""></i>
                        </a>
                        <div class=""accordion-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a5aff6e112bf4a68f810bb3ec132fdfd3da71f21682", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83a5aff6e112bf4a68f810bb3ec132fdfd3da71f21973", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 189 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Creditforadd);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <button type=\"submit\" class=\"btn btn-danger\" style=\"margin:10px\">اضافه کردن</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 188 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\ProfileOfConsultant.cshtml"
                                                                                    WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsultantProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
