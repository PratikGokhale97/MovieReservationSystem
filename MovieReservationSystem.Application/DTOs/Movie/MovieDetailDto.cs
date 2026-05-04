using MovieReservationSystem.Application.DTOs.ShowTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Movie
{
	public class MovieDetailDto
	{
		public string MovieName { get; set; } = null!;

		public string MovieDescription { get; set; } = null!;

		public decimal Rating { get; set; }

		public string PosterUrl { get; set; } = string.Empty;

		//public string MovieReviews { get; set; } = string.Empty;

		public List<string> GenreName { get; set; } = new List<string>();

		public List<ShowTimeDto> Showtime { get; set; } = new List<ShowTimeDto>();
	}
}
