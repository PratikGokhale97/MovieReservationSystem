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
	public class ScreenConfiguration : IEntityTypeConfiguration<Screen>
	{
		public void Configure(EntityTypeBuilder<Screen> builder)
		{
			builder.HasKey(s => s.ScreenId);

			builder.HasOne(s => s.Theatre)
				.WithMany(t => t.Screens)
				.HasForeignKey(s => s.TheatreId);

			builder.HasMany(s => s.Seats)
				.WithOne(se => se.Screen)
				.HasForeignKey(se => se.ScreenId);

			builder.HasMany(s => s.ShowTimes)
				.WithOne(sh => sh.Screen)
				.HasForeignKey(sh => sh.ScreenId);
		}
	}
}
