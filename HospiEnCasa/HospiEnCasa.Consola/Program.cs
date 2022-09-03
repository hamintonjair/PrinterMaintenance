using System.Data;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospiEnCasa.Dominio;
using HospiEnCasa.Persistencia;


namespace HospiEnCasa.Consola
{
    class Program
    {
        //instancia del repositorio
        private static Persistencia.INivelEstudiosRepository nivelEstudiosRepository = new NivelEstudiosRepository( new HospiEnCasa.Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            // var nivelEstudio = new NivelEstudio{
            //     estudio = "Bachiller"
            // };

            // var  result = nivelEstudiosRepository.Add(nivelEstudio);

            // if(result > 0){
            //     Console.WriteLine("Profesión insertado con exito..");
            // }else{
            //     Console.WriteLine("Error" , "No se pudo insertar la profesión.");
            // }

            Console.WriteLine("Buscando...");
            var nivelEstudio = nivelEstudiosRepository.Buscar(1);
            Console.WriteLine(nivelEstudio);
           
        }
    }
}
