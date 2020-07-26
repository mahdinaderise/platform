#pragma checksum "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a7ba34c259c6fbcff89d82214f0eeb07117fc39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultant_invoice), @"mvc.1.0.view", @"/Views/Consultant/invoice.cshtml")]
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
#nullable restore
#line 3 "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\_ViewImports.cshtml"
using WebPlatformV1.ViewModels.Consultant;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7ba34c259c6fbcff89d82214f0eeb07117fc39", @"/Views/Consultant/invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e891dc01b2ad2dd83768b6bbd65f5d1b5b520d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultant_invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Naderi\platform\Project\WebPlatformV1\WebPlatformV1\Views\Consultant\invoice.cshtml"
  
    ViewData["Title"] = "invoice";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">

    <div class=""container-fluid"">
        <!-- اینجا ساخته شود -->

        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""card"">
                    <div class=""card-body p-50"">
                        <div class=""invoice"">
                            <div class=""d-md-flex justify-content-between align-items-center"">
                                <h2 class=""font-weight-800 d-flex align-items-center"">
                                </h2>
                                <h3 class=""text-xs-left m-b-0"">صورتحساب #INV-16</h3>
                            </div>
                            <hr class=""m-t-b-50"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <p>
                                        <b>قالب مدیریتی بورداش</b>
                                    </p>
                                    <p>اصفهان,<br>جلفا ,<br>پلاک 1</p>
");
            WriteLiteral(@"                                </div>
                                <div class=""col-md-6"">
                                    <p class=""text-right"">
                                        <b>صورتحساب به </b>
                                    </p>
                                    <p class=""text-right"">اصفهان &amp; ولیعصر,<br> کوچه یک<br> پلاک 125</p>
                                </div>
                            </div>
                            <div class=""table-responsive"">
                                <table class=""table mb-4 mt-4"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th>#</th>
                                            <th>توضیحات</th>
                                            <th class=""text-right"">روز</th>
                                            <th class=""text-right"">قیمت هر واحد</th>
                                            <th class=""text-rig");
            WriteLiteral(@"ht"">جمع کل</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class=""text-right"">
                                            <td class=""text-right"">1</td>
                                            <td class=""text-right"">تعرفه</td>
                                            <td>60</td>
                                            <td> 50,000</td>
                                            <td> 3,000,000</td>
                                        </tr>

                                    </tbody>
                                </table>
                            </div>
                            <div class=""text-left"">
                                <p>بهای کل بدون مالیات:  3,000,000  </p>
                                <p>مالیات (10%) : 300,000</p>
                                <h4 class=""font-weight-800"">کل : 3,300,000</h4>
                      ");
            WriteLiteral(@"      </div>
                            <p class=""text-center small text-muted  m-t-50"">
                                <span class=""row"">
                                    <span class=""col-md-12 offset-3"">
                                        لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است
                                    </span>
                                </span>
                            </p>
                        </div>
                        <div class=""text-left d-print-none"">
                            <hr class=""mb-5 mt-5"">
                            <a href=""#"" class=""btn btn-primary"">
                                <i data-feather=""send"" class=""mr-2""></i>پرداخت صورتحساب
                            </a>
                            <a href=""javascript:window.print()"" class=""btn btn-success m-l-5"">
                                <i data-feather=""printer"" class=""mr-2""></i> پرینت
                            </a>
        ");
            WriteLiteral("                </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <!-- end::main-content -->\r\n\r\n</div>");
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
