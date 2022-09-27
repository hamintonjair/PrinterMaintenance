
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Impresion3D
{
    public class GestionImpresion3D : PageModel
    {
        private readonly ILogger<GestionImpresion3D> _logger;

        public GestionImpresion3D(ILogger<GestionImpresion3D> logger)
        {
            _logger = logger;
        }
    
        private IImpresion3DRepository impresion = new Impresion3DRepository(new HospiEnCasa.Persistencia.AppContext());
        private IImpresorasRepository _impresora = new ImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Impresiones3D> listadoImpresion3D {get; set; }
        public List<Impresora> listadoImpresora {get; set; }
        
        public IActionResult OnGet()
        {
             
            listadoImpresion3D = new List<Impresiones3D>();
            listadoImpresion3D = impresion.ObtenerTodo();
            listadoImpresora = new List<Impresora>();
            listadoImpresora = _impresora.ObtenerTodo(); 
            return Page();
        }

        public IActionResult OnPost()
        {
            var mensaje = ""; 

            var cliente        = Request.Form["cliente"];
            var Tipo_impresion = Request.Form["impresion3d"];
            var cantidad       = Request.Form["cantidad"];
            var precio         = Request.Form["precio"];          
            

            //validamos que no exista para poder regiostrarlo
            // var validado = _impresora.Buscar(Int32.Parse(impresora));
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(cliente) || String.IsNullOrEmpty(Tipo_impresion) || String.IsNullOrEmpty(cantidad) || String.IsNullOrEmpty(precio)){

                  mensaje = "Error, debes llenar todos los campos";
                
           }else{
          
                 var N_Imppresion3D = new Impresiones3D{
                        cliente = cliente,
                        Tipo_impresion = Tipo_impresion,
                        cantidad = cantidad,
                        precio = precio
                    };
                     var result =  impresion.AdicionarImpresiones3D(N_Imppresion3D);

                    // N_Imppresion3D.impresora = validado;
                    // var result = impresion.Update(N_Imppresion3D);

                    if(result > 0){
                        mensaje = "Impresión agregado con exito";  
                        TempData["mensaje"] = mensaje;
                        OnGet();
                        return RedirectToPage("/Impresion3D/GestionImpresion3D");                     
                                   
                    }else{
                       mensaje = "No se pudo ingresar el registro";
                                    
                    }
              
            }   
            OnGet();
            TempData["mensaje"] = mensaje;       
            return Page();
        }
         public IActionResult OnPostDelete(int id){

                 var mensaje = "";              
               
                var _impresion = impresion.Buscar(id);

                if( _impresion != null){
                    
                    var result = impresion.Delete(_impresion);    

                  if( result > 0){
                      mensaje ="Registro eliminado correctamente ";      
                      return RedirectToPage("./Gestionimpresion3D");
                    }else{
                       mensaje ="No fue posible la eliminación ";      
                      return RedirectToPage("./Gestionimpresion3D");
                    }
                }else{
                 mensaje ="Error en el sistema ";
                 TempData["mensaje"] = mensaje;
                 return Page();
                        
               }
           
        }

     
    }
}