#pragma checksum "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d51bbf59244d7c2f9cf53a15f6747a80f7ef9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.ConsultantViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.StudentViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d51bbf59244d7c2f9cf53a15f6747a80f7ef9d", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ae6053615c6228361e0c4a0af90505855f00e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcriveRequestClassAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"main-content\">\r\n        <h6> ");
#nullable restore
#line 8 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
        Write(ViewBag.s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <div class=\"container-fluid\">\r\n");
#nullable restore
#line 10 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
             if (ViewBag.Request > 0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger \" role=\"alert\" style=\"margin-top: 50px;\">\r\n                    <p>شما ");
#nullable restore
#line 14 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
                      Write(ViewBag.Request);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عدد درخواست برگزاری کلاس انلاین دارید..</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66d51bbf59244d7c2f9cf53a15f6747a80f7ef9d6405", async() => {
                WriteLiteral("مشاهده");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-7"">
                    <div class=""card bg-secondary-gradient"">
                        <div class=""card-body"">
                            <div class=""row align-items-center"">
                                <div class=""col-md-7"">
                                    <h6 class=""card-title mb-3"">مدیر محترم خوش آمدید</h6>
                                    <p>مشاوران که ثبت نام کرده اند و هنوز مدارک خود را ارسال نکرده اند در قسمت مشاورین غیر فعال مدیریت می شوند</p>
                                    <ul class=""mb-3"">
                                        <li>پس از فعال سازی و پرداخت هزینه ثبت نام در قسمت مشاورین فعال مدیریت می شوند</li>
                                    </ul>
                                </div>
                                <div class=""col-md-5"">
                                    <img src=""/assets/media/svg/undraw_onboarding_o8mv.svg"" alt=""..."" class=""img-fluid"">
                                </div>
");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-5"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""card-title d-flex justify-content-between"">
                                <h6 class=""card-title"">وضعیت مشاورین در سایت </h6>

                            </div>
                            <h2 class=""mb-3 font-weight-bold"">");
#nullable restore
#line 45 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
                                                         Write(ViewBag.consultant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <div class=\"progress md-3\">\r\n                                <div class=\"progress-bar bg-danger\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2304, "\"", 2348, 3);
            WriteAttributeValue("", 2312, "width:", 2312, 6, true);
#nullable restore
#line 47 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
WriteAttributeValue("  ", 2318, ViewBag.DeAcriveConsultant, 2320, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2347, "%", 2347, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2349, "\"", 2393, 1);
#nullable restore
#line 47 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
WriteAttributeValue(" ", 2365, ViewBag.DeAcriveConsultant, 2366, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                                <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2528, "\"", 2569, 3);
            WriteAttributeValue("", 2536, "width:", 2536, 6, true);
#nullable restore
#line 48 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
WriteAttributeValue(" ", 2542, ViewBag.ActiveConsultant, 2543, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2568, "%", 2568, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2570, "\"", 2612, 1);
#nullable restore
#line 48 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
WriteAttributeValue(" ", 2586, ViewBag.ActiveConsultant, 2587, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>

                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""mb-0"">
                                        <span class=""fa fa-circle text-danger mr-1""></span>
                                        پروفایل های غیرفعال
                                    </p>
                                    <h5 class=""mt-2 mb-0"">");
#nullable restore
#line 57 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
                                                     Write(ViewBag.DeAcriveConsultant);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</h5>
                                </div>


                                <div class=""col"">
                                    <p class=""mb-0"">
                                        <span class=""fa fa-circle text-success mr-1""></span>
                                        پروفایل های فعال
                                    </p>
                                    <h5 class=""mt-2 mb-0"">");
#nullable restore
#line 66 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
                                                     Write(ViewBag.ActiveConsultant);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</h5>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""d-flex align-items-center justify-content-between"">
                                        <div>
                                            <h6 class=""card-title mb-3"">اعتبار مشاوران</h6>
                                            <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                                <h2 class=""mb-0 mr-2 font-weight-bold"">");
#nullable restore
#line 83 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
                                                                                  Write(ViewBag.CreditConsultant);

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
                                <di");
            WriteLiteral(@"v class=""card-body"">
                                    <div class=""d-flex align-items-center justify-content-between"">
                                        <div>
                                            <h6 class=""card-title mb-3"">تعداد دانش اموزان </h6>
                                            <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                                <h2 class=""mb-0 mr-2 font-weight-bold"">");
#nullable restore
#line 106 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
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
                                <di");
            WriteLiteral(@"v class=""card-body"">
                                    <div class=""d-flex align-items-center justify-content-between"">
                                        <div>
                                            <h6 class=""card-title mb-3"">اعتبار مالی</h6>
                                            <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                                <h2 class=""mb-0 mr-2 font-weight-bold""> ");
#nullable restore
#line 129 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\Index.cshtml"
                                                                                   Write(ViewBag.Credit);

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

        </div>
        <!-- end::main-content -->

   ");
            WriteLiteral(" </div>\r\n\r\n");
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
