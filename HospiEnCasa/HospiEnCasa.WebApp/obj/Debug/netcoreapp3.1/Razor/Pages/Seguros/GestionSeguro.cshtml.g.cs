#pragma checksum "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff1b2d056360b6f010b5e01bff8043de2c18cfc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.WebApp.Pages.Seguros.Pages_Seguros_GestionSeguro), @"mvc.1.0.razor-page", @"/Pages/Seguros/GestionSeguro.cshtml")]
namespace HospiEnCasa.WebApp.Pages.Seguros
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff1b2d056360b6f010b5e01bff8043de2c18cfc2", @"/Pages/Seguros/GestionSeguro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad804e27c17b5eb4fefb73f0a3f2cf1858fb0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Seguros_GestionSeguro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditSeguros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
  
    ViewData["Title"] = "Registro de Seguros";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 9 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
 if( TempData["mensaje"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n     ");
#nullable restore
#line 12 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n     </button>\r\n   </div>\r\n");
#nullable restore
#line 17 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row m-4"" style=""padding-top: 10px;"">
    <div class=""col-sm-12"">
        <button style=""width: auto; type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#FormModal"">Registrar
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
                    <th>Tipo de seguro</th>
                    <th>Precio</th>
                    <th>Impresora</th>
                    <th>Fecha activación</th>
                    <th>Fecha vencimiento</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 43 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                  foreach (var seguro in Model.listadoSeguro)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">");
#nullable restore
#line 46 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                   Write(seguro.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                       Write(seguro.tipo_seguro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                       Write(seguro.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                       Write(seguro.impresora.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                       Write(seguro.fecha_activacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n                        <td>");
#nullable restore
#line 51 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                       Write(seguro.fecha_vencimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                             
                        <td>
                         <a title=""Ver"" class=""btn btn-info btnVer "" id=""btnVer""><i
                                    class=""fa-sharp fa-solid fa-eye""></i></a>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1b2d056360b6f010b5e01bff8043de2c18cfc210390", async() => {
                WriteLiteral("<i\r\n                                    class=\"fa-sharp fa-solid fa-pen-to-square\"></i>");
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
#line 56 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                                              WriteLiteral(seguro.id);

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
            WriteLiteral("\r\n                                <a title=\"Eliminar\" class=\"btn btn-danger btnEliminarSeguro\" ><i\r\n                                    class=\"fa-regular fa-trash-can\"></i></a>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 63 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                }           

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>
</div>
<div class=""modal fade"" id=""FormModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
    aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header "" style=""background-color:#2668AC ;"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Nuevo Registro</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1b2d056360b6f010b5e01bff8043de2c18cfc214106", async() => {
                WriteLiteral(@"
                    <p class=""text-primary"">
                        Los campos con asterisco (<font color=""red"">*</font>) son obligatorios.
                    </p>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label>Tipo de seguro (<font color=""red"">*</font>)</label>
                            <input name=""tipoSeguro"" id=""tipoSeguro"" type=""text"" class=""form-control"" placeholder=""Tipo de seguro""");
                BeginWriteAttribute("value", "  value=\"", 3731, "\"", 3740, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                              minlength=\"4\" maxlength=\"20\" placeholder=\"Tipo seguro\"");
                BeginWriteAttribute("required", " required=\"", 3827, "\"", 3838, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                         <div class=""form-group col-md-4"">
                            <label>Precio(<font color=""red"">*</font>)</label>
                            <input type=""number"" class=""form-control"" id=""precio"" name=""precio""");
                BeginWriteAttribute("value", " value=\"", 4108, "\"", 4116, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                minlength=\"4\" maxlength=\"10\" placeholder=\"Precio seguro\"");
                BeginWriteAttribute("required", " required=\"", 4207, "\"", 4218, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Fecha de activación(<font color=""red"">*</font>)</label>
                            <input type=""date"" class=""form-control""   id=""fechaActivacion"" name=""fechaActivacion""");
                BeginWriteAttribute("value", " value=\"", 4518, "\"", 4526, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                               min=\"10\" max=\"10\" placeholder=\"01-02-2017\"");
                BeginWriteAttribute("required", " required=\"", 4602, "\"", 4613, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Fecha de vencimiento(<font color=""red"">*</font>)</label>
                            <input type=""date"" class=""form-control"" id=""fechaVencimiento"" name=""fechaVencimiento""");
                BeginWriteAttribute("value", " value=\"", 4914, "\"", 4922, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                min=\"10\" max=\"10\" placeholder=\"01-02-2017\"");
                BeginWriteAttribute("required", " required=\"", 4999, "\"", 5010, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Impresora (<font color=""red"">*</font>)</label>
                            <select name=""impresora"" type=""imprasora"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 5278, "\"", 5289, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1b2d056360b6f010b5e01bff8043de2c18cfc217872", async() => {
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
                WriteLiteral("\r\n");
#nullable restore
#line 109 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                  foreach (var impresora in Model.listadoImpresora)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1b2d056360b6f010b5e01bff8043de2c18cfc219579", async() => {
#nullable restore
#line 111 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                                             Write(impresora.nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                       WriteLiteral(impresora.id);

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
#line 112 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </select>
                        </div>
                       
                    </div>
                    <div class=""modal-footer"">
                        <button style=""width: auto;""  type=""reset"" class=""btn btn-danger"" data-dismiss=""modal"">Cerrar</button>
                        <button style=""width: auto;""  type=""submit"" class=""btn btn-success"">Guardar</button>
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
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modalEliminarSeguro"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""background: #14465b;"">
                <h5 class=""modal-title"" style=""color:#FFFDEE ;"">Revisión de impresora</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Cerrar"">
                    <span aria-hidden=""true"">&times; </span>
                    </botón>
            </div>
            <div class=""modal-body"">
                <h3 class="" text-align: center;"">¿Deseas eliminar el registro de la revision de?</h3>
                <input type=""hidden"" name=""idSegurosEliminar"" id=""idSegurosEliminar"">
                <input  style=""border: 0;"" type=""text"" name=""idSeguroImpresoraEliminar"" id=""idSeguroImpresoraEliminar"" disabled>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""btnEliminarSe");
            WriteLiteral("guros\">Si</button>\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">No</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div class=""modal fade"" id=""modalViewSeguro"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff1b2d056360b6f010b5e01bff8043de2c18cfc225592", async() => {
                WriteLiteral(@"
                    <p class=""text-primary"">
                    </p>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label>Tipo de seguro</label>
                        </div>
                        <div class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""VertipoSeguro"" name=""VertipoSeguro"" disabled>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Precio</label>                            
                        </div>
                        <div class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""verprecio"" name=""verprecio"" disabled>
                        </div>
                        <div class=""form-group col-md-4"">
                            <td>Fecha de activación</td>
                        </div>
                        <div ");
                WriteLiteral(@"class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""verfechaActivacion"" name=""verfechaActivacion"" disabled>
                        </div>  
                        <div class=""form-group col-md-4"">
                            <td>Fecha de vencimiento</td>
                        </div>
                        <div class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""verfechaVencimiento"" name=""verfechaVencimiento"" disabled>
                        </div>  
                        <div class=""form-group col-md-4"">
                            <td>Impresora</td>
                        </div>
                        <div class=""form-group col-md-8"">
                            <input style=""border: 0;"" type=""text"" id=""verimpresora"" name=""verimpresora"" disabled>
                        </div>                               
                        <hr>
                    </div>
                    <div cl");
                WriteLiteral("ass=\"modal-footer\">\r\n                        <button style=\"width: auto;\" type=\"reset\" class=\"btn btn-danger\"\r\n                            data-dismiss=\"modal\">Cerrar</button>\r\n                    </div>\r\n                ");
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
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.WebApp.Pages.Seguros.GestionSeguro> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Seguros.GestionSeguro> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Seguros.GestionSeguro>)PageContext?.ViewData;
        public HospiEnCasa.WebApp.Pages.Seguros.GestionSeguro Model => ViewData.Model;
    }
}
#pragma warning restore 1591
