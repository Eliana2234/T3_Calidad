using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3ESOT.Models
{
    public class EtiquetaNota
    {
        public int Id { get; set; }
        public int IdEtiqueta { get; set; }
        public int IdNota { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public Nota Nota { get; set; }
    }
}
