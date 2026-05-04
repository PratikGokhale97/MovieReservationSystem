using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.Genre;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class GenreMappingProfile : Profile
	{
		public GenreMappingProfile()
		{
			CreateMap<CreateGenreDto, Genre>();
				//.ForMember(dest => dest.MovieGenres, opt => opt.Ignore());

			CreateMap<UpdateGenreDto, Genre>();
				//.ForMember(dest => dest.MovieGenres, opt => opt.Ignore());

			CreateMap<Genre, GenreDto>();
		}
	}
}

//Note for mapping
// If property does not exist in source and exist in destination automapper ignores it 
// If property exist in source and destination and we dont want the property to be mapped and add ignore then automapper ignores it
// If property exist in source and destination and we want to map it but the property name is different then we need to use ForMember method to map it
