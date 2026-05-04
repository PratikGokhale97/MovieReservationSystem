using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Genre
{
	public class UpdateGenreDto
	{
		public int GenreId { get; set; }
		public string GenreName { get; set; } = string.Empty;
	}
}
