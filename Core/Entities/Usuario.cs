using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Usuario
    {
        public int id { get; set; }
        public string ? nombre { get; set; }
        public string ? segdo_nombre { get; set; }
        public string ? primer_apellido { get; set; }
        public string ? segundo_apellido { get; set; }
        public string ? telefono { get; set; }
        public string ? direccion { get; set; }
        public string ? email { get; set; }
        public int ? tipodoc { get; set; }
        public TipoDoc TipoDoc { get; set; }
        public int ? genero { get; set; }
        public Genero Genero { get; set; }
        public int ? acudiente { get; set; }
        public Acudiente Acudiente { get; set; }

        public ICollection<Cita> Citas { get; set; }

    }
