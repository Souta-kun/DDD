using Panaderia.ApplicationCore.Models.Base;

namespace Panaderia.ApplicationCore.Models
{
    public class Proveedor : Entity
    {
        public string Nombre { get; set; }
        public ICollection<Pan> PanLista { get; set; }
    }
}