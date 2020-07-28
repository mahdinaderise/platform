#pragma checksum "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Students\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1db2d68f1a791137b41a5770b992fe6d6554d7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_index), @"mvc.1.0.view", @"/Views/Students/index.cshtml")]
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
#line 1 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Consultant;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1db2d68f1a791137b41a5770b992fe6d6554d7f", @"/Views/Students/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff32afada450f7f1f93ecfbde765105a74752662", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Students\index.cshtml"
  
    ViewData["Title"] = "index";
    Layout = "~/Views/Shared/_LayoutStudent.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""main-content"">

        <div class=""container-fluid"">
            <!-- اینجا ساخته شود -->
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
                                    <a href=""#"" class=""btn bg-white"">اضافه کردن");
            WriteLiteral(@" دانش آموز</a>
                                </div>
                                <div class=""col-md-5"">
                                    <img src=""assets/media/svg/undraw_onboarding_o8mv.svg"" alt=""..."" class=""img-fluid"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-5"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""card-title d-flex justify-content-between"">
                                <h6 class=""card-title"">وضعیت من</h6>
                                <div>
                                    <div class=""dropdown"">
                                        <a href=""#"" data-toggle=""dropdown"" aria-haspopup=""true""
                                           aria-expanded=""false"">
                                            <i class=""fa fa-ellipsis-v"" aria-hidden=");
            WriteLiteral(@"""true""></i>
                                        </a>
                                        <span class=""dropdown-menu dropdown-menu-left"">
                                            <a href=""#"" class=""dropdown-item"">گزارش</a>
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
                            <");
            WriteLiteral(@"div class=""row"">
                                <div class=""col"">
                                    <p class=""mb-0"">
                                        <span class=""fa fa-circle text-danger mr-1""></span>
                                        تکلیف ها انجام نشده
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
            ");
            WriteLiteral(@"    <div class=""col-md-12"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""d-flex align-items-center justify-content-between"">
                                        <div>
                                            <h6 class=""card-title mb-3""> وظیفه های منقضی شده</h6>
                                            <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                                <h2 class=""mb-0 mr-2 font-weight-bold"">350</h2>
                                                <p class=""small text-muted mb-0 line-height-20"">
                                                </p>
                                            </div>
                                        </div>
                                        <div>
                                            <div class=""a");
            WriteLiteral(@"vatar avatar-lg"">
                                                <div class=""avatar-title bg-danger-bright text-danger rounded-circle"">
                                                    <i class=""fa fa-window-close"" aria-hidden=""true""></i>
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
                                            <h6 class=""card-title mb-3"">وظیفه های انجام شده</h6>
                                            <div class=""d-flex d-sm-blo");
            WriteLiteral(@"ck d-lg-flex align-items-end"">
                                                <h2 class=""mb-0 mr-2 font-weight-bold"">554</h2>
                                                <p class=""small text-muted mb-0 line-height-20"">
                                                </p>
                                            </div>
                                        </div>
                                        <div>
                                            <div class=""avatar avatar-lg"">
                                                <div class=""avatar-title bg-success-bright text-success rounded-circle"">
                                                    <i class=""fa fa-check""></i>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
         ");
            WriteLiteral(@"               <div class=""col-md-4"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""d-flex align-items-center justify-content-between"">
                                        <div>
                                            <h6 class=""card-title mb-3""> وظیفه های امروز</h6>
                                            <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                                <h2 class=""mb-0 mr-2 font-weight-bold"">900</h2>
                                                <p class=""small text-muted mb-0 line-height-20"">
                                                </p>
                                            </div>
                                        </div>
                                        <div>
                                            <div class=""avatar avatar-lg"">
                                                <div class=""av");
            WriteLiteral(@"atar-title bg-info-bright text-info rounded-circle"">
                                                    <i class=""fa fa-tasks"" aria-hidden=""true""></i>
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
                        <div class=""card-body"">
                            <div class=""d-flex justify-content-between"">
                                <h6 class=""card-title"">کارهای روزانه</h6>
                                <div>
                                    <a href=""#"" class=""mr-3"">
                                        <i class=""fa fa-refresh""></i>
      ");
            WriteLiteral(@"                              </a>
                                    <div class=""dropdown"">
                                        <a href=""#"" data-toggle=""dropdown"" aria-haspopup=""true""
                                           aria-expanded=""false"">
                                            <i class=""fa fa-ellipsis-v"" aria-hidden=""true""></i>
                                        </a>
                                        <span class=""dropdown-menu dropdown-menu-left"">
                                            <a href=""#"" class=""dropdown-item"">گزارش</a>
                                            <a href=""#"" class=""dropdown-item"">دانلود</a>
                                            <a href=""#"" class=""dropdown-item"">بستن</a>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div class=""custom-control custom-checkbox-success custom-checkbox t");
            WriteLiteral(@"odo-item"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                <label class=""custom-control-label d-flex justify-content-between""
                                       for=""customCheck1"">
                                    صحبت با کاربران جدید
                                    <span class=""text-muted"">13 فروردین 1399</span>
                                </label>
                            </div>
                            <div class=""custom-control custom-checkbox-success custom-checkbox-success custom-checkbox todo-item"">
                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"" checked>
                                <label class=""custom-control-label d-flex justify-content-between""
                                       for=""customCheck2"">
                                    کاربران قدیمی به زودی حذف میشوند
                                    <span class=""text");
            WriteLiteral(@"-muted"">20 فروردین 1399</span>
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
                                <input type=""checkbox"" class=""custom-control-input"" id=""customCheck4"" checked>
                                <label class=""custom-control-label ");
            WriteLiteral(@"d-flex justify-content-between""
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
                            <div class=""custom-control custom-checkbox custom-checkbox-success todo-item"">
                   ");
            WriteLiteral(@"             <input type=""checkbox"" class=""custom-control-input"" id=""customCheck6"">
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
                                    <span class=""text-muted"">13 فروردین 1399</span>
                       ");
            WriteLiteral("         </label>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1db2d68f1a791137b41a5770b992fe6d6554d7f19524", async() => {
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
                            <div class=""row"">
                                <div class=""table-responsive"">
                                    <table class=""table table-hover bg-white text-center"">
                                        <thead class=""thead-dark"">
                                            <tr>
                                                <th scope=""col"">#</th>
                                                <th scope=""col"">نام وظیفه</th>
                                                <th scope=""col"">شرح </th>
                                                <th scope=""col"">تاریخ</th>
                                                <th scope=""col"">عملیات</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                      ");
            WriteLiteral(@"                      <tr>
                                                <th scope=""row"">1</th>
                                                <td>وظیفه یک</td>
                                                <td>توضیحات یک</td>
                                                <td><a href=""#"">11/12/1398</a></td>
                                                <td>
                                                    <button type=""button"" class=""btn btn-primary"" title=""انجام"" data-toggle=""tooltip"" data-placement=""bottom"">
                                                        <i class=""fa fa-check-square-o"" aria-hidden=""true""></i>
                                                        <!-- مودال ویرایش اطلاعات -->


                                                    </button>

                                                    <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
          ");
            WriteLiteral(@"                                              <i class=""fa fa-info"" aria-hidden=""true""></i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <th scope=""row"">2</th>
                                                <td>وظیفه دو</td>
                                                <td>توضیحات دو</td>
                                                <td><a href=""#"">1/10/1398</a></td>
                                                <td>
                                                    <button type=""button"" class=""btn btn-primary"" title=""انجام"" data-toggle=""tooltip"" data-placement=""bottom"">
                                                        <i class=""fa fa-check-square-o"" aria-hidden=""true""></i>
                                                        <!-- مودال ویرایش اطلاعات -->

    ");
            WriteLiteral(@"                                                </button>

                                                    <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
                                                        <i class=""fa fa-info"" aria-hidden=""true""></i>
                                                    </button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <th scope=""row"">3</th>
                                                <td>وظیفه سه</td>
                                                <td>توضیحات سه</td>
                                                <td><a href=""#"">5/2/1399</a></td>
                                                <td>
                                                    <button type=""button"" class=""btn b");
            WriteLiteral(@"tn-primary"" title=""انجام"" data-toggle=""tooltip"" data-placement=""bottom"">
                                                        <i class=""fa fa-check-square-o"" aria-hidden=""true""></i>
                                                        <!-- مودال ویرایش اطلاعات -->

                                                    </button>

                                                    <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
                                                        <i class=""fa fa-info"" aria-hidden=""true""></i>
                                                    </button>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div");
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </Div>\r\n\r\n            <!-- end::main-content -->\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
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
