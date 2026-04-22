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
	public class SeatConfiguration : IEntityTypeConfiguration<Seat>
	{
		public void Configure(EntityTypeBuilder<Seat> builder)
		{
			builder.HasKey(s => s.SeatId);

			builder.HasOne(s => s.Screen)
				.WithMany(sc => sc.Seats)
				.HasForeignKey(s => s.ScreenId);
		}
	}
}
