using System.Net;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Personas
{
    public class NivelStudio : PageModel
    {
        private readonly ILogger<NivelStudio> _logger;

        public NivelStudio(ILogger<NivelStudio> logger)
        {
            _logger = logger;
        }
        private INivelEstudiosRepository studio = new NivelEstudiosRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<NivelEstudio> listadoNivelEstudio {get; set; }
        
        public void OnGet()
        {
            listadoNivelEstudio = new List<NivelEstudio>();
            listadoNivelEstudio = studio.ObtenerTodo();
        }

        public void OnPost()
        {
            var nivelStudio = Request.Form["nivelEstudio"];

            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(nivelStudio)){

                  Console.WriteLine("Error, debes llenar todos los campos");
          
           }else{
          
               var N_estudio = new NivelEstudio{
                estudio = nivelStudio
            };
            var result = studio.AdicionarNivelEstudio(N_estudio);

            if(result > 0){
                Console.WriteLine("Nivel de estudio creado");                      
                // Response.Redirect("page");  
            }else{
               Console.WriteLine("No se pudo ingresar el registro");
            }
           }
           
        }
    }
}