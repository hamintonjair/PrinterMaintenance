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
    public class GestionImpresora : PageModel
    {
        private readonly ILogger<GestionImpresora> _logger;

        public GestionImpresora(ILogger<GestionImpresora> logger)
        {
            _logger = logger;
        }

        private IImpresorasRepository _impresora = new ImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        private ITipoImpresorasRepository tipo_Impresora = new TipoImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<TipoImpresora> listadoTipoImpresora {get; set; }
        public List<Impresora> listadoImpresora {get; set; }

        public void OnGet()
        {
            listadoImpresora = new List<Impresora>();
            listadoImpresora = _impresora.ObtenerTodo();
            listadoTipoImpresora = new List<TipoImpresora>();
            listadoTipoImpresora = tipo_Impresora.ObtenerTodo();
        }

        public void OnPost(){
 
             var impresora           = Request.Form["impresora"];
             var marca               = Request.Form["marca"];
             var tipoImpresora       = Request.Form["tipoImpresora"];
             var placa               = Request.Form["placa"];                 
             var fechaMantenimiento  = Request.Form["fechaMantenimiento"];
             var fechaModelo         = Request.Form["fechaModelo"];
             var velocidadImp        = Request.Form["velocidadImp"];
             var volumenImp          = Request.Form["volumenImp"];
             var pais                = Request.Form["pais"];
             var detalles            = Request.Form["detalles"];
             var otrasCaract         = Request.Form["otrasCaract"];          
          
            
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(impresora) || String.IsNullOrEmpty(marca) || String.IsNullOrEmpty(tipoImpresora)
           || String.IsNullOrEmpty(placa) || String.IsNullOrEmpty(fechaMantenimiento) || String.IsNullOrEmpty(fechaModelo)
           || String.IsNullOrEmpty(velocidadImp) || String.IsNullOrEmpty(volumenImp) ||String.IsNullOrEmpty(pais)
           || String.IsNullOrEmpty(detalles)){

                 Console.WriteLine("Error, debes llenar todos los campos "+impresora+ " , "+marca+ ", " +tipoImpresora);
                 Console.WriteLine("Error, debes llenar todos los campos "+placa+ " , "+fechaMantenimiento+ ", " +fechaModelo);
                 Console.WriteLine("Error, debes llenar todos los campos "+velocidadImp+ " , "+volumenImp+ ", " +pais+ ", " +detalles);
                 OnGet();    
          
           }else{               
                                
                  var N_impresora = new Impresora{
                        nombre = impresora,
                        marca = marca,
                        placa = placa,             
                        ano_modelo = fechaModelo,
                        velocidad_imp = velocidadImp,
                        volumen_imp = volumenImp,
                        pais_origen = pais, 
                        fecha_mantenimiento = fechaMantenimiento,   
                        detalles = detalles,        
                        otros_caracteristicas = detalles,
                        // tipoImpresora =  tipoImpresora,                   
                    
                    };

                    var result = _impresora.AdicionarImpresora(N_impresora);

                    if(result > 0){
                        Console.WriteLine("Impresora agregada con exito");
                        OnGet();    
                
                    }else{
                        Console.WriteLine("No se pudo ingresar el registro");
               
                    }              
            }
       }
    }
}