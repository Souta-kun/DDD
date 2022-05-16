using AutoMapper;
using Panaderia.ApplicationCore.DTOs;
using Panaderia.ApplicationCore.Interfaces;

namespace Panaderia.ApplicationCore.Services.Proveedor
{
    public class ProveedorService : IProveedorService
    {
        public IProveedorRepository proveedorRepository { get; set; }
        public IMapper mapper { get; set; }

        public ProveedorService(IProveedorRepository panRepository, IMapper mapper)
        {
            this.proveedorRepository = panRepository;
            this.mapper = mapper;
        }

        public void Create(ProveedorDto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProveedorDto Read(int id)
        {
            var pan = this.proveedorRepository.Read(id);
            
            return mapper.Map<ProveedorDto>(pan);
        }

        public IEnumerable<ProveedorDto> Read()
        {
            var panes = this.proveedorRepository.Read();

            return mapper.Map<IEnumerable<ProveedorDto>>(panes);
        }

        public void Update(ProveedorDto entity)
        {
            throw new NotImplementedException();
        }
    }
}