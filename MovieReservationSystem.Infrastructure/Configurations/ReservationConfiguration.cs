using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieReservationSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieReservationSystem.Infrastructure.Configurations
{
	public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
	{
		public void Configure(EntityTypeBuilder<Reservation> builder)
		{
			builder.HasKey(r => r.ReservationId);

			builder.HasOne(r => r.User)
				.WithMany(u => u.Reservations)
				.HasForeignKey(r => r.UserId);


			builder.HasOne(r => r.ShowTime)
				.WithMany()
				.HasForeignKey(r => r.ShowTimeId);
				
				
			builder.HasMany(r => r.ReservationSeats)
				.WithOne(rs => rs.Reservation)
				.HasForeignKey(rs => rs.ReservationId);

			builder.Property(r => r.BookedAt)
				.HasDefaultValueSql("GETUTCDATE()");
		}
	}
}
