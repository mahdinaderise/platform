#pragma checksum "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61943114806c83f554be971b6c9cd9f1f4e86596"
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
using WebPlatformV1.ViewModels.Consultant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.StudentViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61943114806c83f554be971b6c9cd9f1f4e86596", @"/Views/Consultant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db76787fbf33d9986710adc22c8a6b542f110a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<todoappc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-success small p-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:35px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("انجام کار"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodoAppDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "consultant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Example text with button addon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("کار جدید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("button-addon1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodoApp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"main-content\">\r\n    <h6> ");
#nullable restore
#line 9 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
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
            WriteLiteral(@"             <img src=""/assets/media/svg/undraw_onboarding_o8mv.svg"" alt=""..."" class=""img-fluid"">
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
                           
                        </div>
                        <h2 class=""mb-3 font-weight-bold"">");
#nullable restore
#line 39 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                                     Write(ViewBag.Tasks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div class=\"progress md-3\">\r\n                            <div class=\"progress-bar bg-danger\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 1978, "\"", 2011, 3);
            WriteAttributeValue("", 1986, "width:", 1986, 6, true);
#nullable restore
#line 41 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
WriteAttributeValue("  ", 1992, ViewBag.NDoTest, 1994, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2010, "%", 2010, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2012, "\"", 2045, 1);
#nullable restore
#line 41 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
WriteAttributeValue(" ", 2028, ViewBag.NDoTest, 2029, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                            <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("style", " style=\"", 2176, "\"", 2207, 3);
            WriteAttributeValue("", 2184, "width:", 2184, 6, true);
#nullable restore
#line 42 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
WriteAttributeValue(" ", 2190, ViewBag.DoTest, 2191, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2206, "%", 2206, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2208, "\"", 2240, 1);
#nullable restore
#line 42 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
WriteAttributeValue(" ", 2224, ViewBag.DoTest, 2225, 15, false);

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
                                    تکلیف ها انجام نشده
                                </p>
                                <h5 class=""mt-2 mb-0"">");
#nullable restore
#line 51 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                                 Write(ViewBag.NDoTest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</h5>
                            </div>


                            <div class=""col"">
                                <p class=""mb-0"">
                                    <span class=""fa fa-circle text-success mr-1""></span>
                                    تکلیف های انجام شده
                                </p>
                                <h5 class=""mt-2 mb-0"">");
#nullable restore
#line 60 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                                 Write(ViewBag.DoTest);

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
                                        <h6 class=""card-title mb-3"">دانش آموزان</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">");
#nullable restore
#line 77 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
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
                                        <h6 class=""card-title mb-3"">تسک های انجام شده</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold"">");
#nullable restore
#line 100 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                                                              Write(ViewBag.tasksdo);

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
                                        <h6 class=""card-title mb-3"">اعتبار مالی</h6>
                                        <div class=""d-flex d-sm-block d-lg-flex align-items-end"">
                                            <h2 class=""mb-0 mr-2 font-weight-bold""> ");
#nullable restore
#line 123 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
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
        <Div class=""row"">
            <div class="" col-md-12"">
                <div class=""card"">
                    <div class");
            WriteLiteral(@"=""card-body"">
                        <div class=""d-flex justify-content-between"">
                            <h6 class=""card-title"">کارهای روزانه</h6>
                           
                        </div>
                        <div class=""custom-control custom-checkbox-success custom-checkbox todo-item"">
");
#nullable restore
#line 151 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                             foreach (var item in Model.Todo)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                 if (Model != null && item.IsFinally == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"form-group d-flex flex-row\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61943114806c83f554be971b6c9cd9f1f4e8659622631", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61943114806c83f554be971b6c9cd9f1f4e8659622934", async() => {
                    WriteLiteral("\r\n                                                <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 8620, "checkbox", 8620, 8, true);
#nullable restore
#line 157 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
AddHtmlAttributeValue(" ", 8628, item.Id, 8629, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                                                                                                                                                                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <label class=\"p-2\"");
            BeginWriteAttribute("for", "\r\n                                               for=\"", 8980, "\"", 9051, 2);
            WriteAttributeValue("", 9034, "checkbox", 9034, 8, true);
#nullable restore
#line 163 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
WriteAttributeValue(" ", 9042, item.Id, 9043, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 164 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                       Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n");
#nullable restore
#line 167 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                 


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61943114806c83f554be971b6c9cd9f1f4e8659629401", async() => {
                WriteLiteral("\r\n                            <div class=\"input-group\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61943114806c83f554be971b6c9cd9f1f4e8659629751", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 176 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.consultantid);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 177 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
                                                                              WriteLiteral(ViewBag.myid);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61943114806c83f554be971b6c9cd9f1f4e8659632406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#nullable restore
#line 178 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Note);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                <div class=""input-group-append"">
                                    <button class=""btn btn-primary"" type=""submit"" id=""button-addon1"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_16.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_16);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </Div>\r\n\r\n    </div>\r\n    <!-- end::main-content -->\r\n\r\n</div>\r\n<!-- end::main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<todoappc> Html { get; private set; }
    }
}
#pragma warning restore 1591
