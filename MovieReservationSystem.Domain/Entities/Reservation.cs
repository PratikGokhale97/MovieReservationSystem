using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Reservation
	{
		public int ReservationId { get; set; }

		public int UserId { get; set; }

		public int ShowTimeId { get; set; }

		public BookingStatus BookingStatus { get; set; }

		public DateTime BookedAt { get; set; }

		//Navigation property
		public User User { get; set; } = null!;
		public ShowTime ShowTime { get; set; } = null!;
		public ICollection<ReservationSeat> ReservationSeats { get; set; } = new List<ReservationSeat>();
	}
}
