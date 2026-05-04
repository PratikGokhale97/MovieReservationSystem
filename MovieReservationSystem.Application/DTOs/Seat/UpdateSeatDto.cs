using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Seat
{
	//Not required for now
	public class UpdateSeatDto
	{
		public int SeatId { get; set; }

		public string SeatNumber { get; set; } = null!;

		public SeatType SeatType { get; set; }

		public int ScreenId { get; set; }
	}
}
