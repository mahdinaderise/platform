#pragma checksum "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c92ce0f7ee5cee53e94d9634754280c368d723"
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
#nullable restore
#line 5 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.StudentViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c92ce0f7ee5cee53e94d9634754280c368d723", @"/Views/Consultant/blog.cshtml")]
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
  
    ViewData["Title"] = "blog";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">

    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-4"">

                <div class=""card"">
                    <div class=""card-body text-center"">
                        <figure class=""avatar avatar-lg m-b-20"">
                            <img src=""assets/media/image/user/man_avatar1.jpg"" class=""rounded-circle"" alt=""..."">
                        </figure>
                        <h5 class=""mb-1"">");
#nullable restore
#line 18 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 18 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
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
#line 27 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                        Write(Model.CountPost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <span>پست</span>\r\n                            </div>\r\n                            <div class=\"col-6 text-success\">\r\n                                <h4 class=\"font-weight-bold\">");
#nullable restore
#line 31 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
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
#line 49 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row mb-2\">\r\n                            <div class=\"col-6 text-muted\">نام خانوادگی:</div>\r\n                            <div class=\"col-6\">");
#nullable restore
#line 53 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        <div class=\"row mb-2\">\r\n                            <div class=\"col-6 text-muted\">سن:</div>\r\n                            <div class=\"col-6\">");
#nullable restore
#line 57 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                       \r\n                      \r\n                        <div class=\"row mb-2\">\r\n                            <div class=\"col-6 text-muted\">آدرس:</div>\r\n                            <div class=\"col-6\">");
#nullable restore
#line 63 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                          Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                        \r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c92ce0f7ee5cee53e94d9634754280c368d72312435", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c92ce0f7ee5cee53e94d9634754280c368d72312784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 102 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04c92ce0f7ee5cee53e94d9634754280c368d72315010", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 109 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Picture);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
#line 149 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                         foreach (var item in Model.blog)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""d-flex mb-3"">
                                        <div class=""d-flex align-items-center"">
                                            <figure class=""avatar avatar-sm mr-3"">
                                                <img src=""assets/media/image/user/man_avatar3.jpg""
                                                     class=""rounded-circle"" alt=""..."">
                                            </figure>
                                            <div class=""d-inline-block"">
                                                <div> ");
#nullable restore
#line 160 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 160 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
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
                                                <a href=""#"" class=""dropdown-item"">ویرایش</a>
                                                <a href=""#"" class=""dropdown-item"">حذف</a>
                                            </div>
                                        </div>
                                    </div>
                                    <p>");
#nullable restore
#line 174 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
                                  Write(item.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"row row-xs\">\r\n                                        <div class=\"col-12\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 9169, "\"", 9197, 3);
            WriteAttributeValue("", 9175, "/images/", 9175, 8, true);
#nullable restore
#line 177 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"
WriteAttributeValue("", 9183, item.ID, 9183, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9193, ".JPG", 9193, 4, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100 border-radius-1""
                                                 alt=""image"">
                                        </div>

                                    </div>
                                    <div class=""d-flex justify-content-between align-items-center mt-4"">
");
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 193 "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\blog.cshtml"

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
