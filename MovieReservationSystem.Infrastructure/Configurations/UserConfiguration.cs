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
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(u => u.UserId);

			builder.HasMany(u => u.Reservations)
				.WithOne(r => r.User)
				.HasForeignKey(r => r.UserId);


			builder.Property(u => u.UserName)
				.IsRequired();

			builder.Property(u => u.Email)
				.IsRequired();

			builder.Property(u => u.Passwordhash)
				.IsRequired();
		}
	}
}
