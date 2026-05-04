using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MovieReservationSystem.Application.DTOs.User;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class UserMappingProfile : Profile
	{
		public UserMappingProfile()
		{
			CreateMap<CreateUserDto, User>();
			//.ForMember(dest => dest.Reservations, opt => opt.Ignore())
			//.ForMember(dest => dest.Passwordhash, opt=> opt.Ignore())
			//.ForMember(dest => dest.Role, opt => opt.Ignore());

			CreateMap<UpdateUserDto, User>();
				//.ForMember(dest => dest.Reservations, opt => opt.Ignore())
				//.ForMember(dest => dest.Passwordhash, opt => opt.Ignore())
				//.ForMember(dest => dest.Role, opt => opt.Ignore());

			CreateMap<User, UserDto>();
	
		}
	}
}
