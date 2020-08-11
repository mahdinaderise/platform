#pragma checksum "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94d11b38a4b8f3a731973675e7d257ac653179c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_Index), @"mvc.1.0.view", @"/Views/Consultant/Index.cshtml")]
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
#line 1 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Consultant;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94d11b38a4b8f3a731973675e7d257ac653179c", @"/Views/Consultant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff32afada450f7f1f93ecfbde765105a74752662", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultantDashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"main-content\">\r\n    <h6> ");
#nullable restore
#line 9 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
    Write(ViewBag.s);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-7"">
                <div class=""card bg-secondary-gradient"">
                    <div class=""card-body"">
                        <div class=""row align-items-center"">
                            <div class=""col-md-7"">
                                <h6 class=""card-title mb-3"">خوش برگشتی (نام کاربر)</h6>
                                <p>با چک کردن قسمت های مختلف بیشتر با سایت آشنا شو لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است</p>
                                <ul class=""mb-3"">
                                    <li>این قسمت ها را مشاهده کنید</li>
                                    <li>مخاطبان خود را اضافه کنید</li>
                                </ul>
                                <a href=""#"" class=""btn bg-white"">اضافه کردن دانش آموز</a>
                            </div>
                            <div class=""col-md-5"">
                   ");
            WriteLiteral(@"             <img src=""assets/media/svg/undraw_onboarding_o8mv.svg"" alt=""..."" class=""img-fluid"">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-5"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""card-title d-flex justify-content-between"">
                            <h6 class=""card-title"">وضعیت دانش آموزان </h6>
                            <div>
                                <div class=""dropdown"">
                                    <a href=""#"" data-toggle=""dropdown"" aria-haspopup=""true""
                                       aria-expanded=""false"">
                                        <i class=""fa fa-ellipsis-v"" aria-hidden=""true""></i>
                                    </a>
                                    <span class=""dropdown-menu dropdown-menu-left"">
                                        <a hr");
            WriteLiteral(@"ef=""#"" class=""dropdown-item"">گزارش</a>
                                        <a href=""#"" class=""dropdown-item"">دانلود</a>
                                        <a href=""#"" class=""dropdown-item"">بستن</a>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <h2 class=""mb-3 font-weight-bold"">469,453</h2>
                        <div class=""progress mb-3"" style=""height: 10px"">
                            <div class=""progress-bar w-25 bg-danger-gradient"" role=""progressbar""></div>

                            <div class=""progress-bar w-75 bg-success-gradient"" role=""progressbar""></div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <p class=""mb-0"">
                                    <span class=""fa fa-circle text-danger mr-1""></span>
                                    تکلیف");
            WriteLiteral(@" ها انجام نشده
                                </p>
                                <h5 class=""mt-2 mb-0"">25%</h5>
                            </div>


                            <div class=""col"">
                                <p class=""mb-0"">
                                    <span class=""fa fa-circle text-success mr-1""></span>
                                    تکلیف های انجام شده
                                </p>
                                <h5 class=""mt-2 mb-0"">75%</h5>
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
                           ");
            WriteLiteral(@"         <div>
                                        <h6 class=""card-title mb-3"">دانش آموزان</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">1.425</h2>
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
                                </div>");
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <div class=""d-flex align-items-center justify-content-between"">
                                    <div>
                                        <h6 class=""card-title mb-3"">تسک های انجام شده</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">554</h2>
                                            <p class=""small text-muted mb-0 line-height-20"">
                                            </p>
                                        </div>
                                    </div>
                                    <div>
                                        <div class=""avatar avatar-lg"">
          ");
            WriteLiteral(@"                                  <div class=""avatar-title bg-warning-bright text-warning rounded-circle"">
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
                                <div class=""d-flex align-items-center justify-content-between"">
                                    <div>
                                        <h6 class=""card-title mb-3"">اعتبار مالی</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">900</h2>
");
            WriteLiteral(@"                                            <p class=""small text-muted mb-0 line-height-20"">
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
        <Div class=""row"">
            <div class="" col-md-12"">
                <div class=""card"">
                    <div class=""card-body"">");
            WriteLiteral(@"
                        <div class=""d-flex justify-content-between"">
                            <h6 class=""card-title"">کارهای روزانه</h6>
                            <div>
                                <a href=""#"" class=""mr-3"">
                                    <i class=""fa fa-refresh""></i>
                                </a>
                                <div class=""dropdown"">
                                    <a href=""#"" data-toggle=""dropdown"" aria-haspopup=""true""
                                       aria-expanded=""false"">
                                        <i class=""fa fa-ellipsis-v"" aria-hidden=""true""></i>
                                    </a>
                                    <span class=""dropdown-menu dropdown-menu-left"">
                                        <a href=""#"" class=""dropdown-item"">گزارش</a>
                                        <a href=""#"" class=""dropdown-item"">دانلود</a>
                                        <a href=""#"" class=""dropdown-item"">بستن<");
            WriteLiteral(@"/a>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox todo-item"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                            <label class=""custom-control-label d-flex justify-content-between""
                                   for=""customCheck1"">
                                صحبت با کاربران جدید
                                <span class=""text-muted"">13 فروردین 1399</span>
                            </label>
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox-success custom-checkbox todo-item"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"" checked>
                            <label class=""custom-control-label d-flex");
            WriteLiteral(@" justify-content-between""
                                   for=""customCheck2"">
                                کاربران قدیمی به زودی حذف میشوند
                                <span class=""text-muted"">20 فروردین 1399</span>
                            </label>
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox todo-item"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck3"">
                            <label class=""custom-control-label d-flex justify-content-between""
                                   for=""customCheck3"">
                                واگذاری
                                تکمیل شده
                                <span class=""text-muted"">13 فروردین 1399</span>
                            </label>
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox todo-item"">
                            <");
            WriteLiteral(@"input type=""checkbox"" class=""custom-control-input"" id=""customCheck4"" checked>
                            <label class=""custom-control-label d-flex justify-content-between""
                                   for=""customCheck4"">
                                نظرات خریدار
                                <span class=""text-muted"">10 فروردین 1398</span>
                            </label>
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox todo-item"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck5"">
                            <label class=""custom-control-label d-flex justify-content-between""
                                   for=""customCheck5"">
                                حذف بک آپ های قبلی
                                <span class=""text-muted"">13 فروردین 1399</span>
                            </label>
                        </div>
                        <div class=""c");
            WriteLiteral(@"ustom-control custom-checkbox custom-checkbox-success todo-item"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck6"">
                            <label class=""custom-control-label d-flex justify-content-between""
                                   for=""customCheck6"">
                                صحبت با کاربران جدید
                                <span class=""text-muted"">27 فروردین 1399</span>
                            </label>
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox todo-item"">
                            <input type=""checkbox"" class=""custom-control-input"" id=""customCheck7"" checked>
                            <label class=""custom-control-label d-flex justify-content-between""
                                   for=""customCheck7"">
                                کاربران قدیمی به زودی حذف میشوند
                                <span class=""text-muted"">13 فروردین 13");
            WriteLiteral("99</span>\r\n                            </label>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94d11b38a4b8f3a731973675e7d257ac653179c18687", async() => {
                WriteLiteral(@"
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control""
                                       aria-label=""Example text with button addon""
                                       placeholder=""کار جدید"" aria-describedby=""button-addon1"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-primary"" type=""button"" id=""button-addon1"">
                                        افزودن
                                    </button>
                                </div>
                            </div>
                        ");
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
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-body"">
                        <h6 class=""card-title"">کاربر واگذاری شده به من</h6>
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex align-items-center p-l-r-0"">
                                <div>
                                    <figure class=""avatar avatar-state-success m-r-15"">
                                        <img src=""assets/media/image/user/man_avatar5.jpg""
                                             class=""rounded-circle"" alt=""image"">
                                    </figure>
                                </div>
                                <div>
                                    <h6 class=""m-b-0"">وحید موحد</h6>
                                    <small class=""text-muted"">مهندس</small>
                                </div>
                                <div cl");
            WriteLiteral(@"ass=""ml-auto"">
                                    <span class=""badge badge-danger mr-2 d-sm-inline d-none"">رد شده</span>
                                    <div class=""dropdown"">
                                        <a href=""#"" data-toggle=""dropdown""
                                           class=""btn btn-outline-light btn-sm""
                                           aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fa fa-ellipsis-h"" aria-hidden=""true""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-left"">
                                            <a href=""#"" class=""dropdown-item"">مشاهده</a>
                                            <a href=""#"" class=""dropdown-item"">ارسال پیام</a>
                                            <a href=""#"" class=""dropdown-item"">واگذاری </a>
                                        </div>
                                    </di");
            WriteLiteral(@"v>
                                </div>
                            </li>
                            <li class=""list-group-item d-flex align-items-center p-l-r-0"">
                                <div>
                                    <figure class=""avatar avatar-state-success m-r-15"">
                                        <img src=""assets/media/image/user/man_avatar4.jpg""
                                             class=""rounded-circle"" alt=""image"">
                                    </figure>
                                </div>
                                <div>
                                    <h6 class=""m-b-0"">شهرام میرزایی</h6>
                                    <small class=""text-muted"">مشاور منابع انسانی</small>
                                </div>
                                <div class=""ml-auto"">
                                    <span class=""badge badge-success mr-2 d-sm-inline d-none"">تکمیل شده</span>
                                    <div class=""dropdo");
            WriteLiteral(@"wn"">
                                        <a href=""#"" data-toggle=""dropdown""
                                           class=""btn btn-outline-light btn-sm""
                                           aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fa fa-ellipsis-h"" aria-hidden=""true""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-left"">
                                            <a href=""#"" class=""dropdown-item"">مشاهده</a>
                                            <a href=""#"" class=""dropdown-item"">ارسال پیام</a>
                                            <a href=""#"" class=""dropdown-item"">واگذاری </a>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class=""list-group-item d-flex align-items-center p-l-r-0"">
       ");
            WriteLiteral(@"                         <div>
                                    <figure class=""avatar avatar-state-success m-r-15"">
                                        <span class=""avatar-title bg-secondary rounded-circle"">م</span>
                                    </figure>
                                </div>
                                <div>
                                    <h6 class=""m-b-0"">مسعود رسولی</h6>
                                    <small class=""text-muted"">مشاور</small>
                                </div>
                                <div class=""ml-auto"">
                                    <span class=""badge badge-warning mr-2 d-sm-inline d-none"">در انتظار</span>
                                    <div class=""dropdown"">
                                        <a href=""#"" data-toggle=""dropdown""
                                           class=""btn btn-outline-light btn-sm""
                                           aria-haspopup=""true"" aria-expanded=""false"">
           ");
            WriteLiteral(@"                                 <i class=""fa fa-ellipsis-h"" aria-hidden=""true""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-left"">
                                            <a href=""#"" class=""dropdown-item"">مشاهده</a>
                                            <a href=""#"" class=""dropdown-item"">ارسال پیام</a>
                                            <a href=""#"" class=""dropdown-item"">واگذاری </a>
                                        </div>
                                    </div>
                                </div>
                            </li>
                            <li class=""list-group-item d-flex align-items-center p-l-r-0"">
                                <div>
                                    <figure class=""avatar avatar-state-success m-r-15"">
                                        <img src=""assets/media/image/user/man_avatar2.jpg""
                                             clas");
            WriteLiteral(@"s=""rounded-circle"" alt=""image"">
                                    </figure>
                                </div>
                                <div>
                                    <h6 class=""m-b-0"">احمد ایمانی</h6>
                                    <small class=""text-muted"">مهندس</small>
                                </div>
                                <div class=""ml-auto"">
                                    <span class=""badge badge-danger mr-2 d-sm-inline d-none"">رد شده</span>
                                    <div class=""dropdown"">
                                        <a href=""#"" data-toggle=""dropdown""
                                           class=""btn btn-outline-light btn-sm""
                                           aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fa fa-ellipsis-h"" aria-hidden=""true""></i>
                                        </a>
                                        <div class=""dropdown-menu");
            WriteLiteral(@" dropdown-menu-left"">
                                            <a href=""#"" class=""dropdown-item"">مشاهده</a>
                                            <a href=""#"" class=""dropdown-item"">ارسال پیام</a>
                                            <a href=""#"" class=""dropdown-item"">واگذاری </a>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                        <div class=""mt-3 text-center"">
                            <a href=""#"">
                                دیدن همه
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </Div>

    </div>
    <!-- end::main-content -->

</div>
<!-- end::main -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsultantDashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
