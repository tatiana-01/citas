using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class EstadoCita
    {
        public int id { get; set; }
        public string ? nombre { get; set; }

        public ICollection<Cita> Citas { get; set; }
    }
