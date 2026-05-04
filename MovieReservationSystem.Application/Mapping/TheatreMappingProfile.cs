using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.Theatre;
using MovieReservationSystem.Domain.Entities;


namespace MovieReservationSystem.Application.Mapping
{
	public class TheatreMappingProfile : Profile
	{
		public TheatreMappingProfile()
		{
			CreateMap<Theatre, TheatreDto>()
				.ForMember(dest => dest.State, opt => opt.MapFrom(src => src.Address.State))
				.ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Address.City))
				.ForMember(dest => dest.Pincode, opt => opt.MapFrom(src => src.Address.Pincode));



		}
	}
}
