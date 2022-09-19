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
    public class Edit : PageModel
    {
        private readonly ILogger<Edit> _logger;

        public Edit(ILogger<Edit> logger)
        {
            _logger = logger;
        }

        public Impresiones3D impresiones;

        private IImpresion3DRepository impresion = new Impresion3DRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<Impresiones3D> listadoImpresion3D {get; set; }
        
        public IActionResult OnGet(int Id)
        {
            listadoImpresion3D = new List<Impresiones3D>();
            listadoImpresion3D = impresion.ObtenerTodo();

             impresiones = impresion.Buscar(Id);

            if(impresiones == null){

                return RedirectToPage("./Gestionimpresiones3D");

            }else{
                return Page();
            }
        }
    }
}