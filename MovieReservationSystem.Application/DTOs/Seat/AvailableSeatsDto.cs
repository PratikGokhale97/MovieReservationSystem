using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Seat
{
	public class AvailableSeatsDto
	{
		public int SeatId { get; set; }

		public string SeatNumber { get; set; } = null!;

		public SeatType SeatType { get; set; }

		public decimal Price { get; set; } //Not sure tw to get this property from seat
	}
}
