using MovieReservationSystem.Application.DTOs.Seat;
using MovieReservationSystem.Application.DTOs.ShowTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Screen
{
	//Not required for now
	public class UpdateScreenDto
	{
		public int ScreenId { get; set; }

		public int TheatreId { get; set; }

		public string ScreenName { get; set; } = null!;

		public List<CreateSeatDto> Seats { get; set; } = new List<CreateSeatDto>();

		//public List<CreateShowTimeDto> ShowTime { get; set; } = new List<CreateShowTimeDto>(); told to remove by claude
	}
}
