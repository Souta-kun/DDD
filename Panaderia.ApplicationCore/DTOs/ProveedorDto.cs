namespace Panaderia.ApplicationCore.DTOs
{
    public class ProveedorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<PanDto> PanLista { get; set; }
    }
}