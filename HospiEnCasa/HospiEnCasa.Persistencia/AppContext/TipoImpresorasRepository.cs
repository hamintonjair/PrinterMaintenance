using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class TipoImpresorasRepository : ITipoImpresorasRepository
    {
      //instancia 
        private readonly AppContext _context;

        //constructor
        public TipoImpresorasRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int ITipoImpresorasRepository.Add(TipoImpresora tipoImpresora){
           _context.TipoImpresoras.Add(tipoImpresora);
           return _context.SaveChanges();
       }
    }
   
}
