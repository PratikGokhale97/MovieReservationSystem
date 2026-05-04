using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Screen
{
	public class ScreenDto
	{
		public int ScreenId { get; set; }

		public int TheatreId { get; set; }

		public string ScreenName { get; set; } = null!;

		//Below is not actual proprty of Screen but added for ease of use in ShowTimeDto
		public int TotalSeats { get; set; }
	}
}
