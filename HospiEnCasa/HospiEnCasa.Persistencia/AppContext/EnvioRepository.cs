using System;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;
using System.Linq;
using Microsoft.EntityFrameworkCore; //para pode uar el include
using System.Collections.Generic;

namespace HospiEnCasa.Persistencia
{
    public class EnvioRepository : IEnvioRepository
    {
      //instancia
        private readonly AppContext _context;

        //constructor
        public EnvioRepository(AppContext context)
        {
          _context = context;
        }     
         //Guardar
        int IEnvioRepository.AdicionarEnvio(Envio envio){
           _context.Envio.Add(envio);
           return _context.SaveChanges();
       }       
        //buscar por id
        // bool IEnvioRepository.Add(Envio envio){
        //     _context.Envio.Add(envio);
        //     return (_context.SaveChanges() > 0 ? true : false);            
        // }
        // //Añadir
        // Envio IEnvioRepository.Buscar(int id){
        //     return _context.Envio.Find(id);
        // }
        // //enumerar
        // IEnumerable<Envio> IEnvioRepository.GetAll(){
        //     return _context.Envio;
        // }
        // //listar
        List<Envio> IEnvioRepository.ObtenerTodo(){
            return _context.Envio.ToList();           
        }
        // //buscar por nombre
        // IEnumerable<Envio> IEnvioRepository.FindByName(string name){
        //     return _context.Envio.Where(p => p.nombre.Contains(name) );
        // }

        // IEnumerable<Envio> IEnvioRepository.FindMultipleParameter(string value){
        //     return _context.Envio.Where(p => p.nombre.Contains(value) || 
        //     p.marca.Contains(value) || p.placa.Contains(value)|| p.velocidad_imp.Contains(value) || 
        //   p.pais_origen.Contains(value));
        // }
        // //actualizar
        int IEnvioRepository.Update(Envio envio){
            _context.Envio.Update(envio);
            return _context.SaveChanges();
         }
        // //eliminar
        // int IEnvioRepository.Delete(Envio envio){
        //     _context.Envio.Remove(envio);
        //     return _context.SaveChanges();
        // }

        // IEnumerable<Envio> IEnvioRepository.ObtenerTodosEnvio(){
        //     return _context.Envio;
        // }

        // List<Envio> IEnvioRepository.ObtenerEnvioPorNombre(string nombre){
        //     return _context.Envio.Where( p => p.nombre.Contains(nombre) ).ToList();
        // }

        // IEnumerable<Envio> IEnvioRepository.Buscador(string busqueda){
        //          return _context.Envio.Where(p => p.nombre.Contains(busqueda) ||
        //       p.marca.Contains(busqueda) ||  p.placa.Contains(busqueda) ||
        //       p.velocidad_imp.Contains(busqueda) ||  p.pais_origen.Contains(busqueda) );
        // }

        // int IEnvioRepository.ActualizarEnvio(Envio envio){
        //     _context.Envio.Update(envio);
        //     return _context.SaveChanges();
        // }

        // int IEnvioRepository.EliminarEnvio(Envio envio){
        //     _context.Envio.Remove(envio);
        //     return _context.SaveChanges();
        // }
       
    }
   
}
