#pragma checksum "/Users/Aelien/Documents/work/FlashCard/Views/Home/Kanji.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f3785eb98c60a6c9476dee83d4204b972e2f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Kanji), @"mvc.1.0.view", @"/Views/Home/Kanji.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Kanji.cshtml", typeof(AspNetCore.Views_Home_Kanji))]
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
#line 1 "/Users/Aelien/Documents/work/FlashCard/Views/_ViewImports.cshtml"
using FlashCard;

#line default
#line hidden
#line 2 "/Users/Aelien/Documents/work/FlashCard/Views/_ViewImports.cshtml"
using FlashCard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f3785eb98c60a6c9476dee83d4204b972e2f29", @"/Views/Home/Kanji.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53f6db93bf1d1dbc4055aae4225aca24f9a9a471", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Kanji : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(5, 24, false);
#line 1 "/Users/Aelien/Documents/work/FlashCard/Views/Home/Kanji.cshtml"
Write(Html.Raw(@ViewBag.Kanji));

#line default
#line hidden
            EndContext();
            BeginContext(29, 6, true);
            WriteLiteral("</h1>\n");
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
