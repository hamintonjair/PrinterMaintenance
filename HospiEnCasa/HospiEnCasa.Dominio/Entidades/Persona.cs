using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Persona
    {
       public int id { get; set; }
       public string nombre { get; set; }
       public string apellidos { get; set; }
       public string cedula { get; set; }
       public string telefono { get; set; }
       public string fecha_nacimiento { get; set; }
       public string direccion { get; set; }  
       public string email { get; set; }   
       public NivelEstudio nivelEstudio { get; set; }  
       public Socio socio { get; set; }     
    }
}