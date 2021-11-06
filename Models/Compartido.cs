using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3ESOT.Models
{
    public class Compartido
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdNota { get; set; }

        public User User { get; set; }
        public Nota Nota { get; set; }

    }
}
