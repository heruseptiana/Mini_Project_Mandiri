
using AutoMapper;
using DataNasabah.Dtos;
using DataNasabah.Models;

namespace DataNasabah
{
  public class AppMapperProfile : Profile
  {
    public AppMapperProfile() 
    {
      CreateMap<NasabahDto, Nasabah>();
      CreateMap<AlamatNasabahDto, AlamatNasabah>();
    }
  }
}
