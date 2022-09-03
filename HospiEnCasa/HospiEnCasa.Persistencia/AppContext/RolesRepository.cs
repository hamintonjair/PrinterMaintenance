using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class RolesRepository : IRolesRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public RolesRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int IRolesRepository.Add(Rol rol){
           _context.Roles.Add(rol);
           return _context.SaveChanges();
       }
    }
   
}
