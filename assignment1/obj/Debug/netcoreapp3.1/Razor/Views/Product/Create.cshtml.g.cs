#pragma checksum "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b925d80d690978a0117e4e347f7aa25d5aadc69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "D:\visual studio source code\assignment\assignment1\assignment1\Views\_ViewImports.cshtml"
using assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\visual studio source code\assignment\assignment1\assignment1\Views\_ViewImports.cshtml"
using assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b925d80d690978a0117e4e347f7aa25d5aadc69", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ec9bbb3a297dde244f6b0a2620babf17d5d546", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml"
    using(Html.BeginForm("Validate", "Product","POST"))
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n          <td>\r\n             Product Id:\r\n          </td>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml"
           Write(Html.TextBox("pid","",new { type="number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           </tr>\r\n           <tr>\r\n            <td>\r\n               Product Name:\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml"
           Write(Html.TextBox("pname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            </tr>\r\n        <tr>\r\n        <td>\r\n            Product Price:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 32 "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml"
       Write(Html.TextBox("price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n          </tr>\r\n        <tr>\r\n            <td>\r\n                Product Stock:\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml"
           Write(Html.TextBox("stock","",new { type="number"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <center><input type=\"submit\" value=\"Submit\" /></center>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 49 "D:\visual studio source code\assignment\assignment1\assignment1\Views\Product\Create.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
