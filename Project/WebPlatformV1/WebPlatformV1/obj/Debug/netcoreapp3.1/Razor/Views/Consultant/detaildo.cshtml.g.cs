#pragma checksum "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c430543947c46c308a23c8607c204403059820a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_detaildo), @"mvc.1.0.view", @"/Views/Consultant/detaildo.cshtml")]
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
#line 1 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Consultant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.StudentViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c430543947c46c308a23c8607c204403059820a", @"/Views/Consultant/detaildo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb22dfadcffadcb5e8623a0efad498c6bfb74f15", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_detaildo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<detaildo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
  
    ViewData["Title"] = "detaildo";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""main-content"">
        <div class=""page-header"">
            <div class=""container-fluid d-sm-flex justify-content-between"">
                <h4>گزارش اجرای دانش آموز</h4>

            </div>
        </div>
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""table-responsive"">
                    <table class=""table table-hover bg-white text-center"">
                        <thead class=""thead-dark"">
                            <tr>
                                <th scope=""col"">تعداد تست غلط</th>
                                <th scope=""col"">تعداد تست درست </th>
                                <th scope=""col""> تعداد تست خالی </th>
                                <th scope=""col"">  زمان برای  تشریحی</th>
                                <th scope=""col"">  زمان برای  تست</th>
                                <th scope=""col"">  زمان برای  بررسی</th>
                            </tr>
                        </thead>
                  ");
            WriteLiteral("      <tbody>\r\n\r\n                            <tr>\r\n\r\n                                <td> ");
#nullable restore
#line 31 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
                                Write(Model.falseTest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 32 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
                                Write(Model.TrueTest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 33 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
                                Write(Model.NullTest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 34 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
                                Write(Model.DiscriptiveTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 35 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
                                Write(Model.TestTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 36 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\detaildo.cshtml"
                                Write(Model.RevisionTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<detaildo> Html { get; private set; }
    }
}
#pragma warning restore 1591
