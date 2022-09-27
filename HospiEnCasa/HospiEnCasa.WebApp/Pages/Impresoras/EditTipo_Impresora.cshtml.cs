using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Impresoras
{
    public class EditTipo_Impresora : PageModel
    {
        private readonly ILogger<EditTipo_Impresora> _logger;

        public EditTipo_Impresora(ILogger<EditTipo_Impresora> logger)
        {
            _logger = logger;
        }
        public TipoImpresora Tipo_Impresora;

        private ITipoImpresorasRepository T_impresora = new TipoImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<TipoImpresora> listadoTipoImpresora {get; set; }
        
        public IActionResult OnGet(int Id)
        {
            listadoTipoImpresora = new List<TipoImpresora>();
            listadoTipoImpresora = T_impresora.ObtenerTodo();

             Tipo_Impresora = T_impresora.Buscar(Id);

            if(Tipo_Impresora == null){

                return RedirectToPage("./Tipo_Impresora");

            }else{
                return Page();
            }
        }       
 
        public IActionResult OnPost(){

            var mensaje = ""; 

            var id             = Request.Form["id"];
            var tipoImpresora        = Request.Form["tipoImpresora"];        

            var TipoImpresora = T_impresora.Buscar(Int32.Parse(id));

            if(TipoImpresora != null ){

                TipoImpresora.nombre_impresora = tipoImpresora;                

                var result = T_impresora.Update(TipoImpresora);

                if(result > 0){

                    mensaje ="Se actualizaron los datos a "+ TipoImpresora.nombre_impresora;
                    TempData["mensaje"] = mensaje;
                    return RedirectToPage("./Tipo_Impresora");
                 
                }else
                {                   
                   mensaje ="No fue posible la actualización "+ TipoImpresora.nombre_impresora;                    
                }
            }else
            {
                 mensaje ="Error, Se produjo un problemainterno, intente nuevamente ";
            }
            TempData["mensaje"] = mensaje;
            return Page();
        }
         public IActionResult OnPostDelete(string Id){

            //  var mensaje = "";   
            
            var _T_impresora = T_impresora.Buscar( Int32.Parse(Id) );

                if( _T_impresora != null){
                    
                    var result = T_impresora.Delete(_T_impresora);    

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