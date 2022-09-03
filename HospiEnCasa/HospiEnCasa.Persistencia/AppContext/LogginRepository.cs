using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public class LogginRepository : ILogginRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public LogginRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int ILogginRepository.Add(Login login){
           _context.Loggin.Add(login);
           return _context.SaveChanges();
       }
    }
   
}
