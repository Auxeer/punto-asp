#pragma checksum "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124c0b9b7a32a3cc74adc94677db1bae925cad70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Index), @"mvc.1.0.view", @"/Views/Producto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Producto/Index.cshtml", typeof(AspNetCore.Views_Producto_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124c0b9b7a32a3cc74adc94677db1bae925cad70", @"/Views/Producto/Index.cshtml")]
    public class Views_Producto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<punto.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Producto/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
              
             ViewData["Title"] = "Helados - ";    
        

#line default
#line hidden
            BeginContext(129, 538, true);
            WriteLiteral(@"
    <section class=""content-header"">
        <h1>
        Helados
        </h1>
        <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Inicio </a></li>
        <li class=""active"">Helados</li>
        </ol>
        
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
            <div class=""box-header"">
                <h3 class=""box-title"">Manejar Helados</h3>
                ");
            EndContext();
            BeginContext(667, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124c0b9b7a32a3cc74adc94677db1bae925cad704893", async() => {
                BeginContext(695, 80, true);
                WriteLiteral("<button type=\"button\" class=\"btn btn-success pull-right\">Agregar Helado</button>");
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
            BeginContext(779, 526, true);
            WriteLiteral(@"
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <table class=""table table-bordered table-striped"">
                <thead>
                <tr> 
                    <th style=""display:none;"">Id</th>                 
                    <th>Nombre</th>                  
                    <th>Precio</th>
                    <th>Descripcion</th>
                    <th>Accion</th>
                </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 39 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1378, 84, true);
            WriteLiteral("                        <tr>\r\n                            <td style=\"display:none;\">");
            EndContext();
            BeginContext(1463, 37, false);
#line 42 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1540, 41, false);
#line 43 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1581, 41, true);
            WriteLiteral("</td>\r\n                            <td>Q ");
            EndContext();
            BeginContext(1623, 41, false);
#line 44 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1704, 46, false);
#line 45 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 114, true);
            WriteLiteral("</td>                                               \r\n                            <td style=\"text-align: center;\">");
            EndContext();
            BeginContext(1864, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124c0b9b7a32a3cc74adc94677db1bae925cad708879", async() => {
                BeginContext(1901, 58, true);
                WriteLiteral("<img src=\"../dist/img/editar.png\" width=\"25\" height=\"25\"/>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1873, "~/Producto/Update/", 1873, 18, true);
#line 46 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
AddHtmlAttributeValue("", 1891, item.Id, 1891, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1963, 13, true);
            WriteLiteral(" | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1976, "\"", 2004, 3);
            WriteAttributeValue("", 1986, "Delete(\'", 1986, 8, true);
#line 46 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
WriteAttributeValue("", 1994, item.Id, 1994, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2002, "\')", 2002, 2, true);
            EndWriteAttribute();
            BeginContext(2005, 103, true);
            WriteLiteral("><img src=\"../dist/img/eliminar.png\" width=\"25\" height=\"25\"/></a></td>\r\n                        </tr>\r\n");
            EndContext();
#line 48 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2131, 261, true);
            WriteLiteral(@"                </table>
            </div>
            <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
        </div>
        <!-- /.row -->
    </section>
       
    <!-- DataTables -->
    ");
            EndContext();
            BeginContext(2392, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124c0b9b7a32a3cc74adc94677db1bae925cad7011782", async() => {
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
            BeginContext(2477, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(2483, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "124c0b9b7a32a3cc74adc94677db1bae925cad7012966", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2574, 1860, true);
            WriteLiteral(@"

    <!-- page script -->
    <script>
        $(function () {
            $('#example1').DataTable( {
                    ""language"": idioma_español
                } );
        });

        var idioma_español = {
                    ""sProcessing"":     ""Procesando..."",
                    ""sLengthMenu"":     ""Mostrar _MENU_ Registros"",
                    ""sZeroRecords"":    ""No se encontraron resultados"",
                    ""sEmptyTable"":     ""Ningún dato disponible en esta tabla"",
                    ""sInfo"":           ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
                    ""sInfoEmpty"":      ""Mostrando registros del 0 al 0 de un total de 0 registros"",
                    ""sInfoFiltered"":   ""(filtrado de un total de _MAX_ registros)"",
                    ""sInfoPostFix"":    """",
                    ""sSearch"":         ""Buscar:"",
                    ""sUrl"":            """",
                    ""sInfoThousands"":  "","",
                    ""sLoadingReco");
            WriteLiteral(@"rds"": ""Cargando..."",
                    ""oPaginate"": {
                        ""sFirst"":    ""Primero"",
                        ""sLast"":     ""Último"",
                        ""sNext"":     ""Siguiente"",
                        ""sPrevious"": ""Anterior""
                    },
                    ""oAria"": {
                        ""sSortAscending"":  "": Activar para ordenar la columna de manera ascendente"",
                        ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
                    }
                }

        function Delete(id){
            var txt;
            var r = confirm(""Estas seguro que deseas eliminar esto?"");
            if (r == true) {
                
                $.ajax(
                {
                    type: ""POST"",
                    url: '");
            EndContext();
            BeginContext(4435, 32, false);
#line 105 "d:\Users\brian\Documents\ASP .net\punto\Views\Producto\Index.cshtml"
                     Write(Url.Action("Delete", "Producto"));

#line default
#line hidden
            EndContext();
            BeginContext(4467, 651, true);
            WriteLiteral(@"',
                    data: {
                        id: id
                    },
                    error: function (result) {
                        alert(""error"");
                    },
                    success: function (result) {
                        if (result == true) {
                            var baseUrl=""/Producto"";
                            window.location.reload();
                        }
                        else {
                            alert(""Hay un problema, Intenta Despues!"");
                        }
                    }
                });
            } 
        }
    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<punto.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591