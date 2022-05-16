using Microsoft.EntityFrameworkCore;
using Panaderia.ApplicationCore.Interfaces;
using Panaderia.ApplicationCore.Models;
using Panaderia.Infrastructure.Database;

namespace Panaderia.Infrastructure.Repository
{
    public class ProveedorRepository : IProveedorRepository
    {
        public PanaderiaContext context { get; set; }

        public ProveedorRepository(PanaderiaContext context)
        {
            this.context = context;

        }
        public void Create(Proveedor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Proveedor Read(int id)
        {
            return this.context.Proveedor
                .Include(p => p.PanLista)
                .First(p => p.Id == id);
        }

        public IEnumerable<Proveedor> Read()
        {
            return this.context.Proveedor
                .Include(p => p.PanLista)
                .ToList();
        }

        public void Update(Proveedor entity)
        {
            throw new NotImplementedException();
        }
    }
}