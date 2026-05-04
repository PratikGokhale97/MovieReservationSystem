using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Auth
{
	public class AuthResponseDto
	{
		public string AuthToken { get; set; } = null!;

		public string RefreshToken { get; set; } = null!;
	}
}
