using MovieReservationSystem.Application.DTOs.Reservation;
using MovieReservationSystem.Application.DTOs.Reservation.ReservationSeat;
using MovieReservationSystem.Domain.Entities;
using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.User
{
	public class CreateUserDto
	{
		public string UserName { get; set; } = null!;

		public string Email { get; set; } = null!;

		public string Password { get; set; } = null!;

		//Role not mentioned because it will be assigned by default as user at runtime
	}
}
