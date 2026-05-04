using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Movie
{
	public class CreateMovieDto
	{
		public string MovieName {  get; set; } = null!;

		public string MovieDescription { get; set; } = null!;

		public decimal Rating { get; set; }

		public string PosterUrl { get; set; } = string.Empty;

		public List<int> GenreId { get; set; } = new List<int>();

	}
}
