using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Consultorio
    {
        public int id { get; set; }
        public string ? nombre { get; set; }
        public ICollection<Medico> Medicos { get; set; }
    }
