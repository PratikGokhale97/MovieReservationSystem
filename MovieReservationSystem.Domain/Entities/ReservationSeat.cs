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

		public int Reservationid { get; set; }

		public int SeatId { get; set; }

		public decimal Price { get; set; }

	}
}
