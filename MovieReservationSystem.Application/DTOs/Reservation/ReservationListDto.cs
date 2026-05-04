using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Reservation
{
	public class ReservationListDto
	{
		public int ReservationId { get; set; }

		public BookingStatus BookingStatus { get; set; }

		public DateTime BookedAt { get; set; }

		//Below properrty do not exists but still will be shown to user
		public double TotalPrice { get; set; }

		public string MovieName { get; set; } = string.Empty;

		public DateTime StartTime { get; set; }
	}
}
