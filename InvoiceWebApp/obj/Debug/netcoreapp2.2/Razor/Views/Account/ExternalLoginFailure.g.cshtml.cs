#pragma checksum "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\Account\ExternalLoginFailure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c0ad8ad33bd27182585fbd2fbf56d4d7cd2f0f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ExternalLoginFailure), @"mvc.1.0.view", @"/Views/Account/ExternalLoginFailure.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ExternalLoginFailure.cshtml", typeof(AspNetCore.Views_Account_ExternalLoginFailure))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0ad8ad33bd27182585fbd2fbf56d4d7cd2f0f1", @"/Views/Account/ExternalLoginFailure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80831de9ee2f7bea6f2ab52a8d5ce940722baa4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ExternalLoginFailure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\Account\ExternalLoginFailure.cshtml"
  
    ViewData["Title"] = "Login Failure";

#line default
#line hidden
            BeginContext(49, 20, true);
            WriteLiteral("\r\n<header>\r\n    <h2>");
            EndContext();
            BeginContext(70, 17, false);
#line 6 "D:\Git\MVC-Invoice2\InvoiceWebApp\Views\Account\ExternalLoginFailure.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(87, 82, true);
            WriteLiteral(".</h2>\r\n    <p class=\"text-danger\">Unsuccessful login with service.</p>\r\n</header>");
            EndContext();
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
