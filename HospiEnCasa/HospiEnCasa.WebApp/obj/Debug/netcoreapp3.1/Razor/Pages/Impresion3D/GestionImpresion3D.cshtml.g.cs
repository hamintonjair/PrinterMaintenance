#pragma checksum "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d01e9615d7a81ba80268a06c036e4de33296e7b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.WebApp.Pages.Impresion3D.Pages_Impresion3D_GestionImpresion3D), @"mvc.1.0.razor-page", @"/Pages/Impresion3D/GestionImpresion3D.cshtml")]
namespace HospiEnCasa.WebApp.Pages.Impresion3D
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
#line 1 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\_ViewImports.cshtml"
using HospiEnCasa.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d01e9615d7a81ba80268a06c036e4de33296e7b5", @"/Pages/Impresion3D/GestionImpresion3D.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad804e27c17b5eb4fefb73f0a3f2cf1858fb0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Impresion3D_GestionImpresion3D : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditImpresion3d", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
  
    ViewData["Title"] = "Registro de Impresiones 3D";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
 if (TempData["mensaje"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">  \r\n        ");
#nullable restore
#line 13 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
   Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n    </div>\r\n");
#nullable restore
#line 18 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row m-4"" style=""padding-top: 10px;"">
    <div class=""col-sm-12"">
        <button style=""width: auto;"" type=""button"" class=""btn btn-primary"" data-toggle=""modal""
            data-target=""#FormModal"">Impresiones 3D
        </button>
    </div>
</div>


<div id=""container"" class=""app-title"">
    <div class=""row"">
        <div margin:0 class=""col-12 table-responsive"">
            <table id=""customerDatatable"" class=""table table-striped table-bordered nowrap"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Cliente</th>
                        <th>Tipo de impresión</th>
                        <th>Cantiddad</th>
                        <th>Precio</th>                       
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 45 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                     foreach (var _impresion in Model.listadoImpresion3D)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td scope=\"row\">");
#nullable restore
#line 48 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                                       Write(_impresion.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                           Write(_impresion.cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                           Write(_impresion.Tipo_impresion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                           Write(_impresion.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                           Write(_impresion.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>                                                      
                            <td>
                                <a title=""Ver"" class=""btn btn-info btnVer "" id=""btnVer""><i class=""fa-sharp fa-solid fa-eye""></i></a>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d01e9615d7a81ba80268a06c036e4de33296e7b59561", async() => {
                WriteLiteral("<i class=\"fa-sharp fa-solid fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                                                                  WriteLiteral(_impresion.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                  <a title=\"Eliminar\" class=\"btn btn-danger btnEliminar\" ><i\r\n                                    class=\"fa-regular fa-trash-can\"></i></a>\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 61 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n \r\n\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""FormModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
    aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header "" style=""background-color:#2668AC ;"">

                <h5 class=""modal-title""  style=""color:#FFFDEE ;"" id=""exampleModalLabel"">Nuevo Registro</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d01e9615d7a81ba80268a06c036e4de33296e7b513359", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 84 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresion3D\GestionImpresion3D.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <p class=""text-primary"">
                        Los campos con asterisco (<font color=""red"">*</font>) son obligatorios.
                    </p>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label>Cliente (<font color=""red"">*</font>)</label>
                            <input type=""text"" id=""cliente"" name=""cliente"" class=""form-control"" placeholder=""Cliente""");
                BeginWriteAttribute("required", "\r\n                                required=\"", 3824, "\"", 3868, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-6"">
                            <label>Tipo de impresón(<font color=""red"">*</font>)</label>
                            <input type=""text"" id=""impresion3d"" name=""impresion3d"" class=""form-control""
                                placeholder=""Tipo de impresón""");
                BeginWriteAttribute("required", " required=\"", 4219, "\"", 4230, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-6"">
                            <label>Cantidad (<font color=""red"">*</font>)</label>
                            <input type=""text"" id=""cantidad"" name=""cantidad"" class=""form-control"" placeholder=""Cantidad""");
                BeginWriteAttribute("required", "\r\n                                required=\"", 4599, "\"", 4643, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-6"">
                            <label>Precio(<font color=""red"">*</font>)</label>
                            <input type=""text"" id=""precio"" name=""precio"" class=""form-control"" placeholder=""Precio""");
                BeginWriteAttribute("required", "\r\n                                required=\"", 4931, "\"", 4975, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>                    
                    <div class=""modal-footer"">
                        <button style=""width: auto;"" type=""reset"" class=""btn btn-danger""
                            data-dismiss=""modal"">Cerrar</button>
                        <button style=""width: auto;"" type=""submit"" class=""btn btn-success"">Guardar</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modalEliminar"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">          
            <div class=""modal-header"" style=""background: #14465b;"">
                <h5 class=""modal-title"" style=""color:#FFFDEE ;"">Impresiones 3D</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Cerrar"">
                    <span aria-hidden=""true"">&times; </span>
                    </botón>
            </div>
            <div class=""modal-body"">
                <h3 class="" text-align: center;""> ¿Deseas eliminar la Impresión 3D de?</h3>
                <input type=""hidden"" name=""idImpresion3dEliminar"" id=""idImpresion3dEliminar"">
                <input  style=""border: 0;"" type=""text"" name=""idNombreEliminar"" id=""idNombreEliminar"" disabled>
            </div>
            <div class=""modal-footer"">
                <button type=""Submit"" class=""btn btn-primary"">Si</button>
                <button typ");
            WriteLiteral("e=\"reset\" class=\"btn btn-secondary\" data-dismiss=\"modal\">No</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""modalViewCliente"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header header-primary"" style=""background: #14465b;"">
                <h5 class=""modal-title"" style=""color:#FFFDEE ;"" id=""titleModal"">Datos de la impresión 3D</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" style=""background: #b4dcee;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d01e9615d7a81ba80268a06c036e4de33296e7b519918", async() => {
                WriteLiteral(@"
                    <p class=""text-primary"">
                    </p>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label>Cliente</label>
                        </div>
                        <div class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""VerCliente"" name=""VerCliente"" disabled>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Cantidad</label>                            
                        </div>
                        <div class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""verCantidad"" name=""verCantidad"" disabled>
                        </div>
                        <div class=""form-group col-md-4"">
                            <td>Precio</td>
                        </div>
                        <div class=""form-group co");
                WriteLiteral(@"l-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""verPrecio"" name=""verPrecio"" disabled>
                        </div>                                 
                        <hr>
                    </div>
                    <div class=""modal-footer"">
                        <button style=""width: auto;"" type=""reset"" class=""btn btn-danger""
                            data-dismiss=""modal"">Cerrar</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.WebApp.Pages.Impresion3D.GestionImpresion3D> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Impresion3D.GestionImpresion3D> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Impresion3D.GestionImpresion3D>)PageContext?.ViewData;
        public HospiEnCasa.WebApp.Pages.Impresion3D.GestionImpresion3D Model => ViewData.Model;
    }
}
#pragma warning restore 1591
