#pragma checksum "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd8d080f6b200d46ae4bd3df69647324c9d75d6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd8d080f6b200d46ae4bd3df69647324c9d75d6", @"/Pages/Seguros/GestionSeguro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad804e27c17b5eb4fefb73f0a3f2cf1858fb0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Seguros_GestionSeguro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: auto; class="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
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
            WriteLiteral("</td>\r\n                                             \r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd8d080f6b200d46ae4bd3df69647324c9d75d611830", async() => {
                WriteLiteral("<i class=\"fa-sharp fa-solid fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd8d080f6b200d46ae4bd3df69647324c9d75d613979", async() => {
                WriteLiteral("<i class=\"fa-regular fa-trash-can\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("btn", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("btn-danger\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd8d080f6b200d46ae4bd3df69647324c9d75d617777", async() => {
                WriteLiteral(@"
                    <p class=""text-primary"">
                        Los campos con asterisco (<font color=""red"">*</font>) son obligatorios.
                    </p>
                    <div class=""form-row"">
                        <div class=""form-group col-md-4"">
                            <label>Tipo de seguro (<font color=""red"">*</font>)</label>
                            <input name=""tipoSeguro"" id=""tipoSeguro"" type=""text"" class=""form-control"" placeholder=""Tipo de seguro""");
                BeginWriteAttribute("value", "  value=\"", 3634, "\"", 3643, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                              minlength=\"4\" maxlength=\"20\" placeholder=\"Tipo seguro\"");
                BeginWriteAttribute("required", " required=\"", 3730, "\"", 3741, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                         <div class=""form-group col-md-4"">
                            <label>Precio(<font color=""red"">*</font>)</label>
                            <input type=""number"" class=""form-control"" id=""precio"" name=""precio""");
                BeginWriteAttribute("value", " value=\"", 4011, "\"", 4019, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                minlength=\"4\" maxlength=\"10\" placeholder=\"Precio seguro\"");
                BeginWriteAttribute("required", " required=\"", 4110, "\"", 4121, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Fecha de activación(<font color=""red"">*</font>)</label>
                            <input type=""date"" class=""form-control""   id=""fechaActivacion"" name=""fechaActivacion""");
                BeginWriteAttribute("value", " value=\"", 4421, "\"", 4429, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                               min=\"10\" max=\"10\" placeholder=\"01-02-2017\"");
                BeginWriteAttribute("required", " required=\"", 4505, "\"", 4516, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Fecha de vencimiento(<font color=""red"">*</font>)</label>
                            <input type=""date"" class=""form-control"" id=""fechaVencimiento"" name=""fechaVencimiento""");
                BeginWriteAttribute("value", " value=\"", 4817, "\"", 4825, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                                min=\"10\" max=\"10\" placeholder=\"01-02-2017\"");
                BeginWriteAttribute("required", " required=\"", 4902, "\"", 4913, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-4"">
                            <label>Impresora (<font color=""red"">*</font>)</label>
                            <select name=""impresora"" type=""imprasora"" class=""form-control""");
                BeginWriteAttribute("required", " required=\"", 5181, "\"", 5192, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd8d080f6b200d46ae4bd3df69647324c9d75d621543", async() => {
                    WriteLiteral("Seleccionar..");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 106 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
                                  foreach (var impresora in Model.listadoImpresora)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fd8d080f6b200d46ae4bd3df69647324c9d75d623250", async() => {
#nullable restore
#line 108 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
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
#line 108 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
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
#line 109 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Seguros\GestionSeguro.cshtml"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
