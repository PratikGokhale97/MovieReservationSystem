using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Theatre
	{
		public int TheatreId { get; set; }

		public string TheatreName { get; set; } = null!;

		public Address Address { get; set; } = null!;

		public int AddressId { get; set; }

		public ICollection<Screen> Screens { get; set; } = new List<Screen>();
	}
}
