using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class RevisionesRepository : IRevisionesRepository
    {
     //instancia
        private readonly AppContext _context;

        //constructor
        public RevisionesRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IRevisionesRepository.Add(Revision revision){
           _context.Revisiones.Add(revision);
           return _context.SaveChanges();
       }
    }
   
}
