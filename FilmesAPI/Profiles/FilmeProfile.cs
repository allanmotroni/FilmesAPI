using AutoMapper;
using FilmesAPI.Data.Dto;
using FilmesAPI.Models;
using System;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>()
                .ForMember(dto => dto.HoraDaConsulta, filme => filme.MapFrom(p => DateTime.Now));
        }
    }
}
