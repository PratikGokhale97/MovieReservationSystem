using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class ShowTime
	{
		public int ShowTimeId { get; set; }

		public int MovieId { get; set; }

		public int ScreenId { get; set; }

		public DateTime StartTime { get; set; } 

		public Movie Movie { get; set; } = null!;

		public Screen Screen { get; set; } = null!;

		public ICollection<ShowTimePricing> ShowTimePricing { get; set; } = new List<ShowTimePricing>(); //one showtime has 3 pricing rows (Normal, VIP, Executive):

	}
}
