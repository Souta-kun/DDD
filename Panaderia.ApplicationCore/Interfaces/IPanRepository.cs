using Panaderia.ApplicationCore.Models;

namespace Panaderia.ApplicationCore.Interfaces
{
    public interface IPanRepository
    {
        void Create(Pan entity);
        Pan Read(int id);
        IEnumerable<Pan> Read();
        void Update(Pan entity);
        void Delete(int id);
    }
}