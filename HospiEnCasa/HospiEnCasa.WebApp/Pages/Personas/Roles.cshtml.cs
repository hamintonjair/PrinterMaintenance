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
    public class Roles : PageModel
    {
        private readonly ILogger<Roles> _logger;

        public Roles(ILogger<Roles> logger)
        {
            _logger = logger;
        }

        private IPersonaRepository persona = new PersonaRepository(new HospiEnCasa.Persistencia.AppContext());
        private IRolesRepository rol = new RolesRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Persona> listadoPersona {get; set; }
        public List<Rol> listado_Rol {get; set; }


        public void OnGet()
        {
           listadoPersona = new List<Persona>();
           listadoPersona = persona.ObtenerTodo();
           listado_Rol = new List<Rol>();       
           listado_Rol = rol.ObtenerTodo();
        }

        public void OnPost()
        {
          
           
        }
    }
}