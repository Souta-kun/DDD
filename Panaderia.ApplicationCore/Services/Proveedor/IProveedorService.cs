using Panaderia.ApplicationCore.DTOs;

namespace Panaderia.ApplicationCore.Services.Proveedor
{
    public interface IProveedorService
    {
        void Create(ProveedorDto entity);
        ProveedorDto Read(int id);
        IEnumerable<ProveedorDto> Read();
        void Update(ProveedorDto entity);
        void Delete(int id);
    }
}