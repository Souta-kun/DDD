namespace Panaderia.ApplicationCore.Models.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime Creado { get; set; }
        public DateTime? Modificado { get; set; }
    }
}