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
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MovieGenre> MovieGenres { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Screen> Screens { get; set; }
		public DbSet<Seat> Seats { get; set; }
		public DbSet<ShowTime> ShowTimes { get; set; }
		public DbSet<ShowTimePricing> ShowTimePricings { get; set; }
		public DbSet<Theatre> Theatres { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<ReservationSeat> ReservationSeats { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}

	}
}
