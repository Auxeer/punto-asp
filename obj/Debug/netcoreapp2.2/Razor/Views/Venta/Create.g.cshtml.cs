#pragma checksum "d:\Users\brian\Documents\ASP .net\punto\Views\Venta\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89ffc470b3cf64e7d5088b3ca62d2b46277ef3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_Create), @"mvc.1.0.view", @"/Views/Venta/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venta/Create.cshtml", typeof(AspNetCore.Views_Venta_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89ffc470b3cf64e7d5088b3ca62d2b46277ef3f", @"/Views/Venta/Create.cshtml")]
    public class Views_Venta_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<punto.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Venta/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\Users\brian\Documents\ASP .net\punto\Views\Venta\Create.cshtml"
          
    ViewData["Title"] = "Realizar Venta - ";    
    

#line default
#line hidden
            BeginContext(106, 183, true);
            WriteLiteral("\r\n\r\n    <!-- Content Header (Page header) -->\r\n    \r\n    <section class=\"content-header\">\r\n        <h1>\r\n        Ventas\r\n        </h1>\r\n\r\n        <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(289, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b89ffc470b3cf64e7d5088b3ca62d2b46277ef3f4042", async() => {
                BeginContext(312, 39, true);
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
            BeginContext(355, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(374, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b89ffc470b3cf64e7d5088b3ca62d2b46277ef3f5385", async() => {
                BeginContext(398, 44, true);
                WriteLiteral("<i class=\"fa fa-circle-o-notch\"></i> Ventas ");
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
            BeginContext(446, 707, true);
            WriteLiteral(@"</li>
        <li class=""active"">Agregar</li>
        </ol>

    </section>
    <!-- Main content -->
    <section class=""content container-fluid"">
        <!-- Horizontal Form -->
        <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Realizar Venta</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        <form class=""form-horizontal"" method=""post"" action="""">
            <div class=""box-body"">       
                <div class=""form-group"">
                    <label for="""" class=""col-sm-1 control-label"">Producto</label>
                    <div class=""col-sm-10"">
                            ");
            EndContext();
            BeginContext(1154, 132, false);
#line 36 "d:\Users\brian\Documents\ASP .net\punto\Views\Venta\Create.cshtml"
                       Write(Html.DropDownListFor(model => model.Id, Model.ProductoListItems, "Elegir Producto", new { @class = "form-control", id="selectlist"}));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 7226, true);
            WriteLiteral(@" 
                    </div>                      
                    <input onclick=""Ambas()"" id=""btnCreate"" class=""btn btn-success"" value=""Agregar"" style=""width:100px"">
                </div>                
            </div>
            <div class=""box-body"">
            <table id=""tPedidos"" width=""100%"" class=""table table-bordered table-responsive"">
                <thead>
                <tr>                  
                    <th style=""text-align: center"" width= ""50%"">Producto</th>
                    <th style=""text-align: center"" width= ""30%"">Precio</th>
                    <th style=""text-align: center"" width= ""10%"">Cantidad</th>
                    <th style=""text-align: center"" width= ""10%"">Accion</th>                  
                </tr>
                </thead>
                <tbody></tbody>        
           </table>

            <div class=""form-group"">
            <br>
            <label class=""col-sm-1 control-label"">Total</label>
            <div class=""col-sm");
            WriteLiteral(@"-2"">
            <input type=""text"" style=""text-align: center"" id=""tot"" value=""0"" class=""form-control"" readonly>                      
            </div> 
            <img src=""../dist/img/actualizar.png"" width=""30"" height=""31"" onclick=""CalcularTotal()""/>          
            </div>        

           </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
            <a href=""./""><button type=""button"" class=""btn btn-default"">Cancelar</button></a>
            <input onclick=""Guardar()"" id=""btnSave"" class=""btn btn-info pull-right"" value=""Crear"" style=""width:100px"">
            </div>
            <!-- /.box-footer -->
        </form>
        </div>
        <!-- /.box -->
    </section>
                
    <script type=""text/javascript""> 
    //Opcion para disabled la primera opcion del dropdownlist
    $(""#selectlist option:first-child"").attr(""disabled"",""disabled"");   

    //Funcion Eliminar Fila de la tabla
    function Remove(button) { button.parentElement.parent");
            WriteLiteral(@"Element.remove(); };

    //Opcion Eliminar (( ABSTRAIDO A UNA FUNCION PARA TENER UNA INSTANCIA UNICA ))
    function crearBotonEliminar () {
        const eliminar = document.createElement(""img"");
        eliminar.src = ""../dist/img/eliminar.png"";      
        eliminar.style.width = '25px';
        eliminar.style.height = ""25px"";
        return eliminar;
    }
    //Opcion Cantidad (( ABSTRAIDO A UNA FUNCION PARA TENER UNA INSTANCIA UNICA ))
    function crearBotonCantidad () {
        const cantidad = document.createElement('input')
        cantidad.type = 'number'
        cantidad.style.width = '147px'
        cantidad.style.height = '30px'
        cantidad.value= '1'
        cantidad.min = '1'
        cantidad.style.textAlign = ""center""
        cantidad.className = 'form-control'
        return cantidad;
    }
    function Ambas () {
        Seleccionar(); 
        //Delay para que ingrese los valores la funcion seleccionar
        setTimeout(CalcularTotal, 100);  
        Calcu");
            WriteLiteral(@"larTotal();    
    }

    function Seleccionar() {       
        var id = $(""#selectlist"").val()
        $.ajax({
            type: ""GET"",
            url: ""/Venta/GetProduct?Id="" + id,
            success: function (data) {
                var tBody = $(""#tPedidos > TBODY"")[0];
                var row = tBody.insertRow(-1);
            
                //Add Nombre cell. 
                cell = $(row.insertCell(0));
                cell.html(data.nombre);
                $(cell).css({""text-align"":""center""});

                //Add Precio cell.
                cell = $(row.insertCell(1));
                cell.html(""Q"" + data.precio)
                $(cell).css({""text-align"":""center""});

                //Add Cantidad cell
                cell = $(row.insertCell(2));
                cantidad = crearBotonCantidad();
                cell.html(cantidad) 
                $(cell).css({""width"":""10%""}); 
                cantidad.onchange = function(){
                   CalcularTotal(); ");
            WriteLiteral(@"
                }          
                
                //Add Eliminar cell
                cell = $(row.insertCell(3));
                eliminar = crearBotonEliminar();
                cell.html(eliminar);
                $(cell).css({""width"":""10%"",""text-align"":""center""});
                //Despues de mostrar-lo en el HTML
                eliminar.onclick = function(){
                Remove(this);
                CalcularTotal();
                };

            }
        });
    };   

    function Guardar() {
            //Loop through the Table rows and build a JSON array.
            var ventas = new Array();
            //Fecha y Hora
            var today = new Date();
            var n = today.getTime();
            var date = today.getFullYear()+'-'+(today.getMonth()+1)+'-'+today.getDate();
            var time = today.getHours() + "":"" + today.getMinutes() + "":"" + today.getSeconds();
            var dateTime = date+' '+time;

            $(""#tPedidos TBODY TR"").each(");
            WriteLiteral(@"function () {
                var row = $(this);
                var venta = {};
                venta.Producto = row.find(""TD"").eq(0).html();

                pre = row.find(""TD"").eq(1).html();
                venta.Precio = pre.split('Q')[1];

                venta.Cantidad = row.find(""TD"").eq(2).find('input').val();

                venta.Total = venta.Precio * venta.Cantidad;
                venta.Cliente = ""Brian"";
                venta.Fecha = dateTime;
                
                
                ventas.push(venta);
            }); 
        
            
            //tot = $(""#tot"").val();  
            //console.log(""Total: "" + tot);

            //ventas[3].push(tot); 
            //ventas.splice(3, 0, tot);
                             
 
            //Send the JSON array to Controller using AJAX.
            $.ajax({
                type: ""POST"",
                url: ""/Venta/InsertVentas"",
                data: JSON.stringify(ventas),
                contentType");
            WriteLiteral(@": ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function () {
                    alert(""Venta realizada!"");
                    location.reload();
                }
            }
            );
            console.log(ventas);
        };
    
    function CalcularTotal () {
        var subtotal = 0;
        var total = 0;
        $(""#tPedidos TBODY TR"").each(function () {
                var row = $(this);

                //Valor de Precio
                pre = row.find(""TD"").eq(1).html();
                const Precio = pre.split('Q')[1];
                //Valor de Cantidad
                CantidadPedido = row.find(""TD"").eq(2).find('input').val();

                //subtotal de PRECIO * CAntidad y Total de cada fila
                subtotal = Precio * CantidadPedido;
                total += Number(subtotal);
                
            });

            //Asignarle el valor al input
            $(""#tot"").val(total);
            ");
            WriteLiteral("//console.log(total);          \r\n    }\r\n\r\n    </script> \r\n");
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