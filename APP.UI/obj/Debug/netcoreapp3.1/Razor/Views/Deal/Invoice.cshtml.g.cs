#pragma checksum "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade610aac80893be4e631d38b55672ebc3ccb3ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deal_Invoice), @"mvc.1.0.view", @"/Views/Deal/Invoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade610aac80893be4e631d38b55672ebc3ccb3ab", @"/Views/Deal/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d119d014277ee6abece65d2557710d542f342", @"/Views/_ViewImports.cshtml")]
    public class Views_Deal_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<APP.Core.Models.CompletedDeal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/invoice.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logos/acikio-logo-orange.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade610aac80893be4e631d38b55672ebc3ccb3ab4867", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Acikio - Fatura</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ade610aac80893be4e631d38b55672ebc3ccb3ab5199", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
  
    Layout = null;
    var chef = ViewBag.Chef;
    var client = ViewBag.Client;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade610aac80893be4e631d38b55672ebc3ccb3ab7376", async() => {
                WriteLiteral(@"

    <!-- Print Button -->
    <div class=""print-button-container"">
        <a href=""javascript:window.print()"" class=""print-button green"">Faturayı Yazdır</a>
    </div>

    <!-- Invoice -->
    <div id=""invoice"">

        <!-- Header -->
        <div class=""row"">
            <div class=""col-xl-6"">
                <div id=""logo"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ade610aac80893be4e631d38b55672ebc3ccb3ab7991", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</div>\r\n            </div>\r\n\r\n            <div class=\"col-xl-6\">\r\n\r\n                <p id=\"details\">\r\n                    <strong>Fatura No:</strong> #");
#nullable restore
#line 36 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                                            Write(Model.Id.ToString().Split('-').FirstOrDefault());

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\r\n                    <strong>İşlem Tarihi:</strong> ");
#nullable restore
#line 37 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                                              Write(Model.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br>
                </p>
            </div>
        </div>


        <!-- Client & Supplier -->
        <div class=""row"">
            <div class=""col-xl-12"">
                <h2>Sanal Fatura</h2>
            </div>

            <div class=""col-xl-6"">
                <strong class=""margin-bottom-5"">Hizmeti Veren</strong>
                <p>
                    ");
#nullable restore
#line 52 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
               Write(chef.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                          Write(chef.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>\r\n                    ");
#nullable restore
#line 53 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
               Write(chef.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>\r\n                    ");
#nullable restore
#line 54 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
               Write(chef.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"col-xl-6\">\r\n                <strong class=\"margin-bottom-5\">Müşteri</strong>\r\n                <p>\r\n                    ");
#nullable restore
#line 61 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
               Write(client.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                            Write(client.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>\r\n                    ");
#nullable restore
#line 62 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
               Write(client.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br>\r\n                    ");
#nullable restore
#line 63 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
               Write(client.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <br>
                </p>
            </div>
        </div>


        <!-- Invoice -->
        <div class=""row"">
            <div class=""col-xl-12"">
                <table class=""margin-top-20"">
                    <tbody>
                        <tr>
                            <th>Açıklama</th>
                            <th>Bedel</th>
                            <th>KDV (0%)</th>
                            <th>Toplam</th>
                        </tr>

                        <tr>
                            <td>Standart Acikio Hizmeti</td>
                            <td>₺");
#nullable restore
#line 83 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                            Write(Model.Deal.OrderOffer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(".00</td>\r\n                            <td>₺0.00</td>\r\n                            <td>$");
#nullable restore
#line 85 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                            Write(Model.Deal.OrderOffer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@".00</td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <div class=""col-xl-4 col-xl-offset-8"">
                <table id=""totals"">
                    <tbody>
                        <tr>
                            <th>Toplam Ödenen</th>
                            <th><span>$");
#nullable restore
#line 96 "C:\Users\semih\Source\Repos\semihelitas\kodlayacagiz\APP.UI\Views\Deal\Invoice.cshtml"
                                  Write(Model.Deal.OrderOffer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@".00</span></th>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>


        <!-- Footer -->
        <div class=""row"">
            <div class=""col-xl-12"">
                <ul id=""footer"">
                    <li><span>www.acikio.com</span></li>
                    <li>support@acikio.com</li>
                    <li> +90 (212) 426 10 10</li>
                </ul>
            </div>
        </div>

    </div>

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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APP.Core.Models.CompletedDeal> Html { get; private set; }
    }
}
#pragma warning restore 1591
