#pragma checksum "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4737c5451389254ec751982fcfc6cfc94e93b011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Buy), @"mvc.1.0.view", @"/Views/Shop/Buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4737c5451389254ec751982fcfc6cfc94e93b011", @"/Views/Shop/Buy.cshtml")]
    #nullable restore
    public class Views_Shop_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"jumbotron\">\n\n");
#nullable restore
#line 4 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
     if (User?.Identity?.IsAuthenticated ?? false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Welcome, ");
#nullable restore
#line 6 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
                Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
            WriteLiteral("        <p>\n");
#nullable restore
#line 9 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
             foreach (var claim in Context.User.Claims)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><code>");
#nullable restore
#line 11 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
                      Write(ViewBag.SteamURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>: <strong>");
#nullable restore
#line 11 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
                                                        Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\n");
#nullable restore
#line 12 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\n");
            WriteLiteral("        <a class=\"btn btn-lg btn-danger\" href=\"/signout?returnUrl=%2F\">Sign out</a>\n");
#nullable restore
#line 16 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
    }

    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Welcome, anonymous</h1>\n        <a class=\"btn btn-lg btn-success\" href=\"/signin?returnUrl=%2F\">Sign in</a>\n");
#nullable restore
#line 22 "C:\VineWood\AmlexTradeWeb\Views\Shop\Buy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
