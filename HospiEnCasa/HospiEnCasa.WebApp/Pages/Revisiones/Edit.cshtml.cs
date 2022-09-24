using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospiEnCasa.WebApp.Pages.Revisiones
{
    public class Edit : PageModel
    {
        private readonly ILogger<Edit> _logger;

        public Edit(ILogger<Edit> logger)
        {
            _logger = logger;
        }

        // public Impresiones3D impresiones;

        // private IRevisionesRepository _revision = new RevisionesRepository(new HospiEnCasa.Persistencia.AppContext());
        // public List<Revision> listadoRevision {get; set; }
        
        // public IActionResult OnGet(int Id)
        // {
        //     listadoImpresion3D = new List<Impresiones3D>();
        //     listadoImpresion3D = impresion.ObtenerTodo();

        //      impresiones = impresion.Buscar(Id);

        //     if(impresiones == null){

        //         return RedirectToPage("./Gestionimpresion3D");

        //     }else{
        //         return Page();
        //     }
        // }        

        // public void OnPost(){

        //     var mensaje = ""; 

        //     var id             = Request.Form["id"];
        //     var cliente        = Request.Form["cliente"];
        //     var Tipo_impresion = Request.Form["impresion3d"];
        //     var cantidad       = Request.Form["cantidad"];
        //     var precio         = Request.Form["precio"];

        //     var impresion3d = impresion.Buscar(Int32.Parse(id));

        //     if(impresion3d != null ){

        //         impresion3d.cliente = cliente;
        //         impresion3d.Tipo_impresion = Tipo_impresion;
        //         impresion3d.cantidad = cantidad;
        //         impresion3d.precio = precio;

        //         var result = impresion.Update(impresion3d);

        //         if(result > 0){

        //             mensaje ="Se actualizaron los datos a "+ cliente;
        //         }else
        //         {                   
        //            mensaje ="No fue posible la actualización"+ cliente;                    
        //         }
        //     }else
        //     {
        //          mensaje ="Error, Se produjo un problemainterno, intente nuevamente ";
        //     }
        //     TempData["mensaje"] = mensaje;
        //     // return RedirectToPage("./Gestionimpresion3D");
        // }       

        // public IActionResult OnPostUpdateJson([FromBody]Impresiones3D impresiones3d){

        //     var mensaje = "";          
                
        //     var _impresion3d = impresion.Buscar(impresiones3d.id);

        //     if(_impresion3d != null ){

        //         _impresion3d.cliente = impresiones3d.cliente;
        //         _impresion3d.Tipo_impresion = impresiones3d.Tipo_impresion;
        //         _impresion3d.cantidad = impresiones3d.cantidad;
        //         _impresion3d.precio = impresiones3d.precio;
        //         _impresion3d.impresora = impresiones3d.impresora;

        //         var result = impresion.Update(_impresion3d);

        //         if(result > 0){

        //             mensaje ="Se actualizaron los datos a "+ _impresion3d.cliente;
        //         }else
        //         {                   
        //            mensaje ="No fue posible la actualización "+ _impresion3d.cliente;                    
        //         }
        //     }else
        //     {
        //          mensaje ="Error, Se produjo un problemainterno, intente nuevamente ";
        //     }
            
        //     TempData["mensaje"] = mensaje;
        //     return new JsonResult( _impresion3d.id);
            
        // }

        // public IActionResult OnPostDelete(string Id){

        //     //  var mensaje = "";   
            
        //         var _impresion = impresion.Buscar( Int32.Parse(Id) );

        //         if( impresion != null){
                    
        //             var result = impresion.Delete(_impresion);    

        //           if( result > 0){
        //                 return Content("Se eliminó la persona con exito");
        //             }else{
        //                 return Content("No se logro eliminar la persona");
        //             }
        //         }else{

        //           return Content("No existe la persona a eliminar");
                    
                  
        //        }
           
        // }
    }
}