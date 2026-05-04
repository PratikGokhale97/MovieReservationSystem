using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.Seat;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class SeatMappingProfile : Profile
	{
		public SeatMappingProfile()
		{
			CreateMap<CreateSeatDto, Seat>();
			CreateMap<UpdateSeatDto, Seat>();
			CreateMap<Seat, AvailableSeatsDto>();
		}
	}
}
