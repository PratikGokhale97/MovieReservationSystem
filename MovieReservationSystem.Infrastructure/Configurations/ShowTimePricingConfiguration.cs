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
	public class ShowTimePricingConfiguration : IEntityTypeConfiguration<ShowTimePricing>
	{
		public void Configure(EntityTypeBuilder<ShowTimePricing> builder)
		{
			builder.HasKey(sp =>sp.ShowTimePricingId);

			builder.HasOne(sp => sp.ShowTime)
				.WithMany(sh => sh.ShowTimePricing)
				.HasForeignKey(sp => sp.ShowTimeId);


			// Prevent duplicate SeatType pricing for same showtime:
			builder.HasIndex(sp => new { sp.SeatType, sp.ShowTimeId })
				.IsUnique();
		}
	}
}
