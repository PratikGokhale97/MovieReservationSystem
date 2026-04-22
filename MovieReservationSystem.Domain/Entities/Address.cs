using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Address
	{
		public int AddressId { get; set; }   
		public string State { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public int Pincode { get; set; } 

	}
}
