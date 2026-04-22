using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationSystem.Domain.Enums;

namespace MovieReservationSystem.Domain.Entities
{
	public class User
	{
		public int UserId { get; set; }

		public string UserName { get; set; } = null!;

		public string Email { get; set; } = null!;

		public string Passwordhash { get; set; } = null!;

		public Role Role { get; set; }

		//Navigation property
		public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();  //Intialiase to avoid null reference issue

	}
}
