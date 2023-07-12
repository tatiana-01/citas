using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class TipoDoc
    {
        public int id { get; set; }
        public string ? nombre { get; set; }
        public string ? abreviatura { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
