using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Medico
    {
        [Key]
        public int nroMatriculaProfesional { get; set; }
        public string ? nombreCompleto { get; set; }
        public int consultorio { get; set; }
        public Consultorio consultorioMedico { get; set; }
        public int especialidad { get; set; }
        public Especialidad especialidadMedico { get; set; }
        public ICollection<Cita> Citas { get; set; }
    }
