using AutoMapper;
using Panaderia.ApplicationCore.DTOs;
using Panaderia.ApplicationCore.Interfaces;
using Panaderia.ApplicationCore.Models;

namespace Panaderia.ApplicationCore.Services
{
    public class PanService : IPanService
    {
        private readonly IPanRepository panRepository;
        private readonly IMapper mapper;

        public PanService(IPanRepository panRepository, IMapper mapper)
        {
            this.panRepository = panRepository;
            this.mapper = mapper;
        }

        public void Create(PanDto entity)
            => this.panRepository.Create(mapper.Map<Pan>(entity));

        public void Delete(int id) 
            => this.panRepository.Delete(id);

        public PanDto Read(int id)
        {
            var pan = this.panRepository.Read(id);
            
            return mapper.Map<PanDto>(pan);
        }

        public IEnumerable<PanDto> Read()
        {
            var panes = this.panRepository.Read();

            return mapper.Map<IEnumerable<PanDto>>(panes);
        }

        public void Update(PanDto entity)
            => this.panRepository.Update(mapper.Map<Pan>(entity));
    }
}