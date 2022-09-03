using System;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;

namespace HospiEnCasa.Persistencia
{
    public class NivelEstudiosRepository : INivelEstudiosRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public NivelEstudiosRepository(AppContext context)
        {
          _context = context;
        }   
        //Guardar
        int INivelEstudiosRepository.Add(NivelEstudio nivelEstudio){
           _context.NivelEstudios.Add(nivelEstudio);
           return _context.SaveChanges();
        }
        //buscar
        NivelEstudio INivelEstudiosRepository.Buscar(int id){
           return _context.NivelEstudios.Buscar(id);
        }
    }
   
}
