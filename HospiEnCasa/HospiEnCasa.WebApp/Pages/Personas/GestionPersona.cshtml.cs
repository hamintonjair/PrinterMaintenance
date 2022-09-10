using System.Data;
using System.Data.Common;
using System.Net.Cache;
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
    public class GestionPersona : PageModel
    {
        private readonly ILogger<GestionPersona> _logger;

        public GestionPersona(ILogger<GestionPersona> logger)
        {
            _logger = logger;
        }

         private INivelEstudiosRepository studio = new NivelEstudiosRepository(new HospiEnCasa.Persistencia.AppContext());
        public void OnGet()
        {
        }
        public void OnPost(){

            var nivelStudio = Request.Form["nivelEstudio"];

            var N_estudio = new NivelEstudio{
                estudio = nivelStudio
            };
            var result = studio.AdicionarNivelEstudio(N_estudio);

            if(result > 0){
                Console.WriteLine("Nivel de estudio creado");
            }else{
               Console.WriteLine("No se pudo ingresar el registro");
            }
        }


    }
}