using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Screen
	{
		public int ScreenId { get; set; }

		public int TheatreId { get; set; }

		public string ScreenName { get; set; } = null!;

		public Theatre Theatre { get; set; } = null!;

		public ICollection<Seat> Seats { get; set; } = new List<Seat>();

		public ICollection<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();

	}
}
