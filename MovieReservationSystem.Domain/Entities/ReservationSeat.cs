using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class ReservationSeat
	{
		public int ReservationSeatId { get; set; }

		public SeatType SeatType { get; set; }

		public int ReservationId { get; set; }

		public int ShowTimeId {  get; set; }

		public int SeatId { get; set; }

		public decimal Price { get; set; }

		public Seat Seat { get; set; } = null!;

		public ShowTime ShowTime { get; set; } = null!;

		public Reservation Reservation { get; set; } = null!;


	}
}
