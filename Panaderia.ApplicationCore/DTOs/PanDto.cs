
using Panaderia.ApplicationCore.Enums;

namespace Panaderia.ApplicationCore.DTOs
{
    public class PanDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public HarinaEnum Harina { get; set; }
        public double Precio { get; set; }
        public ProveedorDto Proveedor { get; set; }
    }
}