#pragma checksum "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Students\ido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51749509854714d06fc31683eb45c22d21aba11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_ido), @"mvc.1.0.view", @"/Views/Students/ido.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51749509854714d06fc31683eb45c22d21aba11", @"/Views/Students/ido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a67829122e1bddf11305ae4715d0376510130ffd", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_ido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\gitp\platform\Project\WebPlatformV1\WebPlatformV1\Views\Students\ido.cshtml"
  
    ViewData["Title"] = "ido";
    Layout = "~/Views/Shared/_LayoutConsultant.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
        <!-- اینجا ساخته شود -->
        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""card"">
                    <div class=""card-body"">
                        <br>


                        <label class=""form-control-label"">تعداد تست  :</label>
                        <input id=""state"" class=""form-control"" name=""name_state"" style=""width: 300px;"">

                  ");
            WriteLiteral(@"      <label class=""form-control-label"" style=""margin-top: 5px;"">زمان مطالعه  :</label>
                        <input id=""state"" class=""form-control"" name=""name_state"" style=""width: 300px;"">


                        <!-- Textarea -->
                        <div class=""form-group"">
                            <label class=""form-control-label"" style=""margin-top: 5px;""> توضیحات  :</label>
                            <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                        </div>
                        <button type=""button"" class=""btn btn-success"">ثبت</button>
                        <button type=""button"" class=""btn btn-danger"">لغو</button>
                    </div>
                </div>
            </div>

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
