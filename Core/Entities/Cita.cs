using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Cita
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public EstadoCita EstadoCita { get; set; }
        public int estadoCita { get; set; }
        public Medico medicoCita { get; set; }
        public int medico { get; set; }
        public Usuario usuarioCita { get; set; }
        public int datosUsuario { get; set; }
    }
