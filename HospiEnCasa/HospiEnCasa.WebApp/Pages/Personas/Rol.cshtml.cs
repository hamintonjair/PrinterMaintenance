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
    public class Rol : PageModel
    {
        private readonly ILogger<Rol> _logger;

        public Rol(ILogger<Rol> logger)
        {
            _logger = logger;
        }
        // private INivelEstudiosRepository Persona = new NivelEstudiosRepository(new HospiEnCasa.Persistencia.AppContext());

        public void OnGet()
        {
        }
    }
}