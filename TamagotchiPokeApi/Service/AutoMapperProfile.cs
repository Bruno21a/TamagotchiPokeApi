using AutoMapper;
using TamagotchiPokeApi.Model;

namespace TamagotchiPokeApi.Service
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AbilityDetail, Habilidade>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Ability != null ? src.Ability.Name : null));

            CreateMap<PokemonDetailsResult, TamagotchiDto>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Altura, opt => opt.MapFrom(src => src.Height))
                .ForMember(dest => dest.Peso, opt => opt.MapFrom(src => src.Weight))
                .ForMember(dest => dest.Habilidades, opt => opt.MapFrom(src => src.Abilities));
        }
    }
    public class MascoteService
    {
        private readonly IMapper _mapper;

        public MascoteService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TamagotchiDto CriarMascote(PokemonDetailsResult pokemon)
        {
            return _mapper.Map<TamagotchiDto>(pokemon);
        }
    }
}
