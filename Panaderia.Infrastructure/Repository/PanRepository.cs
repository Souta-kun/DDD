using Microsoft.EntityFrameworkCore;
using Panaderia.ApplicationCore.Interfaces;
using Panaderia.ApplicationCore.Models;
using Panaderia.Infrastructure.Database;

namespace Panaderia.Infrastructure.Repository
{
    public class PanRepository : IPanRepository
    {
        private readonly PanaderiaContext panaderiaContext;

        public PanRepository(PanaderiaContext panaderiaContext)
        {
            this.panaderiaContext = panaderiaContext;
        }

        public void Create(Pan entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pan Read(int id)
        {
            return this.panaderiaContext.Pan
                .Include(p => p.Proveedor)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Pan> Read()
        {
            return this.panaderiaContext.Pan
                .Include(p => p.Proveedor)
                .ToList();
        }

        public void Update(Pan entity)
        {
            throw new NotImplementedException();
        }
    }
}