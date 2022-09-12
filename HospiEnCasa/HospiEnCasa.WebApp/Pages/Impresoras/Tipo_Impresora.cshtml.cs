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
    public class Tipo_Impresora : PageModel
    {
        private readonly ILogger<Tipo_Impresora> _logger;

        public Tipo_Impresora(ILogger<Tipo_Impresora> logger)
        {
            _logger = logger;
        }

        private ITipoImpresorasRepository tipo_Impresora = new TipoImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<TipoImpresora> listadoTipoImpresora {get; set; }

        public void OnGet()
        {
            listadoTipoImpresora = new List<TipoImpresora>();
            listadoTipoImpresora = tipo_Impresora.ObtenerTodo();
        }

        public void OnPost()
        {
            var tipoImpresora = Request.Form["tipoImpresora"];

            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(tipoImpresora)){

                  Console.WriteLine("Error, debes llenar todos los campos");
          
           }else{
          
               var N_tipoImpresora = new TipoImpresora{
                 nombre_impresora = tipoImpresora
              };
          

             var validado = tipo_Impresora.FindByName(tipoImpresora);

            if(validado != null){ 
              var result = tipo_Impresora.AdicionarTipoImpresora(N_tipoImpresora);

                if(result > 0){
                    Console.WriteLine("Tipo impresora creado");                      
                    // Response.Redirect("page");  
                }else{
                Console.WriteLine("No se pudo ingresar el registro");
                }
            }else{
                     Console.WriteLine("Ya heciste un Tipo con esté Nombre");
                }
           
           }
           
        }
    }
}