using System;
using HospiEnCasa.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public interface IEnvioRepository
    {    
        int AdicionarEnvio(Envio envio);
        // bool Add(Envio envio);
        // Envio Buscar(int id);
        // IEnumerable<Envio> GetAll();
        List<Envio> ObtenerTodo();
        // IEnumerable<Envio> FindByName(string name);
        // IEnumerable<Envio> FindMultipleParameter(string value);
        int Update(Envio envio);
        // int Delete(Envio envio);

        // IEnumerable<Envio> ObtenerTodosEnvio();
        // List<Envio> ObtenerEnvioPorNombre(string envio);
        // IEnumerable<Envio> Buscador(string busqueda);
        // int ActualizarEnvio(Envio envio);
        // int EliminarEnvio(Envio envio);
        
    } 
   
}
