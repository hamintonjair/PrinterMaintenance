#pragma checksum "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81f8daa774dbcd7ae087cb3ecfba1468d746109b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.WebApp.Pages.Impresoras.Pages_Impresoras_GestionImpresora), @"mvc.1.0.razor-page", @"/Pages/Impresoras/GestionImpresora.cshtml")]
namespace HospiEnCasa.WebApp.Pages.Impresoras
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81f8daa774dbcd7ae087cb3ecfba1468d746109b", @"/Pages/Impresoras/GestionImpresora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad804e27c17b5eb4fefb73f0a3f2cf1858fb0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Impresoras_GestionImpresora : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Impresoras/Tipo_Impresora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
  
    
    ViewData["Title"] = "Registro de Impresoras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 10 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
 if( TempData["mensaje"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n     ");
#nullable restore
#line 13 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n     </button>\r\n   </div>\r\n");
#nullable restore
#line 18 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row m-4\" style=\"padding-top: 10px;\">\r\n    <div class=\"col-sm-12\">\r\n        <button style=\"width: auto;\" type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#FormModal\">Impresora</button>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f8daa774dbcd7ae087cb3ecfba1468d746109b7281", async() => {
                WriteLiteral("ir a Tipo de impresoras");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
  
</div>

<div id=""container"" class=""app-title"">
    <div class=""row"">
        <div margin:0 class=""col-12 table-responsive"">
            <table id=""customerDatatable"" class=""table table-striped table-bordered nowrap"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Nombre</th>
                        <th>Marca</th>
                        <th>Tipo imp.</th>
                        <th>Mantenimiento</th>
                        <th>Placa</th>                                                                           
                        <th>Detalles</th>                        
                        <th>Acción</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                     foreach (var _impresoras in Model.listadoImpresora)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">");
#nullable restore
#line 48 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                                   Write(_impresoras.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                       Write(_impresoras.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>         \r\n                        <td>");
#nullable restore
#line 50 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                       Write(_impresoras.marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>       \r\n                        <td>");
#nullable restore
#line 51 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                       Write(_impresoras.tipoImpresora.nombre_impresora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>       \r\n                        <td>");
#nullable restore
#line 52 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                       Write(_impresoras.fecha_mantenimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>  \r\n                        <td>");
#nullable restore
#line 53 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                       Write(_impresoras.placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                  \r\n                        <td>");
#nullable restore
#line 54 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                       Write(_impresoras.detalles);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>                                                      
                         <td>
                          <a title=""Ver"" class=""btn btn-info btnVer "" id=""btnVer""><i
                                    class=""fa-sharp fa-solid fa-eye""></i></a>
                                <a title=""Editar"" class=""btn btn-success "" id=""btnEdit""><i
                                    class=""fa-sharp fa-solid fa-pen-to-square""></i></a>
                                <a title=""Eliminar"" class=""btn btn-danger btnEliminar"" ><i
                                    class=""fa-regular fa-trash-can""></i></a>

                        </td>
                    </tr>
");
#nullable restore
#line 65 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                }                   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
       </div>
   </div>
</div>

<div class=""modal fade"" id=""FormModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
    aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header "" style=""background-color:#2668AC ;"" >
                <h5 class=""modal-title"" id=""exampleModalLabel"">Nuevo Registro - Impresoras</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f8daa774dbcd7ae087cb3ecfba1468d746109b13887", async() => {
                WriteLiteral(@"
                    <p class=""text-primary"">
                        Los campos con asterisco (<font color=""red"">*</font>) son obligatorios.
                    </p>
                  <div class=""form-row"" style=""padding-top:14px;"">
                        <div class=""form-group col-md-4"">
                            <label>Nombre Impresora (<font color=""red"">*</font>)</label>
                            <input type=""text"" id=""impresora"" name=""impresora"" class=""form-control"" placeholder=""Nombre Impresora""");
                BeginWriteAttribute("required", " required=\"", 4190, "\"", 4201, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Marca (<font color=""red"">*</font>)</label>
                            <input type=""text""id=""marca"" name=""marca"" class=""form-control"" placeholder=""Marca""");
                BeginWriteAttribute("required", " required=\"", 4485, "\"", 4496, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Tipo Impresora (<font color=""red"">*</font>)</label>
                            <select  name=""tipoImpresora"" type=""text"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 4769, "\"", 4780, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f8daa774dbcd7ae087cb3ecfba1468d746109b15781", async() => {
                    WriteLiteral("Seleccionar..");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("                                \r\n");
#nullable restore
#line 100 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                                  foreach (var tipo in Model.listadoTipoImpresora)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f8daa774dbcd7ae087cb3ecfba1468d746109b17525", async() => {
#nullable restore
#line 102 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                                                        Write(tipo.nombre_impresora);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                                       WriteLiteral(tipo.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 103 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Impresoras\GestionImpresora.cshtml"
                                }                               

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                        </div>
                    </div>
                     <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label>Placa (<font color=""red"">*</font>)</label>
                            <input type=""text"" id=""placa"" name=""placa"" class=""form-control"" placeholder=""Placa""");
                BeginWriteAttribute("required", " required=\"", 5581, "\"", 5592, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Fecha de Ingreso (<font color=""red"">*</font>)</label>
                            <input type=""date"" class=""form-control"" id=""fechaMantenimiento"" name=""fechaMantenimiento""  min=""10"" max=""10"" placeholder=""01-02-2017""");
                BeginWriteAttribute("required", " required=\"", 5938, "\"", 5949, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Año modelo</label>
                            <input type=""date"" id=""fechaModelo"" name=""fechaModelo"" class=""form-control""  min=""10"" max=""10"" placeholder=""01-02-2017"">
                        </div>
                    </div>
                     <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label>Velocidad Impresión</label>
                            <input type=""text"" id=""velocidadImp"" name=""velocidadImp"" class=""form-control"" placeholder=""velocidad Impresión"">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Volumen Impresión </label>
                            <input type=""text"" id=""volumenImp"" name=""volumenImp"" class=""form-control"" placeholder=""volumen Impresión"">
                        </div>
                        <div clas");
                WriteLiteral(@"s=""form-group col-md-4"">
                            <label>País</label>
                            <input type=""text"" id=""pais"" name=""pais"" class=""form-control"" placeholder=""pas"">
                        </div>
                    </div>
                    <div class=""form-row"">
                        <div class=""form-group col-md-8"">
                            <label>Detalles (<font color=""red"">*</font>)</label>
                            <textarea  type=""text"" id=""detalles"" name=""detalles"" class=""form-control"" placeholder=""detalles""");
                BeginWriteAttribute("required", " required=\"", 7528, "\"", 7539, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Otras caracteristicas </label>
                            <textarea  type=""text"" id=""otrasCaract"" name=""otrasCaract"" class=""form-control"" placeholder=""Otras caracteristicas ""></textarea>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button style=""width: auto;""  type=""reset"" class=""btn btn-danger"" data-dismiss=""modal"">Cerrar</button>
                        <button style=""width: auto;""  type=""submit"" class=""btn btn-success"" >Guardar</button>
                   </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n           \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.WebApp.Pages.Impresoras.GestionImpresora> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Impresoras.GestionImpresora> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Impresoras.GestionImpresora>)PageContext?.ViewData;
        public HospiEnCasa.WebApp.Pages.Impresoras.GestionImpresora Model => ViewData.Model;
    }
}
#pragma warning restore 1591