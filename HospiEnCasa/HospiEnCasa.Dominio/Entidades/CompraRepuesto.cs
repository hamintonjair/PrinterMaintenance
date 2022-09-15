using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospiEnCasa.Dominio
{
    public class CompraRepuesto
    {
        public int id { get; set; }
        public string tipo_repuesto { get; set; }
        public string valor { get; set; }
        public string fecha_compra { get; set; }
        public Impresora impresora { get; set; }
        public Repuesto repuesto { get; set; }
       
    }
}