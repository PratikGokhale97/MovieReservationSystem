using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.ShowTimePricing
{
	//This is redundant class because for a showtime the default price will be same 
	public class AddShowTimePricingDto
	{
		public SeatType SeatType { get; set; }
		public decimal Price { get; set; }
	}
}
