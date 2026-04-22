using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class ShowTimePricing
	{
		public int ShowTimePricingId { get; set; } 

		public SeatType SeatType { get; set; }

		public ShowTime ShowTime { get; set; } = null!;

		public decimal Price { get; set; }

		public int ShowTimeId {  get; set; }
	}
}
