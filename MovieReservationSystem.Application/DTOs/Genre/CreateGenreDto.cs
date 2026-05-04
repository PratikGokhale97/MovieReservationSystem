using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Application.DTOs.Genre
{
	public class CreateGenreDto
	{
		public string GenreName { get; set; } = string.Empty;		
	}
}
