using AutoMapper;
using TMenos3.NetCore.EFTesting.API.Dtos;
using TMenos3.NetCore.EFTesting.Database.Models;

namespace TMenos3.NetCore.EFTesting.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TeamDto, Team>().ReverseMap();
            CreateMap<PlayerDto, Player>().ReverseMap();
        }
    }
}
