using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public interface IRevisionesRepository
    {
        int Add(Revision revision);
    } 
   
}
