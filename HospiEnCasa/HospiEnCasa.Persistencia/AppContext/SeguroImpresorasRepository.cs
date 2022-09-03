using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class SeguroImpresorasRepository : ISeguroImpresorasRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public SeguroImpresorasRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int ISeguroImpresorasRepository.Add(SeguroImpresora seguroImpresora){
           _context.SeguroImpresoras.Add(seguroImpresora);
           return _context.SaveChanges();
       }
    }
   
}
