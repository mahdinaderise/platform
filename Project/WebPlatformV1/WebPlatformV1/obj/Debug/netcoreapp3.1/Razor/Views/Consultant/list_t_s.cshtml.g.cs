#pragma checksum "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\list_t_s.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd20f6c931e7a79465b65387d48f8abf19a684d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_list_t_s), @"mvc.1.0.view", @"/Views/Consultant/list_t_s.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd20f6c931e7a79465b65387d48f8abf19a684d7", @"/Views/Consultant/list_t_s.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db76787fbf33d9986710adc22c8a6b542f110a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_list_t_s : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\list_t_s.cshtml"
  
    ViewData["Title"] = "list_t_s";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">

    <div class=""container-fluid"">

        <!-- اینجا ساخته شود -->
        <div class=""table-responsive"">
            <!-- Required for Responsive -->
            <table class=""table table-striped table-bordered bg-white"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>ردیف</th>
                        <th>نام</th>
                        <th>پایه</th>
                        <th>وضعیت</th>
                        <th>تاریخ</th>

                    </tr>
                </thead>
                <tr>
                    <td>1 </td>
                    <td> هدی محمدی</td>
                    <td>سوم</td>
                    <td>انجام شده</td>
                    <td>1398/01/25</td>
                </tr>
                <tr>
                    <td>2 </td>
                    <td>  زهرا  محمدی</td>
                    <td>پنجم</td>
                    <td>انجام نشده</td>
                    <td>-</td>
");
            WriteLiteral(@"                </tr>
                <tr>
                    <td> </td>
                    <td> </td>
                    <td>  </td>
                    <td>  </td>
                    <td> </td>
                </tr>
                <tr>
                    <td> </td>
                    <td> </td>
                    <td>  </td>
                    <td>  </td>
                    <td> </td>
                </tr>


                <tbody>
                </tbody>

            </table>
        </div>
    </div>
    <!-- end::main-content -->

</div>

");
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
