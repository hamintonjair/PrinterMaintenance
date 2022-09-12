using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Repuestos
{
    public class GestionRepuesto : PageModel
    {
        private readonly ILogger<GestionRepuesto> _logger;

        public GestionRepuesto(ILogger<GestionRepuesto> logger)
        {
            _logger = logger;
        }

        private IRepuestosRepository repuestos = new RepuestosRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Repuesto> listadoRepuestos {get; set; }

        public void OnGet()
        {
            listadoRepuestos = new List<Repuesto>();
            listadoRepuestos = repuestos.ObtenerTodo();
        }
         public void OnPost()
        {
            var repuesto = Request.Form["repuesto"];
            var precio = Request.Form["precio"];
            var cantidad =Request.Form["cantidad"];

            //VALIDAMOS SI EL DATO INGRESADO ES VACIO
           if(String.IsNullOrEmpty(repuesto) || String.IsNullOrEmpty(precio)){

                  Console.WriteLine("Error, debes llenar todos los campos");
          
           }else{
          
               var N_repuesto = new Repuesto{
                n_Repuesto = repuesto,
                cantidad = cantidad,
                valor =  precio
                };

                var validado = repuestos.FindByName(repuesto);

                if(validado != null){
                    var result = repuestos.AdicionarRepuesto(N_repuesto);

                    if(result > 0){
                        Console.WriteLine("Repuesto Agrregado");                      
                        Response.Redirect("page");  
                    }else{
                    Console.WriteLine("No se pudo ingresar el registro");
                    }
                }else{
                     Console.WriteLine("Ya heciste un repuesto con esté Nombre");
                }
            }
           
           
        }
    }
}