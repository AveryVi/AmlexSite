#pragma checksum "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bca8ab07779ab46af70e6d59602ec85f38560c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wiki_Plugin), @"mvc.1.0.view", @"/Views/Wiki/Plugin.cshtml")]
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
#line 2 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
using AmlexTradeWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bca8ab07779ab46af70e6d59602ec85f38560c", @"/Views/Wiki/Plugin.cshtml")]
    #nullable restore
    public class Views_Wiki_Plugin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WikiPluginInfo>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"jumbotron\">\r\n    ");
#nullable restore
#line 6 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
Write(Model.Plugin.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 7 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
Write(Model.Plugin.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
     foreach(Command com in Model.Commands)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 10 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
      Write(com.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 11 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
      Write(com.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\VineWood\AmlexTradeWeb\Views\Wiki\Plugin.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WikiPluginInfo> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591