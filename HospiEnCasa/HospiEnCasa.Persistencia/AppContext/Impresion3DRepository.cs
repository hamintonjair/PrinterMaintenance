using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class Impresion3DRepository : IImpresion3DRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public Impresion3DRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IImpresion3DRepository.Add(Impresiones3D impresiones3D){
           _context.Impresion3D.Add(impresiones3D);
           return _context.SaveChanges();
       }
    }
   
}
