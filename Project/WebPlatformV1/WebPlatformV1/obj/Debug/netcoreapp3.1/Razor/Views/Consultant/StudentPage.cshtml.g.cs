#pragma checksum "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7305feab5d5798d6f3d1ec1aaaa2533c1ff29561"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_StudentPage), @"mvc.1.0.view", @"/Views/Consultant/StudentPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7305feab5d5798d6f3d1ec1aaaa2533c1ff29561", @"/Views/Consultant/StudentPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db76787fbf33d9986710adc22c8a6b542f110a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_StudentPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TasksStudents>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTask", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Consultant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "consultant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:0px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("جزئیات"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-right: 20px; padding-left: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detaildo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/persianDatePicker/calendar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/persianDatePicker/jquery.Bootstrap-PersianDateTimePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebPlatformV1.TagHelpers.PersianDateTagHelper __WebPlatformV1_TagHelpers_PersianDateTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
  
    ViewData["Title"] = "StudentPage";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""page-header"">
        <div class=""container-fluid d-sm-flex justify-content-between"">
            <h4>شرح وظایف دانش آموز</h4>

        </div>
    </div>
    <div class=""container-fluid"">
        <h5>نام و نام خانوادگی دانش آموز</h5>
");
#nullable restore
#line 16 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
         foreach (var item in Model.Students)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>\r\n                ");
#nullable restore
#line 19 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
                      Write(item.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </h5>\r\n");
#nullable restore
#line 22 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div style=\"margin-bottom: 20px; \" class=\"d-flex justify-content-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7305feab5d5798d6f3d1ec1aaaa2533c1ff2956111428", async() => {
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-success btn-uppercase\">\r\n                    <i class=\"ti-check-box mr-2\"></i>  ایجاد وظیفه برای دانش آموز\r\n                </button>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n        <div class=\"d-flex justify-content-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7305feab5d5798d6f3d1ec1aaaa2533c1ff2956113572", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"form-group mx-sm-3 mb-2\">\r\n                    <label for=\"inputPassword2\" class=\"sr-only\">تاریخ</label>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("persian-date", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7305feab5d5798d6f3d1ec1aaaa2533c1ff2956113999", async() => {
                }
                );
                __WebPlatformV1_TagHelpers_PersianDateTagHelper = CreateTagHelper<global::WebPlatformV1.TagHelpers.PersianDateTagHelper>();
                __tagHelperExecutionContext.Add(__WebPlatformV1_TagHelpers_PersianDateTagHelper);
#nullable restore
#line 41 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
__WebPlatformV1_TagHelpers_PersianDateTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StartDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __WebPlatformV1_TagHelpers_PersianDateTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-primary mb-2 \">جست و جو</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>     \r\n       \r\n");
#nullable restore
#line 48 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>برای امروز وظیفه ای ایجاد نکردی</h1>\r\n");
#nullable restore
#line 51 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""table-responsive"">
                <table class=""table table-hover bg-white text-center"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">نام وظیفه</th>
                            <th scope=""col"">توضیحات وظیفه </th>
                            <th scope=""col""> انجام شده </th>
                            <th scope=""col"">مدیریت</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 64 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
                         foreach (var item in Model.tasks)
                        {
                            if (item != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td> ");
#nullable restore
#line 70 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
                                    Write(item.NameTasks);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
#nullable restore
#line 71 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
                                    Write(item.Descibtion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 73 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
                                   Write(Html.CheckBoxFor(m => item.isDo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>

                                        <button type=""button"" class=""btn btn-primary"" title=""حذف"" data-toggle=""tooltip"" data-placement=""bottom"">
                                            <i class=""fa fa-times"" aria-hidden=""true""></i>
                                        </button>

                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7305feab5d5798d6f3d1ec1aaaa2533c1ff2956120343", async() => {
                WriteLiteral("\r\n                                            <i class=\"fa fa-info\" aria-hidden=\"true\"></i>\r\n\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"
                                                                                                                                                                                                                                     WriteLiteral(item.IdoId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 87 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\StudentPage.cshtml"


                            }
                            
                        

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
            DefineSection("MyScripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7305feab5d5798d6f3d1ec1aaaa2533c1ff2956124113", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7305feab5d5798d6f3d1ec1aaaa2533c1ff2956125214", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <div class=""popover fade left in"" role=""tooltip"" id=""popover308426"" style=""top: 44.5px; left: 915px; display: block;""><div class=""arrow"" style=""top: 50%;""></div><h3 class=""popover-title"" data-name=""Md-DateTimePicker-Title"">پنج شنبه، ۰۱ فروردین ۱۳۹۲</h3><div class=""popover-content"" data-name=""Md-DateTimePicker-PopoverContent""><div data-name=""Md-PersianDateTimePicker""><table class=""table table-striped""><tbody><tr><td colspan=""100"" style=""padding:5px;""><table class=""table"" data-name=""Md-PersianDateTimePicker-HeaderTable""><tbody><tr><td><button type=""button"" class=""btn btn-default btn-xs"" title=""سال بعد"" data-name=""Md-PersianDateTimePicker-NextYear"">&lt;&lt;</button></td><td><button type=""button"" class=""btn btn-default btn-xs"" title=""ماه بعد"" data-name=""Md-PersianDateTimePicker-NextMonth"">&lt;</button></td><td data-name=""Md-PersianDateTimePicker-TitleYear"">۱۳۹۲</td><td data-name=""Md-PersianDateTimePicker-TitleMonth"">فروردین</td><td><button type=""button"" class=""btn btn-default btn-xs"" title=""ماه قبل"" data-na");
                WriteLiteral(@"me=""Md-PersianDateTimePicker-PreviousMonth"">&gt;</button></td><td><button type=""button"" class=""btn btn-default btn-xs"" title=""سال قبل"" data-name=""Md-PersianDateTimePicker-PreviousYear"">&gt;&gt;</button></td></tr></tbody></table></td></tr><tr data-name=""Md-PersianDateTimePicker-WeekDaysNames""><td>ش</td><td>ی</td><td>د</td><td>س</td><td>چ</td><td>پ</td><td class=""text-danger"">ج</td></tr><tr><td data-name=""disabled-day"">۲۷</td><td data-name=""disabled-day"">۲۸</td><td data-name=""disabled-day"">۲۹</td><td data-name=""disabled-day"">۳۰</td><td data-name=""disabled-day"">۳۱</td><td data-name=""day"" class=""bg-info"">۰۱</td><td data-name=""day"" class=""text-danger"">۰۲</td></tr><tr><td data-name=""day"">۰۳</td><td data-name=""day"">۰۴</td><td data-name=""day"">۰۵</td><td data-name=""day"">۰۶</td><td data-name=""day"">۰۷</td><td data-name=""day"">۰۸</td><td data-name=""day"" class=""text-danger"">۰۹</td></tr><tr><td data-name=""day"">۱۰</td><td data-name=""day"">۱۱</td><td data-name=""day"">۱۲</td><td data-name=""day"">۱۳</td><td data-name=""day"">۱۴</td>");
                WriteLiteral(@"<td data-name=""day"">۱۵</td><td data-name=""day"" class=""text-danger"">۱۶</td></tr><tr><td data-name=""day"">۱۷</td><td data-name=""day"">۱۸</td><td data-name=""day"">۱۹</td><td data-name=""day"">۲۰</td><td data-name=""day"">۲۱</td><td data-name=""day"">۲۲</td><td data-name=""day"" class=""text-danger"">۲۳</td></tr><tr><td data-name=""day"">۲۴</td><td data-name=""day"">۲۵</td><td data-name=""day"">۲۶</td><td data-name=""day"">۲۷</td><td data-name=""day"">۲۸</td><td data-name=""day"">۲۹</td><td data-name=""day"" class=""text-danger"">۳۰</td></tr><tr><td colspan=""100""><button class=""btn btn-default btn-xs"" data-name=""go-today"">امروز</button></td></tr></tbody></table></div></div></div>

");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TasksStudents> Html { get; private set; }
    }
}
#pragma warning restore 1591
