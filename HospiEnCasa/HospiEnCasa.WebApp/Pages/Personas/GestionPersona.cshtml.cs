using System.Runtime.InteropServices.WindowsRuntime;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.IO.Pipes;
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
        private IPersonaRepository persona = new PersonaRepository(new HospiEnCasa.Persistencia.AppContext());
        private IRolesRepository role = new RolesRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<NivelEstudio> listadoNivelEstudio {get; set; }
        public List<Persona> listadoPersona {get; set; }
        public List<Rol> listadoRol {get; set; }
        
        public void OnGet()
        {
            listadoNivelEstudio = new List<NivelEstudio>();
            listadoNivelEstudio = studio.ObtenerTodo();
            listadoPersona = new List<Persona>();
            listadoPersona = persona.ObtenerTodo();
            listadoRol = new List<Rol>();
            // listadoRol = role.ObtenerTodo();
        }
        public void OnPost(){
 
             var nombre      = Request.Form["nombre"];
             var apellido    = Request.Form["apellido"];
             var identificacion  = Request.Form["identificacion"];
             var telefono    = Request.Form["telefono"];                 
             var fecha       = Request.Form["fecha"];
             var direccion   = Request.Form["direccion"];
             var email       = Request.Form["email"];
             var _socio       = Request.Form["socio"];
             var nivelEstudio = Request.Form["profesion"];

            var validado = studio.FindByName(nivelEstudio);
            var id = 0;
           
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(identificacion)){

                  Console.WriteLine("Error, debes llenar todos los campos");
          
           }else{

                foreach (var Estudio in validado)
                {
                   id =  Estudio.id ;
                }
            
                var N_persona = new Persona{
                    nombre = nombre,
                    apellidos = apellido,
                    cedula = identificacion,             
                    telefono = telefono,
              //      fecha_nacimiento = fecha,
                    direccion = direccion,
                    email = email,
                    // nivelEstudio =  id,
                    socio =  (_socio == 1 ? Socio.Si : Socio.No),
                
                   };
                //  var N_rol = new Rol{
                //     tipo_Rol = rol,              
                    
                // };
                var result = persona.AdicionarPersona(N_persona);
                // var result = persona.AdicionarPersona(N_rol);

                if(result > 0){
                    Console.WriteLine("Nivel de estudio creado, " + id);
            
                }else{
                Console.WriteLine("No se pudo ingresar el registro");
                }
           }
        }


    }
}