using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Movie
	{
		public int MovieId { get; set; }

		public string MovieName { get; set; } = null!;  //null forgiving operator value will be given during runtime by externa system like api etc

		public string MovieDescription { get; set; } = string.Empty;  //empty string is passed even if value is not given from external source it can be empty but not null

		public int Rating { get; set; }

		public string MovieReviews { get; set; } = string.Empty;

		public string PosterUrl {  get; set; } = string.Empty;

		public ICollection<Genre> Genres { get; set; } = null!;

	}
}
