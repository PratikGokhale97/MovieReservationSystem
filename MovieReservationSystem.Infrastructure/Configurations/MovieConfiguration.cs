using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Infrastructure.Configurations
{
	public class MovieConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			builder.HasKey(m => m.MovieId);

			builder.HasMany(m => m.MovieGenres)
				.WithOne(mg => mg.Movie)
				.HasForeignKey(mg => mg.MovieId);

			builder.HasMany(m => m.ShowTimes)
				.WithOne(s => s.Movie)
				.HasForeignKey(s => s.MovieId);
		}
	}
}
