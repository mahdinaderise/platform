#pragma checksum "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe610d539eae6a675848dcd3387e3a4e39b42d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AcceptDeagre), @"mvc.1.0.view", @"/Views/Admin/AcceptDeagre.cshtml")]
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
#nullable restore
#line 6 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afe610d539eae6a675848dcd3387e3a4e39b42d0", @"/Views/Admin/AcceptDeagre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb22dfadcffadcb5e8623a0efad498c6bfb74f15", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AcceptDeagre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DegreeCheck>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptDeagre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectDeagre", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActiveAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
  
    ViewData["Title"] = "AcceptDeagre";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">

    <div class=""container-fluid"">
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
#line 21 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
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
");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 86 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
         if (Model.Degree==null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>تمام مدارک فرد تایید شده</h3>\r\n");
#nullable restore
#line 89 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- end::main-content -->\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 92 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
         if (Model.Degree.Count != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
             foreach (var item in Model.Degree)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\" style=\"margin-bottom:20px\">\r\n                    <div class=\"card\">\r\n\r\n");
#nullable restore
#line 100 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
                         if (item.type == "Melli")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-body\">\r\n                                <h6 class=\" card-title\">عکس کارت ملی</h6>\r\n                            </div>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5409, "\"", 5448, 3);
            WriteAttributeValue("", 5415, "/images/Degree/", 5415, 15, true);
#nullable restore
#line 104 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
WriteAttributeValue("", 5430, ViewBag.id, 5430, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5443, "m.jpg", 5443, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"image\">\r\n");
#nullable restore
#line 105 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
                         if (item.type == "Degree")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-body\">\r\n                                <h6 class=\" card-title\">عکس مدرک</h6>\r\n                            </div>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 5756, "\"", 5794, 3);
            WriteAttributeValue("", 5762, "/images/Degree/", 5762, 15, true);
#nullable restore
#line 111 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
WriteAttributeValue("", 5777, ViewBag.id, 5777, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5790, ".jpg", 5790, 4, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"image\">\r\n");
#nullable restore
#line 112 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-12  bg-white\">\r\n                        <div class=\"d-flex justify-content-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afe610d539eae6a675848dcd3387e3a4e39b42d012064", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-success\" style=\"margin:10px\">تایید مدرک</button>\r\n                            ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afe610d539eae6a675848dcd3387e3a4e39b42d015126", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-danger\" style=\"margin:10px\">رد مدرک</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
                                                                                     WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 136 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
                        


            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>تمام مدارک مشاور تایید شده لطفا بر روی قسمت فعال سازی کلیک کنید.</h5>\r\n            <div class=\"col-12  bg-white\">\r\n                <div class=\"d-flex justify-content-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afe610d539eae6a675848dcd3387e3a4e39b42d018943", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-success\" style=\"margin:10px\">فعال سازی</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
                                                                              WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                   \r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 153 "E:\GitHub\newplatform\Project\WebPlatformV1\WebPlatformV1\Views\Admin\AcceptDeagre.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DegreeCheck> Html { get; private set; }
    }
}
#pragma warning restore 1591
