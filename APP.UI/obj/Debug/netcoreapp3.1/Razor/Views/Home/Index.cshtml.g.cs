#pragma checksum "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef1414e472275f815a17ef4254507023ad5f995c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\_ViewImports.cshtml"
using APP.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\_ViewImports.cshtml"
using APP.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef1414e472275f815a17ef4254507023ad5f995c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/avatar/woman-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChiefAds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("job-listing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app-js/chiefAdsSearch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Acikio";
    Layout = "_Layout";

    var returnIstanbulDataUrl = "/usta-ilanlari?location=İstanbul&keyword=";
    // returnUrlAnkaraDataUrl = ...
    // returnUrlIzmirDataUrl =...
    // returnUrlAdanaDataUrl =...

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Intro Banner -->
<div class=""intro-banner"">
    <div class=""background-image-container""></div>
    <div class=""container"">

        <!-- Intro Headline -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""banner-headline"">
                    <h3>
                        <strong>Anne yemeği gibisi yoktur. Belki de vardır?</strong>
                        <br>
                        <span>Binlerce usta bu platformu kullanarak anne lezzetlerini sizlerle buluşturuyor.</span>
                    </h3>
                </div>
            </div>
        </div>

        <!-- Search Bar -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""intro-banner-search-form margin-top-95"">

                    <!-- Search Field -->
                    <div class=""intro-search-field with-autocomplete"">
                        <label for=""autocomplete-input"" class=""field-title ripple-effect"">Neredesiniz?</label>
    ");
            WriteLiteral(@"                    <div class=""input-with-icon"">
                            <input id=""autocomplete-input"" type=""text"" placeholder=""Midenize yakın bir konum"">
                            <i class=""icon-material-outline-location-on""></i>
                        </div>
                    </div>

                    <!-- Search Field -->
                    <div class=""intro-search-field"">
                        <label for=""intro-keywords"" class=""field-title ripple-effect"">Canınız ne çekti?</label>
                        <input id=""intro-keywords"" type=""text"" placeholder=""Canınız ne çektiyse söyleyin, annelerimiz yapsın"">
                    </div>

                    <!-- Button -->
                    <div id=""getAdsWithSearch"" class=""intro-search-button"">
");
            WriteLiteral(@"                        <a style=""color:white""  class=""button ripple-effect""><i class=""icon-line-awesome-cutlery""></i> Acıktım</a>
                    </div>
                </div>
            </div>
        </div>

        <!-- Stats -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""intro-stats margin-top-45 hide-under-992px"">
                    <li>
                        <strong class=""counter"">1,586</strong>
                        <span>Acıkan</span>
                    </li>
                    <li>
                        <strong class=""counter"">1,221</strong>
                        <span>Ev Hanımı</span>
                    </li>
                    <li>
                        <strong class=""counter"">3,543</strong>
                        <span>Lezzet İlanı</span>
                    </li>

                </ul>
            </div>
        </div>

    </div>
</div>

<!-- Chief Advertisements -->
<div class=""section gray paddi");
            WriteLiteral(@"ng-top-65 padding-bottom-75"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xl-12"">

                <!-- Section Headline -->
                <div class=""section-headline margin-top-0 margin-bottom-35"">
                    <h3>Ustalardan Gelenler</h3>
                    <a href=""jobs-list-layout-full-page-map.html"" class=""headline-link"">Bütün ilanları gör</a>
                </div>

                <div class=""listings-container grid-layout margin-top-35"">
");
#nullable restore
#line 96 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                     foreach (var ads in Model.ChiefAdvertisements)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef1414e472275f815a17ef4254507023ad5f995c9521", async() => {
                WriteLiteral("\r\n                            <div class=\"job-listing-details\">\r\n                                <div class=\"job-listing-company-logo\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef1414e472275f815a17ef4254507023ad5f995c9955", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"job-listing-description\">\r\n                                    <h4 class=\"job-listing-company\">");
#nullable restore
#line 105 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                               Write(ads.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 105 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                         Write(ads.ApplicationUser.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                    <h3 class=\"job-listing-title\">");
#nullable restore
#line 106 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                             Write(ads.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                                </div>
                            </div>
                            <div class=""job-listing-footer"">
                                <span href=""/ilanlar"" class=""bookmark-icon bookmarked label label-important""></span>
                                <ul>
                                    <li><i class=""icon-material-outline-location-on""></i> ");
#nullable restore
#line 112 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                     Write(ads.ApplicationUser.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <li><i class=\"icon-material-outline-business-center\"></i> ");
#nullable restore
#line 113 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                         Write(ads.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                    <br />\r\n                                    <li><i class=\"icon-material-outline-account-balance-wallet\"></i> ");
#nullable restore
#line 115 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                Write(ads.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₺</li>\r\n                                    <li><i class=\"icon-material-outline-access-time\"></i> ");
#nullable restore
#line 116 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                     Write(ads.CreatedAt.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                            WriteLiteral(ads.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 120 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<!-- Chief Advertisements / End -->

<!-- Features Cities -->
<div class=""section margin-top-65 margin-bottom-65"">
    <div class=""container"">
        <div class=""row"">

            <!-- Section Headline -->
            <div class=""col-xl-12"">
                <div class=""section-headline centered margin-top-0 margin-bottom-45"">
                    <h3>Acıkan Şehirler</h3>
                </div>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <!-- Photo Box -->
                <a");
            BeginWriteAttribute("href", " href=", 6048, "", 6076, 1);
#nullable restore
#line 142 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 6054, returnIstanbulDataUrl, 6054, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""photo-box"" data-background-image=""images/cities/istanbul.jpg"">
                    <div class=""photo-box-content"">
                        <h3>İstanbul</h3>
                        <span>1376 İlan</span>
                    </div>
                </a>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <!-- Photo Box -->
                <a href=""jobs-list-layout-full-page-map.html"" class=""photo-box"" data-background-image=""images/cities/ankara.jpg"">
                    <div class=""photo-box-content"">
                        <h3>Ankara</h3>
                        <span>845 İlan</span>
                    </div>
                </a>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <!-- Photo Box -->
                <a href=""jobs-grid-layout-full-page.html"" class=""photo-box"" data-background-image=""images/cities/izmir.jpg"">
                    <div class=""photo-box-content"">
                        <h3>İzmir</h3>
           ");
            WriteLiteral(@"             <span>832 İlan</span>
                    </div>
                </a>
            </div>

            <div class=""col-xl-3 col-md-6"">
                <!-- Photo Box -->
                <a href=""jobs-list-layout-2.html"" class=""photo-box"" data-background-image=""images/cities/adana.jpg"">
                    <div class=""photo-box-content"">
                        <h3>Adana</h3>
                        <span>513 İlan</span>
                    </div>
                </a>
            </div>
        </div>
    </div>
</div>
<!-- Features Cities / End -->
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef1414e472275f815a17ef4254507023ad5f995c19647", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
