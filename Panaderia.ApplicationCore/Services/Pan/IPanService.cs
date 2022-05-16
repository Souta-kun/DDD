using Panaderia.ApplicationCore.DTOs;

namespace Panaderia.ApplicationCore.Services.Pan
{
    public interface IPanService
    {
        void Create(PanDto entity);
        PanDto Read(int id);
        IEnumerable<PanDto> Read();
        void Update(PanDto entity);
        void Delete(int id);
    }
}