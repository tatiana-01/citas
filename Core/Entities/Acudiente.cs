

namespace Core.Entities;

    public class Acudiente
    {
        public int id { get; set; }
        public string ? nombreCompleto { get; set; }
        public string ? telefono { get; set; }
        public string ? direccion { get; set; }
        public ICollection<Usuario>  Usuarios { get; set; }

    }
