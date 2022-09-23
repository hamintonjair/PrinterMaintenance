using System.Globalization;
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
    public class GestionRevision : PageModel
    {
        private readonly ILogger<GestionRevision> _logger;

        public GestionRevision(ILogger<GestionRevision> logger)
        {
            _logger = logger;
        }

        private IRevisionesRepository _revision = new RevisionesRepository(new HospiEnCasa.Persistencia.AppContext());
        private IPersonaRepository _persona = new PersonaRepository(new HospiEnCasa.Persistencia.AppContext());
        private IRepuestosRepository _repuestos = new RepuestosRepository(new HospiEnCasa.Persistencia.AppContext());
        private IImpresorasRepository _Impresora = new ImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        private IEnvioRepository _envio = new EnvioRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Revision> listadoRevision {get; set; }
        public List<Repuesto> listadoRepuestos {get; set; }    
        public List<Persona> listadoPersona {get; set; }
        public List<Impresora> listadoImpresora {get; set; }

      
        public void OnGet()
        {
            listadoRevision  = new List<Revision>();
            listadoRevision  = _revision.ObtenerTodo();            
            listadoPersona   = new List<Persona>();
            listadoPersona   = _persona.ObtenerTodo();
            listadoRepuestos = new List<Repuesto>();
            listadoRepuestos = _repuestos.ObtenerTodo();
            listadoImpresora = new List<Impresora>();
            listadoImpresora = _Impresora.ObtenerTodo();      
        }  

         public void OnPost(){
 
             var mensaje = "";     

             var tecnico   = Request.Form["tecnico"];
             var impresora = Request.Form["impresora"];
             var _estado   = Request.Form["estado"];
             var revision  = Request.Form["revision"];                 
             var repuesto  = Request.Form["repuesto"];
             var precio    = Request.Form["precio"];
             var detalle   = Request.Form["detalle"];
             var fecha     = Request.Form["fecha"];
             var _actualizacion  = Request.Form["actualizacion"];
             var correo    = Request.Form["email"];
 
            //validamos que no exista para poder regiostrarlo
            var validadoT = _persona.Buscar(Int32.Parse(tecnico));
            var validadoI = _Impresora.Buscar(Int32.Parse(impresora));
            var validadoR = _repuestos.Buscar(Int32.Parse(repuesto));
            var validadoC = _persona.Buscar(Int32.Parse(correo));
            
                mensaje = "Error, debes llenar todos los campos "+_actualizacion;      
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(impresora) || String.IsNullOrEmpty(tecnico) || String.IsNullOrEmpty(fecha)
           || String.IsNullOrEmpty(_estado) || String.IsNullOrEmpty(revision) || String.IsNullOrEmpty(precio)
           || String.IsNullOrEmpty(_actualizacion) || String.IsNullOrEmpty(correo) )
           {
              mensaje = "Error, debes llenar todos los campos";               
          
           }else{  
            
                var N_Revision = new Revision{
                        valor = precio,
                        detalles = detalle,
                        fecha_revision = fecha,             
                        revision = (revision == "1" ? TipoRevision.Interno : TipoRevision.Externo),   
                        actualizacion = (_actualizacion == "1" ? Actualizacion_Software.SI : Actualizacion_Software.NO),               
                        estado =  (_estado == "1" ? Estado.Proceso : Estado.Finalizado)   
                       
                    };            
                    var N_Envio = new Envio{
                        correo = validadoC.email           
                    }; 
                
                if (validadoT.id > 0 || validadoI.id > 0 || validadoR.id > 0 || validadoC.id > 0  )
                {                  

                     _revision.AdicionarRevision(N_Revision);
                      _envio.AdicionarEnvio(N_Envio);
                       N_Envio.persona = validadoC; 
                      N_Revision.persona = validadoT;                   
                      N_Revision.impresora = validadoI;
                      N_Revision.repuesto = validadoR;

                     var result = _revision.Update(N_Revision);
                     var result2 = _envio.Update(N_Envio);                             

                    if(result > 0 && result2 > 0){

                        mensaje = "Revision asignado con exito";
                        OnGet();    
                
                    }else{
                        mensaje = "No se pudo asignarla revisión";
                         
                    }        
                }                                 
            }
            TempData["mensaje"] = mensaje;
       }
    }
}