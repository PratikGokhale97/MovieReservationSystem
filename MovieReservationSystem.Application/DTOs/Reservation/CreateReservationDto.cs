using MovieReservationSystem.Application.DTOs.Reservation.ReservationSeat;
using MovieReservationSystem.Domain.Entities;
using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Reservation
{
	public class CreateReservationDto
	{
		public int ShowTimeId { get; set; }

		public List<int> SeatIds = new();
	}
}
