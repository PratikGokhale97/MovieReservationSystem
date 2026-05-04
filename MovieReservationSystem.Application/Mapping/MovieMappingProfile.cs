using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MovieReservationSystem.Application.DTOs.Movie;
using MovieReservationSystem.Domain.Entities;

namespace MovieReservationSystem.Application.Mapping
{
	public class MovieMappingProfile : Profile
	{
		public MovieMappingProfile()
		{
			//Mapping from left to right means from source to destination
			CreateMap<Movie, MovieDto>()
				.ForMember(dest => dest.GenreName, opt => opt.MapFrom(src => src.MovieGenres.Select(mg => mg.Genre.GenreName).ToList()));


			CreateMap<CreateMovieDto, Movie>();
			//.ForMember(dest => dest.MovieGenres, opt => opt.Ignore())
			//.ForMember(dest => dest.ShowTimes, opt => opt.Ignore());
			//Not done because creating movie object means we need to create movie genre object as well 
			//and we need to get genre id from database and we cannot do that in mapping profile so we will do that in service layer


			CreateMap<UpdateMovieDto, Movie>();
				//.ForMember(dest => dest.MovieGenres, opt => opt.Ignore())
				//.ForMember(dest => dest.MovieGenres, opt => opt.Ignore());
			//Not done because updating movie object means we need to update movie genre object as well 
			//and we need to get genre id from database and we cannot do that in mapping profile so we will do that in service layer

			CreateMap<Movie, MovieDetailDto>()
				.ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.MovieGenres.Select(mg => mg.Genre.GenreName).ToList()))
				.ForMember(dest => dest.Showtime, opt => opt.MapFrom(src => src.ShowTimes));


		}
	}
}
