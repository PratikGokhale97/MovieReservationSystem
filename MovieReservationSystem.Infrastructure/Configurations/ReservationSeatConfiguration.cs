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
	public class ReservationSeatConfiguration : IEntityTypeConfiguration<ReservationSeat>
	{
		public void Configure(EntityTypeBuilder<ReservationSeat> builder)
		{
			builder.HasKey(rs => rs.ReservationSeatId);

			builder.HasOne(rs => rs.Seat)
				.WithMany()
				.HasForeignKey(rs => rs.SeatId)
				.OnDelete(DeleteBehavior.Restrict);  //cannot delete seat if reservationseat exists

			builder.HasOne(rs => rs.ShowTime)
				.WithMany()
				.HasForeignKey(rs => rs.ShowTimeId)
				.OnDelete(DeleteBehavior.Restrict);  //cannot delete showtime seat if reservationseat exists

			builder.HasOne(rs => rs.Reservation)
				.WithMany(r => r.ReservationSeats)
				.HasForeignKey(rs => rs.ReservationId)
				.OnDelete(DeleteBehavior.Cascade);   //can delete reservation even if reservationseat exists

			builder.HasIndex(rs => new { rs.SeatId, rs.ShowTimeId })
				.IsUnique();

			builder.Property(rs => rs.Price)
				.HasColumnType("decimal(18,2)");
			
		}
	}
}
