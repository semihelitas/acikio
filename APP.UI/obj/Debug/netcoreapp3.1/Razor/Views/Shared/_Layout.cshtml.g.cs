#pragma checksum "W:\KodlayacagizProje\APP.UI\APP.UI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01531662cc65a6210e1d1a4232e350d14565e631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "W:\KodlayacagizProje\APP.UI\APP.UI\Views\_ViewImports.cshtml"
using APP.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "W:\KodlayacagizProje\APP.UI\APP.UI\Views\_ViewImports.cshtml"
using APP.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01531662cc65a6210e1d1a4232e350d14565e631", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("register-account-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e6315601", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "W:\KodlayacagizProje\APP.UI\APP.UI\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - APP.UI</title>\r\n\r\n    <!-- CSS  -->\r\n    <link rel=\"stylesheet\" href=\"css/style.css\">\r\n    <link rel=\"stylesheet\" href=\"css/colors/blue.css\">\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e6317075", async() => {
                WriteLiteral(@"
    <div id=""wrapper"">
        <header id=""header-container"" class=""fullwidth transparent"">
            <div id=""header"">
                <div class=""container"">
                    <div class=""left-side"">
                        <div id=""logo"">
                            <a href=""index.html""><img src=""images/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 672, "\"", 678, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                        </div>
                        <nav id=""navigation"">
                            <ul id=""responsive"">
                                <li>
                                    <a href=""#"" class=""current""><i class=""icon-material-outline-home""></i> Anasayfa</a>
                                </li>
                                <li>
                                    <a href=""#""><i class=""icon-material-outline-search""></i> Ev Hanımı Bul</a>
                                </li>
                                <li>
                                    <a href=""#""><i class=""icon-material-outline-dashboard""></i> Kontrol Paneli</a>
                                </li>
                                <li>
                                    <a href=""#""><i class=""icon-material-outline-forum""></i> İlan Ver</a>
                                </li>
                            </ul>
                        </nav>
                        <div class=""clearfix""></div>
    ");
                WriteLiteral(@"                </div>
                    <div class=""right-side"">
                        <div class=""header-widget"">
                            <a href=""#sign-in-dialog"" class=""popup-with-zoom-anim log-in-button""><i class=""icon-feather-log-in""></i> <span>Giriş Yap / Kaydol</span></a>
                        </div>
                        <span class=""mmenu-trigger"">
                            <button class=""hamburger hamburger--collapse"" type=""button"">
                                <span class=""hamburger-box"">
                                    <span class=""hamburger-inner""></span>
                                </span>
                            </button>
                        </span>
                    </div>
                </div>
            </div>
        </header>
        <div class=""clearfix""></div>

        ");
#nullable restore
#line 57 "W:\KodlayacagizProje\APP.UI\APP.UI\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <div id=""footer"">
            <div class=""footer-top-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-12"">
                            <div class=""footer-rows-container"">
                                <div class=""footer-rows-left"">
                                    <div class=""footer-row"">
                                        <div class=""footer-row-inner footer-logo"">
                                            <img src=""images/logo2.png""");
                BeginWriteAttribute("alt", " alt=\"", 3126, "\"", 3132, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                                <div class=""footer-rows-right"">
                                    <div class=""footer-row"">
                                        <div class=""footer-row-inner"">
                                            <ul class=""footer-social-links"">
                                                <li>
                                                    <a href=""#"" title=""Facebook"" data-tippy-placement=""bottom"" data-tippy-theme=""light"">
                                                        <i class=""icon-brand-facebook-f""></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"" title=""Twitter"" data-tippy-placement=""bottom"" data-tippy-theme=""light"">
                     ");
                WriteLiteral(@"                                   <i class=""icon-brand-twitter""></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"" title=""Google Plus"" data-tippy-placement=""bottom"" data-tippy-theme=""light"">
                                                        <i class=""icon-brand-google-plus-g""></i>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"" title=""LinkedIn"" data-tippy-placement=""bottom"" data-tippy-theme=""light"">
                                                        <i class=""icon-brand-linkedin-in""></i>
                                                    </a>
                                                </li>
                                 ");
                WriteLiteral(@"           </ul>
                                            <div class=""clearfix""></div>
                                        </div>
                                    </div>
                                    <div class=""footer-row"">
                                        <div class=""footer-row-inner"">
                                            <select class=""selectpicker language-switcher"" data-selected-text-format=""count"" data-size=""5"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63113405", async() => {
                    WriteLiteral("English");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63114792", async() => {
                    WriteLiteral("Français");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63115857", async() => {
                    WriteLiteral("Español");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63116921", async() => {
                    WriteLiteral("Deutsch");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""footer-middle-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-2 col-lg-2 col-md-3"">
                            <div class=""footer-links"">
                                <h3>For Candidates</h3>
                                <ul>
                                    <li><a href=""#""><span>Browse Jobs</span></a></li>
                                    <li><a href=""#""><span>Add Resume</span></a></li>
                                    <li><a href=""#""><span>Job Alerts</span></a></li>
                                    <li><a href=""#""><span>My Bookmarks</span></a></li>
");
                WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                        <div class=""col-xl-2 col-lg-2 col-md-3"">
                            <div class=""footer-links"">
                                <h3>For Employers</h3>
                                <ul>
                                    <li><a href=""#""><span>Browse Candidates</span></a></li>
                                    <li><a href=""#""><span>Post a Job</span></a></li>
                                    <li><a href=""#""><span>Post a Task</span></a></li>
                                    <li><a href=""#""><span>Plans & Pricing</span></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-xl-2 col-lg-2 col-md-3"">
                            <div class=""footer-links"">
                                <h3>Helpful Links</h3>
                                <ul>
                     ");
                WriteLiteral(@"               <li><a href=""#""><span>Contact</span></a></li>
                                    <li><a href=""#""><span>Privacy Policy</span></a></li>
                                    <li><a href=""#""><span>Terms of Use</span></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-xl-2 col-lg-2 col-md-3"">
                            <div class=""footer-links"">
                                <h3>Account</h3>
                                <ul>
                                    <li><a href=""#""><span>Log In</span></a></li>
                                    <li><a href=""#""><span>My Account</span></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-lg-4 col-md-12"">
                            <h3><i class=""icon-feather-mail""></i> Sign Up For a Newsletter</h3>
                            ");
                WriteLiteral("<p>Weekly breaking news, analysis and cutting edge advices on job searching.</p>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63121277", async() => {
                    WriteLiteral("\r\n                                <input type=\"text\" name=\"fname\" placeholder=\"Enter your email address\">\r\n                                <button type=\"submit\"><i class=\"icon-feather-arrow-right\"></i></button>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                </div>
            </div>
            <div class=""footer-bottom-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xl-12"">
                            © 2018 <strong>Hireo</strong>. All Rights Reserved.
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Sign In Popup
    ================================================== -->
    <div id=""sign-in-dialog"" class=""zoom-anim-dialog mfp-hide dialog-with-tabs"">

        <!--Tabs -->
        <div class=""sign-in-form"">

            <ul class=""popup-tabs-nav"">
                <li><a href=""#login"">Log In</a></li>
                <li><a href=""#register"">Register</a></li>
            </ul>

            <div class=""popup-tabs-container"">

                <!-- Login -->
                <div class=""popup-tab-co");
                WriteLiteral(@"ntent"" id=""login"">

                    <!-- Welcome Text -->
                    <div class=""welcome-text"">
                        <h3>We're glad to see you again!</h3>
                        <span>Don't have an account? <a href=""#"" class=""register-tab"">Sign Up!</a></span>
                    </div>

                    <!-- Form -->
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63124664", async() => {
                    WriteLiteral(@"
                        <div class=""input-with-icon-left"">
                            <i class=""icon-material-baseline-mail-outline""></i>
                            <input type=""text"" class=""input-text with-border"" name=""emailaddress"" id=""emailaddress"" placeholder=""Email Address"" required />
                        </div>

                        <div class=""input-with-icon-left"">
                            <i class=""icon-material-outline-lock""></i>
                            <input type=""password"" class=""input-text with-border"" name=""password"" id=""password"" placeholder=""Password"" required />
                        </div>
                        <a href=""#"" class=""forgot-password"">Forgot Password?</a>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    <!-- Button -->
                    <button class=""button full-width button-sliding-icon ripple-effect"" type=""submit"" form=""login-form"">Log In <i class=""icon-material-outline-arrow-right-alt""></i></button>

                    <!-- Social Login -->
                    <div class=""social-login-separator""><span>or</span></div>
                    <div class=""social-login-buttons"">
                        <button class=""facebook-login ripple-effect""><i class=""icon-brand-facebook-f""></i> Log In via Facebook</button>
                        <button class=""google-login ripple-effect""><i class=""icon-brand-google-plus-g""></i> Log In via Google+</button>
                    </div>

                </div>

                <!-- Register -->
                <div class=""popup-tab-content"" id=""register"">

                    <!-- Welcome Text -->
                    <div class=""welcome-text"">
                        <h3>Let's create your account!</h3>
                    </div>

");
                WriteLiteral(@"                    <!-- Account Type -->
                    <div class=""account-type"">
                        <div>
                            <input type=""radio"" name=""account-type-radio"" id=""freelancer-radio"" class=""account-type-radio"" checked />
                            <label for=""freelancer-radio"" class=""ripple-effect-dark""><i class=""icon-material-outline-account-circle""></i> Freelancer</label>
                        </div>

                        <div>
                            <input type=""radio"" name=""account-type-radio"" id=""employer-radio"" class=""account-type-radio"" />
                            <label for=""employer-radio"" class=""ripple-effect-dark""><i class=""icon-material-outline-business-center""></i> Employer</label>
                        </div>
                    </div>

                    <!-- Form -->
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01531662cc65a6210e1d1a4232e350d14565e63129022", async() => {
                    WriteLiteral(@"
                        <div class=""input-with-icon-left"">
                            <i class=""icon-material-baseline-mail-outline""></i>
                            <input type=""text"" class=""input-text with-border"" name=""emailaddress-register"" id=""emailaddress-register"" placeholder=""Email Address"" required />
                        </div>

                        <div class=""input-with-icon-left"" title=""Should be at least 8 characters long"" data-tippy-placement=""bottom"">
                            <i class=""icon-material-outline-lock""></i>
                            <input type=""password"" class=""input-text with-border"" name=""password-register"" id=""password-register"" placeholder=""Password"" required />
                        </div>

                        <div class=""input-with-icon-left"">
                            <i class=""icon-material-outline-lock""></i>
                            <input type=""password"" class=""input-text with-border"" name=""password-repeat-register"" id=""password-repeat");
                    WriteLiteral("-register\" placeholder=\"Repeat Password\" required />\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                    <!-- Button -->
                    <button class=""margin-top-10 button full-width button-sliding-icon ripple-effect"" type=""submit"" form=""register-account-form"">Register <i class=""icon-material-outline-arrow-right-alt""></i></button>

                    <!-- Social Login -->
                    <div class=""social-login-separator""><span>or</span></div>
                    <div class=""social-login-buttons"">
                        <button class=""facebook-login ripple-effect""><i class=""icon-brand-facebook-f""></i> Register via Facebook</button>
                        <button class=""google-login ripple-effect""><i class=""icon-brand-google-plus-g""></i> Register via Google+</button>
                    </div>

                </div>

            </div>
        </div>
    </div>
    <!-- Sign In Popup / End -->
    <!-- Scripts
    ================================================== -->
    <script src=""js/jquery-3.3.1.min.js""></script>
    <script src=""js/jquery-migrate-3.0.");
                WriteLiteral(@"0.min.js""></script>
    <script src=""js/mmenu.min.js""></script>
    <script src=""js/tippy.all.min.js""></script>
    <script src=""js/simplebar.min.js""></script>
    <script src=""js/bootstrap-slider.min.js""></script>
    <script src=""js/bootstrap-select.min.js""></script>
    <script src=""js/snackbar.js""></script>
    <script src=""js/clipboard.min.js""></script>
    <script src=""js/counterup.min.js""></script>
    <script src=""js/magnific-popup.min.js""></script>
    <script src=""js/slick.min.js""></script>
    <script src=""js/custom.js""></script>

    <!-- Snackbar // documentation: https://www.polonel.com/snackbar/ -->
    <script>
        // Snackbar for user status switcher
        $('#snackbar-user-status label').click(function () {
            Snackbar.show({
                text: 'Your status has been changed!',
                pos: 'bottom-center',
                showAction: false,
                actionText: ""Dismiss"",
                duration: 3000,
                textColor: '#fff'");
                WriteLiteral(@",
                backgroundColor: '#383838'
            });
        });
    </script>


    <!-- Google Autocomplete -->
    <script>
        function initAutocomplete() {
            var options = {
                types: ['(cities)'],
                // componentRestrictions: {country: ""us""}
            };

            var input = document.getElementById('autocomplete-input');
            var autocomplete = new google.maps.places.Autocomplete(input, options);
        }

        // Autocomplete adjustment for homepage
        if ($('.intro-banner-search-form')[0]) {
            setTimeout(function () {
                $("".pac-container"").prependTo("".intro-search-field.with-autocomplete"");
            }, 300);
        }

    </script>

    <!-- Google API -->
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyAgeuuDfRlweIs7D6uo4wdIHVvJ0LonQ6g&libraries=places&callback=initAutocomplete""></script>

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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
