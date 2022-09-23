
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
        
        public void OnGet()
        {
             
            listadoImpresion3D = new List<Impresiones3D>();
            listadoImpresion3D = impresion.ObtenerTodo();
            listadoImpresora = new List<Impresora>();
            listadoImpresora = _impresora.ObtenerTodo(); 
        }

        public void OnPost()
        {
            var mensaje = ""; 

            var cliente        = Request.Form["cliente"];
            var Tipo_impresion = Request.Form["impresion3d"];
            var cantidad       = Request.Form["cantidad"];
            var precio         = Request.Form["precio"];
            var impresora      = Request.Form["impresora"];
            

            //validamos que no exista para poder regiostrarlo
            var validado = _impresora.Buscar(Int32.Parse(impresora));
            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(cliente) || String.IsNullOrEmpty(Tipo_impresion) || String.IsNullOrEmpty(cantidad) || String.IsNullOrEmpty(precio)){

                  mensaje = "Error, debes llenar todos los campos";
                  OnGet();    
           }else{
          
                var N_Imppresion3D = new Impresiones3D{
                 cliente = cliente,
                 Tipo_impresion = Tipo_impresion,
                 cantidad = cantidad,
                 precio = precio
            };
            if(validado.id > 0){

                    impresion.AdicionarImpresiones3D(N_Imppresion3D);

                    N_Imppresion3D.impresora = validado;
                    var result = impresion.Update(N_Imppresion3D);

                    if(result > 0){
                        mensaje = "Impresión agregado con exito";  
                        OnGet();                       
                        // Response.Redirect("page");  
                        //  RedirectToPage("./Page");               
                    }else{
                    Console.WriteLine("No se pudo ingresar el registro");
                    OnGet(); 
                    }
                }
            }
           
           TempData["mensaje"] = mensaje;
        }

     
    }
}