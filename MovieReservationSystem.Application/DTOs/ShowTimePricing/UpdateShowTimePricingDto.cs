using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.ShowTimePricing
{
	public class UpdateShowTimePricingDto
	{
		public int ShowTimePricingId { get; set; }
		public SeatType SeatType { get; set; }
		public decimal Price { get; set; }
	}
}
