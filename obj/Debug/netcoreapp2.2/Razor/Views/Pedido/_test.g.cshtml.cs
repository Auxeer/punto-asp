#pragma checksum "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32c94a8d6435a61e4e9518e28f2976980732aa0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido__test), @"mvc.1.0.view", @"/Views/Pedido/_test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/_test.cshtml", typeof(AspNetCore.Views_Pedido__test))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c94a8d6435a61e4e9518e28f2976980732aa0b", @"/Views/Pedido/_test.cshtml")]
    public class Views_Pedido__test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<punto.Models.Producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 114, true);
            WriteLiteral("\r\n<fieldset>  \r\n    <legend>Producto Seleccionado</legend>  \r\n    <div class=\"display-label\">  \r\n        <strong> ");
            EndContext();
            BeginContext(145, 38, false);
#line 6 "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml"
            Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(183, 63, true);
            WriteLiteral(" </strong>  \r\n    </div>  \r\n    <div class=\"display-field\">  \r\n");
            EndContext();
            BeginContext(247, 34, false);
#line 9 "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml"
Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(281, 66, true);
            WriteLiteral("  \r\n</div>  \r\n    <div class=\"display-label\">  \r\n        <strong> ");
            EndContext();
            BeginContext(348, 42, false);
#line 12 "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml"
            Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(390, 63, true);
            WriteLiteral(" </strong>  \r\n    </div>  \r\n    <div class=\"display-field\">  \r\n");
            EndContext();
            BeginContext(454, 38, false);
#line 15 "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml"
Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(492, 66, true);
            WriteLiteral("  \r\n</div>  \r\n    <div class=\"display-label\">  \r\n        <strong> ");
            EndContext();
            BeginContext(559, 42, false);
#line 18 "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml"
            Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(601, 63, true);
            WriteLiteral(" </strong>  \r\n    </div>  \r\n    <div class=\"display-field\">  \r\n");
            EndContext();
            BeginContext(665, 38, false);
#line 21 "d:\Users\brian\Documents\ASP .net\punto\Views\Pedido\_test.cshtml"
Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(703, 25, true);
            WriteLiteral("  \r\n</div>  \r\n</fieldset>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<punto.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
