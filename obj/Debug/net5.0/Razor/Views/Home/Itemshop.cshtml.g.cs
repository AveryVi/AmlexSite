#pragma checksum "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1ea940e40d3ad7c4534147f92b4942c43da8d0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Itemshop), @"mvc.1.0.view", @"/Views/Home/Itemshop.cshtml")]
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
#line 2 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
using AmlexTradeWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1ea940e40d3ad7c4534147f92b4942c43da8d0c", @"/Views/Home/Itemshop.cshtml")]
    #nullable restore
    public class Views_Home_Itemshop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Item>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"jumbotron\">\r\n       <h1>Items</h1>\r\n");
#nullable restore
#line 6 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
     if(Model.Count()>0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
         foreach (Item item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"sellitem\">\r\n                <div class=\"id\" asp-for=\"id\">");
#nullable restore
#line 11 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
                                        Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <input asp-for=\"id\"");
            BeginWriteAttribute("value", " value=\"", 319, "\"", 335, 1);
#nullable restore
#line 12 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
WriteAttributeValue("", 327, item.ID, 327, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n                <div class=\"cost\">");
#nullable restore
#line 13 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
                             Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"name\">");
#nullable restore
#line 14 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"item_id\">");
#nullable restore
#line 15 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
                                Write(item.ItemID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
                 if (User?.Identity?.IsAuthenticated ?? false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1ea940e40d3ad7c4534147f92b4942c43da8d0c5000", async() => {
                WriteLiteral("Купить");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 628, "~/Home/BuyCar/", 628, 14, true);
#nullable restore
#line 18 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
AddHtmlAttributeValue("", 642, item.ID, 642, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 21 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\VineWood\AmlexTradeWeb\Views\Home\Itemshop.cshtml"
         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Item>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591