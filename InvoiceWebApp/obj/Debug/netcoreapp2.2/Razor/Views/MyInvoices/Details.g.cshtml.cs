#pragma checksum "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aac0f000d4498c77b5f9af66ff66778b66e9ed19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyInvoices_Details), @"mvc.1.0.view", @"/Views/MyInvoices/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MyInvoices/Details.cshtml", typeof(AspNetCore.Views_MyInvoices_Details))]
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
#line 1 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp;

#line default
#line hidden
#line 2 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp.Models;

#line default
#line hidden
#line 3 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\_ViewImports.cshtml"
using InvoiceWebApp.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac0f000d4498c77b5f9af66ff66778b66e9ed19", @"/Views/MyInvoices/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80831de9ee2f7bea6f2ab52a8d5ce940722baa4a", @"/Views/_ViewImports.cshtml")]
    public class Views_MyInvoices_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceWebApp.Models.Invoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/my-invoice.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("icon_created createdon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("icon_expired expired"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pay-invoice-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Pay"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyInvoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-large indigo darken-1 waves-effect waves-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("indigo-text text-darken-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
  
    ViewData["Title"] = "Invoice Details";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("HEAD", async() => {
                BeginContext(107, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(110, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aac0f000d4498c77b5f9af66ff66778b66e9ed198895", async() => {
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
                EndContext();
                BeginContext(163, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(168, 358, true);
            WriteLiteral(@"
<div class=""container"" id=""details-myinvoice"">

    <div class=""row"">
        <div class=""col s12 col m12 center-align"">
            <h4 style=""margin-top: 0px;"">Invoice Details</h4>
        </div>
    </div>

    <br />

    <!--Form-->
    <div class=""row"" style=""margin-top: 5px;"">
        <div class=""col s12 col m12 col l12"">
            ");
            EndContext();
            BeginContext(526, 3946, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aac0f000d4498c77b5f9af66ff66778b66e9ed1910724", async() => {
                BeginContext(532, 201, true);
                WriteLiteral("\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col s12 col m12 col l5\">\r\n                        <fieldset>\r\n                            <legend>Invoice Information</legend>\r\n\r\n");
                EndContext();
#line 31 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                             if (Model.DebtorID != null) {

#line default
#line hidden
                BeginContext(793, 376, true);
                WriteLiteral(@"                                <div class=""row"" id=""debtor-row"">
                                    <label for=""debtor"">Debtor</label>
                                    <div class=""input-field col s12 col m12 col l12"">
                                        <i class=""material-icons prefix"">perm_identity</i>
                                        <input id=""debtor""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1169, "\"", 1201, 1);
#line 36 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
WriteAttributeValue("", 1177, Model.Debtor.FullName, 1177, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1202, 98, true);
                WriteLiteral(" disabled />\r\n                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 39 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                            }

#line default
#line hidden
                BeginContext(1331, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                             if (Model.CompanyID != null) {

#line default
#line hidden
                BeginContext(1394, 375, true);
                WriteLiteral(@"                                <div class=""row"" id=""company-row"">
                                    <label for=""company"">Company</label>
                                    <div class=""input-field col s12 col m12 col l12"">
                                        <i class=""material-icons prefix"">business</i>
                                        <input id=""company""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1769, "\"", 1805, 1);
#line 46 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
WriteAttributeValue("", 1777, Model.Company.CompanyName, 1777, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1806, 98, true);
                WriteLiteral(" disabled />\r\n                                    </div>\r\n                                </div>\r\n");
                EndContext();
#line 49 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                            }

#line default
#line hidden
                BeginContext(1935, 328, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <label for=""icon_created"">Invoice Date</label>
                                <div class=""input-field col s12 col m12 col l12"">
                                    <i class=""material-icons prefix"">today</i>
                                    ");
                EndContext();
                BeginContext(2263, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aac0f000d4498c77b5f9af66ff66778b66e9ed1914552", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 55 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedOn);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2329, 409, true);
                WriteLiteral(@"
                                </div>
                            </div>

                            <div class=""row"">
                                <label for=""icon_expired"">Expiration Date</label>
                                <div class=""input-field col s12 col m12 col l12"">
                                    <i class=""material-icons prefix"">today</i>
                                    ");
                EndContext();
                BeginContext(2738, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aac0f000d4498c77b5f9af66ff66778b66e9ed1916971", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 63 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ExpirationDate);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2807, 1000, true);
                WriteLiteral(@"
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""input-field col s12 col m12 col l6"">
                                    <i class=""material-icons prefix"">euro_symbol</i>
                                    <input id=""total"" name=""total"" type=""text"" disabled />
                                    <label for=""total"">Total</label>
                                </div>
                            </div>

                        </fieldset>
                    </div>
                    <div class=""col s12 col m12 col l7"">
                        <fieldset>
                            <legend>Products</legend>

                            <div id=""products""></div>
                        </fieldset>
                    </div>
                </div>

                <div class=""row"">
                    <div id=""button-area"">
                        ");
                EndContext();
                BeginContext(3807, 452, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aac0f000d4498c77b5f9af66ff66778b66e9ed1920002", async() => {
                    BeginContext(4101, 149, true);
                    WriteLiteral("\r\n                            <i class=\"material-icons left\">attach_money</i>\r\n                            <span>Pay</span>\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 90 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                                  WriteLiteral(Model.InvoiceNumber);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4259, 62, true);
                WriteLiteral("\r\n\r\n                        <br />\r\n\r\n                        ");
                EndContext();
                BeginContext(4321, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aac0f000d4498c77b5f9af66ff66778b66e9ed1923267", async() => {
                    BeginContext(4377, 16, true);
                    WriteLiteral("Back to Overview");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4397, 68, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4472, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4532, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 109 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(4602, 425, true);
                WriteLiteral(@"
    <script>
        //Variables
        var firstRun = true;

        //Run when page has loaded
        $(document).ready(function () {
            $(""#products select"").material_select();
            $(""#debtor-row #select_debtor"").material_select();
            $(""#company-row #select_company"").material_select();

            //Set value of the total amount in the input box
            var totalAmount = """);
                EndContext();
                BeginContext(5029, 13, false);
#line 122 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                           Write(ViewBag.Total);

#line default
#line hidden
                EndContext();
                BeginContext(5043, 604, true);
                WriteLiteral(@""";
			$(""#total"").val(totalAmount);

			//Reinitialize all labels
			Materialize.updateTextFields();

            //Set product rows is this is the first run
            if (firstRun == true) {
                setRows();
            }
        });

        //-------------------------------------------------------------------------------------------
        //Create new product rows based on the products selected when creating this invoice
        function setRows() {
            var pids = new Array();
            var amounts = new Array();
            var pnames = new Array();

");
                EndContext();
#line 141 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
             foreach (var pid in ViewBag.PIDs)
            {

#line default
#line hidden
                BeginContext(5710, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(5728, 11, true);
                WriteLiteral("pids.push(\'");
                EndContext();
                BeginContext(5741, 3, false);
#line 143 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                         Write(pid);

#line default
#line hidden
                EndContext();
                BeginContext(5745, 5, true);
                WriteLiteral("\');\r\n");
                EndContext();
#line 144 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(5765, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 145 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
             foreach (var amount in ViewBag.Amounts)
            {

#line default
#line hidden
                BeginContext(5834, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(5852, 14, true);
                WriteLiteral("amounts.push(\'");
                EndContext();
                BeginContext(5868, 6, false);
#line 147 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                            Write(amount);

#line default
#line hidden
                EndContext();
                BeginContext(5875, 5, true);
                WriteLiteral("\');\r\n");
                EndContext();
#line 148 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(5895, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 149 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
             foreach (var name in ViewBag.Names)
            {

#line default
#line hidden
                BeginContext(5960, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(5978, 13, true);
                WriteLiteral("pnames.push(\'");
                EndContext();
                BeginContext(5993, 4, false);
#line 151 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                           Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(5998, 5, true);
                WriteLiteral("\');\r\n");
                EndContext();
#line 152 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(6018, 1368, true);
                WriteLiteral(@"
            for (var i = 0; i < amounts.length; i++) {
                var amount = amounts[i];

                var html = `
                    <div id=""product-row-` + i + `"" class=""row"">
                        <div class=""input-field col s12 col m8 col l8"">
                            <input id=""_product-` + i + `"" disabled/>
                        </div>

                        <div class=""input-field col s8 col m2 col l2"">
                            <input id=""_amount"" placeholder=""Qnt."" value=""` + amount + `"" disabled />
                        </div>
                    </div>
                `;

                $(""#products"").append(html);
            }

            for (var i = 0; i < amounts.length; i++) {
                var pid = pids[i];
                var pname = pnames[i];

                var element = ""#products #product-row-"" + i.toString() + "" #_product-"" + i.toString();

                $(element).prop(""value"", pname);
                $(element).prop(""disab");
                WriteLiteral(@"led"", true);

                //Reset variables
                pid = """";
                pname = """";
            }
        }

        //-------------------------------------------------------------------------------------------
        //Pay this invoice
        $(""#pay-invoice-btn"").on(""click"", function () {
            var id = ");
                EndContext();
                BeginContext(7388, 19, false);
#line 190 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                 Write(Model.InvoiceNumber);

#line default
#line hidden
                EndContext();
                BeginContext(7408, 80, true);
                WriteLiteral(";\r\n\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \'");
                EndContext();
                BeginContext(7489, 17, false);
#line 194 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                 Write(Url.Action("Pay"));

#line default
#line hidden
                EndContext();
                BeginContext(7506, 169, true);
                WriteLiteral("\',\r\n                data: {\r\n                    id: id\r\n                },\r\n                success: function() { alert(\'Thank you for paying!\'); window.location.href=\'");
                EndContext();
                BeginContext(7676, 19, false);
#line 198 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\MyInvoices\Details.cshtml"
                                                                                       Write(Url.Action("Index"));

#line default
#line hidden
                EndContext();
                BeginContext(7695, 148, true);
                WriteLiteral("\'; },\r\n                error: function() { alert(\'An error occured while paying. Please try again!\');}\r\n            });\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceWebApp.Models.Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
