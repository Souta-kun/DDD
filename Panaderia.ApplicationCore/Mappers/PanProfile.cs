using AutoMapper;
using Panaderia.ApplicationCore.DTOs;
using Panaderia.ApplicationCore.Models;

namespace Panaderia.ApplicationCore.Mappers
{
    public class PanMapper : Profile
    {
        public PanMapper()
        {
            CreateMap<Proveedor, ProveedorDto>();            
            CreateMap<ProveedorDto, Proveedor>();                        

            CreateMap<Pan, PanDto>();
            CreateMap<PanDto, Pan>();
        }
    }
}