using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public interface IPersonaRepository
    {
        int Add(Persona persona);
    } 
   
}
