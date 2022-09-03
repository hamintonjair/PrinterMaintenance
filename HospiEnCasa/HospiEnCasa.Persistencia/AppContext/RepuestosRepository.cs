using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class RepuestosRepository : IRepuestosRepository
    {
        //instancia
        private readonly AppContext _context;

        //constructor
        public RepuestosRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IRepuestosRepository.Add(Repuesto repuesto){
           _context.Repuestos.Add(repuesto);
           return _context.SaveChanges();
       }
    }
   
}
