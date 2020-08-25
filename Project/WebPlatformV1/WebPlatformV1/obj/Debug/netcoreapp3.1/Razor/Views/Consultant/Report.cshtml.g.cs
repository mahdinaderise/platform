#pragma checksum "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ac846d558eb470b3c80fd64ca368f7c0f5a6cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_Report), @"mvc.1.0.view", @"/Views/Consultant/Report.cshtml")]
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
#nullable restore
#line 5 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.StudentViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ac846d558eb470b3c80fd64ca368f7c0f5a6cc", @"/Views/Consultant/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db76787fbf33d9986710adc22c8a6b542f110a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< ReportViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml"
  
    ViewData["Title"] = "Report";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""main-content"">


    <div class=""page-header"">
        <div class=""container-fluid d-sm-flex justify-content-between"">
            <h4>    گزارش ماهانه </h4>
        </div>
    </div>
    <div class=""container-fluid"">
        <!-- اینجا ساخته شود -->



        <div class=""row"">
            <div class=""table-responsive"">
                <table class=""table table-hover bg-white text-center"">
                    <thead class=""thead-dark"">
                        <tr>

                            <th scope=""col"">نام درس</th>
                            <th scope=""col"">  زمان تخصیص داده شده توسط مشاوره  </th>
                            <th scope=""col"">زمان انجام شده توسط دانش آموز  </th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 35 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 40 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml"
                               Write(item.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 43 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml"
                               Write(item.CtimeStudy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 47 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml"
                               Write(item.StimeStudy);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </td>\r\n\r\n\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 54 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\Report.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        }\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <!-- end::main-content -->\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< ReportViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
