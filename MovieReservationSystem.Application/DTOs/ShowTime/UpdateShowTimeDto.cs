using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.ShowTime
{
	public class UpdateShowTimeDto
	{
		public int ShowTimeId { get; set; }

		public int MovieId { get; set; }

		public int ScreenId { get; set; }

		public DateTime StartTime { get; set; }
	}
}
