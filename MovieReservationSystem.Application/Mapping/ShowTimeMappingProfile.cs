using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.ShowTime;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class ShowTimeMappingProfile : Profile
	{
		public ShowTimeMappingProfile()
		{
			CreateMap<CreateShowTimeDto, ShowTime>();
			//.ForMember(dest => dest.ShowTimePricing, opt => opt.Ignore())
			//.ForMember(dest => dest.Movie, opt => opt.Ignore())
			//.ForMember(dest => dest.Screen, opt => opt.Ignore());

			CreateMap<UpdateShowTimeDto, ShowTime>();
			//.ForMember(dest => dest.ShowTimePricing, opt => opt.Ignore())
			//.ForMember(dest => dest.Movie, opt => opt.Ignore())
			//.ForMember(dest => dest.Screen, opt => opt.Ignore());


			CreateMap<ShowTime, ShowTimeDto>()
				.ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.Movie.MovieName))
				.ForMember(dest => dest.ScreenName, opt => opt.MapFrom(src => src.Screen.ScreenName));
				//.ForMember(dest=> dest.AvailableSeats, opt => opt.Ignore());

		}
	}
}
