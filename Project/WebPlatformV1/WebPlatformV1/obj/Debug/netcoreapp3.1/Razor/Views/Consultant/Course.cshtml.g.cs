#pragma checksum "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2daa30616008549ec29522631a720bdcd2fe59d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_Course), @"mvc.1.0.view", @"/Views/Consultant/Course.cshtml")]
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
#line 1 "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2daa30616008549ec29522631a720bdcd2fe59d", @"/Views/Consultant/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67829122e1bddf11305ae4715d0376510130ffd", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Course.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""main-content"">
        <div class=""page-header"">
            <div class=""container-fluid d-sm-flex justify-content-between"">
                <h4>لیست درس</h4>
                <nav aria-label=""breadcrumb"">
                    <!-- <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">
                            <a href=""#"">داشبرد</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page""></li>
                    </ol>
                </nav> -->
            </div>
        </div>
        <div class=""container-fluid"">

            <div style=""margin-bottom: 20px;"">
                <button type=""button"" class=""btn btn-success btn-uppercase"" data-toggle=""modal"" data-target=""#exampleModal"">
                    <i class=""ti-check-box mr-2""></i>  ایجاد درس
                </button>

                <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""exampleModal"">
                    <div class=""modal-d");
            WriteLiteral("ialog\" role=\"document\">\r\n                        <div class=\"modal-content\">\r\n                            <div class=\"modal-header\">\r\n                                <h5");
            BeginWriteAttribute("class", " class=\"", 1294, "\"", 1302, 0);
            EndWriteAttribute();
            WriteLiteral(@">ایجاد درس</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">×</span>
                                </button>
                            </div>

                            <div class=""modal-body"">
                                <div>
                                    <label class=""form-control-label"">نام درس :</label>
                                    <input id=""state"" class=""form-control"" name=""name_state"">
                                </div>
                                <div class=""form-group wd-xs-300"">

                                    <div class=""valid-feedback"">
                                        عالی!
                                    </div>
                                </div>


                                <!-- Textarea -->
                                <div class=""form-group"">
                                    <label for=""");
            WriteLiteral(@"exampleFormControlTextarea1""> شرح توضیحات</label>
                                    <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                                </div>

                            </div>

                        </div>
                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">بستن</button>
                            <button type=""button"" class=""btn btn-primary"">اعمال تغییرات</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""table-responsive"">
                <table class=""table table-hover bg-white text-center"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">نام وظیفه</th>
                        ");
            WriteLiteral(@"    <th scope=""col"">توضیحات وظیفه </th>
                            <th scope=""col"">لیست افراد</th>
                            <th scope=""col"">مدیریت</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">1</th>
                            <td>وظیفه یک</td>
                            <td>توضیحات یک</td>
                            <td><a href=""#"">نمایش</a></td>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" title=""ویرایش"" data-toggle=""tooltip"" data-placement=""bottom"">
                                    <i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i>
                                    <!-- مودال ویرایش اطلاعات -->

                                </button>
                                <button type=""button"" class=""btn btn-primary"" title=""حذف"" data-toggle=""tooltip"" data-placement=""bottom"">
                  ");
            WriteLiteral(@"                  <i class=""fa fa-times"" aria-hidden=""true""></i>
                                </button>
                                <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
                                    <i class=""fa fa-info"" aria-hidden=""true""></i>
                                </button>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">2</th>
                            <td>وظیفه دو</td>
                            <td>توضیحات دو</td>
                            <td><a href=""#"">نمایش</a></td>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" title=""ویرایش"" data-toggle=""tooltip"" data-placement=""bottom"">
                                    <i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i>
                          ");
            WriteLiteral(@"          <!-- مودال ویرایش اطلاعات -->

                                </button>
                                <button type=""button"" class=""btn btn-primary"" title=""حذف"" data-toggle=""tooltip"" data-placement=""bottom"">
                                    <i class=""fa fa-times"" aria-hidden=""true""></i>
                                </button>
                                <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
                                    <i class=""fa fa-info"" aria-hidden=""true""></i>
                                </button>
                            </td>
                        </tr>
                        <tr>
                            <th scope=""row"">3</th>
                            <td>وظیفه سه</td>
                            <td>توضیحات سه</td>
                            <td><a href=""#"">نمایش</a></td>
                            <td>
                   ");
            WriteLiteral(@"             <button type=""button"" class=""btn btn-primary"" title=""ویرایش"" data-toggle=""tooltip"" data-placement=""bottom"">
                                    <i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i>
                                    <!-- مودال ویرایش اطلاعات -->

                                </button>
                                <button type=""button"" class=""btn btn-primary"" title=""حذف"" data-toggle=""tooltip"" data-placement=""bottom"">
                                    <i class=""fa fa-times"" aria-hidden=""true""></i>
                                </button>
                                <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
                                    <i class=""fa fa-info"" aria-hidden=""true""></i>
                                </button>
                            </td>
                        </tr>
                    </tbody>
                </t");
            WriteLiteral("able>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n");
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
