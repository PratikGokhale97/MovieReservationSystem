using MovieReservationSystem.Application.DTOs.Reservation;
using MovieReservationSystem.Domain.Entities;
using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.User
{
	public class UserDto
	{
		public int UserId { get; set; }
		public string UserName { get; set; } = null!;

		public string Email { get; set; } = null!;

		public Role Role { get; set; }

		//public List<CreateReservationDto> Reservations { get; set; } = new List<CreateReservationDto>();
		//commted by claude because reservation is done seperately
	}
}
