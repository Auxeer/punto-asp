#pragma checksum "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6089c9af6c8931caa1cea50b38447f6706e251ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Create), @"mvc.1.0.view", @"/Views/Producto/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Producto/Create.cshtml", typeof(AspNetCore.Views_Producto_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6089c9af6c8931caa1cea50b38447f6706e251ea", @"/Views/Producto/Create.cshtml")]
    public class Views_Producto_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Producto/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 1 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Create.cshtml"
          
    ViewData["Title"] = "Agregar Helado - ";    
    

#line default
#line hidden
            BeginContext(72, 180, true);
            WriteLiteral("    \r\n    <!-- Content Header (Page header) -->\r\n    <section class=\"content-header\">\r\n        <h1>\r\n        Helados\r\n        </h1>\r\n\r\n        <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(252, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6089c9af6c8931caa1cea50b38447f6706e251ea3945", async() => {
                BeginContext(275, 39, true);
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Inicio ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(337, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6089c9af6c8931caa1cea50b38447f6706e251ea5288", async() => {
                BeginContext(364, 45, true);
                WriteLiteral("<i class=\"fa fa-circle-o-notch\"></i> Helados ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(413, 1880, true);
            WriteLiteral(@"</li>
        <li class=""active"">Agregar</li>
        </ol>

    </section>
    <!-- Main content -->
    <section class=""content container-fluid"">
        <!-- Horizontal Form -->
        <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Agregar Helado</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action=""CreateProducto"">
            <div class=""box-body"">
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Nombre</label>
                <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""Nombre"" placeholder=""Nombre"" required>              
                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Descripcion</label>
                <div class=""col-sm-10"">
         ");
            WriteLiteral(@"       <input type=""text"" class=""form-control"" name=""Descripcion"" placeholder=""Descripcion"" required>
                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputPassword3"" class=""col-sm-2 control-label"">Precio</label>
                <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""Precio"" placeholder=""Precio"" required>
                </div>
            </div>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
            <a href=""./""><button type=""button"" class=""btn btn-default"">Cancelar</button></a>
            <button type=""submit"" class=""btn btn-info pull-right"">Crear</button>
            </div>
            <!-- /.box-footer -->
        </form>
        </div>
        <!-- /.box -->
    </section>");
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
