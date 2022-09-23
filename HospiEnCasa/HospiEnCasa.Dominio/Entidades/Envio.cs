using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class Envio
    {
        public int id {get; set;}
        public string correo {get; set;}
        public Persona persona {get; set;}
    }
}