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
    public class EditImpresoras : PageModel
    {
        private readonly ILogger<EditImpresoras> _logger;

        public EditImpresoras(ILogger<EditImpresoras> logger)
        {
            _logger = logger;
        }

         public Impresora impresoras;

        private IImpresorasRepository _impresora = new ImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Impresora> listadoImpresora {get; set; }
        
        public IActionResult OnGet(int Id)
        {
           
            listadoImpresora = new List<Impresora>();
            listadoImpresora = _impresora.ObtenerTodo();         
          
            impresoras = _impresora.Buscar(Id);

            if(impresoras == null){

                return RedirectToPage("./GestionImpresora");

            }else{
                return Page();
            }    
      
         }        

        public IActionResult OnPost(){

            var mensaje = ""; 

             var id                  = Request.Form["id"];
             var impresora           = Request.Form["impresora"];
             var marca               = Request.Form["marca"];            
             var placa               = Request.Form["placa"];                 
             var fechaMantenimiento  = Request.Form["fechaMantenimiento"];
             var fechaModelo         = Request.Form["fechaModelo"];
             var velocidadImp        = Request.Form["velocidadImp"];
             var volumenImp          = Request.Form["volumenImp"];
             var pais                = Request.Form["pais"];
             var detalles            = Request.Form["detalles"];
      
      
            var _Impresora = _impresora.Buscar(Int32.Parse(id));

            if(_Impresora != null ){

                _Impresora.nombre = impresora;
                _Impresora.marca = marca;
                _Impresora.placa = placa;  
                _Impresora.fecha_mantenimiento = fechaMantenimiento;
                _Impresora.ano_modelo = fechaModelo;  
                _Impresora.velocidad_imp = velocidadImp;
                _Impresora.volumen_imp = volumenImp;
                _Impresora.pais_origen = pais;  
                _Impresora.detalles = detalles;
         
                var result = _impresora.Update(_Impresora);

                if(result > 0){

                    mensaje ="Se actualizaron los datos";
                    TempData["mensaje"] = mensaje;
                    return RedirectToPage("./GestionImpresora");
                 
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

        public IActionResult OnPostDelete(string Id){

            //  var mensaje = "";   
               
                var impresora = _impresora.Buscar( Int32.Parse(Id) );
    
                if( impresora != null){
                    
                    var result = _impresora.Delete(impresora);    

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