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
	public class UpdateUserDto
	{
		public int UserId { get; set; }
		public string UserName { get; set; } = null!;
		public string oldEmail { get; set; } = null!;
		public string newEmail { get; set; } = null!;
		public string oldPassword { get; set; } = null!;
		public string newPassword { get; set; } = null!;
		public Role Role { get; set; }
		//public List<CreateReservationDto> Reservations { get; set; } = new List<CreateReservationDto>();
		//since user will not be updated alsong with reservation seat so comment above code
	}
}
