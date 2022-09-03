using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
  public class PersonaRepository : IPersonaRepository
  {
    //instancia
    private readonly AppContext _context;

        //constructor
      public PersonaRepository(AppContext context)
      {
          _context = context;
      }   
        //Guardar
        int IPersonaRepository.Add(Persona persona){
           _context.Personas.Add(persona);
           return _context.SaveChanges();
        }
  }
   
}
