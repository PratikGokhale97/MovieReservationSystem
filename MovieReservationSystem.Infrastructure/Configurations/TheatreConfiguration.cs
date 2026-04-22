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
	public class TheatreConfiguration : IEntityTypeConfiguration<Theatre>
	{
		public void Configure(EntityTypeBuilder<Theatre> builder)
		{
			builder.HasKey(t => t.TheatreId);

			builder.HasOne(t => t.Address)
				.WithMany()
				.HasForeignKey(t => t.AddressId);

			builder.HasMany(t => t.Screens)
				.WithOne(s => s.Theatre)
				.HasForeignKey(s => s.TheatreId);
		}
	}
}
