using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Domain.Entities
{
	public class Genre
	{
		public int GenreId { get; set; }

		public string GenreName { get; set; } = string.Empty;

		public ICollection<Movie> Movies { get; set; } = null!;

	}
}

//Note : 
//Understand why ICollection is used for collection why List or IQuerable or IEnumerable is not used