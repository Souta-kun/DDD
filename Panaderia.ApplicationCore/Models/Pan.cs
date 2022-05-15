using Panaderia.ApplicationCore.Enums;
using Panaderia.ApplicationCore.Models.Base;

namespace Panaderia.ApplicationCore.Models
{
    public class Pan : Entity
    {
        public string Nombre { get; set; }
        public HarinaEnum Harina { get; set; }
        public double Precio { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}