using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class CompraRepuestosRepository : ICompraRepuestosRepository
    {
      //instancia
      private readonly AppContext _context;

        //constructor
        public CompraRepuestosRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int ICompraRepuestosRepository.Add(CompraRepuesto compraRepuestos){
           _context.CompraRepuestos.Add(compraRepuestos);
           return _context.SaveChanges();
       }

       //buscar
       
    }
   
}
