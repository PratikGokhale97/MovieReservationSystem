using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.Reservation;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class ReservationMappingProfile : Profile
	{
		public ReservationMappingProfile()
		{
			CreateMap<CreateReservationDto, Reservation>();

			CreateMap<UpdateReservationDto, Reservation>();

			CreateMap<Reservation, ReservationListDto>()
				.ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.ShowTime.Movie.MovieName))
				.ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.ShowTime.StartTime));

			CreateMap<Reservation, ReservationDetailsDto>()
				.ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.ShowTime.Movie.MovieName))
				.ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.ShowTime.StartTime))
				.ForMember(dest => dest.ReservationSeatDto, opt => opt.MapFrom(src => src.ReservationSeats));
		}

	}
}
