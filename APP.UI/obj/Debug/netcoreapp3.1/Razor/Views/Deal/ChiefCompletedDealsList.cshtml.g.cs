#pragma checksum "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c374e1ad05e34a14a5826f5edf015d1a7097ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deal_ChiefCompletedDealsList), @"mvc.1.0.view", @"/Views/Deal/ChiefCompletedDealsList.cshtml")]
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
#line 2 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
using APP.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c374e1ad05e34a14a5826f5edf015d1a7097ce", @"/Views/Deal/ChiefCompletedDealsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_Deal_ChiefCompletedDealsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APP.Core.Models.CompletedDeal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SidebarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_WhiteFooterPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.3.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
  
    ViewData["Title"] = "Acikio - Tamamlanmış Siparişler";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dashboard-container\" style=\"height: 778px;\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3c374e1ad05e34a14a5826f5edf015d1a7097ce5455", async() => {
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
        <div class=""simplebar-track vertical"" style=""visibility: visible;""><div class=""simplebar-scrollbar"" style=""visibility: visible; top: 0px; height: 547px;""></div></div><div class=""simplebar-track horizontal"" style=""visibility: visible;""><div class=""simplebar-scrollbar"" style=""visibility: visible; left: 0px; width: 25px;""></div></div><div class=""simplebar-scroll-content"" style=""padding-right: 17px; margin-bottom: -34px;"">
            <div class=""simplebar-content"" style=""padding-bottom: 17px; margin-right: -17px;"">
                <div class=""dashboard-content-inner"" style=""min-height: 778px;"">
                    <!-- Dashboard Headline -->
                    <div class=""dashboard-headline"">
                        <h3>Tamamlanmış Siparişler</h3>

                        <!-- Breadcrumbs -->
                        <nav id=""breadcrumbs"" class=""dark"">
                            <ul>
               ");
            WriteLiteral(@"                 <li><a href=""#"">Yönetim Paneli</a></li>
                                <li>Tamamlanmış Siparişler</li>
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
                                    <h3><i class=""icon-material-outline-business-center""></i> Tamamlanmış ");
#nullable restore
#line 39 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Sipariş</h3>\r\n                                </div>\r\n\r\n                                <div class=\"content\">\r\n                                    <ul class=\"dashboard-box-list\">\r\n");
#nullable restore
#line 44 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                         foreach (var completedDeal in Model)
                                        {
                                            var client = await UserManager.FindByIdAsync(completedDeal.Deal.OrderOffer.ClientId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li>
                                                <!-- Job Listing -->
                                                <div class=""job-listing"">

                                                    <!-- Job Listing Details -->
                                                    <div class=""job-listing-details"">

                                                        <!-- Logo -->
                                                        <a href=""#"" class=""job-listing-company-logo"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3c374e1ad05e34a14a5826f5edf015d1a7097ce9964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3114, "~/images/avatar/", 3114, 16, true);
#nullable restore
#line 56 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
AddHtmlAttributeValue("", 3130, client.Image, 3130, 13, false);

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
            WriteLiteral(@"
                                                        </a>

                                                        <!-- Details -->
                                                        <div class=""job-listing-description"">
                                                            <h3 class=""job-listing-title""><a href=""#""><i class=""icon-line-awesome-hourglass""></i> ");
#nullable restore
#line 61 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                                                             Write(completedDeal.Deal.OrderOffer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h3>

                                                            <!-- Job Listing Footer -->
                                                            <div class=""job-listing-footer"">
                                                                <ul>
                                                                    <li><i class=""icon-feather-user""></i> ");
#nullable restore
#line 66 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                     Write(client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                                  Write(client.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                                    <li><i class=\"icon-material-outline-location-on\"></i> ");
#nullable restore
#line 67 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                                     Write(client.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                                    <li><i class=\"icon-line-awesome-money\"></i> ");
#nullable restore
#line 68 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                           Write(completedDeal.Deal.OrderOffer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</li>\r\n                                                                    <li><i class=\"icon-line-awesome-calendar-check-o\"></i> Teslim Tarihi: ");
#nullable restore
#line 69 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                                                     Write(completedDeal.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                                </ul>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- Buttons -->
                                                <div class=""buttons-to-right single-right-button"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5009, "\"", 5047, 2);
            WriteAttributeValue("", 5016, "/Deal/Invoice/", 5016, 14, true);
#nullable restore
#line 77 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
WriteAttributeValue("", 5030, completedDeal.Id, 5030, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button color ripple-effect\"><i class=\"icon-line-awesome-dollar\"></i> Faturayı Gör</a>\r\n                                                    <a href=\"#small-dialog-3\" id=\"readOffer\" data-title=\"");
#nullable restore
#line 78 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                    Write(completedDeal.Deal.OrderOffer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-description=\"");
#nullable restore
#line 78 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                                                                                                                                            Write(completedDeal.Deal.OrderOffer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""popup-with-zoom-anim button red ripple-effect ico"" data-tippy-placement=""left"" data-tippy="""" data-original-title=""Read""><i class=""icon-feather-eye""></i></a>
                                                </div>
                                            </li>
");
#nullable restore
#line 81 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\ChiefCompletedDealsList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <!-- Row / End -->\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b3c374e1ad05e34a14a5826f5edf015d1a7097ce17779", async() => {
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

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3c374e1ad05e34a14a5826f5edf015d1a7097ce19690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).on(""click"", ""#readOffer"", function () {
        var offerTitle = $(this).data('title');
        var offerDescription = $(this).data('description');
        $(""#offer-title"").text(offerTitle);
        $(""#offer-description"").text(offerDescription);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APP.Core.Models.CompletedDeal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
