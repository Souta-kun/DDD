using Microsoft.EntityFrameworkCore;
using Panaderia.ApplicationCore.Interfaces;
using Panaderia.ApplicationCore.Models;
using Panaderia.Infrastructure.Database;

namespace Panaderia.Infrastructure.Repository
{
    public class PanRepository : IPanRepository
    {
        private readonly PanaderiaContext context;

        public PanRepository(PanaderiaContext panaderiaContext)
        {
            this.context = panaderiaContext;
        }

        public void Create(Pan entity)
        {
            entity.Proveedor = null;
            context.Pan.Add(entity);            
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pan Read(int id)
        {
            return this.context.Pan
                .Include(p => p.Proveedor)
                .First(p => p.Id == id);
        }

        public IEnumerable<Pan> Read()
        {
            return this.context.Pan
                .Include(p => p.Proveedor)
                .ToList();
        }

        public void Update(Pan entity)
        {
            throw new NotImplementedException();
        }
    }
}