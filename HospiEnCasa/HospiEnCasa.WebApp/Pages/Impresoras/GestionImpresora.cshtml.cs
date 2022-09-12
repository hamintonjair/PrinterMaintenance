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

        private IImpresorasRepository impresora = new ImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        private ITipoImpresorasRepository tipo_Impresora = new TipoImpresorasRepository(new HospiEnCasa.Persistencia.AppContext());
        public List<TipoImpresora> listadoTipoImpresora {get; set; }
        public List<Impresora> listadoImpresora {get; set; }

        public void OnGet()
        {
            listadoImpresora = new List<Impresora>();
            listadoImpresora = impresora.ObtenerTodo();
            listadoTipoImpresora = new List<TipoImpresora>();
            listadoTipoImpresora = tipo_Impresora.ObtenerTodo();
        }
    }
}