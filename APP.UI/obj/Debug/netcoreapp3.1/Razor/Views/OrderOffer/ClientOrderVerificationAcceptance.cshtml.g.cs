#pragma checksum "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abed5817d53a201a999c631dda5d56a22716c1dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderOffer_ClientOrderVerificationAcceptance), @"mvc.1.0.view", @"/Views/OrderOffer/ClientOrderVerificationAcceptance.cshtml")]
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
#nullable restore
#line 2 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
using APP.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abed5817d53a201a999c631dda5d56a22716c1dc", @"/Views/OrderOffer/ClientOrderVerificationAcceptance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderOffer_ClientOrderVerificationAcceptance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APP.Core.Models.OrderOffers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_WhiteFooterPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("send-pm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
  
    ViewData["Title"] = "Acikio - Onay Bekleyen Siparişlerin";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dashboard-container\" style=\"height: 778px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abed5817d53a201a999c631dda5d56a22716c1dc6541", async() => {
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

    <div class=""dashboard-content-container"" data-simplebar=""init"" style=""height: 778px;"">
        <div class=""simplebar-track vertical"" style=""visibility: visible;""><div class=""simplebar-scrollbar"" style=""visibility: visible; top: 0px; height: 452px;""></div></div><div class=""simplebar-track horizontal"" style=""visibility: visible;""><div class=""simplebar-scrollbar"" style=""visibility: visible; left: 0px; width: 25px;""></div></div><div class=""simplebar-scroll-content"" style=""padding-right: 17px; margin-bottom: -34px;"">
            <div class=""simplebar-content"" style=""padding-bottom: 17px; margin-right: -17px;"">
                <div class=""dashboard-content-inner"" style=""min-height: 778px;"">

                    <!-- Dashboard Headline -->
                    <div class=""dashboard-headline"">
                        <h3>Doğrulama Onayı Bekleyen Siparişlerin</h3>
                        <span class=""margin-top-7"">Ustaların teklifini kabul ettiği siparişlerin, doğrulama onayını bekliyorlar</span>

   ");
            WriteLiteral(@"                     <!-- Breadcrumbs -->
                        <nav id=""breadcrumbs"" class=""dark"">
                            <ul>
                                <li><a href=""#"">Yönetim Paneli</a></li>
                                <li><a href=""#"">Onay Bekleyen Siparişlerin</a></li>
                            </ul>
                        </nav>
                    </div>

                    <!-- Row -->
                    <div class=""row"">

                        <!-- Dashboard Box -->
                        <div class=""col-xl-12"">
                            <div class=""dashboard-box margin-top-0"">

                                <!-- Headline -->
                                <div class=""headline"">
                                    <h3><i class=""icon-material-outline-supervisor-account""></i> Toplam ");
#nullable restore
#line 42 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                   Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bekleyen Sipariş Onayı</h3>\r\n                                </div>\r\n                                <div class=\"content\">\r\n                                    <ul class=\"dashboard-box-list\">\r\n");
#nullable restore
#line 46 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                         foreach (var offer in Model)
                                        {
                                            var client = await UserManager.FindByIdAsync(offer.ClientId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li>
                                                <!-- Overview -->
                                                <div class=""freelancer-overview manage-candidates"">
                                                    <div class=""freelancer-overview-inner"">

                                                        <!-- Avatar -->
                                                        <div class=""freelancer-avatar"">
                                                            <div class=""verified-badge""></div>
                                                            <a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "abed5817d53a201a999c631dda5d56a22716c1dc11277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3311, "~/images/avatar/", 3311, 16, true);
#nullable restore
#line 57 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
AddHtmlAttributeValue("", 3327, offer.ApplicationUser.Image, 3327, 28, false);

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
            WriteLiteral(@"</a>
                                                        </div>

                                                        <!-- Name -->
                                                        <div class=""freelancer-name"">

                                                            <h4><a href=""#"">");
#nullable restore
#line 63 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                       Write(offer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h4>\r\n\r\n                                                            <!-- Details -->\r\n                                                            <span class=\"freelancer-detail-item\"><i class=\"icon-feather-user\"></i> ");
#nullable restore
#line 66 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                              Write(offer.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                                                          Write(offer.ApplicationUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                            <span class=\"freelancer-detail-item\"><a href=\"#\"><i class=\"icon-material-outline-add-location\"></i> ");
#nullable restore
#line 67 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                                                           Write(offer.ApplicationUser.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>

                                                            <!-- Bid Details -->
                                                            <ul class=""dashboard-task-info bid-info"">
                                                                <li><strong id=""offerPrice"" data-price=""");
#nullable restore
#line 71 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                   Write(offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 71 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                 Write(offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</strong><span>Teklif Miktarı</span></li>\r\n                                                                <li><strong>");
#nullable restore
#line 72 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                       Write(offer.DeliveryTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><span>Teslimat Tarihi</span></li>\r\n                                                                <li><strong>");
#nullable restore
#line 73 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                       Write(offer.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><span>Teklif Tarihi</span></li>
                                                            </ul>

                                                            <!-- Buttons -->
                                                            <div class=""buttons-to-right always-visible margin-top-25 margin-bottom-0"">
                                                                <a href=""#small-dialog-3"" id=""readOffer"" data-title=""");
#nullable restore
#line 78 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                Write(offer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-description=\"");
#nullable restore
#line 78 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                                                Write(offer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"popup-with-zoom-anim button green ripple-effect\"><i class=\"icon-feather-eye\"></i></a>\r\n                                                                <a href=\"#small-dialog-1\" id=\"acceptOffer\" data-offer-id=\"");
#nullable restore
#line 79 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                     Write(offer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-price=\"");
#nullable restore
#line 79 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                                                            Write(offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""popup-with-zoom-anim button green ripple-effect""><i class=""icon-material-outline-check""></i> Siparişi Onayla</a>
                                                                <a href=""#small-dialog-2"" class=""popup-with-zoom-anim button ripple-effect""><i class=""icon-feather-mail""></i> Mesaj Gönder</a>
                                                                <a href=""#small-dialog-4"" id=""rejectOffer"" data-id=""");
#nullable restore
#line 81 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                                                                                               Write(offer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""popup-with-zoom-anim button red ripple-effect""><i class=""icon-feather-trash""></i> Teklifi Geri Çek</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </li>
");
#nullable restore
#line 87 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\ClientOrderVerificationAcceptance.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <!-- Row / End -->\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abed5817d53a201a999c631dda5d56a22716c1dc21155", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
</div>

<!-- Read Popup -->
<div id=""small-dialog-3"" class=""zoom-anim-dialog mfp-hide dialog-with-tabs"">

    <!--Tabs -->
    <div class=""sign-in-form"">

        <ul class=""popup-tabs-nav"">
            <li><a href=""#tab2"">Teklif İçeriği</a></li>
        </ul>

        <div class=""popup-tabs-container"">

            <!-- Tab -->
            <div class=""popup-tab-content"" id=""tab2"">

                <!-- Welcome Text -->
                <div class=""welcome-text"">
                    <h3 id=""offer-title""></h3>
                </div>

                <!-- Form -->
                <p id=""offer-description""></p>
            </div>

        </div>
    </div>
</div>

<!-- Accept Offer Popup -->
<div id=""small-dialog-1"" class=""zoom-anim-dialog mfp-hide dialog-with-tabs"">

    <!--Tabs -->
    <div class=""sign-in-form"">

        <ul class=""popup-tabs-nav"">
            <li><a href=""#tab1"">Sipariş Onayı</a></");
            WriteLiteral(@"li>
        </ul>

        <div class=""popup-tabs-container"">

            <!-- Tab -->
            <div class=""popup-tab-content"" id=""tab"">

                <!-- Welcome Text -->
                <div class=""welcome-text"">
                    <h3>Siparişi Doğrula</h3>
                    <div class=""bid-acceptance margin-top-15"">
                        <span id=""price-label""></span>
                    </div>
                </div>

                <div class=""radio"">
                    <input id=""radio-1"" name=""radio"" type=""radio"" required>
                    <label for=""radio-1""><span class=""radio-label""></span> Sipariş detaylarını, yükümlülüklerimi ve kullanıcı sözleşmesini okudum, kabul ediyorum.</label>
                </div>

                <!-- Button -->
                <button id=""acceptOfferConfirm"" class=""margin-top-15 button full-width button-sliding-icon ripple-effect"" type=""submit"" form=""terms"">Onayla <i class=""icon-material-outline-arrow-right-alt""></i></button>
     ");
            WriteLiteral(@"       </div>

        </div>
    </div>
</div>

<!-- Send Direct Message Popup -->
<div id=""small-dialog-2"" class=""zoom-anim-dialog mfp-hide dialog-with-tabs"">

    <!--Tabs -->
    <div class=""sign-in-form"">

        <ul class=""popup-tabs-nav"">
            <li><a href=""#tab2"">Send Message</a></li>
        </ul>

        <div class=""popup-tabs-container"">

            <!-- Tab -->
            <div class=""popup-tab-content"" id=""tab2"">

                <!-- Welcome Text -->
                <div class=""welcome-text"">
                    <h3>Direct Message To David</h3>
                </div>

                <!-- Form -->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abed5817d53a201a999c631dda5d56a22716c1dc25136", async() => {
                WriteLiteral("\r\n                    <textarea name=\"textarea\" cols=\"10\" placeholder=\"Message\" class=\"with-border\" required></textarea>\r\n                ");
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
                <button class=""button full-width button-sliding-icon ripple-effect"" type=""submit"" form=""send-pm"">Send <i class=""icon-material-outline-arrow-right-alt""></i></button>

            </div>

        </div>
    </div>
</div>

<!-- Delete Popup -->
<div id=""small-dialog-4"" class=""zoom-anim-dialog mfp-hide dialog-with-tabs"">

    <!--Tabs -->
    <div class=""sign-in-form"">

        <ul class=""popup-tabs-nav"">
            <li><a href=""#tab2"">Teklifi Geri Çek</a></li>
        </ul>

        <div class=""popup-tabs-container"">

            <!-- Tab -->
            <div class=""popup-tab-content"" id=""tab2"">

                <!-- Welcome Text -->
                <div class=""welcome-text"">
                    <h3>Siparişi iptal etmek istiyor musun?</h3>
                </div>

                <!-- Button -->
                <button id=""rejectOfferConfirm"" class=""full-width button button-sliding-icon ripple-effect"" type=""submit"" form=""send-pm"">E");
            WriteLiteral("vet <i class=\"icon-material-outline-arrow-right-alt\"></i></button>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abed5817d53a201a999c631dda5d56a22716c1dc28027", async() => {
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
            WriteLiteral(@"
<script type=""text/javascript"">
    var offerId = ""null"";
    $(document).on(""click"", ""#acceptOffer"", function () {
        offerId = $(this).data('offer-id');
        var offerPrice = $(this).data('price');
        console.log(offerId);
        console.log(offerPrice);
        $(""#price-label"").text(offerPrice + "" ₺"");
    });

    $(document).on(""click"", ""#acceptOfferConfirm"", function () {
        $.ajax({
            type: ""POST"",
            url: ""/OrderOffer/ClientOfferAcceptance"",
            data: { orderOfferId: offerId },
            success: function (result) {
                window.location.href = ""/OrderOffer/OrderAgreementSuccessful"";
            },
            error: function (result) {
                alert(""Hata!"");
            }
        });
    });

    $(document).on(""click"", ""#readOffer"", function () {
        var offerTitle = $(this).data('title');
        var offerDescription = $(this).data('description');
        $(""#offer-title"").text(offerTitle);
       ");
            WriteLiteral(@" $(""#offer-description"").text(offerDescription);
    });

    var willDelete = ""null"";
    $(document).on(""click"", ""#rejectOffer"", function () {
        willDelete = $(this).data('id');
    });

    $(document).on(""click"", ""#rejectOfferConfirm"", function () {
        $.ajax({
            type: ""POST"",
            url: ""/OrderOffer/RejectOffer"",
            data: { id: willDelete },
            success: function (result) {
                window.location.href = ""/OrderOffer/ClientOrderVerificationAcceptance"";
            },
            error: function (result) {
                alert(""silme hatali!"");
            }
        });
    });

</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APP.Core.Models.OrderOffers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
