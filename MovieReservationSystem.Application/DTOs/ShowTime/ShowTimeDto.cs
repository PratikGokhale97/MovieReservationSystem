using MovieReservationSystem.Application.DTOs.Seat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.ShowTime
{
	public class ShowTimeDto
	{
		public int ShowTimeId { get; set; }

		public string MovieName { get; set; }

		public string ScreenName { get; set; }

		public DateTime StartTime { get; set; }

		public List<AvailableSeatsDto> AvailableSeats { get; set; } = new List<AvailableSeatsDto>();
	}
}
