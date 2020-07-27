#pragma checksum "E:\Naderi\platform\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f42482847be269a3f3c14f6d71e86cfe790d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_students), @"mvc.1.0.view", @"/Views/Consultant/students.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f42482847be269a3f3c14f6d71e86cfe790d78", @"/Views/Consultant/students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e891dc01b2ad2dd83768b6bbd65f5d1b5b520d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultantDashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"    ViewData[""Title""] = ""students"";
    Layout = ""~/Views/Shared/_LayoutConsultant.cshtml"";
}

    <div class=""main-content"">
        <div class=""page-header"">
            <div class=""container-fluid d-sm-flex justify-content-between"">
                <h4>لیست دانش آموزان</h4>
                <nav aria-label=""breadcrumb""/>
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
");
            WriteLiteral(@"             
                <div class=""row"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover bg-white text-center"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th scope=""col"">#</th>
                                    <th scope=""col"">نام وظیفه</th>
                                    <th scope=""col"">توضیحات وظیفه </th>
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
                     ");
            WriteLiteral(@"               <td>
                                        <button type=""button"" class=""btn btn-primary"" title=""ویرایش"" data-toggle=""tooltip"" data-placement=""bottom"">
                                            <i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i>
                                            <!-- مودال ویرایش اطلاعات -->

                                        </button>
                                        <button type=""button"" class=""btn btn-primary"" title=""حذف"" data-toggle=""tooltip"" data-placement=""bottom"">
                                            <i class=""fa fa-times"" aria-hidden=""true""></i>
                                        </button>
                                        <button type=""button"" class=""btn btn-primary"" title=""جزئیات"" data-toggle=""tooltip"" data-placement=""bottom"" style=""padding-right: 20px; padding-left: 20px;"">
                                            <i class=""fa fa-info"" aria-hidden=""true""></i>
                                        </butt");
            WriteLiteral(@"on>
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
                                            <!-- مودال ویرایش اطلاعات -->

                                        </button>
                                        <button type=""button"" class=""btn btn-primary"" title=""حذف"" data-toggle=""tooltip"" data-placement=""bottom"">
                                            <i class=""fa fa-times"" aria-hidden=""true""></i>
");
            WriteLiteral(@"                                        </button>
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
                                        <button type=""button"" class=""btn btn-primary"" title=""ویرایش"" data-toggle=""tooltip"" data-placement=""bottom"">
                                            <i class=""fa fa-pencil-square-o"" aria-");
            WriteLiteral(@"hidden=""true""></i>
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
                        </table>
                    </div>
                </div>
            </div>



        </div>");
            WriteLiteral("\n\r\n");
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
