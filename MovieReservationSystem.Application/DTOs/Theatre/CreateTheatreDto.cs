using MovieReservationSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Theatre
{
	public class CreateTheatreDto
	{
		public string TheatreName { get; set; } = null!;
		public string State { get; set; } = string.Empty;
		public string City { get; set; } = string.Empty;
		public int Pincode { get; set; }
		
	}
}
