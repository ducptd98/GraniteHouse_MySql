#pragma checksum "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe3ad879808ccc0d5d0faf670c74dfbe870df62c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TableButtonPartial.cshtml", typeof(AspNetCore.Views_Shared__TableButtonPartial))]
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
#line 1 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Views\_ViewImports.cshtml"
using GraniteHouse_MySQL;

#line default
#line hidden
#line 2 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Views\_ViewImports.cshtml"
using GraniteHouse_MySQL.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3ad879808ccc0d5d0faf670c74dfbe870df62c", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66d582f5e19e89a3a1401bc0bf4cb34c3475b56c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(132, 132, true);
            WriteLiteral("\r\n\r\n<td style=\"width: 150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a class=\"btn btn-primary text-white\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 264, "\"", 309, 1);
#line 8 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 271, Url.Action($"Edit", new {id = Model}), 271, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(310, 117, true);
            WriteLiteral(">\r\n            <i class=\"fas fa-edit\"></i>\r\n        </a>\r\n        <a class=\"btn btn-success text-white\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 427, "\"", 474, 1);
#line 11 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 434, Url.Action($"Details",new {id = Model}), 434, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(475, 120, true);
            WriteLiteral(">\r\n            <i class=\"fas fa-list-alt\"></i>\r\n        </a>\r\n        <a class=\"btn btn-danger text-white\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 595, "\"", 642, 1);
#line 14 "D:\Study\Visual Project\ASP.NET\GraniteHouse_MySQL\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 602, Url.Action($"Delete" ,new {id = Model}), 602, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(643, 80, true);
            WriteLiteral(">\r\n            <i class=\"fas fa-trash-alt\"></i>\r\n        </a>\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
