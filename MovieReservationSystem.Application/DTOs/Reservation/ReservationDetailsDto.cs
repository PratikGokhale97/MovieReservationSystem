using MovieReservationSystem.Application.DTOs.Reservation.ReservationSeat;
using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Reservation
{
	public class ReservationDetailsDto
	{
		public int ReservationId { get; set; }

		public BookingStatus BookingStatus { get; set; }

		public DateTime BookedAt { get; set; }

		//public int SeatId { get; set; }

		public DateTime StartTime { get; set; }

		public string MovieName { get; set; } = null!;

		public List<ReservationSeatDto> ReservationSeatDto { get; set; } = new List<ReservationSeatDto>();
	}
}
