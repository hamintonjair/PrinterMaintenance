using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Revisiones
{
    public class EditRevision : PageModel
    {
        private readonly ILogger<EditRevision> _logger;

        public EditRevision(ILogger<EditRevision> logger)
        {
            _logger = logger;
        }
        public Revision revision;

        private IRevisionesRepository _revision = new RevisionesRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Revision> listadoRevision {get; set; }
        
        public IActionResult OnGet(int Id)
        {
           listadoRevision  = new List<Revision>();
           listadoRevision  = _revision.ObtenerTodo();  

            revision = _revision.Buscar(Id);

            if(revision == null){

                return RedirectToPage("./GestionRevision");

            }else{
                return Page();
            }    
      
         }        

        public IActionResult OnPost(){

            var mensaje = ""; 

             var id        = Request.Form["id"];
             var _estado   = Request.Form["estado"];                  
             var precio    = Request.Form["precio"];
             var detalle   = Request.Form["detalle"];
             var fecha     = Request.Form["fecha"];    
             var _Revision     = Request.Form["revision"]; 
             var _actualizacion     = Request.Form["actualizacion"];   
      
            var revisiones = _revision.Buscar(Int32.Parse(id));

            if(revisiones != null ){

                revisiones.valor = precio;
                revisiones.detalles = detalle;
                revisiones.fecha_revision = fecha;  
                if(_Revision == "Seleccionar" || _estado  == "Seleccionar" || _actualizacion == "Seleccionar" ){

                }else{
                     revisiones.revision = (_Revision == "1" ? TipoRevision.Interno : TipoRevision.Externo);                              
                     revisiones.estado = (_estado == "1" ? Estado.Proceso : Estado.Finalizado) ;
                    revisiones.actualizacion = (_actualizacion == "1" ? Actualizacion_Software.SI : Actualizacion_Software.NO) ;
                }              
               
                var result = _revision.Update(revisiones);

                if(result > 0){

                    mensaje ="Se actualizaron los datos";
                    TempData["mensaje"] = mensaje;
                    return RedirectToPage("./GestionRevision");
                 
                }else
                {                   
                   mensaje ="No fue posible la actualización ";                    
                }
            }else
            {
                 mensaje ="Error, Se produjo un problemainterno, intente nuevamente ";
            }
            TempData["mensaje"] = mensaje;
            return Page();
        }       

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

        public IActionResult OnPostDelete(string Id){

            //  var mensaje = "";   
            
                var revision = _revision.Buscar( Int32.Parse(Id) );

                if( revision != null){
                    
                    var result = _revision.Delete(revision);    

                  if( result > 0){
                        return Content("");
                    }else{
                        return Content("");
                    }
                }else{

                  return Content("");
                                   
               }
        }
    }
}