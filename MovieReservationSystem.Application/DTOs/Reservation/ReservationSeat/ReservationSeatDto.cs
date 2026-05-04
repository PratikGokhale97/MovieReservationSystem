using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Reservation.ReservationSeat
{
	public class ReservationSeatDto
	{
		public int ReservationSeatId { get; set; }
		public SeatType SeatType { get; set; }
		public decimal Price { get; set; }
		public string SeatNumber { get; set; } = null!;
	}
}
