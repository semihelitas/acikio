#pragma checksum "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b767a126acfecbcfb176a4a6d07bcfc663d6e5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b767a126acfecbcfb176a4a6d07bcfc663d6e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HowItWorksPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-sliding-icon ripple-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_FooterPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/app-js/chiefAdsSearch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Acikio";
    Layout = "_Layout";

    var returnIstanbulDataUrl = "/User/Users?location=İstanbul&keyword=";
    var returnUrlAnkaraDataUrl = "/User/Users?location=Ankara&keyword=";
    var returnUrlIzmirDataUrl = "/User/Users?location=İzmir&keyword=";
    var returnUrlAdanaDataUrl = "/User/Users?location=Adana&keyword=";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Intro Banner -->
<div class=""intro-banner dark-overlay"">
    <div class=""background-image-container""></div>
    <div class=""container"">

        <!-- Intro Headline -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""banner-headline"">
                    <h3>
                        <span><strong class=""white-text"">Anne yemeği gibisi yoksa, <mark class=""color"">Acikio</mark> var!</strong></span>
                        <br>
                        <span class=""white-text"">Binlerce usta bu platformu kullanarak anne lezzetlerini sizlerle buluşturuyor.</span>
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
                        <label ");
            WriteLiteral(@"for=""autocomplete-input"" class=""field-title ripple-effect"">Neredesiniz?</label>
                        <div class=""input-with-icon"">
                            <input id=""autocomplete-input"" type=""text"" placeholder=""Midenize yakın bir konum"">
                            <i class=""icon-material-outline-location-on""></i>
                        </div>
                    </div>

                    <!-- Search Field -->
                    <div class=""intro-search-field"">
                        <label for=""intro-keywords"" class=""field-title ripple-effect"">Canınız ne çekti?</label>
                        <input id=""intro-keywords"" type=""text"" placeholder=""Ne vereyim abime?"">
                    </div>

                    <!-- Button -->
                    <div id=""getAdsWithSearch"" class=""intro-search-button"">
");
            WriteLiteral(@"                        <a style=""color:white"" class=""button ripple-effect""><i class=""icon-line-awesome-cutlery""></i> Acıktım</a>
                    </div>
                </div>
            </div>
        </div>

        <!-- Stats -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""intro-stats margin-top-45 hide-under-992px"">
                    <li>
                        <strong class=""counter white-text"">");
#nullable restore
#line 64 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                      Write(ViewBag.TotalUserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        <span style=""color:white"">Toplam Kullanıcı</span>
                    </li>

                    <li>
                        <strong class=""counter white-text""><mark class=""color"">9999</mark></strong>
                        <span style=""color:white"">Tamamlanan Sipariş</span>
                    </li>
                </ul>
            </div>
        </div>

    </div>
</div>

<!-- How Acikio Works -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72b767a126acfecbcfb176a4a6d07bcfc663d6e59790", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- How Acikio Works / End-->

<div class=""section margin-top-65 margin-bottom-30"">
    <div class=""container"">
        <div class=""row"">

            <!-- Section Headline -->
            <div class=""col-xl-12"">
                <div class=""section-headline centered margin-top-0 margin-bottom-45"">
                    <h3>Lezzet Kategorileri</h3>
                </div>
            </div>

");
#nullable restore
#line 94 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
             foreach (var category in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xl-3 col-md-6\">\r\n                    <!-- Photo Box -->\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3932, "\"", 3962, 2);
            WriteAttributeValue("", 3939, "/ustalar/", 3939, 9, true);
#nullable restore
#line 98 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 3948, category.Name, 3948, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-box small\" data-background-image=\"images/categories/");
#nullable restore
#line 98 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                                  Write(category.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <div class=\"photo-box-content\">\r\n                            <h3><mark class=\"color\">");
#nullable restore
#line 100 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</mark></h3>\r\n");
            WriteLiteral("                        </div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 105 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</div>



<!-- Highest Rated Freelancers -->
<div class=""section gray padding-top-65 padding-bottom-70 full-width-carousel-fix"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-xl-12"">
                <!-- Section Headline -->
                <div class=""section-headline margin-top-0 margin-bottom-25"">
                    <h3>En Hamaratlar</h3>
                    <a href=""freelancers-grid-layout.html"" class=""headline-link"">Tüm Ustalara Gözat</a>
                </div>
            </div>

            <div class=""col-xl-12"">
                <div class=""default-slick-carousel freelancers-container freelancers-grid-layout"">

");
#nullable restore
#line 129 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                     foreach (var user in Model.HighestRatedUsers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!--Freelancer -->
                        <div class=""freelancer"">

                            <!-- Overview -->
                            <div class=""freelancer-overview"">
                                <div class=""freelancer-overview-inner"">

                                    <!-- Bookmark Icon -->
                                    <span class=""bookmark-icon""></span>

                                    <!-- Avatar -->
                                    <div class=""freelancer-avatar"">
                                        <div class=""verified-badge""></div>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b767a126acfecbcfb176a4a6d07bcfc663d6e514978", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72b767a126acfecbcfb176a4a6d07bcfc663d6e515195", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5876, "~/images/avatar/", 5876, 16, true);
#nullable restore
#line 144 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5892, user.Image, 5892, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
#line 144 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                    <!-- Name -->\r\n                                    <div class=\"freelancer-name\">\r\n                                        <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b767a126acfecbcfb176a4a6d07bcfc663d6e519171", async() => {
#nullable restore
#line 149 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                             Write(user.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 149 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                                        Write(user.Surname);

#line default
#line hidden
#nullable disable
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
#line 149 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                            WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                                        <span>");
#nullable restore
#line 150 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                         Write(user.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n\r\n                                    <!-- Rating -->\r\n                                    <div class=\"freelancer-rating\">\r\n");
#nullable restore
#line 155 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                          
                                            var rating = user.Rating.ToString().Replace(",", ".");
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"star-rating\" data-rating=\"");
#nullable restore
#line 158 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                         Write(rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></div>
                                    </div>

                                    <!-- Location -->
                                    <div class=""freelancer-details-list"" style=""margin-top:15px;"">
                                        <strong><i class=""icon-material-outline-location-on""></i> ");
#nullable restore
#line 163 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                             Write(user.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                                    </div>

                                </div>
                            </div>

                            <!-- Details -->
                            <div class=""freelancer-details"">
                                <div class=""freelancer-details-list"">
");
#nullable restore
#line 172 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                      
                                        var categoryString = user.Categories.Split(',').ToList();
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                     foreach (var category in categoryString)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"keyword\"><span class=\"keyword-remove\"></span><span class=\"keyword-text\">");
#nullable restore
#line 177 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                                        Write(category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n");
#nullable restore
#line 178 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b767a126acfecbcfb176a4a6d07bcfc663d6e525834", async() => {
                WriteLiteral("Profili Gör ( Minimum ");
#nullable restore
#line 180 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                                                                                                                Write(user.MinimumOrderPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("₺ )<i class=\"icon-material-outline-arrow-right-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
#line 180 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                                                                                                        WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <!-- Freelancer / End -->\r\n");
#nullable restore
#line 184 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>
<!-- Highest Rated Freelancers / End-->
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
            BeginWriteAttribute("href", " href=", 8939, "", 8967, 1);
#nullable restore
#line 205 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 8945, returnIstanbulDataUrl, 8945, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-box\" data-background-image=\"images/cities/istanbul.jpg\">\r\n                    <div class=\"photo-box-content\">\r\n                        <h3>İstanbul</h3>\r\n                        <span>");
#nullable restore
#line 208 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                         Write(ViewBag.IstanbulAdsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" İlan</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-xl-3 col-md-6\">\r\n                <!-- Photo Box -->\r\n                <a");
            BeginWriteAttribute("href", " href=", 9375, "", 9404, 1);
#nullable restore
#line 215 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 9381, returnUrlAnkaraDataUrl, 9381, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-box\" data-background-image=\"images/cities/ankara.jpg\">\r\n                    <div class=\"photo-box-content\">\r\n                        <h3>Ankara</h3>\r\n                        <span>");
#nullable restore
#line 218 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                         Write(ViewBag.AnkaraAdsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" İlan</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-xl-3 col-md-6\">\r\n                <!-- Photo Box -->\r\n                <a");
            BeginWriteAttribute("href", " href=", 9806, "", 9834, 1);
#nullable restore
#line 225 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 9812, returnUrlIzmirDataUrl, 9812, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-box\" data-background-image=\"images/cities/izmir.jpg\">\r\n                    <div class=\"photo-box-content\">\r\n                        <h3>İzmir</h3>\r\n                        <span>");
#nullable restore
#line 228 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                         Write(ViewBag.IzmirAdsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" İlan</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-xl-3 col-md-6\">\r\n                <!-- Photo Box -->\r\n                <a");
            BeginWriteAttribute("href", " href=", 10233, "", 10261, 1);
#nullable restore
#line 235 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 10239, returnUrlAdanaDataUrl, 10239, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"photo-box\" data-background-image=\"images/cities/adana.jpg\">\r\n                    <div class=\"photo-box-content\">\r\n                        <h3>Adana</h3>\r\n                        <span>");
#nullable restore
#line 238 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Home\Index.cshtml"
                         Write(ViewBag.AdanaAdsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" İlan</span>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Features Cities / End -->\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72b767a126acfecbcfb176a4a6d07bcfc663d6e534012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b767a126acfecbcfb176a4a6d07bcfc663d6e535206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
