#pragma checksum "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderOffer_SentOffers), @"mvc.1.0.view", @"/Views/OrderOffer/SentOffers.cshtml")]
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
#line 2 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
using APP.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb3", @"/Views/OrderOffer/SentOffers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderOffer_SentOffers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APP.Core.Models.OrderOffers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user-avatar-big-02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_WhiteFooterPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("terms"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("send-pm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
  
    ViewData["Title"] = "Acikio - Bekleyen Teklifler";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dashboard-container\" style=\"height: 778px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb36663", async() => {
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
                        <h3>Bekleyen Tekliflerin</h3>
                        <span class=""margin-top-7"">Gönderdiğin ve onay almayı bekleyen teklifler</span>

                        <!-- Breadcrumbs -->
     ");
            WriteLiteral(@"                   <nav id=""breadcrumbs"" class=""dark"">
                            <ul>
                                <li><a href=""#"">Yönetim Paneli</a></li>
                                <li><a href=""#"">Bekleyen Teklifler</a></li>
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
                                    <h3><i class=""icon-material-outline-supervisor-account""></i> 3 Bidders</h3>
                                </div>

                                <div class=""content"">
                                    <ul class=""dashboard-box-list"">
");
#nullable restore
#line 46 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                         foreach (var offer in Model)
                                        {
                                            var user = await UserManager.FindByIdAsync(offer.ChiefId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb310938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
#line 62 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                       Write(offer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h4>\r\n\r\n                                                            <!-- Details -->\r\n                                                            <span class=\"freelancer-detail-item\"><a href=\"#\"><i class=\"icon-feather-user\"></i>");
#nullable restore
#line 65 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                                                                                         Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                                                                                                    Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></span>\r\n\r\n                                                            <!-- Rating -->\r\n                                                            <div class=\"freelancer-rating\">\r\n");
#nullable restore
#line 69 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                  
                                                                    var rating = user.Rating.ToString().Replace(",", ".");
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <div class=\"star-rating\" data-rating=\"");
#nullable restore
#line 72 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                                                 Write(rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></div>
                                                            </div>

                                                            <!-- Bid Details -->
                                                            <ul class=""dashboard-task-info bid-info"">
                                                                <li><strong>");
#nullable restore
#line 77 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                       Write(offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</strong><span>Teklif Miktarı</span></li>\r\n                                                                <li><strong>");
#nullable restore
#line 78 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                                                       Write(offer.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><span>Sipariş Tarihi</span></li>
                                                            </ul>
                                                            <!-- Buttons -->
                                                            <div class=""buttons-to-right always-visible margin-top-25 margin-bottom-0"">
                                                                <a href=""#small-dialog-1"" class=""popup-with-zoom-anim button gray ripple-effect disabled""><i class=""icon-line-awesome-hourglass-start""></i> Cevap Bekleniyor</a>
                                                                <a href=""#"" class=""button red ripple-effect ico"" data-tippy-placement=""top"" data-tippy="""" data-original-title=""İptal Et""><i class=""icon-feather-trash-2""></i></a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>");
            WriteLiteral("\r\n                                            </li>\r\n");
#nullable restore
#line 89 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\OrderOffer\SentOffers.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <!-- Row / End -->\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb317467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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

<!-- Bid Acceptance Popup
================================================== -->
<div id=""small-dialog-1"" class=""zoom-anim-dialog mfp-hide dialog-with-tabs"">

    <!--Tabs -->
    <div class=""sign-in-form"">

        <ul class=""popup-tabs-nav"">
            <li><a href=""#tab1"">Sipariş Onayı</a></li>
        </ul>

        <div class=""popup-tabs-container"">

            <!-- Tab -->
            <div class=""popup-tab-content"" id=""tab"">

                <!-- Welcome Text -->
                <div class=""welcome-text"">
                    <h3>Accept Offer From David</h3>
                    <div class=""bid-acceptance margin-top-15"">
                        $3200
                    </div>

                </div>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb319446", async() => {
                WriteLiteral(@"
                    <div class=""radio"">
                        <input id=""radio-1"" name=""radio"" type=""radio"" required>
                        <label for=""radio-1""><span class=""radio-label""></span>  I have read and agree to the Terms and Conditions</label>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
                <button class=""margin-top-15 button full-width button-sliding-icon ripple-effect"" type=""submit"" form=""terms"">Accept <i class=""icon-material-outline-arrow-right-alt""></i></button>

            </div>

        </div>
    </div>
</div>
<!-- Bid Acceptance Popup / End -->
<!-- Send Direct Message Popup
================================================== -->
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52ed51b6e34fbc4a0ce53f9bb27dfd63f7217eb322098", async() => {
                WriteLiteral("\r\n                    <textarea name=\"textarea\" cols=\"10\" placeholder=\"Message\" class=\"with-border\" required></textarea>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
<!-- Send Direct Message Popup / End -->");
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