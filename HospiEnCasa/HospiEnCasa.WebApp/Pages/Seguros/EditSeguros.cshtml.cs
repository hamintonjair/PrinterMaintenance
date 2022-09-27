using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.WebApp.Pages.Seguros
{
    public class EditSeguros : PageModel
    {
        private readonly ILogger<EditSeguros> _logger;

        public EditSeguros(ILogger<EditSeguros> logger)
        {
            _logger = logger;
        }
        public SeguroImpresora seguro;
        private ISeguroImpresorasRepository _seguro = new SeguroImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());        
        public List<SeguroImpresora> listadoSeguro {get; set; }  
      

        public IActionResult OnGet(int Id)
        {
            listadoSeguro = new List<SeguroImpresora>();
            listadoSeguro = _seguro.ObtenerTodo();
            

             seguro = _seguro.Buscar(Id);

            if(seguro == null){

                return RedirectToPage("./GestionSeguro");

            }else{
                return Page();
            }
        }       

        public IActionResult OnPost(){

            var mensaje = ""; 

            var id                 = Request.Form["id"];
            var tipo_seguro        = Request.Form["tipo_seguro"];
            var precio             = Request.Form["precio"];
            var fecha_activacion   = Request.Form["fecha_activacion"];
            var fecha_vencimiento  = Request.Form["fecha_vencimiento"];
          


            var seguros = _seguro.Buscar(Int32.Parse(id));

            if(seguros != null ){

                seguros.tipo_seguro = tipo_seguro;
                seguros.precio = precio;
                seguros.fecha_activacion = fecha_activacion;
                seguros.fecha_vencimiento = fecha_vencimiento;

                var result = _seguro.Update(seguros);

                if(result > 0){

                    mensaje ="Se actualizaron los datos a ";
                    TempData["mensaje"] = mensaje;
                    return RedirectToPage("./GestionSeguro");
                 
                }else
                {                   
                   mensaje ="No fue posible la actualización ";                    
                }
            }else
            {
                 mensaje ="Error, Se produjo un problemainterno, intente nuevamente ";
            }
            TempData["mensaje"] = mensaje;
            return Page();
        }

        
     
    }
    
}