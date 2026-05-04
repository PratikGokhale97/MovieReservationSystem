using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Reservation.ReservationSeat
{
	//This dto should not exists told by claude
	public class CreateReservationSeatDto
	{
		public SeatType SeatType { get; set; }

		public int ReservationId { get; set; }

		public int ShowTimeId { get; set; }

		public int SeatId { get; set; }

		public decimal Price { get; set; }
	}
}
