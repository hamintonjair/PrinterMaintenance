using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Persona : NivelEstudio
    {
       public int id { get; set; }
       public string nombre { get; set; }
       public string apellidos { get; set; }
       public string cedula { get; set; }
       public string telefono { get; set; }
       public DateTime fecha_nacimiento { get; set; }
       public string password { get; set; }
       public string direccion { get; set; }      
       public int nivelEstudioId { get; set; }     
       
    }
}