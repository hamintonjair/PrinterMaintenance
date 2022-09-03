using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class ImpresorasRepository : IImpresorasRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public ImpresorasRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IImpresorasRepository.Add(Impresora impresora){
           _context.Impresoras.Add(impresora);
           return _context.SaveChanges();
       }
    }
   
}
