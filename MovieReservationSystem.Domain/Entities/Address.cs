using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Address
	{
		//public int AddressId { get; set; }   Not needed because since Address cannot exist independently 
		public string State { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public int Pincode { get; set; } 


		private Address() { }   //private constructor to prevent object intialisation 


		//Factory method used to get Address object
		public static Address Create(string state,string city,int pincode)
		{
			return new Address  
			{
				State = state,
				City = city,
				Pincode = pincode
			};
		}

	}
}
