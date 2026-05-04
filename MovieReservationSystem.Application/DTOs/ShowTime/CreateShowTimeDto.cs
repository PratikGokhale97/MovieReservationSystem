using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.ShowTime
{
	public class CreateShowTimeDto
	{
		public int MovieId { get; set; }

		public int ScreenId { get; set; }

		public DateTime StartTime { get; set; }
	}
}
