using Panaderia.ApplicationCore.Models;

namespace Panaderia.ApplicationCore.Interfaces
{
    public interface IProveedorRepository
    {
        void Create(Proveedor entity);
        Proveedor Read(int id);
        IEnumerable<Proveedor> Read();
        void Update(Proveedor entity);
        void Delete(int id);
    }
}