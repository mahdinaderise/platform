#pragma checksum "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15550d7659beb970cf1c6f32019f17a7b8d52248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_blog), @"mvc.1.0.view", @"/Views/Consultant/blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15550d7659beb970cf1c6f32019f17a7b8d52248", @"/Views/Consultant/blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db76787fbf33d9986710adc22c8a6b542f110a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("چیزی بنویسید"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString(".jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Consultant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
  
    ViewData["Title"] = "blog";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"main-content\">\r\n\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n\r\n                <div class=\"card\">\r\n                    <div class=\"card-body text-center\">\r\n");
#nullable restore
#line 15 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                         if (Model.ProfilePicUrl == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <figure class=\"avatar\">\r\n                                <span class=\"avatar-title rounded-circle\">");
#nullable restore
#line 18 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                                     Write(ViewBag.fristCharecter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </figure>\r\n");
#nullable restore
#line 20 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <figure class=\" avatar avatar-xl \">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 804, "\"", 841, 3);
            WriteAttributeValue("", 810, "/images/Profile/", 810, 16, true);
#nullable restore
#line 24 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
WriteAttributeValue("", 826, Model.id, 826, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 837, ".jpg", 837, 4, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                     class=\"rounded-circle bg-info\" alt=\"...\">\r\n                            </figure>\r\n");
#nullable restore
#line 27 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 class=\"mb-1\">");
#nullable restore
#line 28 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                Write(Model.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                        <a href=""#"" class=""btn btn-outline-primary"">
                            <i data-feather=""edit-2"" class=""mr-2""></i> ویرایش پروفایل
                        </a>
                    </div>
                    <hr class=""m-0"">
                    <div class=""card-body"">
                        <div class=""row text-center"">
                            <div class=""col-6 text-info"">
                                <h4 class=""font-weight-bold"">");
#nullable restore
#line 37 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                        Write(Model.CountPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <span>پست</span>\r\n                            </div>\r\n                            <div class=\"col-6 text-success\">\r\n                                <h4 class=\"font-weight-bold\">");
#nullable restore
#line 41 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                        Write(Model.CountStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                <span>دانش آموزان</span>
                            </div>

                        </div>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-body"">
                        <h6 class=""card-title d-flex justify-content-between align-items-center"">
                            اطلاعات
                            <a href=""#"" class=""btn btn-outline-light btn-sm"">
                                <i data-feather=""edit-2"" class=""mr-2""></i> ویرایش
                            </a>
                        </h6>
                        <div class=""row mb-2"">
                            <div class=""col-6 text-muted"">نام:</div>
                            <div class=""col-6"">");
#nullable restore
#line 59 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row mb-2\">\r\n                            <div class=\"col-6 text-muted\">نام خانوادگی:</div>\r\n                            <div class=\"col-6\">");
#nullable restore
#line 63 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row mb-2\">\r\n                            <div class=\"col-6 text-muted\">سن:</div>\r\n                            <div class=\"col-6\">");
#nullable restore
#line 67 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n\r\n\r\n                        <div class=\"row mb-2\">\r\n                            <div class=\"col-6 text-muted\">آدرس:</div>\r\n                            <div class=\"col-6\">");
#nullable restore
#line 73 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15550d7659beb970cf1c6f32019f17a7b8d5224815157", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15550d7659beb970cf1c6f32019f17a7b8d5224815506", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 112 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Note);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <div class=""text-right"">
                                <ul class=""list-inline"">
                                    <li class=""list-inline-item"">
                                        <a href=""#"" data-toggle=""tooltip"" title=""افزودن تصویر""
                                           class=""btn btn-outline-light"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15550d7659beb970cf1c6f32019f17a7b8d5224817726", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 119 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Picture);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <i data-feather=\"image\"></i>\r\n                                        </a>\r\n                                    </li>\r\n");
                WriteLiteral(@"                                    <li class=""list-inline-item"">
                                        <button class=""btn btn-primary"">ارسال</button>
                                    </li>
                                </ul>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
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
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-body"">
                        <ul class=""nav nav-pills flex-column flex-sm-row"" id=""myTab"" role=""tablist"">
                            <li class=""flex-sm-fill text-sm-center nav-item"">
                                <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home""
                                   role=""tab"" aria-selected=""true"">پست ها</a>
                            </li>


                        </ul>
                    </div>
                </div>

                <div class=""tab-content"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"">
");
#nullable restore
#line 159 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                         foreach (var item in Model.blog)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card\">\r\n                                <div class=\"card-body\">\r\n                                    <div class=\"d-flex mb-3\">\r\n                                        <div class=\"d-flex align-items-center\">\r\n");
#nullable restore
#line 165 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                             if (Model.ProfilePicUrl == null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <figure class=\"avatar\">\r\n                                                    <span class=\"avatar-title rounded-circle\">");
#nullable restore
#line 168 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                                                         Write(ViewBag.fristCharecter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </figure>\r\n");
#nullable restore
#line 170 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <figure class=\"avatar avatar-sm mr-3\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 8678, "\"", 8715, 3);
            WriteAttributeValue("", 8684, "/images/Profile/", 8684, 16, true);
#nullable restore
#line 174 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
WriteAttributeValue("", 8700, Model.id, 8700, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8711, ".jpg", 8711, 4, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                                 class=\"rounded-circle\" alt=\"...\">\r\n                                        </figure>\r\n");
#nullable restore
#line 177 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <div class=\"d-inline-block\">\r\n                                                <div> ");
#nullable restore
#line 180 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 180 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                             Write(Model.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral(@"                                            </div>
                                        </div>
                                        <div class=""dropdown ml-auto"">
                                            <a href=""#"" data-toggle=""dropdown"">
                                                <i class=""fa fa-ellipsis-v""></i>
                                            </a>
                                            <div class=""dropdown-menu dropdown-menu-right"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15550d7659beb970cf1c6f32019f17a7b8d5224826697", async() => {
                WriteLiteral("ویرایش");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                                                                        WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15550d7659beb970cf1c6f32019f17a7b8d5224829257", async() => {
                WriteLiteral("حذف");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 190 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                                                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                    <p>");
#nullable restore
#line 194 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                  Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"row row-xs\">\r\n                                        <div class=\"col-12\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 10328, "\"", 10356, 3);
            WriteAttributeValue("", 10334, "/images/", 10334, 8, true);
#nullable restore
#line 197 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
WriteAttributeValue("", 10342, item.ID, 10342, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10352, ".JPG", 10352, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100 border-radius-1""
                                                 alt=""image"">
                                        </div>

                                    </div>
                                    <div class=""d-flex justify-content-between align-items-center mt-4"">
");
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 213 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <!-- begin::footer -->\r\n    <!-- end::footer -->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
