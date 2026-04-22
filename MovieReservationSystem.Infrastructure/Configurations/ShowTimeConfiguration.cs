using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Infrastructure.Configurations
{
	public class ShowTimeConfiguration : IEntityTypeConfiguration<ShowTime>
	{
		public void Configure(EntityTypeBuilder<ShowTime> builder)
		{
			builder.HasKey(sh => sh.ShowTimeId);

			builder.HasOne(sh => sh.Movie)
				.WithMany(m => m.ShowTimes)
				.HasForeignKey(sh => sh.MovieId);

			builder.HasOne(sh => sh.Screen)
				.WithMany(s => s.ShowTimes)	
				.HasForeignKey(sh => sh.ScreenId);

			builder.HasMany(sh => sh.ShowTimePricing)
				.WithOne(s => s.ShowTime)
				.HasForeignKey(s => s.ShowTimeId);
		}
	}
}
