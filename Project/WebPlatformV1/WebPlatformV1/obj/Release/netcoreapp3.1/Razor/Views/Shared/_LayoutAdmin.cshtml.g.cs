#pragma checksum "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Shared\_LayoutAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "151cd390e3a5e0e6f4868a6174d7405bb61b974e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAdmin), @"mvc.1.0.view", @"/Views/Shared/_LayoutAdmin.cshtml")]
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
using WebPlatformV1.ViewModels.ConsultantViewModel;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151cd390e3a5e0e6f4868a6174d7405bb61b974e", @"/Views/Shared/_LayoutAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ae6053615c6228361e0c4a0af90505855f00e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOutAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("خروج"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConsultantManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActiveConsultantManagement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151cd390e3a5e0e6f4868a6174d7405bb61b974e7666", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>  صفحه اصلی - داشبرد مدیر</title>

    <!-- Favicon -->
    <link rel=""shortcut icon"" href=""/assets/media/image/favicon.png"" />

    <!-- Plugin styles -->
    <link rel=""stylesheet"" href=""/vendors/bundle.css"" type=""text/css"">

    <!-- Datepicker -->
    <link rel=""stylesheet"" href=""/vendors/datepicker/daterangepicker.css"">
    <link rel=""stylesheet"" href=""/assets/Datepiker/persian-datepicker.css"">


    <!-- Fullcalendar -->
    <link rel=""stylesheet"" href=""/vendors/fullcalendar/fullcalendar.min.css"" type=""text/css"">
    <link href='/assets/Cal/fullcalendar.css' rel='stylesheet' />
    <link href='/assets/Cal/fullcalendar.print.css' rel='stylesheet' media='print' />

    <!-- Vmap -->
    <link rel=""stylesheet"" href=""/vendors/vmap/jqvmap.min.css"">

    <!-- App styles -->
    <link rel=""stylesheet"" href=""/assets/cs");
                WriteLiteral("s/app.min.css\" type=\"text/css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151cd390e3a5e0e6f4868a6174d7405bb61b974e9767", async() => {
                WriteLiteral(@"

    <!-- begin::preloader-->
    <div class=""preloader"">
        <div class=""preloader-icon""></div>
    </div>
    <!-- end::preloader -->
    <!-- begin::header -->
    <div class=""header"">

        <div>
            <ul class=""navbar-nav"">

                <!-- begin::navigation-toggler -->
                <li class=""nav-item navigation-toggler"">
                    <a href=""#"" class=""nav-link"" title=""Hide navigation"">
                        <i data-feather=""arrow-left""></i>
                    </a>
                </li>
                <li class=""nav-item navigation-toggler mobile-toggler"">
                    <a href=""#"" class=""nav-link"" title=""Show navigation"">
                        <i data-feather=""menu""></i>
                    </a>
                </li>
                <!-- end::navigation-toggler -->
                <!-- <li class=""nav-item dropdown"">
                    <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">اپ ها</a>
                    <");
                WriteLiteral(@"div class=""dropdown-menu dropdown-menu-big dropdown-menu-right"">
                        <div class=""p-3"">
                            <div class=""row row-xs"">
                                <div class=""col-6"">
                                    <a href=""chat.html"">
                                        <div class=""p-3 border-radius-1 border text-center mb-3"">
                                            <i class=""width-23 height-23"" data-feather=""message-circle""></i>
                                            <div class=""mt-2"">چت</div>
                                        </div>
                                    </a>
                                </div>
                                <div class=""col-6"">
                                    <a href=""inbox.html"">
                                        <div class=""p-3 border-radius-1 border text-center mb-3"">
                                            <i class=""width-23 height-23"" data-feather=""mail""></i>
                            ");
                WriteLiteral(@"                <div class=""mt-2"">ایمیل</div>
                                        </div>
                                    </a>
                                </div>
                                <div class=""col-6"">
                                    <a href=""app-todo.html"">
                                        <div class=""p-3 border-radius-1 border text-center"">
                                            <i class=""width-23 height-23"" data-feather=""check-circle""></i>
                                            <div class=""mt-2"">تو دو</div>
                                        </div>
                                    </a>
                                </div>
                                <div class=""col-6"">
                                    <a href=""file-manager.html"">
                                        <div class=""p-3 border-radius-1 border text-center"">
                                            <i class=""width-23 height-23"" data-feather=""file""></i>
            ");
                WriteLiteral(@"                                <div class=""mt-2"">فایل منیجر</div>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </li> -->
            </ul>
        </div>

        <div>
            <ul class=""navbar-nav"">

                <!-- <li class=""nav-item"">
                    <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"">
                        <img width=""18"" class=""mr-2"" src=""assets/media/image/flags/261-china.png"" alt=""flag""> چین
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a href=""#"" class=""dropdown-item"">
                            <img width=""18"" src=""assets/media/image/flags/003-tanzania.png"" class=""mr-2"" alt=""flag"">
                            تانزانیا
                        </a>
                      ");
                WriteLiteral(@"  <a href=""#"" class=""dropdown-item"">
                            <img width=""18"" src=""assets/media/image/flags/262-united-kingdom.png"" class=""mr-2""
                                 alt=""flag""> انگلستان
                        </a>
                        <a href=""#"" class=""dropdown-item"">
                            <img width=""18"" src=""assets/media/image/flags/013-tunisia.png"" class=""mr-2"" alt=""flag"">
                            تونس
                        </a>
                        <a href=""#"" class=""dropdown-item"">
                            <img width=""18"" src=""assets/media/image/flags/044-spain.png"" class=""mr-2"" alt=""flag""> اسپانیا
                        </a>
                    </div>
                </li> -->
                <!-- begin::header search -->
");
                WriteLiteral(@"                <!-- end::header search -->
                <!-- begin::header minimize/maximize -->
                <li class=""nav-item dropdown"">
                    <a href=""#"" class=""nav-link"" title=""تمام صفحه"" data-toggle=""fullscreen"">
                        <i class=""maximize"" data-feather=""maximize""></i>
                        <i class=""minimize"" data-feather=""minimize""></i>
                    </a>
                </li>
                <!-- end::header minimize/maximize -->
                <!-- begin::header messages dropdown -->
                <!-- end::header messages dropdown -->
                <!-- begin::header notification dropdown -->
       
                <!-- end::header notification dropdown -->
                <!-- begin::user menu -->
                <!-- end::user menu -->
            </ul>

            <!-- begin::mobile header toggler -->
            <ul class=""navbar-nav d-flex align-items-center"">
                <li class=""nav-item header-toggler"">
        ");
                WriteLiteral(@"            <a href=""#"" class=""nav-link"">
                        <i data-feather=""arrow-down""></i>
                    </a>
                </li>
            </ul>
            <!-- end::mobile header toggler -->
        </div>

    </div>
    <!-- end::header -->
    <!-- begin::main -->
    <div id=""main"">

        <!-- begin::navigation -->
        <div class=""navigation"">

            <div class=""navigation-menu-tab"">
                <div>
                    <!--<div class=""navigation-menu-tab-header"" data-toggle=""tooltip"" title=""مهدی نظری"" data-placement=""right"">
                        <a href=""#"" class=""nav-link"" data-toggle=""dropdown"" aria-expanded=""false"">
                            <figure class=""avatar avatar-sm"">
                                <img src=""assets/media/image/user/man_avatar5.jpg"" class=""rounded-circle"" alt=""avatar"">
                            </figure>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-left dropdow");
                WriteLiteral(@"n-menu-big"">
                            <div class=""p-3 text-center"" data-backround-image=""assets/media/image/image1.jpg"">
                                <figure class=""avatar mb-3"">
                                    <img src=""assets/media/image/user/man_avatar5.jpg"" class=""rounded-circle"" alt=""image"">
                                </figure>
                                <h6 class=""d-flex align-items-center justify-content-center"">

                                    مهدی نظری
                                    <a href=""#"" class=""btn btn-primary btn-sm ml-2"" data-toggle=""tooltip"" title=""ویرایش پروفایل"">
                                        <i data-feather=""edit-2""></i>
                                    </a>
                                </h6>-->
");
                WriteLiteral(@"                            <!--</div>
                            <div class=""dropdown-menu-body"">
                                <div class=""border-bottom p-4"">
                                    <h6 class=""text-uppercase font-size-11 d-flex justify-content-between"">
                                        حافظه
                                        <span>%25</span>
                                    </h6>
                                    <div class=""progress"" style=""height: 8px;"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 35%;""
                                             aria-valuenow=""35""
                                             aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                                <div class=""list-group list-group-flush"">
                                    <a href=""#"" class=""list-group-item"">پروفایل</a>
  ");
                WriteLiteral(@"                                
                                    <a href=""#"" class=""list-group-item text-danger"" data-sidebar-target=""#settings"">خروج</a>
                                </div>
                            </div>
                        </div>
                    </div>-->
                </div>
                <div class=""flex-grow-1"">
                    <ul>
                        <li>
                            <a class=""active"" href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""داشبرد""
                               data-nav-target=""#dashboards"">
                                <i data-feather=""bar-chart-2""></i>
                            </a>
                        </li>

                  
                        <li>
                            <a href=""pay managment.html"" data-toggle=""tooltip"" data-placement=""right"" title=""مدیریت مالی"" data-nav-target=""#pages"">

                                <i class=""fa fa-credit-card"" aria-hidden=""true""></i>
");
                WriteLiteral(@"
                            </a>
                        </li>
                        <!-- <li>
                            <a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""عناصر رابط کاربری""
                               data-nav-target=""#elements"">
                                <i data-feather=""layers""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" data-toggle=""tooltip"" data-placement=""right"" title=""صفحات"" data-nav-target=""#pages"">
                                <i data-feather=""copy""></i>
                            </a>
                        </li> -->
                    </ul>
                </div>
                <div>
                    <ul>
");
                WriteLiteral("                        <li>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151cd390e3a5e0e6f4868a6174d7405bb61b974e21363", async() => {
                    WriteLiteral("\r\n                                <i data-feather=\"log-out\"></i>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </div>

            <!-- begin::navigation menu -->
            <div class=""navigation-menu-body"">

                <!-- begin::navigation-logo -->
                <!-- <div>
                    <div id=""navigation-logo"">
                        <a href=""index.html"">
                            <img class=""logo"" src=""assets/media/image/logo-F.png"" alt=""logo"">
                            <img class=""logo-light"" src=""assets/media/image/logo-light.png"" alt=""light logo"">
                        </a>
                    </div>
                </div> -->
                <!-- end::navigation-logo -->

                <div class=""navigation-menu-group"">

                    <div class=""open"" id=""dashboards"">
                        <ul>
                            <li class=""navigation-divider"">داشبردها</li>
                            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151cd390e3a5e0e6f4868a6174d7405bb61b974e24136", async() => {
                    WriteLiteral("داشبرد");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151cd390e3a5e0e6f4868a6174d7405bb61b974e25694", async() => {
                    WriteLiteral("  مدیریت مشاورین غیر فعال ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151cd390e3a5e0e6f4868a6174d7405bb61b974e27185", async() => {
                    WriteLiteral("  مدیریت مشاورین  فعال ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>

                            <!-- <li class=""navigation-divider"">دنبال‌کنندگان</li>
    <li>
        <div class=""avatar-group ml-4"">
            <a href=""#"" class=""avatar"">
                <span class=""avatar-title bg-success rounded-circle"">آ</span>
            </a>
            <a href=""#"" class=""avatar"">
                <img src=""assets/media/image/user/women_avatar5.jpg"" class=""rounded-circle"" alt=""avatar"">
            </a>
            <a href=""#"" class=""avatar"">
                <img src=""assets/media/image/user/women_avatar2.jpg"" class=""rounded-circle"" alt=""avatar"">
            </a>
            <a href=""#"" class=""avatar"">
                <span class=""avatar-title bg-info rounded-circle"">س</span>
            </a>
            <a href=""#"" class=""avatar"">
                <span class=""avatar-title bg-dark rounded-circle"">+30</span>
            </a>
        </div>
    </li> -->
                        </ul>
                    </div>
                    <div id=""apps"">
           ");
                WriteLiteral(@"             <ul>
                            <li class=""navigation-divider"">وبلاگ</li>
                            <li>
                                <a href=""#"">
                                    <span>صفحه مشاور من</span>
                                    <span class=""badge badge-danger"">5</span>
                                </a>
                            </li>

                        </ul>
                    </div>
                    <!-- <div id=""pages"">
                        <ul>
                            <li class=""navigation-divider"">مدیریت مالی</li>
                            <li>
                                <a href=""pay managment.html"">
                                    <span> پرداخت های من</span>
                                    <span class=""badge badge-danger"">5</span>
                                </a>
                            </li>

                        </ul>
                    </div>  -->

                </div>
            </div>
 ");
                WriteLiteral("           <!-- end::navigation menu -->\r\n\r\n        </div>\r\n        <!-- end::navigation -->\r\n        <!-- begin::main-content -->\r\n      ");
#nullable restore
#line 347 "C:\Users\4bagh\Documents\GitHub\platform\Project\WebPlatformV1\WebPlatformV1\Views\Shared\_LayoutAdmin.cshtml"
 Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!-- end::main -->
        <!-- Plugin scripts -->
        <script src=""/vendors/bundle.js""></script>

        <!-- Chartjs -->
        <script src=""/vendors/charts/chartjs/chart.min.js""></script>

        <!-- Apex chart -->
        <script src=""/vendors/charts/apex/apexcharts.min.js""></script>

        <!-- Circle progress -->
        <script src=""/vendors/circle-progress/circle-progress.min.js""></script>

        <!-- Peity -->
        <script src=""/vendors/charts/peity/jquery.peity.min.js""></script>
        <script src=""/assets/js/examples/charts/peity.js""></script>

        <!-- Datepicker -->
        <script src=""/vendors/datepicker/daterangepicker.js""></script>
        <script src=""/assets/Datepiker/persian-datepicker.js""></script>
        <script src=""/vendors/datepicker/bootstrap-datepicker.fa.min.js""></script>


        <!-- Slick -->
        <script src=""/vendors/slick/slick.min.js""></script>

        <!-- Vamp -->
        <script src=""/vendors/v");
                WriteLiteral(@"map/jquery.vmap.min.js""></script>
        <script src=""/vendors/vmap/maps/jquery.vmap.usa.js""></script>
        <script src=""/assets/js/examples/vmap.js""></script>


        <!-- a -->
        <script src='/assets/Cal/moment.js'></script>
        <script src='/assets/Cal/moment-jalaali.js'></script>
        <script src='/assets/Cal/fullcalendar.js'></script>
        <script src='/assets/Cal/fa.js'></script>


        <!-- Dashboard scripts -->
        <script src=""/assets/js/examples/dashboard.js""></script>
        <div class=""colors"">
            <!-- To use theme colors with Javascript -->
            <div class=""bg-primary""></div>
            <div class=""bg-primary-bright""></div>
            <div class=""bg-secondary""></div>
            <div class=""bg-secondary-bright""></div>
            <div class=""bg-info""></div>
            <div class=""bg-info-bright""></div>
            <div class=""bg-success""></div>
            <div class=""bg-success-bright""></div>
            <div class=""bg-dang");
                WriteLiteral(@"er""></div>
            <div class=""bg-danger-bright""></div>
            <div class=""bg-warning""></div>
            <div class=""bg-warning-bright""></div>
        </div>


        <!-- App scripts -->
        <script src=""/assets/js/app.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
