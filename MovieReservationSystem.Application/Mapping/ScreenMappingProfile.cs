using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.Screen;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class ScreenMappingProfile : Profile
	{
		public ScreenMappingProfile()
		{
			CreateMap<CreateScreenDto, Screen>()
				.ForMember(dest => dest.Seats, opt => opt.MapFrom(src => src.Seats));


			CreateMap<UpdateScreenDto, Screen>()
				.ForMember(dest => dest.Seats, opt => opt.MapFrom(src => src.Seats));

			CreateMap<Screen, ScreenDto>()
				.ForMember(dest => dest.TotalSeats, opt => opt.MapFrom(src => src.Seats.Count));

		}
	}
}
