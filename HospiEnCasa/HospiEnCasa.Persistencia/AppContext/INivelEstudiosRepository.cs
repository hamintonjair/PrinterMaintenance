using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public interface INivelEstudiosRepository
    {
        int Add(NivelEstudio nivelEstudio);
        
        NivelEstudio Buscar(int id);
    
    } 
   
}
