using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Reservation
{
	public class UpdateReservationDto
	{
		public int ReservationId { get; set; }
		public BookingStatus BookingStatus { get; set; }
	}
}
