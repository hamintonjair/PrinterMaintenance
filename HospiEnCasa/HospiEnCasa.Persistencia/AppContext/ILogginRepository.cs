using System;
using HospiEnCasa.Dominio;

namespace HospiEnCasa.Persistencia
{
    public interface ILogginRepository
    {
        int Add(Login login);
    } 
   
}
