#pragma checksum "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e35aedd2d1d09c0fd32311e9971dc5449306cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Login), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Login.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using TaleonLtd.Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e35aedd2d1d09c0fd32311e9971dc5449306cf", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d46aa75b8886bb4b0bc3cda04fac5d053ee58a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
  
    ViewData["Title"] = "Log in";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<div class=""row"">
    <div class=""col-md-4"">
        <section>
            <form id=""account"" method=""post"">
                <h4>Use a local account to log in.</h4>
                <hr />
                <div asp-validation-summary=""All"" class=""text-danger""></div>
                <div class=""form-group"">
                    <label asp-for=""Input.Email""></label>
                    <input asp-for=""Input.Email"" class=""form-control"" />
                    <span asp-validation-for=""Input.Email"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label asp-for=""Input.Password""></label>
                    <input asp-for=""Input.Password"" class=""form-control"" />
                    <span asp-validation-for=""Input.Password"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <div class=""checkbox"">
                        <label asp-for=""Input.RememberMe"">
                ");
            WriteLiteral("            <input asp-for=\"Input.RememberMe\" />\r\n                            ");
#nullable restore
#line 30 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
                       Write(Html.DisplayNameFor(m => m.Input.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </label>
                    </div>
                </div>
                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-primary"">Log in</button>
                </div>
                <div class=""form-group"">
                    <p>
                        <a id=""forgot-password"" asp-page=""./ForgotPassword"">Forgot your password?</a>
                    </p>
                    <p>
                        <a asp-page=""./Register""");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 1747, "\"", 1785, 1);
#nullable restore
#line 42 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 1769, Model.ReturnUrl, 1769, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Register as a new user</a>
                    </p>
                    <p>
                        <a id=""resend-confirmation"" asp-page=""./ResendEmailConfirmation"">Resend email confirmation</a>
                    </p>
                </div>
            </form>
        </section>
    </div>
    <div class=""col-md-6 col-md-offset-2"">
        <section>
            <h4>Use another service to log in.</h4>
            <hr />
");
#nullable restore
#line 55 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
              
                if ((Model.ExternalLogins?.Count ?? 0) == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div>
                        <p>
                            There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                            for details on setting up this ASP.NET application to support logging in via external services.
                        </p>
                    </div>
");
#nullable restore
#line 64 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <form id=\"external-account\" asp-page=\"./ExternalLogin\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 2860, "\"", 2898, 1);
#nullable restore
#line 67 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 2882, Model.ReturnUrl, 2882, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" class=\"form-horizontal\">\r\n                        <div>\r\n                            <p>\r\n");
#nullable restore
#line 70 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
                                 foreach (var provider in Model.ExternalLogins)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
            BeginWriteAttribute("value", " value=\"", 3217, "\"", 3239, 1);
#nullable restore
#line 72 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 3225, provider.Name, 3225, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3240, "\"", 3295, 6);
            WriteAttributeValue("", 3248, "Log", 3248, 3, true);
            WriteAttributeValue(" ", 3251, "in", 3252, 3, true);
            WriteAttributeValue(" ", 3254, "using", 3255, 6, true);
            WriteAttributeValue(" ", 3260, "your", 3261, 5, true);
#nullable restore
#line 72 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue(" ", 3265, provider.DisplayName, 3266, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3287, "account", 3288, 8, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 73 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                        </div>\r\n                    </form>\r\n");
#nullable restore
#line 77 "C:\Users\HP\Desktop\TaleonLtd\Web\TaleonLtd.Web\Areas\Identity\Pages\Account\Login.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
