#pragma checksum "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1442efa0cbaf37889fa9efe8d5b25097b7ea9842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.WebApp.Pages.Repuestos.Pages_Repuestos_GestionRepuesto), @"mvc.1.0.razor-page", @"/Pages/Repuestos/GestionRepuesto.cshtml")]
namespace HospiEnCasa.WebApp.Pages.Repuestos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1442efa0cbaf37889fa9efe8d5b25097b7ea9842", @"/Pages/Repuestos/GestionRepuesto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad804e27c17b5eb4fefb73f0a3f2cf1858fb0d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Repuestos_GestionRepuesto : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
  
    ViewData["Title"] = "Registro de Repuestos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 9 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
 if( TempData["mensaje"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n     ");
#nullable restore
#line 12 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n     </button>\r\n   </div>\r\n");
#nullable restore
#line 17 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
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
                        <th>Tipo de repuesto</th>
                        <th>Cantidad</th> 
                        <th>Precio</th>                         
                        <th style=""width: 40%;"">Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 40 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
                 foreach (var repuestos in Model.listadoRepuestos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">");
#nullable restore
#line 43 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
                                   Write(repuestos.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
                       Write(repuestos.n_Repuesto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
                       Write(repuestos.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
                       Write(repuestos.valor);

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
#line 58 "E:\Mision_tic\ciclo_3\Proyecto\PrinterMaintenance\HospiEnCasa\HospiEnCasa.WebApp\Pages\Repuestos\GestionRepuesto.cshtml"
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
    <div class=""modal-dialog modal-md"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header "" style=""background-color:#2668AC ;"" >
                <h5 class=""modal-title"" id=""exampleModalLabel"">Nuevo Registro - Repuestos</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1442efa0cbaf37889fa9efe8d5b25097b7ea98429361", async() => {
                WriteLiteral(@"
                    <p class=""text-primary"">
                        Los campos con asterisco (<font color=""red"">*</font>) son obligatorios.
                    </p>
                    <div class=""form-row"" style=""padding-top:14px;"">

                        <div class=""form-row"">
                            <div class=""form-group col-md-4"">
                                <label>Tipo de Repuesto (<font color=""red"">*</font>)</label>
                                <input type=""text"" class=""form-control"" id=""repuesto"" name=""repuesto"" placeholder=""Tipo de Repuesto"" minlength=""4"" maxlength=""40""");
                BeginWriteAttribute("required", " required=\"", 3749, "\"", 3760, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""form-group col-md-4"">
                                <label>Precio(<font color=""red"">*</font>)</label>
                                <input type=""number"" class=""form-control"" id=""precio"" name=""precio"" placeholder=""Precio"" minlength=""4"" maxlength=""10""");
                BeginWriteAttribute("required", " required=\"", 4095, "\"", 4106, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""form-group col-md-4"">
                                <label>Cantidad(<font color=""red"">*</font>)</label>
                                <input type=""number"" class=""form-control"" id=""cantidad"" name=""cantidad"" placeholder=""Cantidad"" minlength=""1"" maxlength=""200""");
                BeginWriteAttribute("required", " required=\"", 4450, "\"", 4461, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.WebApp.Pages.Repuestos.GestionRepuesto> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Repuestos.GestionRepuesto> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.WebApp.Pages.Repuestos.GestionRepuesto>)PageContext?.ViewData;
        public HospiEnCasa.WebApp.Pages.Repuestos.GestionRepuesto Model => ViewData.Model;
    }
}
#pragma warning restore 1591
