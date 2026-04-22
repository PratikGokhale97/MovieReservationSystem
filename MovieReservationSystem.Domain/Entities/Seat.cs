using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Seat
	{
		public int SeatId { get; set; }

		public string SeatNumber { get; set; } = null!;

		public SeatType SeatType { get; set; }

		public Screen Screen { get; set; } = null!;

		public int ScreenId { get; set; }

	}
}
