using Microsoft.EntityFrameworkCore;
using MovieReservationSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationSystem.Infrastructure.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Address> Address {  get; set; }
		public DbSet<Genre> Genre { get; set; }
		public DbSet<Movie> Movie { get; set; }
		public DbSet<MovieGenre> MovieGenre { get; set; }
		public DbSet<Reservation> Reservation { get; set; }
		public DbSet<Screen> Screen { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<ShowTime> ShowTime { get; set; }
		public DbSet<ShowTimePricing> ShowTimePricing { get; set; }
		public DbSet<Theatre> Theatre { get; set; }
		public DbSet<User> User { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}








	}
}
